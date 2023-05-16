using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_01
{
    class MainApp
    {
        /* 함수 형태 4가지
         * 입력x 리턴x
         * 입력o 리턴x
         * 입력x 리턴o
         * 입력o 리턴o
         
         * 매개변수 parameter  /  인수 argument(실인수, 실제 값)
           실인수를 매개변수에 보내주어서 연산이 이루어지는 것
         
         */

        public static int Plus(int a, int b)
        {
            Console.WriteLine("Calling in Plus(int, int)");
            return a + b;
        }

        public static int Plus(int a, int b, int c)
        {
            Console.WriteLine("Calling in Plus(int, int, int)");
            return a + b + c;
        }

        public static double Plus(double a, double b)
        {
            Console.WriteLine("Calling in Plus(double, double)");
            return a + b;
        }

        public static double Plus(double a, double b, double c )
        {
            Console.WriteLine("Calling in Plus(double, double, double)");
            return a + b + c;
        }


    }
}
