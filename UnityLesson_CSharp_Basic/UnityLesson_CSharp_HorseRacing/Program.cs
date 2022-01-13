using System;
using System.Threading;

namespace UnityLesson_CSharp_HorseRacing
{

    class Program
    {
        static Random random;
        static bool isGameFinished = false;
        static int minSpeed = 10;
        static int maxSpeed = 20;
        static int finishDistance = 200;

        static void Main(string[] args)
        {
            Horse[] arr_Horse = new Horse[5];
            string[] arr_FinishedHorseName = new string[5];
            int currentGrade = 1;

            int length = arr_Horse.Length;
            for (int i = 0; i < length; i++)
            {
                arr_Horse[i] = new Horse();
                arr_Horse[i].name = $"경주마{i + 1}";
            }
            Console.WriteLine("경주 시작!");
            int count = 0;
            while (isGameFinished == false)
            {
                Console.WriteLine($"===================== {count} 초 ====================");
                for (int i = 0; i < length; i++)
                {
                    if (arr_Horse[i].dontMove == false)
                    {
                        random = new Random();
                        int tmpMoveDistance = random.Next(minSpeed, maxSpeed + 1);
                        arr_Horse[i].Run(tmpMoveDistance);
                        Console.WriteLine($"{arr_Horse[i].name} 가 달린거리 : {arr_Horse[i].distance}");
                        if (arr_Horse[i].distance >= finishDistance)
                        {
                            arr_Horse[i].dontMove = true;
                            arr_FinishedHorseName[currentGrade - 1] = arr_Horse[i].name;
                            currentGrade++;
                        }
                    }
                }
                Console.WriteLine($"====================================================");
                if (currentGrade > 5)
                {
                    isGameFinished = true;
                    Console.WriteLine("경주 끝!");
                    break;
                }

                Thread.Sleep(1000); // 1000 ms = 1 sec.
                count++;
            }

            Console.WriteLine("==============결과 발표==============");
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine($"{i + 1} 등 : {arr_FinishedHorseName[i]}");
            }

        }
    }
}
