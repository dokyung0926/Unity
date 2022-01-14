using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnityLesson_CSharp_DiceGame
{
    internal class TileMap
    {
        public Dictionary<int, TileInfo> dic_tile = new Dictionary<int, TileInfo>(); // 칸 번호, 칸 정보를 저장할 사전

        // maxTileNum 만큼 칸을 생성하는 함수
        public void MapSetup(int maxTileNum)
        {
            for (int i = 1; i <= maxTileNum; i++)
            {
                if (i % 5 == 0)
                {
                    // 샛별칸 생성
                    TileInfo tileInfo_Star = new TileInfo_Star();
                    tileInfo_Star.index = i;
                    tileInfo_Star.name = "샛별";
                    tileInfo_Star.discription = "당신은 샛별을 얻고, 다음 칸부터 샛별이 1개씩 늘어납니다!";
                    dic_tile.Add(i, tileInfo_Star);
                }
                else
                {
                    // 일반칸 생성
                    TileInfo tileInfo_Dummy = new TileInfo();
                    tileInfo_Dummy.index = i;
                    tileInfo_Dummy.name = "일반";
                    tileInfo_Dummy.discription = "아무일도 일어나지 않았습니다...";
                    dic_tile.Add(i, tileInfo_Dummy);
                }
            }
            Console.WriteLine($"맵 설정이 완료되었습니다 . 최대 칸은 {maxTileNum}칸 입니다 .");
        }
    }
}