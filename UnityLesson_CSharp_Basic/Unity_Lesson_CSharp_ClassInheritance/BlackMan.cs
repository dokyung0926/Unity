using System;
using System.Collections.Generic;
using System.Text;

namespace Unity_Lesson_CSharp_ClassInheritance
{
    class BlackMan : Person 
    {
        public override void Breath()
        {
            lifeTime++;
            height += 0.0001f;
            weight += 0.0005f;
        }
    }
}
