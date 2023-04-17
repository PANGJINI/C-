using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // 조건문
            // 사용자에게 태어난 년도를 입력받아 그 해의 띠를 출력하는 프로그램
            Console.Write("태어난 연도 입력 : ");
            int year = int.Parse(Console.ReadLine());

            switch (year % 12)
            {
                case 0:
                    Console.Write("원숭이");
                    break;
                case 1:
                    Console.Write("닭");
                    break;
                case 2:
                    Console.Write("개");
                    break;
                case 3:
                    Console.Write("돼지");
                    break;
                case 4:
                    Console.Write("쥐");
                    break;
                case 5:
                    Console.Write("소");
                    break;
                case 6:
                    Console.Write("범");
                    break;
                case 7:
                    Console.Write("토끼");
                    break;
                case 8:
                    Console.Write("용");
                    break;
                case 9:
                    Console.Write("뱀");
                    break;
                case 10:
                    Console.Write("말");
                    break;
                case 11:
                    Console.Write("양");
                    break;
                default:
                    break;
            }
            Console.WriteLine("띠 입니다.");




            // 조건문
            // if문으로 작성된 프로그램을 switch 조건문으로 옮기세요
            Console.Write("학년 입력 : ");
            int level = int.Parse(Console.ReadLine());

            switch (level)
            {
                case 1:
                    Console.WriteLine("수강해야 하는 전공 학점 : 12학점");
                    break;
                case 2:
                    Console.WriteLine("수강해야 하는 전공 학점 : 18학점");
                    break;
                case 3:
                    Console.WriteLine("수강해야 하는 전공 학점 : 10학점");
                    break;
                case 4:
                    Console.WriteLine("수강해야 하는 전공 학점 : 18학점");
                    break;
                default:
                    break;
            }



            // 반복문
            // for 반복문을 while 반복문으로 바꿔보세요
            int i = 0;
            while(i < 10)
            {
                Console.WriteLine("출력");
                i++;
            }



            // 반복문
            // 별 피라미드 만들기
            /* 0 공백7 별1
             * 1 공백6 별3
             * 2 공백5 별5
             * 3 공백4 별7
             * 4 공백3 별9
             * 5 공백2 별11
             * 6 공백1 별13
             * 7 공백0 별15
             */
            for (int j = 0; j < 8; j++)
            { 
                for (int k = 0;  k < 7-j; k++)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k < 2*j+1; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }

            string[] starArr = { "       *", "      ***", "     *****", "    *******", "   *********", "  ***********", " *************", "***************"};
            foreach (var item in starArr)
            {
                Console.WriteLine(item);
            }



        }
        


    }
}
