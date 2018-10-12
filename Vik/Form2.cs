using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;


namespace Vik
{
    public partial class Form2 : Form
    {
        private static Build Building = new Build();
        private static FossilsEat EatResources = new FossilsEat();
        private static FossilsForest ForestResources = new FossilsForest();
        private static FossilsStone StoneResources = new FossilsStone();
        private static FossilsGold GoldResources = new FossilsGold();
        //private static ResourceVillage Village = new ResourceVillage();
        ResourceVillage Village = ResourceVillage.GetInstance();
        private int[,] matrix = new int[30, 30];
        private byte[,] BuildMap = new byte[30, 30];
        private int[] buildX = new int[100];
        private int[] buildY = new int[100];
        private int[] enemyX = new int[50];
        private int[] enemyY = new int[50];
        private int[,] wall = new int[30, 30];
        public Form2()
        {
            InitializeComponent();
            Building.Goldmine = new Buildgoldmine[10];
            Building.Quarry = new Buildquarry[10];
            Building.Sawmill = new Buildsawmill[10];
            Building.Watchtower = new Buildwatchtower[30];
            Building.Storage = new Buildstorage[10];
            Building.Field = new Buildfield[20];
            Building.Headquarters = new Buildheadquarters[1];
            Building.Home = new Buildhome[30];
            Building.Market = new Buildmarket[1];
            Building.Wall = new BuildWall[200];
            for(byte j = 0; j < 10; j++)
            {
                Building.Goldmine[j] = new Buildgoldmine();
                Building.Goldmine[j].SetX(254);
                Building.Goldmine[j].SetY(254);
                Building.Goldmine[j].SetHealth(0);
                Building.Goldmine[j].SetDistance(254);
                Building.Quarry[j] = new Buildquarry();
                Building.Quarry[j].SetX(254);
                Building.Quarry[j].SetY(254);
                Building.Quarry[j].SetHealth(0);
                Building.Quarry[j].SetDistance(254);
                Building.Sawmill[j] = new Buildsawmill();
                Building.Sawmill[j].SetX(254);
                Building.Sawmill[j].SetY(254);
                Building.Sawmill[j].SetHealth(0);
                Building.Sawmill[j].SetDistance(254);
                Building.Storage[j] = new Buildstorage();
                Building.Sawmill[j].SetX(254);
                Building.Sawmill[j].SetY(254);
                Building.Sawmill[j].SetHealth(0);
            }
            for (byte j = 0; j < 30; j++)
            {
                Building.Watchtower[j] = new Buildwatchtower();
                Building.Watchtower[j].SetX(254);
                Building.Watchtower[j].SetY(254);
                Building.Watchtower[j].SetHealth(0);
                Building.Watchtower[j].SetDistance(254);
                Building.Home[j] = new Buildhome();
                Building.Home[j].SetX(254);
                Building.Home[j].SetY(254);
                Building.Home[j].SetHealth(0);
            }
            for (byte j = 0; j < 20; j++)
            {
                Building.Field[j] = new Buildfield();
                Building.Field[j].SetX(254);
                Building.Field[j].SetY(254);
                Building.Field[j].SetHealth(0);
                Building.Field[j].SetDistance(254);
            }
            for (byte j = 0; j < 100; j++)
            {
                Building.Wall[j] = new BuildWall();
                Building.Wall[j].SetX(254);
                Building.Wall[j].SetY(254);
                Building.Wall[j].SetHealth(0);
            }

            this.WindowState = FormWindowState.Maximized;
            ToolTip t = new ToolTip();
            //t.SetToolTip(button2, "Подсказка для TextBox");
            int i = 0;
            for (; i < 30; i++)
            {
                arr[i, 0] = addButton(i, 0);
                for (int i2 = 1; i2 < 17; i2++)
                    arr[i, i2] = addButton(i, i2);
            }
            matrix[0, 0] = 1;
            matrix[29, 0] = 1;
            matrix[0, 16] = 1;
            matrix[29, 16] = 1;
            matrix[0, 15] = 1;
            matrix[0, 14] = 1;
            matrix[1, 14] = 1;
            matrix[1, 15] = 1;
            matrix[1, 16] = 1;
            matrix[2, 15] = 1;
            matrix[2, 16] = 1;
            matrix[0, 1] = 1;
            matrix[1, 0] = 1;
            matrix[9, 0] = 1;
            matrix[9, 1] = 1;
            matrix[9, 2] = 1;
            matrix[9, 3] = 1;
            matrix[8, 4] = 1;
            matrix[8, 3] = 1;
            matrix[7, 3] = 1;
            matrix[7, 4] = 1;
            matrix[19, 5] = 1;
            matrix[24, 1] = 1;
            matrix[27, 0] = 1;
            matrix[28, 0] = 1;
            matrix[27, 1] = 1;
            matrix[28, 1] = 1;
            matrix[29, 1] = 1;
            matrix[28, 2] = 1;
            matrix[29, 2] = 1;
            matrix[29, 14] = 1;
            matrix[29, 15] = 1;
            matrix[28, 14] = 1;
            matrix[28, 15] = 1;
            matrix[28, 16] = 1;
            matrix[27, 15] = 1;
            matrix[27, 16] = 1;
            matrix[16, 14] = 1;
            matrix[16, 15] = 1;
            matrix[16, 16] = 1;
            matrix[15, 16] = 1;
            matrix[15, 15] = 1;
            matrix[3, 9] = 1;
            matrix[12, 1] = 1;
            matrix[15, 1] = 1;
            matrix[17, 2] = 1;
            matrix[20, 1] = 1;
            matrix[13, 3] = 1;
            matrix[15, 5] = 1;
            matrix[11, 6] = 1;
            matrix[10, 9] = 1;
            matrix[16, 10] = 1;
            matrix[22, 6] = 1;
            matrix[24, 5] = 1;
            matrix[21, 9] = 1;
            matrix[4, 12] = 1;
            matrix[4, 13] = 1;
            matrix[6, 15] = 1;
            matrix[20, 11] = 1;
            matrix[8, 11] = 1;
            matrix[8, 2] = 1;
            matrix[7, 2] = 1;
        }

        public static Button[,] arr = new Button[30, 30];

