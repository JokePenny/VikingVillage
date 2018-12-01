using System.Drawing;

namespace Vik
{
    class Buildfield : Build
    {
        private static byte ID = 10;// индефикатор объекта 

        public Buildfield(byte X, byte Y, ushort Health) : base(X, Y, Health)
        {
            x = X;
            y = Y;
            health = Health;
        }
        public Buildfield()
        {
        }

        public void SetImage()
        {
            Game.arr[x, y].BackgroundImage = Image.FromFile("D:\\01Programms\\PHCS6\\Project\\Vikings\\builds\\images\\tree_94.png");
        }

        public void SetDeleteImage()
        {
            Game.arr[x, y].BackgroundImage = Image.FromFile("D:\\01Programms\\PHCS6\\Project\\Vikings\\images\\tree_03.png");
        }

        //геттеры
        public byte GetID()
        {
            return ID;
        }
    }
}
