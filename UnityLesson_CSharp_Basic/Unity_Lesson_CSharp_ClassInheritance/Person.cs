using System;
using System.Collections.Generic;
using System.Text;

namespace Unity_Lesson_CSharp_ClassInheritance
{
    class Person : Creature, iTwoLeggedWalker
    {
        public float height;

        // override 키워드 : 부모클래스의 virtual 키워드가 붙은 함수를 재정의하는 키워드
        public override void Breath()
        {
            base.Breath();
            height += 0.00004f;
            weight += 0.00002f;
        }

        public void TwoLeggedWalk()
        {
            Console.WriteLine("두발로 걷는다.");
        }
    }
}
