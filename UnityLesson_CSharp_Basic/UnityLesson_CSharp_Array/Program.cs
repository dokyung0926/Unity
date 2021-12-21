using System;

namespace UnityLesson_CSharp_Array
{
    class Program
    {
        // array
        // 형태 : 자료형 [ ]
        // 자료형이 정적으로 나열되어있는 형태 ( 한번 크기를 정해 놓으면 바꿀 수 없다 . )
        static int[] arr_testInt = new int[5];
        static float[] arr_testFloat1 = new float[3];
        static float[] arr_testFloat2 = { 1.0f, 2.0f, 3.0f, 4.0f };
        static string[] arr_testString = new string[3];
        static void Main(string[] args)
        {
            arr_testInt[0] = 5;
            arr_testInt[1] = 4;
            arr_testInt[2] = 3;
            arr_testInt[3] = 2;
            arr_testInt[4] = 1;

            Console.WriteLine(arr_testInt[0]);
            Console.WriteLine(arr_testInt[1]);
            Console.WriteLine(arr_testInt[2]);
            Console.WriteLine(arr_testInt[3]);
            Console.WriteLine(arr_testInt[4]);

            arr_testFloat1[0] = 2.0f;
            arr_testFloat1[1] = 4.0f;
            arr_testFloat1[2] = 6.0f;

            Console.WriteLine(arr_testFloat1[0]);
            Console.WriteLine(arr_testFloat1[1]);
            Console.WriteLine(arr_testFloat1[2]);

            arr_testString[0] = "김아무개";
            arr_testString[0] = "이아무개";
            arr_testString[0] = "박아무개";

            Console.WriteLine(arr_testString[0]);
            Console.WriteLine(arr_testString[1]);
            Console.WriteLine(arr_testString[2]);

            string[] playerInfo = new string[999];

            playerInfo[0] = "이름";
            playerInfo[1] = "성별";
        }
    }
    class testclass
    {

    }

}
