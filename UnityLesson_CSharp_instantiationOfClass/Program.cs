using System;

namespace UnityLesson_CSharp_instantiationOfClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            // .  점연산자
            // 클래스의 멤버에 접근할때 사용, namespace 안의 클래스에 접근할때 사용.
            person1.age = 40; // 정수형은 그냥 숫자 입력
            person1.height = 223.4f; // 실수형은 숫자 뒤에 f 추가 입력
            person1.isFemale = false; // 논리형은 true 혹은 false 입력
            person1.genderChar = '남'; // 문자형은 ' ' 작은 따옴표 안에 단일 문자
            person1.name = "김아무개"; // 문자열형은 " " 큰 따옴표 안에 다중문자

            person1.SayAllInfo();
        
        }
    }

    class Person
    {
        // 접근제한자 :
        // 위치 : 자료형 앞
        // 아무것도 안써져있면 기본적으로 private
        // public, private, protected
        // public ( 공적 ) : 다른 클래스에서도 접근이 가능
        // private ( 사적 ) : 다른 클래스에서 접근이 불가능
        // protected : 상속자만 접근이 가능

        public int age;
        public float height;
        public bool isFemale;
        public char genderChar;
        public string name;

        public void SayAllInfo()
        {
            SayAge();
            SayHeight();
            SayIsFemale();
            SayGenderChar();
            SayName();
        }
        void SayAge()
        {
            Console.WriteLine(age);
        }
        void SayHeight()
        {
            Console.WriteLine(height);
        }
        void SayIsFemale()
        {
            Console.WriteLine(isFemale);
        }
        void SayGenderChar()
        {
            Console.WriteLine(genderChar);
        }
        void SayName()
        {
            Console.WriteLine(name);
        }
    }
}
