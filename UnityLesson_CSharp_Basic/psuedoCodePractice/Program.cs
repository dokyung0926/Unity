using System;
// 세분화 예시 2 의 코드
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(Sum1ToN(5));
    }

    static int Sum1ToN(int N)
    {
        int resultValue = 0;
        for (int sumValue = 1; sumValue <= N; sumValue++)
        {
            resultValue += sumValue;
        }
        return resultValue;
    }
}