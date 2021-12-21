using System;

// orc 객체를 10마리 만들고 오크들의 인스턴스는 Orc타입 배열에 넣어준다.
// 각 오크의 이름은 "오크 0", "오크 1" ...."오크 9"
// 각 오크에세 isResting의 값을 true로 넣어준다
// 각 오크가 쉬고있는지 확인해서 쉬고있다면 점프하도록 한다
namespace UnityLesson_CSharp_ForLoopExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Orc[] arr_Orc = new Orc[10];
            int length = arr_Orc.Length;
            for (int i = 0; i < length; i++)
            {
                arr_Orc[i] = new Orc();
                arr_Orc[i].name = $"오크{i}";
            }
            for (int i = 0; i < length; i++)
            {
                arr_Orc[i].isResting = GetRandomBool();
            }

            for (int i = 0; i < length; i++)
            {
                if (arr_Orc[i].isResting)
                {
                    arr_Orc[i].Jump();
                }
            }
        }
        static public bool GetRandomBool()
        {
            Random rand = new Random();
            bool value = Convert.ToBoolean(rand.Next(0, 2));
            return value;
        }

    }
    class Orc
    {
        public string name;
        public bool isResting;

        public void Jump()
        {
            Console.WriteLine($"{name} (이)가 점프했다!");
        }
    }
}