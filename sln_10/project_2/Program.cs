using System;

namespace project_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Test test = new Test();
            Console.WriteLine(test.Power(3));
            Console.WriteLine(test.Power(10));
            //Console.WriteLine(Test.Power(10)); --> 에러
            Console.WriteLine();



            //Calcurator calcurator = new Calcurator();
            // Calcurator의 메서드들은 모두 static으로 메모리공간을 이미 할당받은 상태
            // 메모리를 다시 할당할 필요가 없다.
            Console.WriteLine(Calcurator.Plus(1, 2));
            int result1 = Calcurator.Plus(1, 2);
            Console.WriteLine(result1);
            Console.WriteLine(Calcurator.Minus(1,2));
            int result2 = Calcurator.Minus(1, 2);
            Console.WriteLine(result2);
            Console.WriteLine();





        }
    }
}
