using System;

namespace project_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // switch 조건문으로 계절 
            Console.Write("이번달은 몇 월인가요? : ");
            int month = int.Parse(Console.ReadLine());

            switch (month)
            {
                case 12:
                case 1:
                case 2:
                    Console.WriteLine("겨울.");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("봄");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("여름");
                    break;
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("가을");
                    break;
                default:
                    Console.WriteLine("잘못 입력했다.");
                    break;
            }


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












        }
    }
}