        private void b_Click(object sender, EventArgs e)
        {
            Point p = (Point)(sender as Button).Tag;
            byte treY = Convert.ToByte(p.Y);
            byte treX = Convert.ToByte(p.X);
            if (BuildMap[p.X, p.Y] == 0)
            {
                if (Village.GetChoose() == 1) // создание базы
                {
                    Form7 f = new Form7();
                    f.ShowDialog();
                    // определяем коорд базы
                    Building.Headquarters[0] = new Buildheadquarters();
                    Building.Headquarters[0].SetX(Convert.ToByte(p.X));
                    Building.Headquarters[0].SetY(Convert.ToByte(p.Y));
                    byte x = 0;
                    for (byte i = 0; i < x + 1; i++)
                    {
                        if (treY > EatResources.GetY())
                            treY--;
                        else if (treY < EatResources.GetY())
                            treY++;
                        if (treX > EatResources.GetX())
                            treX--;
                        else if (treX < EatResources.GetX())
                            treX++;
                        if (treY == 0 && treX == 0)
                        {
                            x++;
                            Building.Headquarters[0].SetDistance(x);
                            i = 254;
                        }
                        else
                            x++;
                    }
                    Thread eatthread = new Thread(delegate () { Eat(Building.Headquarters[0].GetDistance()); }); ;
                    eatthread.Start();
                    Thread populationthread = new Thread(Population);
                    populationthread.Start();
                    Thread consumptionthread = new Thread(Consumption);
                    consumptionthread.Start();
                    Thread daythread = new Thread(Day);
                    daythread.Start();
                    Thread gameoverthread = new Thread(GameOver);
                    gameoverthread.Start();
                    Building.Headquarters[0].SetImage();
                    arr[p.X, p.Y].Enabled = false;
                    matrix[p.X, p.Y] = 5;
                    BuildMap[p.X, p.Y] = Building.Headquarters[0].GetID();
                    Village.SetChoose(254);
                }
                if (Village.GetChoose() == 2 && Village.GetForest() >= 8) // лесопилка
                {
                    byte numberBuild = 0;
                    for(byte i = 0; i < 254; i++)
                        if (Calculation.CheckBuildCreate(Building.Sawmill[i].GetX(), i) == i)
                        {
                            numberBuild = i;
                            i = 254;
                        }
                    Building.Sawmill[numberBuild].SetX(Convert.ToByte(p.X));
                    Building.Sawmill[numberBuild].SetY(Convert.ToByte(p.Y));
                    Village.SetForest(Convert.ToUInt16(Village.GetForest() - 8));
                    label3.Text = Village.GetForest().ToString();
                    Building.Sawmill[numberBuild].SetDistance(Calculation.DistanceCalc(treX, treY, ForestResources.GetX(), ForestResources.GetX(), Building.Headquarters[0].GetX(), Building.Headquarters[0].GetY()));
                    Thread forestthread = new Thread(delegate () { Forest(Building.Sawmill[numberBuild].GetDistance()); }); ;
                    forestthread.Start();
                    //arr[p.X, p.Y].BackgroundImage = Image.FromFile("D:\\01Programms\\PHCS6\\Project\\Vikings\\builds\\images\\tree_218.png");
                    Building.Sawmill[numberBuild].SetImage();
                    arr[p.X, p.Y].Enabled = false;
                    matrix[p.X, p.Y] = 2;
                    BuildMap[p.X, p.Y] = Building.Sawmill[numberBuild].GetID();
                }
                if (Village.GetChoose() == 3 && Village.GetStone() >= 7) // шахта
                {
                    byte numberBuild = 0;
                    for (byte i = 0; i < 254; i++)
                        if (Calculation.CheckBuildCreate(Building.Quarry[i].GetX(), i) == i)
                        {
                            numberBuild = i;
                            i = 254;
                        }
                    Building.Quarry[numberBuild].SetX(Convert.ToByte(p.X));
                    Building.Quarry[numberBuild].SetY(Convert.ToByte(p.Y));
                    Village.SetStone(Convert.ToUInt16(Village.GetStone() - 7));
                    label4.Text = Village.GetStone().ToString();
                    Building.Quarry[numberBuild].SetDistance(Calculation.DistanceCalc(treX, treY, StoneResources.GetX(), StoneResources.GetX(), Building.Headquarters[0].GetX(), Building.Headquarters[0].GetY()));
                    Thread stonethread = new Thread(delegate () { Stone(Building.Quarry[numberBuild].GetDistance()); }); ;
                    stonethread.Start();
                    //arr[p.X, p.Y].BackgroundImage = Image.FromFile("D:\\01Programms\\PHCS6\\Project\\Vikings\\builds\\images\\tree_155.png");
                    Building.Quarry[numberBuild].SetImage();
                    arr[p.X, p.Y].Enabled = false;
                    matrix[p.X, p.Y] = 2;
                    BuildMap[p.X, p.Y] = Building.Quarry[numberBuild].GetID();
                }
                if (Village.GetChoose() == 4 && Village.GetForest() >= 20 && Village.GetStone() >= 20) // золотой рудник
                {
                    byte numberBuild = 0;
                    for (byte i = 0; i < 254; i++)
                        if (Calculation.CheckBuildCreate(Building.Goldmine[i].GetX(), i) == i)
                        {
                            numberBuild = i;
                            i = 254;
                        }
                    Building.Goldmine[numberBuild].SetX(Convert.ToByte(p.X));
                    Building.Goldmine[numberBuild].SetY(Convert.ToByte(p.Y));
                    Village.SetForest(Convert.ToUInt16(Village.GetForest() - 20));
                    Village.SetStone(Convert.ToUInt16(Village.GetStone() - 20));
                    Building.Goldmine[numberBuild].SetDistance(Calculation.DistanceCalc(treX, treY, GoldResources.GetX(), GoldResources.GetX(), Building.Headquarters[0].GetX(), Building.Headquarters[0].GetY()));
                    Thread goldthread = new Thread(delegate () { Gold(Building.Goldmine[numberBuild].GetDistance()); }); ;
                    goldthread.Start();
                    //arr[p.X, p.Y].BackgroundImage = Image.FromFile("D:\\01Programms\\PHCS6\\Project\\Vikings\\builds\\images\\tree_279.png");
                    Building.Goldmine[numberBuild].SetImage();
                    arr[p.X, p.Y].Enabled = false;
                    label3.Text = Village.GetForest().ToString();
                    label4.Text = Village.GetStone().ToString();
                    matrix[p.X, p.Y] = 2;
                    BuildMap[p.X, p.Y] = Building.Goldmine[numberBuild].GetID();
                }
                if (Village.GetChoose() == 5 && Village.GetForest() >= 10 && Village.GetStone() >= 5) // склад
                {
                    byte numberBuild = 0;
                    for (byte i = 0; i < 254; i++)
                        if (Calculation.CheckBuildCreate(Building.Storage[i].GetX(), i) == i)
                        {
                            numberBuild = i;
                            i = 254;
                        }
                    Building.Storage[numberBuild].SetX(Convert.ToByte(p.X));
                    Building.Storage[numberBuild].SetY(Convert.ToByte(p.Y));
                    Village.SetForest(Convert.ToUInt16(Village.GetForest() - 10));
                    Village.SetStone(Convert.ToUInt16(Village.GetStone() - 5));
                    Village.SetEatMax(Convert.ToUInt16(Village.GetEatMax() + 30));
                    Village.SetForestMax(Convert.ToUInt16(Village.GetForestMax() + 10));
                    Village.SetStoneMax(Convert.ToUInt16(Village.GetStoneMax() + 10));
                    Village.SetGoldMax(Convert.ToUInt16(Village.GetGoldMax() + 5));
                    label3.Text = Village.GetForest().ToString();
                    label4.Text = Village.GetStone().ToString();
                    label11.Text = Village.GetEatMax().ToString();
                    label12.Text = Village.GetForestMax().ToString();
                    label13.Text = Village.GetStoneMax().ToString();
                    label14.Text = Village.GetGoldMax().ToString();
                    //arr[p.X, p.Y].BackgroundImage = Image.FromFile("D:\\01Programms\\PHCS6\\Project\\Vikings\\builds\\images\\tree_126.png");
                    Building.Storage[numberBuild].SetImage();
                    arr[p.X, p.Y].Enabled = false;
                    matrix[p.X, p.Y] = 2;
                    BuildMap[p.X, p.Y] = Building.Storage[numberBuild].GetID();
                }
                if (Village.GetChoose() == 6 && Village.GetForest() >= 10 && Village.GetStone() >= 5) // пшеничное поле
                {
                    byte numberBuild = 0;
                    for (byte i = 0; i < 254; i++)
                        if (Calculation.CheckBuildCreate(Building.Field[i].GetX(), i) == i)
                        {
                            numberBuild = i;
                            i = 254;
                        }
                    Building.Field[numberBuild].SetX(Convert.ToByte(p.X));
                    Building.Field[numberBuild].SetY(Convert.ToByte(p.Y));
                    Village.SetForest(Convert.ToUInt16(Village.GetForest() - 10));
                    Village.SetStone(Convert.ToUInt16(Village.GetStone() - 5));
                    Village.SetSpeedPicking(Convert.ToUInt16(Village.GetSpeedPicking() - 100));
                    label3.Text = Village.GetForest().ToString();
                    label4.Text = Village.GetStone().ToString();
                    arr[p.X, p.Y].Enabled = false;
                    matrix[p.X, p.Y] = 2;
                    //arr[p.X, p.Y].BackgroundImage = Image.FromFile("D:\\01Programms\\PHCS6\\Project\\Vikings\\builds\\images\\tree_94.png");
                    Building.Field[numberBuild].SetImage();
                    BuildMap[p.X, p.Y] = Building.Field[numberBuild].GetID();
                }
                if (Village.GetChoose() == 7 && Village.GetForest() >= 10 && Village.GetStone() >= 5) // дом
                {
                    byte numberBuild = 0;
                    for (byte i = 0; i < 254; i++)
                        if (Calculation.CheckBuildCreate(Building.Home[i].GetX(), i) == i)
                        {
                            numberBuild = i;
                            i = 254;
                        }
                    Building.Home[numberBuild].SetX(Convert.ToByte(p.X));
                    Building.Home[numberBuild].SetY(Convert.ToByte(p.Y));
                    Village.SetPopulationMax(Convert.ToUInt16(Village.GetPopulationMax() + 15));
                    Village.SetForest(Convert.ToUInt16(Village.GetForest() - 10));
                    Village.SetStone(Convert.ToUInt16(Village.GetStone() - 5));
                    label3.Text = Village.GetForest().ToString();
                    label4.Text = Village.GetStone().ToString();
                    label15.Text = Village.GetPopulationMax().ToString();
                    //arr[p.X, p.Y].BackgroundImage = Image.FromFile("D:\\01Programms\\PHCS6\\Project\\Vikings\\builds\\images\\tree_124.png");
                    Building.Home[numberBuild].SetImage();
                    arr[p.X, p.Y].Enabled = false;
                    matrix[p.X, p.Y] = 2;
                    BuildMap[p.X, p.Y] = Building.Home[numberBuild].GetID();
                }
                if (Village.GetChoose() == 8) // дозорная башня
                {
                    byte numberBuild = 0;
                    for (byte i = 0; i < 254; i++)
                        if (Calculation.CheckBuildCreate(Building.Watchtower[i].GetX(), i) == i)
                        {
                            numberBuild = i;
                            i = 254;
                        }
                    Building.Watchtower[numberBuild].SetX(Convert.ToByte(p.X));
                    Building.Watchtower[numberBuild].SetY(Convert.ToByte(p.Y));
                    Thread towerthread = new Thread(delegate () { Tower(p.X, p.Y); }); ;
                    towerthread.Start();
                    arr[p.X, p.Y].Enabled = false;
                    matrix[p.X, p.Y] = 7;
                    BuildMap[p.X, p.Y] = Building.Watchtower[numberBuild].GetID();
                }
                if (Village.GetChoose() == 9 && Village.GetForest() >= 15)
                {
                    Village.SetForest(Convert.ToUInt16(Village.GetForest() - 15));
                    Village.SetStone(Convert.ToUInt16(Village.GetSpeedPicking() - 100));
                    label3.Text = Village.GetForest().ToString();
                    arr[p.X, p.Y].BackgroundImage = Image.FromFile("D:\\01Programms\\PHCS6\\Project\\Vikings\\builds\\images\\tree_186.png");
                    arr[p.X, p.Y].Enabled = false;
                    matrix[p.X, p.Y] = 7;
                    // нет айди
                    //
                    // нет айди
                }
                if (Village.GetChoose() == 10 && Village.GetForest() >= 15)
                {
                    Village.SetForest(Convert.ToUInt16(Village.GetForest() - 15));
                    Village.SetStone(Convert.ToUInt16(Village.GetSpeedPicking() - 100));
                    label3.Text = Village.GetForest().ToString();
                    arr[p.X, p.Y].BackgroundImage = Image.FromFile("D:\\01Programms\\PHCS6\\Project\\Vikings\\builds\\images\\tree_245.png");///////////////////
                    arr[p.X, p.Y].Enabled = false;
                    matrix[p.X, p.Y] = 7;
                    // нет айди
                    //
                    // нет айди
                }
                if (Village.GetChoose() == 11 && Village.GetForest() >= 15)
                {
                    Village.SetForest(Convert.ToUInt16(Village.GetForest() - 15));
                    Village.SetStone(Convert.ToUInt16(Village.GetSpeedPicking() - 100));
                    label3.Text = Village.GetForest().ToString();
                    arr[p.X, p.Y].BackgroundImage = Image.FromFile("D:\\01Programms\\PHCS6\\Project\\Vikings\\builds\\images\\tree_215.png");
                    arr[p.X, p.Y].Enabled = false;
                    matrix[p.X, p.Y] = 7;
                    // нет айди
                    //
                    // нет айди
                }
                if (Village.GetChoose() == 12 && Village.GetForest() >= 15)
                {
                    Village.SetForest(Convert.ToUInt16(Village.GetForest() - 15));
                    Village.SetStone(Convert.ToUInt16(Village.GetSpeedPicking() - 100));
                    label3.Text = Village.GetForest().ToString();
                    arr[p.X, p.Y].BackgroundImage = Image.FromFile("D:\\01Programms\\PHCS6\\Project\\Vikings\\builds\\images\\tree_219.png");
                    arr[p.X, p.Y].Enabled = false;
                    matrix[p.X, p.Y] = 7;
                    // нет айди
                    //
                    // нет айди
                }
                if (Village.GetChoose() == 13 && Village.GetForest() >= 1) // стена
                {
                    byte numberBuild = 0;
                    for (byte i = 0; i < 254; i++)
                        if (Calculation.CheckBuildCreate(Building.Wall[i].GetX(), i) == i)
                        {
                            numberBuild = i;
                            i = 254;
                        }
                    Village.SetForest(Convert.ToUInt16(Village.GetForest() - 1));
                    label3.Text = Village.GetForest().ToString();
                    int direction = 0;
                    int[] side = new int[4];
                    if(p.X != 29)
                    {
                        if (wall[p.X + 1, p.Y] != 0)
                        {
                            side[0] = 1;
                            direction = 1;
                            WallBuild(p.X + 1, p.Y, direction);
                        }
                    }
                    if (p.X != 0)
                    {
                        if (wall[p.X - 1, p.Y] != 0)
                        {
                            side[1] = 1;
                            direction = 2;
                            WallBuild(p.X - 1, p.Y, direction);
                        }
                    }
                    if(p.Y != 0)
                    {
                        if (wall[p.X, p.Y - 1] != 0)
                        {
                            side[2] = 1;
                            direction = 3;
                            WallBuild(p.X, p.Y - 1, direction);
                        }
                    }
                    if(p.Y != 16)
                    {
                        if (wall[p.X, p.Y + 1] != 0)
                        {
                            side[3] = 1;
                            direction = 4;
                            WallBuild(p.X, p.Y + 1, direction);
                        }
                    }
                    if (side[0] == 0 && side[1] == 0 && side[2] == 0 && side[3] == 0)
                    {
                        wall[p.X, p.Y] = 1;
                        arr[p.X, p.Y].BackgroundImage = Image.FromFile("D:\\01Programms\\PHCS6\\Project\\Vikings\\wall\\images\\tree_03.png");
                    }
                    if (side[0] == 1 && side[1] == 0 && side[2] == 0 && side[3] == 0)
                    {
                        wall[p.X, p.Y] = 13;
                        arr[p.X, p.Y].BackgroundImage = Image.FromFile("D:\\01Programms\\PHCS6\\Project\\Vikings\\wall\\images\\tree_09.png");
                    }
                    if (side[0] == 0 && side[1] == 1 && side[2] == 0 && side[3] == 0)
                    {
                        wall[p.X, p.Y] = 14;
                        arr[p.X, p.Y].BackgroundImage = Image.FromFile("D:\\01Programms\\PHCS6\\Project\\Vikings\\wall\\images\\tree_11.png");
                    }
                    if (side[0] == 0 && side[1] == 0 && side[2] == 1 && side[3] == 0)
                    {
                        wall[p.X, p.Y] = 16;
                        arr[p.X, p.Y].BackgroundImage = Image.FromFile("D:\\01Programms\\PHCS6\\Project\\Vikings\\wall\\images\\tree_17.png");
                    }
                    if (side[0] == 0 && side[1] == 0 && side[2] == 0 && side[3] == 1)
                    {
                        wall[p.X, p.Y] = 15;
                        arr[p.X, p.Y].BackgroundImage = Image.FromFile("D:\\01Programms\\PHCS6\\Project\\Vikings\\wall\\images\\tree_04.png");
                    }
                    if (side[0] == 1 && side[1] == 1 && side[2] == 0 && side[3] == 0)
                    {
                        wall[p.X, p.Y] = 3;
                        arr[p.X, p.Y].BackgroundImage = Image.FromFile("D:\\01Programms\\PHCS6\\Project\\Vikings\\wall\\images\\tree_15.png");
                    }
                    if (side[0] == 1 && side[1] == 0 && side[2] == 1 && side[3] == 0)
                    {
                        wall[p.X, p.Y] = 7;
                        arr[p.X, p.Y].BackgroundImage = Image.FromFile("D:\\01Programms\\PHCS6\\Project\\Vikings\\wall\\images\\tree_13.png");
                    }
                    if (side[0] == 1 && side[1] == 0 && side[2] == 0 && side[3] == 1)
                    {
                        wall[p.X, p.Y] = 5;
                        arr[p.X, p.Y].BackgroundImage = Image.FromFile("D:\\01Programms\\PHCS6\\Project\\Vikings\\wall\\images\\tree_01.png");
                    }
                    if (side[0] == 0 && side[1] == 1 && side[2] == 1 && side[3] == 0)
                    {
                        wall[p.X, p.Y] = 6;
                        arr[p.X, p.Y].BackgroundImage = Image.FromFile("D:\\01Programms\\PHCS6\\Project\\Vikings\\wall\\images\\tree_16.png");
                    }
                    if (side[0] == 0 && side[1] == 1 && side[2] == 0 && side[3] == 1)
                    {
                        wall[p.X, p.Y] = 4;
                        arr[p.X, p.Y].BackgroundImage = Image.FromFile("D:\\01Programms\\PHCS6\\Project\\Vikings\\wall\\images\\tree_02.png");
                    }
                    if (side[0] == 0 && side[1] == 0 && side[2] == 1 && side[3] == 1)
                    {
                        wall[p.X, p.Y] = 2;
                        arr[p.X, p.Y].BackgroundImage = Image.FromFile("D:\\01Programms\\PHCS6\\Project\\Vikings\\wall\\images\\tree_07.png");
                    }
                    if (side[0] == 1 && side[1] == 1 && side[2] == 1 && side[3] == 0)
                    {
                        wall[p.X, p.Y] = 10;
                        arr[p.X, p.Y].BackgroundImage = Image.FromFile("D:\\01Programms\\PHCS6\\Project\\Vikings\\wall\\images\\tree_14.png");
                    }
                    if (side[0] == 1 && side[1] == 1 && side[2] == 0 && side[3] == 1)
                    {
                        wall[p.X, p.Y] = 11;
                        arr[p.X, p.Y].BackgroundImage = Image.FromFile("D:\\01Programms\\PHCS6\\Project\\Vikings\\wall\\images\\tree_05.png");
                    }
                    if (side[0] == 1 && side[1] == 0 && side[2] == 1 && side[3] == 1)
                    {
                        wall[p.X, p.Y] = 9;
                        arr[p.X, p.Y].BackgroundImage = Image.FromFile("D:\\01Programms\\PHCS6\\Project\\Vikings\\wall\\images\\tree_12.png");
                    }
                    if (side[0] == 0 && side[1] == 1 && side[2] == 1 && side[3] == 1)
                    {
                        wall[p.X, p.Y] = 8;
                        arr[p.X, p.Y].BackgroundImage = Image.FromFile("D:\\01Programms\\PHCS6\\Project\\Vikings\\wall\\images\\tree_06.png");
                    }
                    if (side[0] == 1 && side[1] == 1 && side[2] == 1 && side[3] == 1)
                    {
                        wall[p.X, p.Y] = 12;
                        arr[p.X, p.Y].BackgroundImage = Image.FromFile("D:\\01Programms\\PHCS6\\Project\\Vikings\\wall\\images\\tree_10.png");
                    }
                    arr[p.X, p.Y].Enabled = false;
                    matrix[p.X, p.Y] = 7;
                    BuildMap[p.X, p.Y] = Building.Wall[numberBuild].GetID();
                }
            }
        }

