using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Vik
{
    abstract class Build
    {
        public byte x;
        public byte y;
        public ushort health;// здоровье
        public Build(byte X, byte Y, ushort Health)
        {
            x = X;
            y = Y;
            health = Health;
        }
        public Build(byte X, byte Y)
        {
            x = X;
            y = Y;
        }
        public Build()
        {
        }
    }
}
