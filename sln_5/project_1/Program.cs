using System;

namespace project_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // if 조건문
            //string a = Console.ReadLine();
            //int input = int.Parse(a);
            int input = int.Parse(Console.ReadLine());

            if (input % 2 == 0)
            {
                Console.WriteLine("짝수");
            }
            if (input % 2 == 1)
            {
                Console.WriteLine("홀수");
            }           
            

            // if else 조건문
            if (input % 2 == 0)
            {
                Console.WriteLine("짝수");
            }
            else
            {
                Console.WriteLine("홀수");
            }


            // switch 조건문
            switch (input % 2)
            {
                case 0:     // 콜론 자체가 블록(중괄호)의 역할을 함, case 절의 수식은 반드시 정수여야 함
                    Console.WriteLine("짝수");
                    break;
                case 1:
                    Console.WriteLine("홀수");
                    break;
                default:    //default 생략 가능, 어떤 case문에도 해당하지 않는 경우에 실행됨
                    break;
            }


            // 오전과 오후 구분하기
            if (DateTime.Now.Hour < 12)
            {
                Console.WriteLine("오전입니다.");
            }
            else
            {
                Console.WriteLine("오후입니다.");
            }


            // 중첩 조건문
            if (DateTime.Now.Hour < 11)
            {
                Console.WriteLine("아침");
            }
            else
            {
                if (DateTime.Now.Hour < 15)
                {
                    Console.WriteLine("점심");
                }
                else
                {
                    Console.WriteLine("저녁");
                }
            }


            // if else if 조건문  : 중첩 조건문의 복잡성에 대한 해결
            if (DateTime.Now.Hour < 11)
            {
                Console.WriteLine("아침");
            }
            else if (DateTime.Now.Hour < 15)
            {
                Console.WriteLine("점심");
            }
            else
            {
                Console.WriteLine("저녁");
            }


            Console.Write("금액을 입력하세요 : ");
            int money = int.Parse(Console.ReadLine());

            // 20000을 입력할 경우 조건에 맞는 모든 명령을 출력해줌
            if (money >= 20000) { Console.WriteLine("칠리새우"); }
            if (money >= 10000) { Console.WriteLine("쟁반짜장"); }
            if (money >= 7000)  { Console.WriteLine("짬뽕"); }
            if (money >= 6000) { Console.WriteLine("짜장면"); }
            else { Console.WriteLine("라면"); }

            // else if는 조건을 반복적으로 점검하여 상황에 맞는 명령 하나만 선택해줌
            if (money >= 20000) { Console.WriteLine("칠리새우"); }
            else if(money >= 10000) { Console.WriteLine("쟁반짜장"); }
            else if (money >= 7000) { Console.WriteLine("짬뽕"); }
            else if(money >= 6000) { Console.WriteLine("짜장면"); }
            else { Console.WriteLine("라면"); }





            // 논리연산자와 조건문
            Console.Write("학점을 입력하세요 : ");
            double score = double.Parse(Console.ReadLine());

            if (score == 4.5)
                Console.WriteLine("A+");
            else if (score >= 4.0 && score < 4.5)
                Console.WriteLine("A");
            else if (score >= 3.5 && score < 4.0)
                Console.WriteLine("B+");
            else if (score >= 3.0 && score < 3.5)
                Console.WriteLine("B");
            else if (score >= 2.5 && score < 3.0)
                Console.WriteLine("C+");
            else if (score >= 2.0 && score < 2.5)
                Console.WriteLine("C");
            else if (score >= 1.5 && score < 2.0)
                Console.WriteLine("D+");
            else if (score >= 1.0 && score < 1.5)
                Console.WriteLine("D");
            else
                Console.WriteLine("F");


            // 조건문 간단하게 사용하기
            // if else 조건문은 이전에 비교했던 것이 자동으로 반영되기 때문에 이전에 비교한 내용을 다시 비교할 필요가 없다.
            if (score == 4.5)
                Console.WriteLine("A+");
            else if (score >= 4.0)
                Console.WriteLine("A");
            else if (score >= 3.5)
                Console.WriteLine("B+");
            else if (score >= 3.0)
                Console.WriteLine("B");
            else if (score >= 2.5)
                Console.WriteLine("C+");
            else if (score >= 2.0)
                Console.WriteLine("C");
            else if (score >= 1.5)
                Console.WriteLine("D+");
            else if (score >= 1.0)
                Console.WriteLine("D");
            else
                Console.WriteLine("F");





            // 삼항연산자
            Console.Write("입력 : ");
            int num = int.Parse(Console.ReadLine());

            //① 참과 거짓의 위치에 bool 자료형 사용
            Console.WriteLine(num % 2 == 0 ? true : false);

            //② 참과 거짓의 위치에 문자열 자료형 사용
            Console.WriteLine(num % 2 == 0 ? "짝수" : "홀수");

            // 삼항 연산자를 이용한 자연수 판별
            Console.WriteLine(num > 0 ? "자연수입니다." : "자연수가 아닙니다.");





            










        }
    }
}
