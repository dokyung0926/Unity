using System;
using System.Collections.Generic;
using System.Text;

namespace Unity_Lesson_CSharp_ClassInheritance
{
    class Dog : Creature, iFourLeggedWalker
    {
        public float tailLength;

        public void FourLeggedWalk()
        {
            Console.WriteLine("네발로 걷는다 .");
        }
    }
}
