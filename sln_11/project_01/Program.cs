using System;

namespace project_01
{
    class MyMath
    {
        //리턴형이 다르면 같은 이름(식별자)의 함수를 만들 수 있다
        public static int Abs(int input)
        {
            if (input < 0)
                return -input;
            else
                return input;
        }

        public static double Abs(double input)  
        {
            if (input < 0)
                return -input;
            else
                return input;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //오버로딩 : 하나의 메서드 이름에 여러 개의 구현을 올리는 것을 뜻함    

            //int Abs
            Console.WriteLine(MyMath.Abs(-52));  //클래스 메서드(멤버 이름으로 바로 abs에 접근 가능함)
            Console.WriteLine(MyMath.Abs(52));
            Console.WriteLine();

            Console.WriteLine(MainApp.Plus(10, 20));
            Console.WriteLine(MainApp.Plus(30, 40, 50));
            Console.WriteLine(MainApp.Plus(10.123, 20.123));
            Console.WriteLine(MainApp.Plus(10, 12.345));            //10이 자동으로 double로 형변환 됨
            Console.WriteLine(MainApp.Plus(30.12, 40.123, 50.12));
        }
    }
}
