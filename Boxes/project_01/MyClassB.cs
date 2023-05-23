using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_01
{
    /// <summary>
    /// Setter, Getter 메서드
    /// </summary>
    class MyClassB
    {
        // 필드
        private int myField;

        // Getter
        public int GetMyField()
        {
            return myField;
        }

        // Setter
        public void SetMyField(int value)
        {
            myField = value;
        }
    }
}
