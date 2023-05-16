using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_02
{
    class Cat
    {
        public string Name;
        public string Color;
        public int Age;

        public void Meow()
        { 
            Console.WriteLine($"{Name} : Meow=￣ω￣=");
        }

        public Cat(string name, string color, int age)    // 변스 초기화를 위해 생성자가 필요함
        {
            Name = name;
            Color = color;
            Age = age;
        }
    }
}
