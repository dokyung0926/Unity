using System;

namespace UnityLesson_Cshat_Class_Object_Instance
{
    class Program
    {
        static void Main(string[] args)
        {
            // 객체 생성
            // new 키워드
            new AA(); // 생성자 : 클래스 이름과 같은 함수, 객체를 생성함

            // 인스턴스화
            // 메모리 공간에 객체를 할당시킨다.
            // AA 타입의 변수 a 에 new AA() 로 생성된 객체가 할당 되었다.
            // 이제 new AA로 생성된 객체가 필요할때마다 
            // 변수 a 를 통해 new AA() 로 생선된 객체에 접근 가능해짐.
            // 그리고 이렇게 되었을때 new AA()로 생성된 객체를 인스턴스 라고 한다.
            AA a = new AA();
            int i = 13;
        }
    }
    //클래스 (설계도)
    public class AA
    {
        // 생성자
        AA()
        {

        }
        //소멸자
        ~AA()
        {

        }

    }
}
