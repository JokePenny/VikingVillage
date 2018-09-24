using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vik
{
    public class BuildWall
    {
        private byte x;// координата горизонтали
        private byte y;// координата вертикали
        private int health = 100;// здоровье


        //геттеры

        public byte GetX()
        {
            return x;
        }
        public byte GetY()
        {
            return y;
        }
        public int GetHealth()
        {
            return health;
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
        public void SetHealth(int A)
        {
            health = A;
        }
    }
}
