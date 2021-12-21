using System;

namespace UnityLesson_CSharp_IF
{
    class Program
    {
        static bool condition1 = true;
        static bool condition2 = true;
        static bool condition3 = true;
        static void Main(string[] args)
        {
            // 만약 소괄호 안의 내용이 참이면 중괄호 안의 내용을 실행한다.
            if (condition1) 
            {
                Console.WriteLine(" 조건1이 참 ");
            }
            else if (condition2)
            {
                Console.WriteLine(" 조건1이 거짓, 조건2가 참 ");
            }
            else if (condition3)
            {
                Console.WriteLine(" 조건1이 거짓, 조건2가 거짓, 조건 3이 참 ");
            }
            else
            {
                Console.WriteLine(" 조건1,2,3모두 거짓 ");
            }
        }
    }
}
