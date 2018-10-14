using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vik
{
    public class FossilsGold : Fossils
    {
        /*
        private byte x = 29;// координата горизонтали
        private byte y = 16;// координата вертикали
        private byte count;// число населения
        */
        private byte ID = 3;// индефикатор объекта 

        //геттеры

        public byte GetX()
        {
            return x;
        }
        public byte GetY()
        {
            return y;
        }
        public byte GetCount()
        {
            return count;
        }
        public byte GetID()
        {
            return ID;
        }

        //сеттеры

        public void SetX(byte A)
        {
            x = A;
        }
        public void SetY(byte A)
        {
            y = A;
        }
        public void SetCount(byte A)
        {
            count = A;
        }
    }
}