        public void WallBuild(int x, int y, int direction)
        {
            int p = wall[x, y];
            if (p == 1 && direction == 1)
            {
                wall[x, y] = 14;
                arr[x, y].BackgroundImage = Image.FromFile("D:\\01Programms\\PHCS6\\Project\\Vikings\\wall\\images\\tree_11.png");
            }
            if (p == 1 && direction == 2)
            {
                wall[x, y] = 13;
                arr[x, y].BackgroundImage = Image.FromFile("D:\\01Programms\\PHCS6\\Project\\Vikings\\wall\\images\\tree_09.png");
            }
            if (p == 1 && direction == 3)
            {
                wall[x, y] = 15;
                arr[x, y].BackgroundImage = Image.FromFile("D:\\01Programms\\PHCS6\\Project\\Vikings\\wall\\images\\tree_04.png");
            }
            if (p == 1 && direction == 4)
            {
                wall[x, y] = 16;
                arr[x, y].BackgroundImage = Image.FromFile("D:\\01Programms\\PHCS6\\Project\\Vikings\\wall\\images\\tree_17.png");
            }
            if (p == 2 && direction == 1)
            {
                wall[x, y] = 8;
                arr[x, y].BackgroundImage = Image.FromFile("D:\\01Programms\\PHCS6\\Project\\Vikings\\wall\\images\\tree_06.png");
            }
            if (p == 2 && direction == 2)
            {
                wall[x, y] = 9;
                arr[x, y].BackgroundImage = Image.FromFile("D:\\01Programms\\PHCS6\\Project\\Vikings\\wall\\images\\tree_12.png");
            }
            if (p == 3 && direction == 3)
            {
                wall[x, y] = 11;
                arr[x, y].BackgroundImage = Image.FromFile("D:\\01Programms\\PHCS6\\Project\\Vikings\\wall\\images\\tree_05.png");
            }
            if (p == 3 && direction == 4)
            {
                wall[x, y] = 10;
                arr[x, y].BackgroundImage = Image.FromFile("D:\\01Programms\\PHCS6\\Project\\Vikings\\wall\\images\\tree_14.png");
            }
            if (p == 4 && direction == 2)
            {
                wall[x, y] = 11;
                arr[x, y].BackgroundImage = Image.FromFile("D:\\01Programms\\PHCS6\\Project\\Vikings\\wall\\images\\tree_05.png");
            }
            if (p == 4 && direction == 4)
            {
                wall[x, y] = 8;
                arr[x, y].BackgroundImage = Image.FromFile("D:\\01Programms\\PHCS6\\Project\\Vikings\\wall\\images\\tree_06.png");
            }
            if (p == 5 && direction == 1)
            {
                wall[x, y] = 11;
                arr[x, y].BackgroundImage = Image.FromFile("D:\\01Programms\\PHCS6\\Project\\Vikings\\wall\\images\\tree_05.png");
            }
            if (p == 5 && direction == 4)
            {
                wall[x, y] = 9;
                arr[x, y].BackgroundImage = Image.FromFile("D:\\01Programms\\PHCS6\\Project\\Vikings\\wall\\images\\tree_12.png");
            }
            if (p == 6 && direction == 2)
            {
                wall[x, y] = 10;
                arr[x, y].BackgroundImage = Image.FromFile("D:\\01Programms\\PHCS6\\Project\\Vikings\\wall\\images\\tree_14.png");
            }
            if (p == 6 && direction == 3)
            {
                wall[x, y] = 8;
                arr[x, y].BackgroundImage = Image.FromFile("D:\\01Programms\\PHCS6\\Project\\Vikings\\wall\\images\\tree_06.png");
            }
            if (p == 7 && direction == 1)
            {
                wall[x, y] = 10;
                arr[x, y].BackgroundImage = Image.FromFile("D:\\01Programms\\PHCS6\\Project\\Vikings\\wall\\images\\tree_14.png");
            }
            if (p == 7 && direction == 3)
            {
                wall[x, y] = 9;
                arr[x, y].BackgroundImage = Image.FromFile("D:\\01Programms\\PHCS6\\Project\\Vikings\\wall\\images\\tree_12.png");
            }
            if ((p == 8 && direction == 2) || (p == 9 && direction == 1) || (p == 10 && direction == 3) || (p == 11 && direction == 4))
            {
                wall[x, y] = 12;
                arr[x, y].BackgroundImage = Image.FromFile("D:\\01Programms\\PHCS6\\Project\\Vikings\\wall\\images\\tree_10.png");
            }
            if (p == 13 && direction == 1)
            {
                wall[x, y] = 3;
                arr[x, y].BackgroundImage = Image.FromFile("D:\\01Programms\\PHCS6\\Project\\Vikings\\wall\\images\\tree_15.png");
            }
            if (p == 13 && direction == 3)
            {
                wall[x, y] = 5;
                arr[x, y].BackgroundImage = Image.FromFile("D:\\01Programms\\PHCS6\\Project\\Vikings\\wall\\images\\tree_01.png");
            }
            if (p == 13 && direction == 4)
            {
                wall[x, y] = 7;
                arr[x, y].BackgroundImage = Image.FromFile("D:\\01Programms\\PHCS6\\Project\\Vikings\\wall\\images\\tree_13.png");
            }
            if (p == 14 && direction == 2)
            {
                wall[x, y] = 3;
                arr[x, y].BackgroundImage = Image.FromFile("D:\\01Programms\\PHCS6\\Project\\Vikings\\wall\\images\\tree_15.png");
            }
            if (p == 14 && direction == 3)
            {
                wall[x, y] = 4;
                arr[x, y].BackgroundImage = Image.FromFile("D:\\01Programms\\PHCS6\\Project\\Vikings\\wall\\images\\tree_02.png");
            }
            if (p == 14 && direction == 4)
            {
                wall[x, y] = 6;
                arr[x, y].BackgroundImage = Image.FromFile("D:\\01Programms\\PHCS6\\Project\\Vikings\\wall\\images\\tree_16.png");
            }
            if (p == 15 && direction == 1)
            {
                wall[x, y] = 4;
                arr[x, y].BackgroundImage = Image.FromFile("D:\\01Programms\\PHCS6\\Project\\Vikings\\wall\\images\\tree_02.png");
            }
            if (p == 15 && direction == 2)
            {
                wall[x, y] = 5;
                arr[x, y].BackgroundImage = Image.FromFile("D:\\01Programms\\PHCS6\\Project\\Vikings\\wall\\images\\tree_01.png");
            }
            if (p == 15 && direction == 4)
            {
                wall[x, y] = 2;
                arr[x, y].BackgroundImage = Image.FromFile("D:\\01Programms\\PHCS6\\Project\\Vikings\\wall\\images\\tree_07.png");
            }
            if (p == 16 && direction == 1)
            {
                wall[x, y] = 6;
                arr[x, y].BackgroundImage = Image.FromFile("D:\\01Programms\\PHCS6\\Project\\Vikings\\wall\\images\\tree_16.png");
            }
            if (p == 16 && direction == 2)
            {
                wall[x, y] = 7;
                arr[x, y].BackgroundImage = Image.FromFile("D:\\01Programms\\PHCS6\\Project\\Vikings\\wall\\images\\tree_13.png");
            }
            if (p == 16 && direction == 3)
            {
                wall[x, y] = 2;
                arr[x, y].BackgroundImage = Image.FromFile("D:\\01Programms\\PHCS6\\Project\\Vikings\\wall\\images\\tree_07.png");
            }
            return;
        }

