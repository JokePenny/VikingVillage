﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vik
{
    public class FossilsEat
    {
        private byte x = 0;// координата горизонтали
        private byte y = 0;// координата вертикали
        private byte count;// число населения

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
