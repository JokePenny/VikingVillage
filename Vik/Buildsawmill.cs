using System.Drawing;

namespace Vik
{
    class Buildsawmill : Build
    {
        private byte distance;// растояние 
        private static byte ID = 16;// индефикатор объекта 

        public Buildsawmill(byte X, byte Y, byte Distance) : base(X, Y)
        {
            x = X;
            y = Y;
            distance = Distance;
        }
        public Buildsawmill()
        {
        }

        public void SetImage()
        {
            Game.arr[x, y].BackgroundImage = Image.FromFile("D:\\01Programms\\PHCS6\\Project\\Vikings\\builds\\images\\tree_218.png");
        }

        public void SetDeleteImage()
        {
            Game.arr[x, y].BackgroundImage = Image.FromFile("D:\\01Programms\\PHCS6\\Project\\Vikings\\images\\tree_03.png");
        }

        //геттеры
        public byte GetDistance()
        {
            return distance;
        }
        public byte GetID()
        {
            return ID;
        }

        //сеттеры
        public void SetDistance(byte A)
        {
            distance = A;
        }
    }
}
