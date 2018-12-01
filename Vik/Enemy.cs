using System.Drawing;

namespace Vik
{
    class Enemy : Build
    {
        private byte level;
        private static byte ID = 100;

        public Enemy(byte X, byte Y, ushort Health, byte Level) : base(X, Y, Health)
        {
            x = X;
            y = Y;
            health = Health;
            level = Level;
        }

        public Enemy()
        {
        }

        public void SetImage()
        {
            Game.arr[x, y].BackgroundImage = Image.FromFile("D:\\01Programms\\PHCS6\\Project\\Vikings\\builds\\123.png");
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
        public byte GetLevel()
        {
            return level;
        }

        //сеттеры
        public void SetLevel(byte A)
        {
            level = A;
        }
    }
}
