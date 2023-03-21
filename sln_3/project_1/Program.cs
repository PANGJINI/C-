using System;

namespace project_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //복합대입연산자
            //사용 이유: 메모리 공간의 절약(?)
            int input = 0;
            input += 57;
            input += 173;
            Console.WriteLine(input);


            //문자열 연결 연산자 (+)
            Console.WriteLine(10+10);   //20 (숫자 + 숫자 --> 숫자)
            Console.WriteLine(10+"원");   //10원(숫자 + 문자열 --> 문자열)
            Console.WriteLine(10+'A');  //75 (10 + 'A'의 아스키코드 번호 --> 숫자)
            Console.WriteLine("10" + "20");     //1020 (문자열 + 문자열 --> 문자열)
            Console.WriteLine("쉬익 : " + 10 + 20);   //쉬익 : 1020
            Console.WriteLine("쉬익 : " + (10 + 20)); //쉬익 : 30


            //증감연산자 (++, --)
            int num1 = 10;
            num1++;
            Console.WriteLine(num1);    //11
            num1--;
            Console.WriteLine(num1);    //10

            int num2 = 20;
            Console.WriteLine(num2);    //20
            Console.WriteLine(num2++);  //20
            Console.WriteLine(num2--);  //21
            Console.WriteLine(num2);    //20
            Console.WriteLine(--num2);  //19
            Console.WriteLine(num2--);  //19
            Console.WriteLine(num2);    //18


            //자료형 변수 선언
            int _int = 375;
            long _long = 123456789123;
            float _float = 12.345F;     //대문자 F 권장
            double _double = 123.45;
            char _char = '키';           //문자
            string _string = "득키득";   //문자열


            //GetType()     자료형 출력하는 method
            //값을 가져올 때 get, 값을 설정할 때 set method
            Console.WriteLine(_int.GetType());
            Console.WriteLine(_long.GetType());
            Console.WriteLine(_float.GetType());
            Console.WriteLine(_double.GetType());
            Console.WriteLine(_char.GetType());
            Console.WriteLine(_string.GetType());

            //직접적인 GetType() method를 활용해서 자료형 출력
            Console.WriteLine((52.275F).GetType());


            //var 변수
            /*  지역변수로 선언 - method 내부에 선언되어 있는 변수
             *  method 외부에 var 키워드 사용하는 경우 - error
             *  변수 선언과 동시에 초기화 해야 함
                왜? 초기화한 데이터값의 자료형에 따라 알맞게 메모리가 할당된다.
             * 
             */
            var global = 100;       //var이 int로 지정
            var number = 12.34;     //var이 double로 지정
            

        }
    }
}
