using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceGame_Copy
{
    internal class TileMap
    {
        public Dictionary<int, TileInfo> dic_Tile = new Dictionary<int,TileInfo>();

        // maxTileNum만큼 칸을 생성하는 함수
        public void MapSetup(int maxTileNum)
        {
            for (int i = 0; i < maxTileNum; i++)
            {
                if (i%5 == 0)
                {
                    // 샛별칸 생성
                    TileInfo tileInfo_Star = new TileInfo_Star();
                    tileInfo_Star.index = i;
                    tileInfo_Star.name = "샛별";
                    tileInfo_Star.description = "당신은 샛별을 얻고, 다음 칸부터 샛별이 1개씩 늘어납니다!";
                    dic_Tile.Add(i, tileInfo_Star);
                }
                else
                {
                    // 일반칸 생성
                    TileInfo tileInfo_Dummy = new TileInfo();
                    tileInfo_Dummy.index = i;
                    tileInfo_Dummy.name = "일반";
                    tileInfo_Dummy.description = "아무일도 일어나지 않았습니다...";
                    dic_Tile.Add(i,tileInfo_Dummy);
                }
            }
            Console.WriteLine($"맵 설정이 완료되었습니다 . 최대 칸은 {maxTileNum}칸 입니다 .");
        }
    }
}
