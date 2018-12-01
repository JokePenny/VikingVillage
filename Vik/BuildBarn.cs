using System.Drawing;

namespace Vik
{
    class BuildBarn : Build
    {
        private static byte ID = 21;// индефикатор объекта 

        public BuildBarn(byte X, byte Y, ushort Health) : base(X,Y,Health)
        {
            x = X;
            y = Y;
            health = Health;
        }
        public BuildBarn()
        {
        }

        public void SetImage()
        {
            Game.arr[x, y].BackgroundImage = Image.FromFile("C:\\Users\\IMP\\Desktop\\Kyrsovaya\\Новая папка\\images\\tree_186.png");
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