        private Button addButton(int x, int y)
        {
            Button b;
            b = new Button();
            b.FlatAppearance.BorderSize = 0;
            b.Width = 40;
            b.Height = 40;
            b.FlatStyle = FlatStyle.Flat;
            if ((x == 0 && y == 0) || (x == 1 && y == 0) || (x == 0 && y == 1))//eda
                b.BackgroundImage = Image.FromFile("D:\\01Programms\\PHCS6\\Project\\Vikings\\images\\tree_01.png");
            else if ((x == 12 && y == 1) || (x == 17 && y == 2) || (x == 11 && y == 6) || (x == 3 && y == 9))//el
                b.BackgroundImage = Image.FromFile("D:\\01Programms\\PHCS6\\Project\\Vikings\\images\\tree_44.png");
            else if ((x == 15 && y == 1) || (x == 15 && y == 5) || (x == 10 && y == 9) || (x == 16 && y == 10) || (x == 4 && y == 12) || (x == 8 && y == 11) || (x == 22 && y == 6) || (x == 21 && y == 9))//kamni
                b.BackgroundImage = Image.FromFile("D:\\01Programms\\PHCS6\\Project\\Vikings\\images\\tree_47.png");
            else if ((x == 13 && y == 3) || (x == 6 && y == 15) || (x == 20 && y == 11))//brevno
                b.BackgroundImage = Image.FromFile("D:\\01Programms\\PHCS6\\Project\\Vikings\\images\\tree_106.png");
            else if ((x == 20 && y == 1) || (x == 24 && y == 5) || (x == 4 && y == 13))//kyst
                b.BackgroundImage = Image.FromFile("D:\\01Programms\\PHCS6\\Project\\Vikings\\images\\tree_52.png");
            else if ((x == 24 && y == 1) || (x == 19 && y == 5) || (x == 8 && y == 11))//idol
                b.BackgroundImage = Image.FromFile("D:\\01Programms\\PHCS6\\Project\\Vikings\\images\\tree_56.png");
            else if ((x == 9 && y == 0) || (x == 15 && y == 15) || (x == 16 && y == 14))//начало реки
                b.BackgroundImage = Image.FromFile("D:\\01Programms\\PHCS6\\Project\\Vikings\\images\\tree_10.png");
            else if ((x == 9 && y == 1) || (x == 9 && y == 2) || (x == 7 && y == 3) || (x == 16 && y == 15))//midl river
                b.BackgroundImage = Image.FromFile("D:\\01Programms\\PHCS6\\Project\\Vikings\\images\\tree_41.png");
            else if ((x == 9 && y == 3) || (x == 8 && y == 4) || (x == 16 && y == 16))//left river
                b.BackgroundImage = Image.FromFile("D:\\01Programms\\PHCS6\\Project\\Vikings\\images\\tree_102.png");
            else if ((x == 8 && y == 3) || (x == 15 && y == 16))//left-right river
                b.BackgroundImage = Image.FromFile("D:\\01Programms\\PHCS6\\Project\\Vikings\\images\\tree_101.png");
            else if ((x == 8 && y == 2))//left-right river
                b.BackgroundImage = Image.FromFile("D:\\01Programms\\PHCS6\\Project\\Vikings\\images\\tree_70.png");
            else if ((x == 7 && y == 2))//left-right river
                b.BackgroundImage = Image.FromFile("D:\\01Programms\\PHCS6\\Project\\Vikings\\images\\tree_69.png");
            else if ((x == 7 && y == 4))//left-right river
                b.BackgroundImage = Image.FromFile("D:\\01Programms\\PHCS6\\Project\\Vikings\\images\\tree_130.png");

            else if ((x == 0 && y == 14))//tree
                b.BackgroundImage = Image.FromFile("D:\\01Programms\\PHCS6\\Project\\Vikings\\images\\tree_424.png");
            else if ((x == 0 && y == 15))//left-right river
                b.BackgroundImage = Image.FromFile("D:\\01Programms\\PHCS6\\Project\\Vikings\\images\\tree_454.png");
            else if ((x == 0 && y == 16))//left-right river
                b.BackgroundImage = Image.FromFile("D:\\01Programms\\PHCS6\\Project\\Vikings\\images\\tree_484.png");
            else if ((x == 1 && y == 14))//left-right river
                b.BackgroundImage = Image.FromFile("D:\\01Programms\\PHCS6\\Project\\Vikings\\images\\tree_425.png");
            else if ((x == 1 && y == 15))//left-right river
                b.BackgroundImage = Image.FromFile("D:\\01Programms\\PHCS6\\Project\\Vikings\\images\\tree_455.png");
            else if ((x == 1 && y == 16))//left-right river
                b.BackgroundImage = Image.FromFile("D:\\01Programms\\PHCS6\\Project\\Vikings\\images\\tree_485.png");
            else if ((x == 2 && y == 15))//left-right river
                b.BackgroundImage = Image.FromFile("D:\\01Programms\\PHCS6\\Project\\Vikings\\images\\tree_456.png");
            else if ((x == 2 && y == 16))//left-right river
                b.BackgroundImage = Image.FromFile("D:\\01Programms\\PHCS6\\Project\\Vikings\\images\\tree_486.png");


            else if ((x == 29 && y == 14))//left-right river
                b.BackgroundImage = Image.FromFile("D:\\01Programms\\PHCS6\\Project\\Vikings\\images\\tree_453.png");
            else if ((x == 29 && y == 15))//left-right river
                b.BackgroundImage = Image.FromFile("D:\\01Programms\\PHCS6\\Project\\Vikings\\images\\tree_483.png");
            else if ((x == 29 && y == 16))//left-right river
                b.BackgroundImage = Image.FromFile("D:\\01Programms\\PHCS6\\Project\\Vikings\\images\\tree_513.png");
            else if ((x == 28 && y == 14))//left-right river
                b.BackgroundImage = Image.FromFile("D:\\01Programms\\PHCS6\\Project\\Vikings\\images\\tree_452.png");
            else if ((x == 28 && y == 15))//left-right river
                b.BackgroundImage = Image.FromFile("D:\\01Programms\\PHCS6\\Project\\Vikings\\images\\tree_482.png");
            else if ((x == 28 && y == 16))//left-right river
                b.BackgroundImage = Image.FromFile("D:\\01Programms\\PHCS6\\Project\\Vikings\\images\\tree_512.png");
            else if ((x == 27 && y == 15))//left-right river
                b.BackgroundImage = Image.FromFile("D:\\01Programms\\PHCS6\\Project\\Vikings\\images\\tree_481.png");
            else if ((x == 27 && y == 16))//left-right river
                b.BackgroundImage = Image.FromFile("D:\\01Programms\\PHCS6\\Project\\Vikings\\images\\tree_511.png");


            else if ((x == 27 && y == 0))//left-right river
                b.BackgroundImage = Image.FromFile("D:\\01Programms\\PHCS6\\Project\\Vikings\\images\\tree_28.png");
            else if ((x == 28 && y == 0))//left-right river
                b.BackgroundImage = Image.FromFile("D:\\01Programms\\PHCS6\\Project\\Vikings\\images\\tree_29.png");
            else if ((x == 29 && y == 0))//left-right river
                b.BackgroundImage = Image.FromFile("D:\\01Programms\\PHCS6\\Project\\Vikings\\images\\tree_30.png");
            else if ((x == 27 && y == 1))//left-right river
                b.BackgroundImage = Image.FromFile("D:\\01Programms\\PHCS6\\Project\\Vikings\\images\\tree_59.png");
            else if ((x == 28 && y == 1))//left-right river
                b.BackgroundImage = Image.FromFile("D:\\01Programms\\PHCS6\\Project\\Vikings\\images\\tree_60.png");
            else if ((x == 29 && y == 1))//left-right river
                b.BackgroundImage = Image.FromFile("D:\\01Programms\\PHCS6\\Project\\Vikings\\images\\tree_61.png");
            else if ((x == 28 && y == 2))//left-right river
                b.BackgroundImage = Image.FromFile("D:\\01Programms\\PHCS6\\Project\\Vikings\\images\\tree_90.png");
            else if ((x == 29 && y == 2))//left-right river
                b.BackgroundImage = Image.FromFile("D:\\01Programms\\PHCS6\\Project\\Vikings\\images\\tree_91.png");
            else
                b.BackgroundImage = Image.FromFile("D:\\01Programms\\PHCS6\\Project\\Vikings\\images\\tree_03.png");
            b.Visible = true;
            b.Tag = new Point(x, y);
            b.Left = x * 40;
            b.Top = y * 40;
            b.Click += new EventHandler(b_Click);
            b.MouseMove += new MouseEventHandler(b_MouseMove);
            b.MouseHover += new EventHandler(b_MouseHover);
            b.MouseLeave += new EventHandler(b_MouseLeave);
            this.Controls.Add(b);
            return b;
        }

