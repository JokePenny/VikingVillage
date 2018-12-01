using System.Drawing;

namespace Vik
{
    class BuildWall : Build
    {
        private static byte ID = 17;// индефикатор объекта 

        public BuildWall(byte X, byte Y, ushort Health) : base(X, Y, Health)
        {
            x = X;
            y = Y;
            health = Health;
        }
        public BuildWall()
        {
        }

        public void SetImage()
        {
            Game.arr[x, y].BackgroundImage = Image.FromFile("D:\\01Programms\\PHCS6\\Project\\Vikings\\builds\\r.png");
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
