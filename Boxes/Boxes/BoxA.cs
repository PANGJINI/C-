using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boxes
{
    class BoxA
    {
        // 필드 (멤버변수)
        public int width;
        public int height;

        public int Area()   //메서드 정의
        {
            return this.width * this.height;
        }

        public BoxA(int width, int height)       //생성자 정의
        {
            this.width = width;
            this.height = height;
        }
    }
}