        private void b_MouseMove(object sender, EventArgs e)
        {
            Point p = (Point)(sender as Button).Tag;
            if (matrix[p.X, p.Y] == 0)
                arr[p.X, p.Y].BackgroundImage = Image.FromFile("D:\\01Programms\\PHCS6\\Project\\Vikings\\builds\\tree_291.png");
        }

        private void b_MouseHover(object sender, EventArgs e)
        {
            Point p = (Point)(sender as Button).Tag;
            if (matrix[p.X, p.Y] == 0)
                arr[p.X, p.Y].BackgroundImage = Image.FromFile("D:\\01Programms\\PHCS6\\Project\\Vikings\\builds\\tree_291.png");
        }

        private void b_MouseLeave(object sender, EventArgs e)
        {
            Point p = (Point)(sender as Button).Tag;
            if (matrix[p.X, p.Y] == 0)
                arr[p.X, p.Y].BackgroundImage = Image.FromFile("D:\\01Programms\\PHCS6\\Project\\Vikings\\builds\\images\\tree_03.png");
        }

        private void Consumption()
        {
            while (Data.exit != 1)
            {
                Thread.Sleep(18000);
                if(Village.GetEat() - (3 * Village.GetPopulation()) < 0)
                    Village.SetEat(0);
                else
                    Village.SetEat(Convert.ToUInt16(Village.GetEat() - (3 * Village.GetPopulation())));
                if(Data.exit == 0)
                    label2.Invoke(new Action(() => label2.Text = Village.GetEat().ToString()));
            }
        }

