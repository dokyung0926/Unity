using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceGame_Copy
{
    internal class TileInfo
    {
        public int index; // 몇번째 칸인지에 대한 정보
        public string name;// 칸의 이름
        public string description; // 각 칸의 설명
        virtual public void TileEvent() // 칸에 도착했을 시 실행할 이벤트 함수
        {
            Console.WriteLine($"\n{index}번째 칸 도착!\n \n{name}칸입니다! \n{description}\n");
        }
    }
}
