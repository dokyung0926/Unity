using System;

namespace UnityLesson_CSharp_GarbageCollector
{
    class Program
    {
        static void Main(string[] args)
        {
            AA aa = new AA();
        }
    }

    class AA
    {
        int age;
        public AA() // 생성자
        {
        }
        ~ AA () // 소멸자
        {
        }

        //C#에서 소멸자를 따로 호출하지 않는 이유
        // GC ( Garbage Collector ) 가 런타임으로  쓰레기 객체를 검색해서
        // 삭제하기 때문에 생성한 객체를 따로 메모리에서 지워주지 않아도 된다.
    }
}
