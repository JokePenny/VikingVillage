using System.Drawing;

namespace Vik
{
    class BuildGoldRec : Build
    {
        private static byte ID = 20;// индефикатор объекта
        private byte distance;

        public BuildGoldRec(byte X, byte Y, byte Distance) : base(X, Y)
        {
            x = X;
            y = Y;
            distance = Distance;
        }
        public BuildGoldRec()
        {
        }

        public void SetImage()
        {
            Game.arr[x, y].BackgroundImage = Image.FromFile("C:\\Users\\IMP\\Desktop\\Kyrsovaya\\Новая папка\\images\\tree_160.png");
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
