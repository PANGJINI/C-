using System;

namespace project_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // 배열
            // 연속된 메모리 공간, 배열의 이름은 배열의 시작 주소이다.
            int score1 = 85;
            Console.WriteLine(score1);

            int[] scores = { 10, 20, 30, 40, 50 };
            Console.WriteLine(scores[2]);
            Console.WriteLine("\n");



            // 배열을 초기화하는 방법 4가지
            int[] arr1 = new int[5];    // new 메모리 할당 연산자

            // ①각 인덱스마다 직접 값을 대입
            arr1[0] = 86;   arr1[1] = 75;   arr1[2] = 82;
            arr1[3] = 95;   arr1[4] = 67;

            // ②선언과 동시에 중괄호 안에 초기화 (★기본)
            int[] arr2 = new int[5] { 86, 75, 82, 95, 67 };

            // ③중괄호 안에 초기값을 설정해주기 때문에 배열의 크기를 생략해도 됨
            int[] arr3 = new int[] { 86, 75, 82, 95, 67 };

            // ④초기값이 설정된 경우, 메모리 할당 연산자와 생성자를 생략할 수 있음 (★사용 빈도 높음)
            int[] arr4 = { 86, 75, 82, 95, 67 };


            
            // 배열의 각 원소를 모두 출력하고 싶을 때 foreach
            foreach (var i in arr4)    //arr4 배열에서 원소를 꺼내서 i에 저장할거임
            {
                Console.WriteLine(i);
            }
       
            int sum = 0;
            foreach (var i in arr4)
            {
                sum += i;
            }
            Console.WriteLine("sum : " + sum);
            double avg = sum / arr4.Length;
            Console.WriteLine("avg : " + avg);
            Console.WriteLine("avg : {0}", avg);
            Console.WriteLine($"avg : {avg}");



            // 문자열 배열
            string[] array1 = new string[3] { "김도영", "정재현", "김정우" };
            foreach (var item in array1)
            {
                Console.WriteLine(item);
                Console.WriteLine($"array1 : {item}");
            }



            // 무한 루프
            // for
            /* for ( ; ; )
            {
                Console.WriteLine("infinite");
            }
            */

            // while
            /*while (true)
            {
                Console.WriteLine("infinite");
            }
            */



            // for 반복문으로 덧셈하기
            int input = 1;
            for (int i = 1; i <= 10; i++)
            {
                input *= 1;
            }
            Console.WriteLine(input);



            // 역 for
            int[] intArray = { 10, 20, 30, 40, 50, 60 };
            for (int i = intArray.Length-1; i >= 0; i--)
            {
                Console.WriteLine(intArray[i]);
            }



            // foreach 반복문, 배열
            string[] array2 = { "사과", "딸기", "키위", "복숭아", "바나나" };
            foreach (var item in array2)
            {
                Console.WriteLine(item);
            }

            

            // ★★ for - while 교환 시험문제 나옴 ★★
            // while
            int index = 0;
            int[] intArray2 = { 52, 273, 45, 75, 84 };

            while (index < intArray2.Length)
            {
                Console.WriteLine(index+"번째 출력 : " + intArray2[index]);
                index++;
            }

            // for
            for (int i = 0; i < intArray2.Length; i++)
            {
                Console.WriteLine(i + "번째 출력 : " + intArray2[i]);
            }



            // do while
            string input2;
            do
            {
                Console.Write("입력 (exit를 입력할 경우 종료) : ");
                input2 = Console.ReadLine();
            } while (input2 != "exit");
            Console.WriteLine("나왔다.");



            // 배열 범위 벗어날 경우에 IndexOutOfRange 예외 발생
            int[] scores2 = { 10, 20, 30, 40, 50 };
            Console.WriteLine(scores[5]);

        }
    }
}
