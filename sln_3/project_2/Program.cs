using System;

namespace project_2
{
    class Program
    {
        static void Main(string[] args)
        {
            /* ★★★ 솔루션에 프로젝트 여러개 만드는 경우 ★★★
             * project_1이 디폴트로 활성화되기 때문에 project_1의 main을 컴파일한다.
             * 솔루션에 우클릭-속성-시작프로젝트-현재영역선택
             */


            //문자열 서식 맞추기
            /* Console.WriteLine();      기본적으로 문자열을 출력하는 메서드
             
             * 숫자를 출력할 때는 문자열로 변환하는 과정이 필요하다.
             * C#은 문자열 서식화에 사용할 수 있는 간단한 두 가지 방법이 있다.
                ① string 형식의 Format() 메서드
                ② 문자열 보간(Interpolation)
             */

            //문자열 결합
            Console.WriteLine("학과 : " + "컴소과");

            //① string 형식의 Format() 메서드
            //{ } 안에 인덱스 번호를 지정하고, 콤마 뒤에 오는 내용 중 알맞은 값을 { } 위치에 출력한다.
            Console.WriteLine("학과 : {0}", "컴소과", "키득");     //학과 : 컴소과
            Console.WriteLine("학과 : {1}", "컴소과", "키득");     //학과 : 키득

            //② 문자열 보간(Interpolation)
            //얘로 많이 쓰는 추세.. { } 안에 출력할 값을 직접 넣어주는 방법
            Console.WriteLine($"학과 : {"컴소과"}");

            //★★★상호 교환하는 문제 시험에 나올 예정★★★
            Console.WriteLine("{0}, {2}", 10, 20, "컴소");
            Console.WriteLine($"{10}, {"컴소"}");



            //★★★서식 항목★★★
            //{ } 안에 들어갈 수 있는 항목 형식 - {첨자, 맞춤:서식문자열}
            Console.WriteLine("Total : {0, -7:D}", 123);
            Console.WriteLine("Total : {0, 7:D}", 123);
            /* 첨자 : 0 (0번 index)
             * 맞춤 : -7 (7자리에 맞춰서 오른쪽 맞춤)
                       7 (7자리에 맞춰서 왼쪽 맞춤)
             * 서식문자열 : D (10진수 형태로 출력)
             */

            Console.WriteLine("{0, -10:D5}", 123);  //00123
            Console.WriteLine("{0, 10:D5}", 123);   //     00123
            //D5 (5자리를 확보해놓고 데이터 입력, 남는 자릿수는 0으로 채워진다.)

            int n = 456;
            string s = "배가 고파와요";
            Console.WriteLine("{0}, {1}", n, s);
            Console.WriteLine($"{n}, {s}");

            string fmt = "{0, -15}, {1, -10}, {2, 20}";
            Console.WriteLine(fmt, "Computer", "Fang Jin", "Programming");

            //서식문자열 N : 입력된 수를 콤마로 구분하여 출력
            Console.WriteLine("{0}", 123456789);        //123456789
            Console.WriteLine("{0:N}", 123456789);      //123,456,789.00
            Console.WriteLine("{0:N0}", 123456789);     //123,456,789 (소수점 이하 제거)

            //서식문자열 F : 실수형으로 표현
            Console.WriteLine("{0:F}", 123456789);     //123456789.00



            //자료형 변환
            //강제 형 변환
            var a = (int)10.0;
            var b = (float)10;
            var c = (double)20;
            Console.WriteLine(a.GetType());
            Console.WriteLine(b.GetType());
            Console.WriteLine(c.GetType());

            //데이터 손실
            long longNumber = 1231231231L + 1231231231L;
            int intNumber = (int)longNumber;
            Console.WriteLine(intNumber);   //-1832504834 언더플로우 발생



        }
    }
}
