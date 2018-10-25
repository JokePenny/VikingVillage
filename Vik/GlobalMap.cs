using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vik
{
    abstract public class GlobalMap
    {
        public byte x;// координата горизонтали
        public byte y;// координата вертикали
        public string Name { get; set; }

        public GlobalMap(byte X)
        {
            x = X;
        }

        public GlobalMap(byte Y, byte X)
        {
            y = Y;
            x = X;
        }
    }
}
