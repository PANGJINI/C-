using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_01
{
    /// <summary>
    /// 일반적인 속성 생성 방법
    /// ⭐⭐시험⭐⭐ 일반적인 속성 <-> 간단한 속성 생성 방법 상호교환
    /// </summary>
    class MyClassC
    {
        private int myField;
        public int MyField
        {
            get { return myField; }
            set { myField = value; }
        }
    }
}