        private void GameOver()
        {
            while(Data.endgame == 0 && Data.exit == 0)
            {
                if(Village.GetEat() == 0)
                {
                    Thread.Sleep(1000);
                    Village.SetPopulation(Convert.ToUInt16(Village.GetPopulation() - 1));
                    label6.Invoke(new Action(() => label6.Text = Village.GetPopulation().ToString()));
                }
                if (Village.GetPopulation() == 0)
                {
                    Village.SetEat(100);
                    Village.SetStone(10);
                    Village.SetGold(0);
                    Village.SetForest(10);
                    Village.SetSpeedPicking(3000);
                    Village.SetClock(0);
                    Village.SetPassedDay(0);
                    Village.SetChoose(0);
                    Village.SetPopulation(5);

                    Data.endgame = 1;
                    Data.exit = 1;
                    for (int i = 0; i < 30; i++)
                        for (int j = 0; j < 30; j++)
                            matrix[i, j] = 0;
                    Form5 f = new Form5();
                    f.ShowDialog();
                    Form1 train = new Form1();
                    train.ShowDialog();
                    this.Close();

                }
            }
        }

        private void Day()
        {
            while (Data.exit != 1)
            {
                Thread.Sleep(3000);
                if (Village.GetClock() < 23)
                {
                    Village.SetClock(Convert.ToByte(Village.GetClock() + 1));
                    if (Village.GetClock() == 12)
                        pictureBox4.BackgroundImage = Image.FromFile("D:\\01Programms\\PHCS6\\Project\\Vikings\\clock\\1.png");
                    if (Village.GetClock() == 13)
                        pictureBox4.BackgroundImage = Image.FromFile("D:\\01Programms\\PHCS6\\Project\\Vikings\\clock\\2.png");
                    if (Village.GetClock() == 14)
                        pictureBox4.BackgroundImage = Image.FromFile("D:\\01Programms\\PHCS6\\Project\\Vikings\\clock\\3.png");
                    if (Village.GetClock() == 15)
                        pictureBox4.BackgroundImage = Image.FromFile("D:\\01Programms\\PHCS6\\Project\\Vikings\\clock\\4.png");
                    if (Village.GetClock() == 16)
                        pictureBox4.BackgroundImage = Image.FromFile("D:\\01Programms\\PHCS6\\Project\\Vikings\\clock\\5.png");
                    if (Village.GetClock() == 17)
                        pictureBox4.BackgroundImage = Image.FromFile("D:\\01Programms\\PHCS6\\Project\\Vikings\\clock\\6.png");
                    if (Village.GetClock() == 18)
                        pictureBox4.BackgroundImage = Image.FromFile("D:\\01Programms\\PHCS6\\Project\\Vikings\\clock\\7.png");
                    if (Village.GetClock() == 19)
                        pictureBox4.BackgroundImage = Image.FromFile("D:\\01Programms\\PHCS6\\Project\\Vikings\\clock\\8.png");
                    if (Village.GetClock() == 20)
                        pictureBox4.BackgroundImage = Image.FromFile("D:\\01Programms\\PHCS6\\Project\\Vikings\\clock\\9.png");
                    if (Village.GetClock() == 21)
                        pictureBox4.BackgroundImage = Image.FromFile("D:\\01Programms\\PHCS6\\Project\\Vikings\\clock\\10.png");
                    if (Village.GetClock() == 22)
                        pictureBox4.BackgroundImage = Image.FromFile("D:\\01Programms\\PHCS6\\Project\\Vikings\\clock\\11.png");
                    if (Village.GetClock() == 23)
                        pictureBox4.BackgroundImage = Image.FromFile("D:\\01Programms\\PHCS6\\Project\\Vikings\\clock\\12.png");
                    if (Village.GetClock() == 1)
                        pictureBox4.BackgroundImage = Image.FromFile("D:\\01Programms\\PHCS6\\Project\\Vikings\\clock\\13.png");
                    if (Village.GetClock() == 2)
                        pictureBox4.BackgroundImage = Image.FromFile("D:\\01Programms\\PHCS6\\Project\\Vikings\\clock\\14.png");
                    if (Village.GetClock() == 3)
                        pictureBox4.BackgroundImage = Image.FromFile("D:\\01Programms\\PHCS6\\Project\\Vikings\\clock\\15.png");
                    if (Village.GetClock() == 4)
                        pictureBox4.BackgroundImage = Image.FromFile("D:\\01Programms\\PHCS6\\Project\\Vikings\\clock\\16.png");
                    if (Village.GetClock() == 5)
                        pictureBox4.BackgroundImage = Image.FromFile("D:\\01Programms\\PHCS6\\Project\\Vikings\\clock\\17.png");
                    if (Village.GetClock() == 6)
                        pictureBox4.BackgroundImage = Image.FromFile("D:\\01Programms\\PHCS6\\Project\\Vikings\\clock\\18.png");
                    if (Village.GetClock() == 7)
                        pictureBox4.BackgroundImage = Image.FromFile("D:\\01Programms\\PHCS6\\Project\\Vikings\\clock\\19.png");
                    if (Village.GetClock() == 8)
                        pictureBox4.BackgroundImage = Image.FromFile("D:\\01Programms\\PHCS6\\Project\\Vikings\\clock\\20.png");
                    if (Village.GetClock() == 9)
                        pictureBox4.BackgroundImage = Image.FromFile("D:\\01Programms\\PHCS6\\Project\\Vikings\\clock\\21.png");
                    if (Village.GetClock() == 10)
                        pictureBox4.BackgroundImage = Image.FromFile("D:\\01Programms\\PHCS6\\Project\\Vikings\\clock\\22.png");
                    if (Village.GetClock() == 11)
                        pictureBox4.BackgroundImage = Image.FromFile("D:\\01Programms\\PHCS6\\Project\\Vikings\\clock\\23.png");
                }
                else
                {
                    Village.SetClock(0);
                    Village.SetPassedDay(Convert.ToByte(Village.GetPassedDay() + 1));
                    label20.Invoke(new Action(() => label20.Text = Village.GetPassedDay().ToString()));
                }
                if (Village.GetPassedDay() == 7 && Data.enemyOn == 1)
                {
                    Data.enemyVolume--;
                    if (Data.enemyVolume == 0)
                    {
                        Data.enemyOn = 0;
                        Data.enemyVolume = 3;
                    }
                }
            }
        }

