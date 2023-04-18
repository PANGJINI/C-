using System;
using System.Threading;

namespace project_3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            // break문
            // 반복문을 탈출한다~~~, 실행종료
            while (true)
            {
                Console.Write("숫자를 입력(짝수 입력시 종료) : ");
                int input = int.Parse(Console.ReadLine());

                if (input % 2 != 1)
                {
                    Console.WriteLine(input);
                }
                else
                    break;
            }
            */


            // continue문
            // continue를 만날 경우에 아래 조건을 실행하지 않고 다음 반복을 실행한다.
            for (int i = 0; i < 10; i++)
            {
                if(i % 2 == 0)
                {
                    continue;
                }
                //Console.WriteLine(i);
                Console.WriteLine($"{i} : 홀수");

            }



            // thread sleep 메소드
            Console.WriteLine("첫 번째 출력");
            Thread.Sleep(1000);
            Console.WriteLine("두 번째 출력");
            Thread.Sleep(1500);
            Console.WriteLine("세 번째 출력");


        }
    }
}
