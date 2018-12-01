using System.Drawing;

namespace Vik
{
    class Buildstorage : Build
    {
        private static byte ID = 25;// индефикатор объекта 

        public Buildstorage(byte X, byte Y, ushort Health) : base(X, Y, Health)
        {
            x = X;
            y = Y;
            health = Health;
        }
        public Buildstorage()
        {
        }

        public void SetImage()
        {
            Game.arr[x, y].BackgroundImage = Image.FromFile("D:\\01Programms\\PHCS6\\Project\\Vikings\\builds\\images\\tree_126.png");
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
