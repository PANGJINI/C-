using System;   //c# 라이브러리 선언 키워드 using
using static System.Console;

namespace project_1 //namespace 메모리 할당과 관련
{
    class Program   //namespace 안에 class 존재, class(설계)는 메모리 공간에 없음
    {
        static void Main(string[] args) //시작함수, 진입점 함수
                                        //static 정적메모리, 프로그램 시작~끝까지 메모리에 올라가있어야 함
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("하이~");   //자동완성 cw + tab
            WriteLine("ㅋㅋ");    //Console.을 생략하고 싶은 경우 2행에 콘솔을 선언해주면 됨

            //기본용어 : 표현식, 키워드, 식별자, 주석, 출력
            Console.WriteLine(10+20+30*2);

            //기본 자료형 (정수, 모듈러 연산!!)
            Console.WriteLine(10 % 3);

            //기본 자료형 (실수)
            Console.WriteLine(52.0175 + 15.623);
            Console.WriteLine(52.0175f + 15.623f);  //실수 자료형을 float으로 사용하고 싶은 경우
            Console.WriteLine(52.0 + 15.0); //출력은 정수형이지만 실제 자료형은 실수
            Console.WriteLine(52.5 % 5);    //실수에서는 나머지 연산자 사용XXX

            //escape 문자
            Console.WriteLine("컴퓨터\t소프트웨어\t공학");    //\t tab
            Console.Write("컴퓨터\n"); //\n 개행
            Console.Write("소프트웨어\n"); //Console.Write()는 자동 개행 안됨

            //문자, 문자열
            Console.WriteLine('A');
            Console.WriteLine("AAAAAAAAA-YO");

            //문자열 연결 연산자 (+)
            Console.WriteLine("안녕" + "하세요");
            Console.WriteLine(123 + "원");   //출력 : 123원
            Console.WriteLine(123 + '원');   //출력 : 51019 (아스키코드)
            Console.WriteLine("원" + 12 + 34);   //출력 : 원1234
            Console.WriteLine(12 + 34 + "원");   //출력 : 46원

            //문자 선책 괄호
            Console.WriteLine("감사합니다."[3]); //출력 : 니 (네번째 문자 출력, 문자열 범위 벗어나면 오류)

            //Bool (비교연산자와 연관지어서)
            Console.WriteLine(52 == 273);   //출력 : False
            Console.WriteLine(52 < 273);    //출력 : True

            //논리연산자 (논리부정(not, !) 논리합(or, ||) 논리곱(and, &&)
            Console.WriteLine(!true);
            Console.WriteLine((DateTime.Now.Hour < 3) || (8 < DateTime.Now.Hour));   //현재 시스템 시간
            Console.WriteLine((3 < DateTime.Now.Hour) && (DateTime.Now.Hour < 8));


            //변수 : 값을 저장할 때 사용하는 식별자
            //정수 자료형 (int, long)
            int a = 123;
            int b = 52;
            Console.WriteLine(a % b);

            //실수 자료형 (float 4, double 8)
            double aa = 52.273;
            double bb = 103.32;
            Console.WriteLine(52.123f + 12.34f);    //결과값 float
            Console.WriteLine(52.123 + 12.34f);    //결과값 double

            //sizeof(자료형), 자료형의 크기를 확인한다
            Console.WriteLine("int : " + sizeof(int));
            Console.WriteLine("long : " + sizeof(long));
            Console.WriteLine("float : " + sizeof(float));
            Console.WriteLine("double : " + sizeof(double));
            Console.WriteLine("char : " + sizeof(char));
            //Console.WriteLine("string : " + sizeof(string));
            //다른 자료형은 모두 구조체이지만 string 자료형은 class이다. class는 메모리 공간에 없기 때문에 크기를 확인할 수 없다.


        }
    }
}
