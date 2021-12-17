using System;

namespace UnityLesson_CSharp_ClassExample1
{
    class Program
    {
        static void Main(string[] args)
        {
            Orc orc1 = new Orc();
            orc1.Name = "상급오크";
            orc1.Height = 240.2f;
            orc1.Weight = 200.0f;
            orc1.Age = 140;
            orc1.genderChar = '남';
            orc1.isResting = false;

            Orc orc2 = new Orc();
            orc2.Name = "하급오크";
            orc2.Height = 140.2f;
            orc2.Weight = 120.0f;
            orc2.Age = 60;
            orc2.genderChar = '여';
            orc2.isResting = true;

            if (orc1.isResting)
            {
                orc1.Jump();
                orc1.Smash();
            }
            else
            {
                Console.WriteLine($"{orc1.Name}(은)는 바쁘다");
            }

            if (orc2.isResting)
            {
                orc2.Jump();
                orc2.Smash();
            }
            else
            {
                Console.WriteLine($"{orc2.Name}(은)는 바쁘다");
            }    
        }
    }

    

    class Orc
    {
        public string Name;
        public float Height;
        public float Weight;
        public int Age;
        public char genderChar;
        public bool isResting;

        public void Smash()
        {
        Console.WriteLine($"{Name}(이)가 휘둘렀다");
        }
        public void Jump()
        {
        Console.WriteLine($"{Name}(이)가 점프했다");
        }
    }
}


