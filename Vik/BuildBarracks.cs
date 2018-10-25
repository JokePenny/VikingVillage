using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Vik
{
    class BuildBarracks : Build
    {
        private byte ID = 22;// индефикатор объекта 

        public BuildBarracks(byte X, byte Y, ushort Health) : base(X, Y, Health)
        {
            x = X;
            y = Y;
            health = Health;
        }
        public BuildBarracks()
        {
        }

        public void SetImage()
        {
            Form2.arr[x, y].BackgroundImage = Image.FromFile("D:\\01Programms\\PHCS6\\Project\\Vikings\\builds\\images\\tree_279.png");
        }

        public void SetDeleteImage()
        {
            Form2.arr[x, y].BackgroundImage = Image.FromFile("D:\\01Programms\\PHCS6\\Project\\Vikings\\images\\tree_03.png");
        }

        //геттеры

        public byte GetX()
        {
            return x;
        }
        public byte GetY()
        {
            return y;
        }
        public ushort GetHealth()
        {
            return health;
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
        public void SetHealth(ushort A)
        {
            health = A;
        }
    }
}
