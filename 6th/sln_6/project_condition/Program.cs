using System;

namespace project_condition
{
    class Program
    {
        static void Main(string[] args)
        {
            // if 조건문으로 계절
            Console.Write("이번달은 몇 월인가요? : ");
            int month2 = int.Parse(Console.ReadLine());

            if (month2 == 12 || month2 == 1 || month2 == 2)
                Console.WriteLine("겨울");
            else if (month2 >= 3 && month2 <= 5)
                Console.WriteLine("봄");
            else if (month2 >= 6 && month2 <= 8)
                Console.WriteLine("여름");
            else if (month2 >= 9 && month2 <= 11)
                Console.WriteLine("가을");
            else
                Console.WriteLine("잘못 입력");


            //교수님 코드
            Console.Write("이번달은 몇 월인가요? : ");
            int month3 = int.Parse(Console.ReadLine());

            if (3 <= month3 && month3 <= 5)
                Console.WriteLine("봄");
            else if (6 <= month3 && month3 <= 8)
                Console.WriteLine("여름");
            else if (9 <= month3 && month3 <= 11)
                Console.WriteLine("가을");
            else if (month3 == 12 || 1 <= month3 && month3 <= 2)
                Console.WriteLine("겨울");
            else
                Console.WriteLine("잘못 입력했다.");


            //논리곱의 조건 확인 중복 문제
            Console.Write("이번달은 몇 월인가요? : ");
            int month4 = int.Parse(Console.ReadLine());

            if (month4 == 12)
                Console.WriteLine("겨울");
            else if (9 <= month4 && month4 < 13)
                Console.WriteLine("가을");
            else if (6 <= month4 && month4 < 13)
                Console.WriteLine("여름");
            else if (3 <= month4 && month4 < 13)
                Console.WriteLine("봄");
            else if (1 <= month4 && month4 < 13)
                Console.WriteLine("겨울");
            else
                Console.WriteLine("잘못 입력");
        }
    }
}
