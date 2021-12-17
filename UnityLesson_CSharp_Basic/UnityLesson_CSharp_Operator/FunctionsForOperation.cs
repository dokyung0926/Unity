using System;
using System.Collections.Generic;
using System.Text;

namespace UnityLesson_CSharp_Operator
{
    class FunctionsForOperation
    {
        // 산술연산
        // ========================================================================
        // 덧셈
        static public int Sum(int a, int b)
        {
            return a + b;
        }
        static public int Sub(int a, int b)
        {
            return a - b;
        }
        static public int Div(int a, int b)
        {
            return a / b;
        }
        static public int Mul(int a, int b)
        {
            return a * b;
        }
        static public int Mod(int a, int b)
        {
            return a % b;
        }

        // 증감연산
        static public int Increase(int a)
        {
            return a++;
        }
        static public int Increase(int a)
        {
            return a--;
        }
        static public bool isSame((int a, int b)
        {
            return a == b;
        }
        static public bool isDiffrent(int a, int b)
        {
            return a != b;
        }
        static public bool isBiffer(int a, int b)
        {
            return a > b;
        }
        static public bool isSmaller(int a, int b)
        {
            return a < b;
        }
        static public bool isBiggerOrSame(int a, int b)
        {
            return a == b;
        }
        static public bool isSmallerOrSame(int a, int b)
        {
            return a == b;
        }

        // 대입연산
        static public int PlusBToA(int a, int b)
        {
            a += b;
            return a;
        }
        static public int PlusBToA(int a, int b)
        {
            a -= b;
            return a;
        }
        static public int PlusBToA(int a, int b)
        {
            a /= b;
            return a;
        }
        static public int PlusBToA(int a, int b)
        {
            a *= b;
            return a;
        }
        static public int PlusBToA(int a, int b)
        {
            a %= b;
            return a;
        }
        
        // 논리연산
        static public bool LogicOR(bool a, bool b)
        {
            return a | b;
        }
        static public bool LogicOR(bool a, bool b)
        {
            return a & b;
        }
        static public bool LogicOR(bool a, bool b)
        {
            return a ^ b;
        }
        static public bool LogicOR(bool a, bool b)
        {
            return !a;
        }
    }
}
