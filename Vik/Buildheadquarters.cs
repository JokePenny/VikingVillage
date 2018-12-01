using System.Drawing;

namespace Vik
{
    class Buildheadquarters : Build
    {
        private byte distance = 0;// растояние 
        private static byte ID = 12;// индефикатор объекта 

        public Buildheadquarters(byte X, byte Y, ushort Health) : base(X, Y, Health)
        {
            x = X;
            y = Y;
            health = Health;
        }
        public Buildheadquarters()
        {
        }

        public void SetImage()
        {
            Game.arr[x,y].BackgroundImage = Image.FromFile("D:\\01Programms\\PHCS6\\Project\\Vikings\\builds\\r.png");
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
