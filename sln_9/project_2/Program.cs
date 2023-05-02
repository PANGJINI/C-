using System;
using System.Collections.Generic;

namespace project_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Random 클래스
            Random random = new Random();
            Console.WriteLine(random.Next());
            Console.WriteLine(random.Next(10));
            Console.WriteLine(random.Next(10, 100));
            Console.WriteLine();
            Console.WriteLine(random.NextDouble());
            Console.WriteLine(random.NextDouble() * 10);
            Console.WriteLine();


            // 배열 생성
            int[] arr = new int[5] { 10, 20, 30, 40, 50 };


            // List 클래스의 인스턴스 생성
            // < > 제네릭, <데이터형> 데이터형을 일반화시키는 것
            List<int> list = new List<int>();
            
            List<int> list2 = new List<int> {10, 20, 30, 40, 50};
            // 제거 - 30을 삭제
            list2.Remove(30);
            // 삽입 - 2번 인덱스에 25를 삽입
            list2.Insert(2, 25);
            // 추가 - 맨 뒤에 80을 추가
            list2.Add(80);

            foreach (var item in list2)
            {
                Console.WriteLine("Count : " + item);
            }
            Console.WriteLine();


            // Math 클래스
            // 인스턴스를 생성하지 않고 바로 클래스 메서드에 접근해서 사용할 수 있다
            // 클래스임에도 미리 메모리공간을 확보하고 있는 것
            Console.WriteLine(Math.Abs(-10));
        }
    }
}
