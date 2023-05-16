using System;

namespace project_02
{
    class Program
    {
        static void Main(string[] args)
        {
            // 접근제한자 (한정자)
            /* 은닉성 : 객체지향 프로그래밍은 클래스의 사용자에게 필요한 최소한의 기능만을 노출하고, 내부를 감출 것을 요구함
             
             * C#에서 제공하는 접근 제한자
             ①public : 클래스의 내부/외부 모든 곳에서 접근
             ②protected : 클래스의 외부에서는 접근할 수 없음, 파생 클래스에서는 접근 가능
             ③private : 클래스의 내부에서만 접근 가능

             internal
             protected internal
             private protected
             */


            // 생성자
            /* 생성자의 클래스와 이름이 같고, 반환형식이 없다.
             * 왜 생성자가 필요할까?
               해당 형식(클래스)의 객체를 생성하기 위해
             * 왜 생성자를 구현해야 할까?
               객체의 필드(변수)를 원하는 값으로 초기화하고 싶을 때 구현
             */


            Cat kitty = new Cat("kitty", "cheese", 2);
            kitty.Meow();
            Console.WriteLine($"{kitty.Name} : {kitty.Color}, {kitty.Age}살");
            Console.WriteLine();

            Cat Nero = new Cat("Nero", "black", 2);
            Nero.Meow();
            Console.WriteLine($"{Nero.Name} : {Nero.Color}, {Nero.Age}살");
            Console.WriteLine();

            Cat Cuttie = new Cat("Cuttie", "white", 1);
            Cuttie.Meow();
            Console.WriteLine($"{Cuttie.Name} : {Cuttie.Color}, {Cuttie.Age}살");
            Console.WriteLine();

        }
    }
}
