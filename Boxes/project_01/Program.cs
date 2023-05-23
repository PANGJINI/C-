using System;

namespace project_01
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClassA objA = new MyClassA();
            objA.myField = 10;
            Console.WriteLine("objA.myField = " + objA.myField);
            Console.WriteLine();

            MyClassB objB = new MyClassB();
            objB.SetMyField(20);
            Console.WriteLine("objB.GetMyField() = " + objB.GetMyField());
            Console.WriteLine();

            MyClassC objC = new MyClassC();
            objC.MyField = 30;
            Console.WriteLine("objC.MyField = " + objC.MyField);
            Console.WriteLine();

            MyClassD objD = new MyClassD();
            objD.MyField = 40;
            Console.WriteLine("objD.MyField = " + objD.MyField);
            Console.WriteLine();
        }
    }
}