        private void Enemy()
        {
            int[] distance = new int[50];
            int x = 1;
            int valueX = 0;
            int valueY = 0;
            int number = Data.enemyCount;
            Data.enemyCount++;
            Random rndY = new Random();
            Random rndX = new Random();
            Random rnd = new Random();
            int u = rnd.Next(0, 1);
            if(u == 0)
            {
                valueX = 29;
                valueY = rndY.Next(1, 15);
                enemyY[number] = valueY;
                enemyX[number] = valueX;
            }
            else
            {
                valueX = rndX.Next(1, 28);
                valueY = 16;
                enemyY[number] = valueY;
                enemyX[number] = valueX;
            }
            matrix[valueX, valueY] = 3;

            if ((valueY < 16 && valueX == 29) || (valueY == 16 && valueX < 29))
            {
                int coordY = valueY;
                int coordX = valueX;
                while(Data.exit != 1)
                {
                    for(int j = 0; j < Data.builds; j++)
                    {
                        arr[valueX, valueY].Invoke(new Action(() => arr[valueX, valueY].Text = "W"));
                        coordY = valueY;
                        coordX = valueX;
                        x = 1;
                        for (int i = 0; i < x; i++)
                        {
                            if (coordY > buildY[j])
                                coordY--;
                            else if(coordY < buildY[j])
                                coordY++;
                            if (coordX > buildX[j])
                                coordX--;
                            else if (coordX < buildX[j])
                                coordX++;
                            if (coordY == buildY[j] && coordX == buildX[j])
                            {
                                distance[j]++;
                            }
                            else
                            {
                                x++;
                                distance[j]++;
                            }
                        }
                    }

                    int minIndex = 0;
                    for (int i = 0; i < Data.builds; i++)
                    {
                        if(distance[minIndex] > distance[i])
                        {
                            minIndex = i;
                        }
                    }
                    x = 1;
                    for (int i = 0; i < x; i++)
                    {
                        Thread.Sleep(1000);
                        arr[valueX, valueY].Invoke(new Action(() => arr[valueX, valueY].Text = ""));
                        if (valueY > buildY[minIndex])
                            valueY--;
                        else if (valueY < buildY[minIndex])
                            valueY++;
                        if (valueX > buildX[minIndex])
                            valueX--;
                        else if (valueX < buildX[minIndex])
                            valueX++;
                        enemyY[number] = valueY;
                        enemyX[number] = valueX;
                        matrix[valueX, valueY] = 3;
                        if ((valueX + 1 == buildX[minIndex] && valueY == buildY[minIndex])
                            || (valueX == buildX[minIndex] && valueY + 1 == buildY[minIndex])
                            || (valueX + 1 == buildX[minIndex] && valueY + 1 == buildY[minIndex])
                            || (valueX - 1 == buildX[minIndex] && valueY == buildY[minIndex])
                            || (valueX == buildX[minIndex] && valueY - 1 == buildY[minIndex])
                            || (valueX - 1 == buildX[minIndex] && valueY - 1 == buildY[minIndex]))
                        {
                            arr[valueX, valueY].Invoke(new Action(() => arr[valueX, valueY].Text = "W"));
                            while (matrix[buildX[minIndex], buildY[minIndex]] > 0)
                            {
                                Thread.Sleep(1000);
                                matrix[buildX[minIndex], buildY[minIndex]]--;
                            }
                        }

                        if (valueY == buildY[minIndex] && valueX == buildX[minIndex])
                        {
                            arr[valueX, valueY].Invoke(new Action(() => arr[valueX, valueY].Text = "W"));
                            for(int a = minIndex; a < Data.builds; a++)
                            {
                                buildY[a] = buildY[a + 1];
                                buildX[a] = buildX[a + 1];
                            }
                            if(Data.builds > 0)
                                Data.builds--;
                        }
                        else
                        {
                            arr[valueX, valueY].Invoke(new Action(() => arr[valueX, valueY].Text = "W"));
                            x++;
                        }
                    }

                }
                //Data.enemyOn = 1;
            }

        }

