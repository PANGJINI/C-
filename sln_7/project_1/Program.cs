using System;
using System.Collections.Generic;

namespace project_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // 배열 : 같은 데이터 타입을 가진 데이터들의 집합(고정)
            int[] array = new int[3] { 10, 30, 50 };
            int[] arryay2 = { 10, 30, 50 };
;

            foreach (var item in array)
            {
                Console.WriteLine(item);
            }



            // 리스트 : 같은 데이터 타입을 가진 데이터들의 집합(가변)
            // 메모리 공간의 크기를 변화시킬 수 있다
            List<int> lists = new List<int>();
            lists.Add(10);
            lists.Add(30);
            lists.Add(50);

            foreach (var item in lists)
            {
                Console.WriteLine(item);
            }



            // 리스트22
            List<int> list2 = new Lists<int>() { 15, 25, 35 };
            list2.Add(45);
            list2 Add(55);
            list2.Remove(55);
            list2.RemoveAt(0);
            list2.Insert(20)


            foreach (var item in collection)
            {

            }
        }
    }
}
