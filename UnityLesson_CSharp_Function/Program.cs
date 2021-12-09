using System;

namespace UnityLesson_CSharp_Function
{
    class Program
    {
        static bool doPrintHelloWorld = true;
        static bool doPrintSomething = true;
        static void Main(string[] args)
        {
            // 함수 호출시 함수이름(); 형태로 호출한다 .
            if (doPrintHelloWorld == true) ;
            {
                PrintHelloWorld();
            }
            // element : 함수 호출시 입력 변수
            string something = "Unity  Hola ! ";
           if(doPrintSomething == true)
            {
                PrintSomething(something);
            }
           else
            {
                Console.WriteLine("do nothing ");
            }
        }

        static void PrintHelloWorld()
        {
            Console.WriteLine("Hello World!");
        }

        static void PrintSomething(string something)
        {
            Console.WriteLine(something);
        }
    }
}
