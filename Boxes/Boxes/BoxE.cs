using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boxes
{
    /// <summary>
    ///  간단한 속성 생성 방법
    /// </summary>
    class BoxE
    {
        // 필드
        private int width;  //일반변수
        public int Width    //속성
        {
            get; set;
        }

        private int height;
        public int Height
        {
            get; set;
        }

        public int Area() //넓이 구하는 메서드
        {
            //return this.width * this.height;
            return Width * Height;
        }

        public BoxE(int width, int height)   //생성자
        {
            // 속성으로 필드에 접근할 수 있다.
            // this.width = width;
            Width = width;
            // this.height = height;
            Height = height;
        }


    }
}
