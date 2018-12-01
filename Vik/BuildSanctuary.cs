using System.Drawing;

namespace Vik
{
    class BuildSanctuary : Build
    {
        private static byte ID = 24;// индефикатор объекта 

        public BuildSanctuary(byte X, byte Y, ushort Health) : base(X, Y, Health)
        {
            x = X;
            y = Y;
            health = Health;
        }
        public BuildSanctuary()
        {
        }

        public void SetImage()
        {
            Game.arr[x, y].BackgroundImage = Image.FromFile("C:\\Users\\IMP\\Desktop\\Kyrsovaya\\Новая папка\\images\\tree_221.png");
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
