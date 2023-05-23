using System;

namespace project_1
{
    class Program
    {
        static void ChangeA(int input)
        {
            input = 10;
            Console.WriteLine(input);
        }

        class Test      // 클래스(사용자 정의 자료형)
        {
            public int value = 20;
        }

        static void ChangeB(Test input)
        {
            input.value = 30;
        }
        
        static void Main(string[] args)
        {
            // 값 복사와 참조 복사
            /* 기본 자료형은 값이 들어있다.
             * 객체(인스턴스)는 참조(주소)가 들어있다.
             */

            int a1 = 40;
            ChangeA(a1);        //10 출력
            Console.WriteLine();

            // 값 복사
            /* b = a;의 경우 a의 값이 b에 복사가 됨
             * a의 값이 변하지 않음
             * a=10이었으면 a, b모두 10
             */
            int a2 = 50;
            int input = a2;
            input = 60;
            ChangeA(a2);        //10 출력
            ChangeA(input);     //10 출력
            Console.WriteLine();


            // 참조 복사
            /* test2.value = test1.value;의 경우 test1이 test2이 가리키는 주소를 참조함
             * test1.value = 100, test2.value=200이었다면
             * test1.value가 200이 됨
             */
            Test test1 = new Test();    //test1 : 객체(인스턴스)
            Test test2 = test1;         //test2 : test1 타입의 변수,  test1 객체를 test2 변수에 할당한 것
            test1.value = 100;
            test2.value = 200;
            Console.WriteLine(test1.value);



        }
    }
}
