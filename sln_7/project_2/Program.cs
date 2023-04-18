using System;

namespace project_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // 중첩 반복문
            for (int dan = 2; dan <= 9; dan++)
            {
                //Console.WriteLine(dan + "단");
                Console.WriteLine($"{dan}단 : ");
                for (int i = 1; i <= 9 ; i++)
                {
                    //Console.WriteLine(dan + " x " + i + " = " + (dan*i));
                    Console.WriteLine($"{dan}x{i} = {dan*i, 0:D2}");
                }
                Console.WriteLine("");
            }



            // 별 피라미드(1)
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < i+1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }



            // 별 피라미드(2)
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 9-i ; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }



            // 별 피라미드 (3)
            /* 0 9 1
             * 1 8 3
             * 2 7 5
             * 3 6 7
             * 4 5 9
             * 5 4 11
             * 6 3 13
             */
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 9-i; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < (i*2) + 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }

            for (int i = 0; i < 10; i++)
            {
                for (int j = 9; j >= i ; j--)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < (i * 2) + 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }




            int ii, jj, sp = 8;
            for (ii = 1; ii <= 9; ii++)
            {
                for (jj = 1; jj <= sp; jj++)
                {
                    Console.Write(" ");
                }
                for (jj = 1; jj <= ii; jj++)
                {
                    //Console.Write(ii + " ");
                    Console.Write(" " + ii);
                }
                Console.WriteLine("");
                sp--;
            }




        }
    }
}