        private void Tower(int x, int y)
        {
            int coordY = y;
            int coordX = x;
            int exit;
            int[] distance = new int[30];
            while (Data.exit != 1)
            {
                for (int j = 0; j < Data.enemyCount; j++)
                {
                    exit = 1;
                    for (int i = 0; i < exit; i++)
                    {
                        if (coordY > enemyY[j])
                            coordY--;
                        else if (coordY < enemyY[j])
                            coordY++;
                        if (coordX > enemyX[j])
                            coordX--;
                        else if (coordX < enemyX[j])
                            coordX++;
                        if (coordY == enemyY[j] && coordX == enemyX[j])
                        {
                            distance[j]++;
                        }
                        else
                        {
                            exit++;
                            distance[j]++;
                        }
                    }
                }

                int minIndex = 0;
                for (int i = 0; i < Data.enemyCount; i++)
                {
                    if (distance[i] <= 2)
                    {
                        minIndex = i;
                    }
                }

                coordY = y;
                coordX = x;
                exit = 1;
                for (int i = 0; i < exit; i++)
                {
                    if (coordY > enemyY[minIndex])
                        coordY--;
                    else if (coordY < enemyY[minIndex])
                        coordY++;
                    if (coordX > enemyX[minIndex])
                        coordX--;
                    else if (coordX < enemyX[minIndex])
                        coordX++;
                    if ((coordX + 1 == enemyX[minIndex] && coordY == enemyY[minIndex])
                        || (coordX == enemyX[minIndex] && coordY + 1 == enemyY[minIndex])
                        || (coordX + 1 == enemyX[minIndex] && coordY + 1 == enemyY[minIndex])
                        || (coordX - 1 == enemyX[minIndex] && coordY == enemyY[minIndex])
                        || (coordX == enemyX[minIndex] && coordY - 1 == enemyY[minIndex])
                        || (coordX - 1 == enemyX[minIndex] && coordY - 1 == enemyY[minIndex]))
                    {
                        while (matrix[enemyX[minIndex], enemyY[minIndex]] > 0)
                        {
                            arr[coordX, coordY].Invoke(new Action(() => arr[coordX, coordY].Text = "*"));
                            Thread.Sleep(100);
                            matrix[enemyX[minIndex], enemyY[minIndex]]--;
                            arr[coordX, coordY].Invoke(new Action(() => arr[coordX, coordY].Text = ""));
                        }
                    }
                }
            }
        }

        private void Eat(int a)
        {
            int night = 0;
            while (Data.exit != 1)
            {
                if (Village.GetClock() < 6 || Village.GetClock() > 21)
                    night = 2000;
                else
                    night = 0;
                Thread.Sleep((a * Village.GetSpeedPicking()) + night);
                if (Village.GetEatMax() > Village.GetEat())
                    Village.SetEat(Convert.ToUInt16(Village.GetEat() + 1));
                if (Data.exit == 0)
                    label2.Invoke(new Action(() => label2.Text = Village.GetEat().ToString()));
            }
        }

        private void Forest(int a)
        {
            int night = 0;
            while (Data.exit != 1)
            {
                if (Village.GetClock() < 6 || Village.GetClock() > 21)
                    night = 2000;
                else
                    night = 0;
                Thread.Sleep((a * 1000) + night);
                if(Village.GetForestMax() > Village.GetForest())
                    Village.SetForest(Convert.ToUInt16(Village.GetForest() + 1));
                if (Data.exit == 0)
                    label3.Invoke(new Action(() => label3.Text = Village.GetForest().ToString()));
            }
        }

        private void Stone(int a)
        {
            int night = 0;
            while (Data.exit != 1)
            {
                if (Village.GetClock() < 6 || Village.GetClock() > 21)
                    night = 2000;
                else
                    night = 0;
                Thread.Sleep((a * 1000) + night);
                if (Village.GetStoneMax() > Village.GetStone())
                    Village.SetStone(Convert.ToUInt16(Village.GetStone() + 1));
                if (Data.exit == 0)
                    label4.Invoke(new Action(() => label4.Text = Village.GetStone().ToString()));
            }
        }

        private void Gold(int a)
        {
            int night = 0;
            while (Data.exit != 1)
            {
                if (Village.GetClock() < 6 || Village.GetClock() > 21)
                    night = 2000;
                else
                    night = 0;
                Thread.Sleep((a * 1000) + night);
                if (Village.GetGoldMax() > Village.GetGold())
                    Village.SetGold(Convert.ToUInt16(Village.GetGold() + 1));
                if (Data.exit == 0)
                    label5.Invoke(new Action(() => label5.Text = Village.GetGold().ToString()));
            }
        }

        private void Population()
        {
            while (Data.exit != 1)
            {
                Thread.Sleep(30000);
                if (Village.GetPopulationMax() > Village.GetPopulation())
                    Village.SetPopulation(Convert.ToUInt16(Village.GetPopulation() + 1));
                if (Data.exit == 0)
                    label6.Invoke(new Action(() => label6.Text = Village.GetPopulation().ToString()));
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            if(Village.GetChoose() == 0)
                Village.SetChoose(1);
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.ShowDialog();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Form8 f = new Form8();
            f.ShowDialog();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            Form9 f = new Form9();
            f.ShowDialog();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            Form10 f = new Form10();
            f.ShowDialog();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Data.healthenemy = 10;
            Data.enemyOn = 1;
            Data.enemyVolume = 3;
            Data.enemyCount = 0;
            Data.builds = 0;
            Data.exit = 1;
            Form1 train = new Form1();
            this.Visible = false;
            train.ShowDialog();
            this.Close();
        }
    }

    static class Data
    {
        static public int healthenemy { get; set; } = 10;
        static public int enemyOn { get; set; } = 1;
        static public int enemyVolume { get; set; } = 3;
        static public int enemyCount { get; set; } = 0;
        static public int builds { get; set; } = 0;
        static public int endgame { get; set; } = 0;
        static public int konung { get; set; } = 0;

        static public int level { get; set; } = 1;
        static public int music { get; set; } = 1;
        static public int exit { get; set; } = 0;
        static public int teach { get; set; } = 0;
    }
}
