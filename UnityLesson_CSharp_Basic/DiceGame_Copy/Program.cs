using System;
using System.Collections.Generic;

namespace DiceGame_Copy
{
    internal class Program
    {
        static private int totalTile = 20; // 총 칸의 갯수
        static private int currentStarPoint = 0; // 샛별의 갯수
        static private int totalDiceNumber = 20; // 보유중인 총 주사위 갯수
        static private int previousTileIndex = 0; // 이전 칸의 번호 ( 플레이어가 샛별칸을 지나는지 확인하기 위해서 )
        static private int currentTileIndex = 0; // 현재 칸의 번호
        static private Random random; // 난수 생성용 함수
        static void Main(string[] args)
        {
            TileMap map = new TileMap(); // 맵 클래스 인스턴스화
            map.MapSetup(totalTile); // 맵 생성 ( 20칸 ) 

            int currentDiceNumber = totalDiceNumber; // 현재 주사위 갯수, 초기값은 최대 주사위 갯수
            while (currentDiceNumber > 0)
            {
                int diceValue = RollADice(); // 주사위 굴려서 나온 눈금 
                currentDiceNumber--; // 주사위 굴렸으니까 남은 주사위 갯수 차감
                currentTileIndex += diceValue; // 주사위 눈금만큼 플레이어 전진

                // 플레이어가 샛별칸을 지날 때
                if (previousTileIndex / 5 < currentTileIndex / 5)
                {
                    int passedStarTileIndex = CalcPassedStarTileIndex(currentTileIndex); // 지나온 샛별칸 번호 계산
                    TileInfo passedStarTileInfo = map.dic_Tile.GetValueOrDefault(passedStarTileIndex); // 지나온 샛별칸의  TileInfo 가져오기
                    TileInfo_Star passedTileInfo_Star = passedStarTileInfo as TileInfo_Star; // TleInfo타입을 TileInfo_Star로 인식하겠다.
                    if (passedTileInfo_Star != null) // 샛별칸의 정보를 가져오는데 성공했으면
                    {
                        currentStarPoint += passedTileInfo_Star.starValue; // 샛별점수 누적
                    }
                }

                if (currentTileIndex > totalTile) // 현재칸이 최대칸을 넘어가 버렸을때
                {
                    currentTileIndex -= totalTile; // 현재칸에다가 최대칸을 뺀다.
                }

                TileInfo info = map.dic_Tile.GetValueOrDefault(currentTileIndex); // map 에서 현재칸의 TileInfo를 가져옴
                if (info == null) // 현재칸의 TileInfo를 가져오지 못했을 경우에는 프로그램을 강제종료한다 .
                {
                    Console.WriteLine($"{currentTileIndex}번째 칸의 정보를 불러오지 못했습니다. 게임을 종료합니다.");
                    return;
                }
                info.TileEvent();

                previousTileIndex = currentTileIndex;
                Console.WriteLine($"총 샛별 {currentStarPoint}개 보유중");
                Console.WriteLine($"남은 주사위 {currentDiceNumber}개 보유중\n\n");
            }

            Console.WriteLine($"게임이 끝났습니다 ! 당신은 총 {currentStarPoint}개의 샛별을 획득하셨습니다 !");
        }
        static private int RollADice()
        {
            string userInput = "Default";
            while (userInput != "")
            {
                Console.WriteLine("엔터키를 눌러 주사위를 굴려주세요 ! ");
                userInput = Console.ReadLine();
            }
            random = new Random(); // 난수 생성용 인스턴스
            int diceValue = random.Next(1, 6 + 1); // 1 ~ 6 중 랜덤한 정수
            DisplayDice(diceValue);
            return diceValue;
        }
        static void DisplayDice(int diceValue)
        {
            switch (diceValue)
            {
                case 1:
                    Console.WriteLine("┌───────────┐");
                    Console.WriteLine("│           │");
                    Console.WriteLine("│           │");
                    Console.WriteLine("│     ●    │");
                    Console.WriteLine("│           │");
                    Console.WriteLine("│           │");
                    Console.WriteLine("└───────────┘");
                    break;
                case 2:
                    Console.WriteLine("┌───────────┐");
                    Console.WriteLine("│ ●        │");
                    Console.WriteLine("│           │");
                    Console.WriteLine("│           │");
                    Console.WriteLine("│           │");
                    Console.WriteLine("│         ●│");
                    Console.WriteLine("└───────────┘");
                    break;
                case 3:
                    Console.WriteLine("┌───────────┐");
                    Console.WriteLine("│ ●        │");
                    Console.WriteLine("│           │");
                    Console.WriteLine("│     ●    │");
                    Console.WriteLine("│           │");
                    Console.WriteLine("│         ●│");
                    Console.WriteLine("└───────────┘");
                    break;
                case 4:
                    Console.WriteLine("┌───────────┐");
                    Console.WriteLine("│ ●      ●│");
                    Console.WriteLine("│           │");
                    Console.WriteLine("│           │");
                    Console.WriteLine("│           │");
                    Console.WriteLine("│ ●      ●│");
                    Console.WriteLine("└───────────┘");
                    break;
                case 5:
                    Console.WriteLine("┌───────────┐");
                    Console.WriteLine("│ ●      ●│");
                    Console.WriteLine("│           │");
                    Console.WriteLine("│     ●    │");
                    Console.WriteLine("│           │");
                    Console.WriteLine("│ ●      ●│");
                    Console.WriteLine("└───────────┘");
                    break;
                case 6:
                    Console.WriteLine("┌───────────┐");
                    Console.WriteLine("│ ●      ●│");
                    Console.WriteLine("│           │");
                    Console.WriteLine("│ ●      ●│");
                    Console.WriteLine("│           │");
                    Console.WriteLine("│ ●      ●│");
                    Console.WriteLine("└───────────┘");
                    break;
                default:
                    break;
            }
        }
        // 현재 칸의 번호를 넣어주면 지나온 샛별칸의 번호를 반환해주는 함수
        static public int CalcPassedStarTileIndex(int currentTileIndex)
        {
            int index = currentTileIndex / 5 * 5;
            return index;
        }
    }
}
