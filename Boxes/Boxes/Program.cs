using System;

namespace Boxes
{
    class Program
    {
        static void Main(string[] args)
        {
            BoxA boxA = new BoxA(-10, 10);
            Console.WriteLine("boxA : " + boxA.Area());
            Console.WriteLine();

            /*
             BoxB boxB = new BoxB(-10, 10);
                // 생성자의 접근지정자가 private이기 때문에 생성자로 값을 초기화 할 수 없다.
             BoxB.width = -10;
                // private이기 때문에 변수에 접근할 수 없다.
             Console.WriteLine(boxB.Area());
            */

            BoxC boxC = new BoxC(20, 10);
            // BoxC.width = 10;
            // private 변수에 개별적으로 접근할 수 없다.
            Console.WriteLine("boxC : " + boxC.Area());
            Console.WriteLine();

            BoxD boxD = new BoxD(20, 20);
            Console.WriteLine("boxD.Area() : " + boxD.Area());
            Console.WriteLine("boxD.Width : " + boxD.Width);
            Console.WriteLine("boxD.Height : " + boxD.Width);
            Console.WriteLine();

            BoxE boxE = new BoxE(-20, 20);
            Console.WriteLine("boxE.Area() : " + boxE.Area());
            Console.WriteLine("boxE.Width : " + boxE.Width);
            Console.WriteLine("boxE.Height : " + boxE.Width);


        }
    }
}
