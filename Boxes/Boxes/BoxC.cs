using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boxes
{
    class BoxC
    {
        // setter, getter 메서드
        // 변수를 바로 수정할 수는 없지만 변수를 변경하는 메서드를 만들고, 메서드를 호출해서 변경


        // 필드는 private으로 선언
        private int width;
        private int height;


        // 메서드, 생성자는 public으로 선언
        public int Area()
        {
            return this.width * this.height;
        }

        public BoxC(int width, int height)
        {
            if (width > 0 && height > 0)
            {
                this.width = width;
                this.height = height;
            }
            else
            {
                Console.WriteLine("너비와 높이는 0보다 커야합니다.");
            }
        }


        // Setter, Getter → 변수가 많아지면 코드가 길어진다.

        // Getter
        // Getter에는 반드시 return 키워드가 있어야 함
        public int GetWidth()
        {
            return width;
        }
        public int GetHeight()
        {
            return height;
        }

        // Setter
        public void SetWidth()
        {
            if (width > 0)
                this.width = width;
            else
                Console.WriteLine("너비는 자연수로 입력하세요.");
        }
        public void SetHeight()
        {
            if (height > 0)
                this.height = height;
            else
                Console.WriteLine("높이는 자연수로 입력하세요.");
        }



    }
}
