using System;

namespace UnityProject
{
    class 검사
    {
        int HP = 100;
        int ATK = 80;

        public void 베기1(object monster)
        {
            monster.HP = monster.HP - ATK;
        }
        public void 베기2(object monster)
        {
            monster.HP = monster.HP - ATK * 1.5;
        }

    }

    class 캐릭터생성
    {
        public void 검사생성()
        {
            검사 검사1 = new 검사();
        }
    }
}
