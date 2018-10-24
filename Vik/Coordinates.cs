using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vik
{
    public abstract class Coordinates
    {
        public byte X { get; set; }
        public byte Y { get; set; }
        public ushort Health { get; set; }
    }
}
