using System;
using System.Collections.Generic;
using System.Text;

namespace project_2
{
    class MyMath
    {
        //★★★클래스 멤버로 올 수 있는 것 - 변수, 메서드, 생성자, 프로퍼티 속성

        public static int Abs(int input)
        {
            if (input >= 0)
                return input;
            else
                return -input;
        }
    }
}
