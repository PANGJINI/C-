using System;

namespace project_3
{
    class Program
    {
        // 클래스 멤버로 들어갈 수 있는 것 네 가지 기억 --> 변수, 메소드, 생성자, 프로퍼티

        class Cat
        {
            public string Name;
            public string Color;

            public void Meow()
            {
                Console.WriteLine($"{Name} : ~o( =∩ω∩= )m~");
            }

            public Cat(string name, string color)    //생성자 정의(선언) - 객체를 초기화함(초기값 설정)
            {
                Name = name;
                Color = color;
            }
        }



        static void Main(string[] args)
        {
            Cat nero = new Cat("NERO", "BLACK");    // public Cat() 생성자 없이 이런 방식으로 객체를 생성할 경우 에러
            nero.Meow();
            Console.WriteLine($"{nero.Name} : {nero.Color}");

            Cat kitty = new Cat("KITTY", "PINK");
            kitty.Meow();
            Console.WriteLine($"{kitty.Name} : {kitty.Color}");
        }
    }
}
