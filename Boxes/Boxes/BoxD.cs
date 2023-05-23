using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boxes
{
    /// <summary>
    /// 일반적인 속성 생성 방법
    /// </summary>
    class BoxD
    {
        // 필드
        private int width;  //일반 변수는 소문자로 작성
        public int Width    //속성명을 지정할 때는 변수명 앞글자 대문자 (width 변수에 접근할 수 있는 속성을 지정한 것)
        {
            get { return width; }   //⭐get - 값 추출, return 존재
            set                     //⭐set - value 키워드 사용
            {  
                // value 키워드 : 매개변수와 같은 기능을 하는 것
                if (value>0) { width = value;  }
                else { Console.WriteLine("너비는 자연수를 입력하렴.."); }
            }
        }

        private int height;
        public int Height
        {
            get { return height; }
            set
            {
                if(value > 0) { height = value; }
                else { Console.WriteLine("높이는 자연수를 입력하세요.."); }
            }
        }

        public int Area() //넓이 구하는 메서드
        {
            //return this.width * this.height;
            return Width * Height;
        }

        public BoxD(int width, int height)   //생성자
        {
            // 속성으로 필드에 접근할 수 있다.
            // this.width = width;
            Width = width;
            // this.height = height;
            Height = height;
        }

    }
}
