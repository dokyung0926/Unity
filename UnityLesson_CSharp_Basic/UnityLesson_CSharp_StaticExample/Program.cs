using System;

namespace UnityLesson_CSharp_StaticExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Orc orc1 = new Orc();
            orc1.Name = "오크";
            orc1.Height = 240.0f;

            Orc.typeName = "오크 타입 설계도";
            Orc.SayTypeName();

            // static 멤버(변수와 함수) 는 객체 단위로 접근이 불가능하다.
            // static으로 정의돈 클래스는 인스턴스화가 불가능하다.
        }
    }

    class Orc
    {
        // 접근제한자
        // 자료형 앞에 붙어서 해당 변수 / 함수/ 클래스의 접근 권한을 지정한다.
        // public , private , protected
        // public ( 공적 ) : 다른 클래스에서도 접근이 가능
        // private (사적 ) : 다른 클래스에서 접근이 불가능
        // protected : 상속자만 접근이 가능
        public string Name;
        public float Height;
        public float Weight;
        public int Age;
        public char genderChar;
        public bool isResting;

        //  static 키워드는 정적 성질을 부여하는 키워드 .
        // 정적 = 메모리에 할당이 불가능하다 .
        // 동적 = 메모리에 할당이 가능하다 .
        static public string typeName;
        static public void SayTypeName()
        {
            Console.WriteLine(typeName);
        }

        public void Smash()
        {
            Console.WriteLine($"{Name}(이)가 휘둘렀다");
        }
        public void Jump()
        {
            Console.WriteLine($"{Name}(이)가 점프했다");
        }
    }

    static class Person
    {
        // static class 를 쓰는 이유 :
        // 객체를 찍어내는것이 아니라 정보, 기능, 개념 등이 유일하게 필요한 경우 사용함
        //
    }
}
