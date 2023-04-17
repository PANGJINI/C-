using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //반복
           


            //역 for
            int[] intArr = { 10, 20, 30, 40, 50 };
            int sum = 0;
            for (int i = intArr.Length-1; i >= 0; i--)
            {
                sum += intArr[i];
            }
            Console.WriteLine(sum);



            //배열
            int[] intArr2 = { 10, 20, 30, 40, 50 };
            string[] strArr = { "딸기", "바나나", "사과"};
            Console.WriteLine(strArr.Length);

            int[] intArr3 = new int[100];   //100 크기의 int 배열 생성, 0으로 초기화
            Console.WriteLine(intArr2[2]);



            //for each
            foreach (var item in strArr)
            {
                Console.WriteLine(item);
            }



            //중첩 for
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < i + 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
            
        }
    }
}
