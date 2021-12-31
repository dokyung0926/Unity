using System;
using System.Collections.Generic;
namespace Unity_Lesson_CSharp_ClassInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Creature creature = new Creature();
            creature.Breath();

            Person person = new Person();
            person.Breath();

            Dog dog = new Dog();
            dog.Breath();

            YellowMan yellowman1 = new YellowMan();
            BlackMan blackman1 = new BlackMan();
            WhiteMan whiteman1 = new WhiteMan();

            yellowman1.TwoLeggedWalk();
            blackman1.TwoLeggedWalk();
            whiteman1.TwoLeggedWalk();

            iTwoLeggedWalker yellowman1_iTwoLeggedWalker = yellowman1;
            iTwoLeggedWalker blackman1_iTwoLeggedWalker = blackman1;
            iTwoLeggedWalker whiteman1_iTwoLeggedWalker = whiteman1;

            List<iTwoLeggedWalker> list_TwoLeggedWalker = new List<iTwoLeggedWalker>();
            list_TwoLeggedWalker.Add(yellowman1_iTwoLeggedWalker);
            list_TwoLeggedWalker.Add(blackman1_iTwoLeggedWalker);
            list_TwoLeggedWalker.Add(whiteman1_iTwoLeggedWalker);

            foreach (iTwoLeggedWalker twoLeggedWalker in list_TwoLeggedWalker)
            {
                twoLeggedWalker.TwoLeggedWalk();
            }
        }
    }
}
