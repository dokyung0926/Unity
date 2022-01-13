using System;
using System.Threading;

namespace UnityLesson_CSharp_HorseRacing
{

    class Program
    {
        static Random random; // 말의 달리는 속도를 랜덤하게 생성하기위한 난수 변수
        static bool isGameFinished = false; // 경주가 끝났는지 체크하는 변수
        static int minSpeed = 10; // 달리는 속도의 최솟값
        static int maxSpeed = 20; // 달리는 속도의 최댓값
        static int finishDistance = 200; // 결승점 거리

        static void Main(string[] args)
        {
            Horse[] arr_Horse = new Horse[5]; // 말 5마리를 인스턴스화 시키기 위한 배열
            string[] arr_FinishedHorseName = new string[5]; // 결승점을 통과한 말의 이름을 저장할 배열
            int currentGrade = 1; // 현재 등수
             
            int length = arr_Horse.Length; // 말들이 저장된 배열의 길이 
            for (int i = 0; i < length; i++) // 말들을 인스턴스화 시키고, 말들의 이름을 초기화 하는 for문
            {
                arr_Horse[i] = new Horse(); // 말 인스턴스화
                arr_Horse[i].name = $"경주마{i + 1}"; // 말의 이름 초기화
            }
            Console.WriteLine("경주 시작!"); 
            int count = 0; // while 문이 실행된 횟수
            while (isGameFinished == false) // 게임이 끝날 때 까지 돌아가는 while문
            {
                Console.WriteLine($"===================== {count} 초 ===================="); // 1. count는 1초에 1씩 올라감 (이유 : while문 마지막에 Tread.Sleep(1000) 으로 1초 지연이 있기 때문. 
                for (int i = 0; i < length; i++) // 랜덤한 속도로 말을 달리게 하는 for문     // 2. 즉, count를 넣으면 "1초" 가 된다.
                {
                    if (arr_Horse[i].dontMove == false) // [i] 번째 말이 움직일 수 있으면 
                    {
                        random = new Random(); // 난수용 인스턴스
                        int tmpMoveDistance = random.Next(minSpeed, maxSpeed + 1); // minSpeed - maxSpeed 범위 내의 난수 생성
                        arr_Horse[i].Run(tmpMoveDistance); // [i] 번째 말을 tmpMoveDistance( 10 ~ 20 사이 정수 ) 만큼 달리게 하는 함수
                        Console.WriteLine($"{arr_Horse[i].name} 가 달린거리 : {arr_Horse[i].distance}"); // {[i] 번째 말 이름} 가 달린 거리 {[i] 번째 말이 달린 거리}
                        if (arr_Horse[i].distance >= finishDistance) // {[i] 번째 말이 달린 거리가 결승점 거리보다 크거나 같을 때 ([i] 번째 말이 결승점을 통과했으면)
                        {
                            arr_Horse[i].dontMove = true; // [i]번째 말을 멈추게 해줌
                            arr_FinishedHorseName[currentGrade - 1] = arr_Horse[i].name; // 결승점에 도달한 말의 이름을  현재 등수 - 1 번째 자리에 저장
                            currentGrade++; // 현재 등수르 1 증가 ( 1등 다음 2등 )
                        }
                    }
                }
                Console.WriteLine($"====================================================");
                if (currentGrade > 5) // 현재 등수가 5보다 크면 ( 즉, 1등에서 5등까지 전부 결승점에 도달했으면 )
                {
                    isGameFinished = true; // 게임이 끝남
                    Console.WriteLine("경주 끝!");
                    break; // while loop 탈출
                }

                Thread.Sleep(1000); // 1000 ms = 1 sec. 1초 지연
                count++; // while문 실행한 횟수 증가
            }

            Console.WriteLine("==============결과 발표==============");
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine($"{i + 1} 등 : {arr_FinishedHorseName[i]}"); // 결승점에 도착한 순서대로 등수를 매겨서 줌 
            }

        }
    }
}
