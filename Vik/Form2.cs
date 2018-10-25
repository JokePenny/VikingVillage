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
using System.Media;
using System.Collections.Generic;

namespace Vik
{
    public partial class Form2 : Form
    {
        private static FossilsEat EatResources = new FossilsEat();
        private static FossilsForest ForestResources = new FossilsForest();
        private static FossilsStone StoneResources = new FossilsStone();
        private static FossilsGold GoldResources = new FossilsGold();
        private static ResourceVillage Village = ResourceVillage.GetInstance();
        private static Buildheadquarters Headquarters = new Buildheadquarters();
        private static BuildPort Port = new BuildPort();
        private static BuildGoldRec GoldRec = new BuildGoldRec();
        private static BuildStoneRec StoneRec = new BuildStoneRec();
        private static BuildWoodRec WoodRec = new BuildWoodRec();
        private static Buildmarket Market = new Buildmarket();
        private static List<Buildgoldmine> Goldmine = new List<Buildgoldmine>(10);
        private static List<Buildquarry> Quarry = new List<Buildquarry>(10);
        private static List<Buildsawmill> Sawmill = new List<Buildsawmill>(10);
        private static List<Buildstorage> Storage = new List<Buildstorage>(10);
        private static List<Buildfield> Field = new List<Buildfield>(10);
        private static List<BuildWall> Wall = new List<BuildWall>(50);
        private static List<Buildhome> Home = new List<Buildhome>(10);
        private static List<BuildSanctuary> Sanctuary = new List<BuildSanctuary>(10);
        private static List<BuildBarn> Barn = new List<BuildBarn>(10);
        private static List<BuildBarracks> Barracks = new List<BuildBarracks>(10);
        SoundPlayer Simple = new SoundPlayer(@"D:\01Programms\VS\Repository\Wik\Vik\Vik\Properties\Resources\soundGame.wav");
        private byte[,] BuildMap = new byte[30, 30];
        private byte[,] wall = new byte[30, 30];
        private ToolTip t = new ToolTip();

        public Form2()
        {
            InitializeComponent();
            Village.SetEat(100);
            Village.SetStone(100);
            Village.SetGold(0);
            Village.SetForest(100);
            Village.SetSpeedPicking(3000);
            Village.SetClock(0);
            Village.SetPassedDay(0);
            Village.SetChoose(0);
            Village.SetPopulation(5);
            Simple.PlayLooping();
            this.WindowState = FormWindowState.Maximized;

            for (int i = 0; i < 30; i++)
            {
                arr[i, 0] = addButton(i, 0);
                for (int i2 = 1; i2 < 17; i2++)
                    arr[i, i2] = addButton(i, i2);
            }

            for (int i = 0; i < 6; i++)
            {
                if (i == 0)
                {
                    Village.SetSkilsEat(0, i);
                    Village.SetSkilsForest(0, i);
                    Village.SetSkilsStone(0, i);
                    Village.SetSkilsGold(0, i);
                }
                if (i < 2)
                {
                    Village.SetSkilsForestOut(1, i);
                    Village.SetSkilsStoneOut(1, i);
                    Village.SetSkilsGoldOut(1, i);
                }
                if (i > 1 && i < 5)
                {
                    Village.SetSkilsEat(1, i);
                    Village.SetSkilsForest(1, i);
                    Village.SetSkilsStone(1, i);
                    Village.SetSkilsGold(1, i);
                }
                if (i == 1)
                {
                    Village.SetSkilsEat(5, i);
                    Village.SetSkilsForest(5, i);
                    Village.SetSkilsStone(5, i);
                    Village.SetSkilsGold(5, i);
                }
                if (i < 6)
                    Village.SetSkilsPassiveBuilds(1, i);
            }
            BuildMap[0, 0] = 1;
            BuildMap[29, 0] = 1;
            BuildMap[0, 16] = 1;
            BuildMap[29, 16] = 1;
            BuildMap[0, 15] = 1;
            BuildMap[0, 14] = 1;
            BuildMap[1, 14] = 1;
            BuildMap[1, 15] = 1;
            BuildMap[1, 16] = 1;
            BuildMap[2, 15] = 1;
            BuildMap[2, 16] = 1;
            BuildMap[0, 1] = 1;
            BuildMap[1, 0] = 1;
            BuildMap[9, 0] = 1;
            BuildMap[9, 1] = 1;
            BuildMap[9, 2] = 1;
            BuildMap[9, 3] = 1;
            BuildMap[8, 4] = 1;
            BuildMap[8, 3] = 1;
            BuildMap[7, 3] = 1;
            BuildMap[7, 4] = 1;
            BuildMap[19, 5] = 1;
            BuildMap[24, 1] = 1;
            BuildMap[27, 0] = 1;
            BuildMap[28, 0] = 1;
            BuildMap[27, 1] = 1;
            BuildMap[28, 1] = 1;
            BuildMap[29, 1] = 1;
            BuildMap[28, 2] = 1;
            BuildMap[29, 2] = 1;
            BuildMap[29, 14] = 1;
            BuildMap[29, 15] = 1;
            BuildMap[28, 14] = 1;
            BuildMap[28, 15] = 1;
            BuildMap[28, 16] = 1;
            BuildMap[27, 15] = 1;
            BuildMap[27, 16] = 1;
            BuildMap[16, 14] = 1;
            BuildMap[16, 15] = 1;
            BuildMap[16, 16] = 1;
            BuildMap[15, 16] = 1;
            BuildMap[15, 15] = 1;
            BuildMap[3, 9] = 1;
            BuildMap[12, 1] = 1;
            BuildMap[15, 1] = 1;
            BuildMap[17, 2] = 1;
            BuildMap[20, 1] = 1;
            BuildMap[13, 3] = 1;
            BuildMap[15, 5] = 1;
            BuildMap[11, 6] = 1;
            BuildMap[10, 9] = 1;
            BuildMap[16, 10] = 1;
            BuildMap[22, 6] = 1;
            BuildMap[24, 5] = 1;
            BuildMap[21, 9] = 1;
            BuildMap[4, 12] = 1;
            BuildMap[4, 13] = 1;
            BuildMap[6, 15] = 1;
            BuildMap[20, 11] = 1;
            BuildMap[8, 11] = 1;
            BuildMap[8, 2] = 1;
            BuildMap[7, 2] = 1;
        }

        public static Button[,] arr = new Button[30, 30];

        private void b_Click(object sender, EventArgs e)
        {
            Point p = (Point)(sender as Button).Tag;
            byte treY = Convert.ToByte(p.Y);
            byte treX = Convert.ToByte(p.X);
            if (BuildMap[p.X, p.Y] == 0)
            {
                if (Village.GetChoose() == 1) // создание базы - добывает еду
                {
                    Form7 f = new Form7();
                    f.ShowDialog();
                    // определяем коорд базы
                    Headquarters.SetX(Convert.ToByte(p.X));
                    Headquarters.SetY(Convert.ToByte(p.Y));
                    Headquarters.SetHealth(100);
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
                            Headquarters.SetDistance(x);
                            i = 254;
                        }
                        else
                            x++;
                    }
                    Thread eatthread = new Thread(delegate () { Eat(Headquarters.GetDistance()); }); ;
                    eatthread.Start();
                    Thread populationthread = new Thread(Population);
                    populationthread.Start();
                    Thread consumptionthread = new Thread(Consumption);
                    consumptionthread.Start();
                    Thread daythread = new Thread(Day);
                    daythread.Start();
                    Thread gameoverthread = new Thread(GameOver);
                    gameoverthread.Start();
                    Thread religionthread = new Thread(OtherReligion);
                    religionthread.Start();
                    Thread depravitythread = new Thread(Spoiled);
                    depravitythread.Start();
                    Thread revolutionthread = new Thread(Revolt);
                    revolutionthread.Start();
                    Thread agingthread = new Thread(BuildingAging);
                    agingthread.Start();
                    Thread tooltipthread = new Thread(UpdateToolTip);
                    tooltipthread.Start();
                    Headquarters.SetImage();
                    BuildMap[p.X, p.Y] = Headquarters.GetID();
                    Village.SetChoose(254);
                    t.SetToolTip(arr[p.X, p.Y], "Дом Конунга\nСостояние: " + Headquarters.GetHealth() + "\nУровень: " + Village.GetSkilsPassiveBuilds(0));
                }
                if (Village.GetChoose() == 2 && Village.GetForest() >= 8) // лагерь лесорубов - добывает лес
                {
                    Buildsawmill sawmill = new Buildsawmill(Convert.ToByte(p.X), Convert.ToByte(p.Y), Calculation.DistanceCalc(treX, treY, ForestResources.GetX(), ForestResources.GetY(), Headquarters.GetX(), Headquarters.GetY()));
                    Village.SetForest(Convert.ToUInt16(Village.GetForest() - 8));
                    label3.Text = Village.GetForest().ToString();
                    Thread forestthread = new Thread(delegate () { Forest(sawmill.GetDistance()); }); ;
                    forestthread.Start();
                    sawmill.SetImage();
                    BuildMap[p.X, p.Y] = sawmill.GetID();
                    Sawmill.Add(sawmill);
                }
                if (Village.GetChoose() == 3 && Village.GetStone() >= 7) // шахта - добывает камень
                {
                    Buildquarry quarry = new Buildquarry(Convert.ToByte(p.X), Convert.ToByte(p.Y), Calculation.DistanceCalc(treX, treY, StoneResources.GetX(), StoneResources.GetY(), Headquarters.GetX(), Headquarters.GetY()));
                    Village.SetStone(Convert.ToUInt16(Village.GetStone() - 7));
                    label4.Text = Village.GetStone().ToString();
                    Thread stonethread = new Thread(delegate () { Stone(quarry.GetDistance()); }); ;
                    stonethread.Start();
                    quarry.SetImage();
                    BuildMap[p.X, p.Y] = quarry.GetID();
                    Quarry.Add(quarry);
                }
                if (Village.GetChoose() == 4 && Village.GetForest() >= 10 && Village.GetStone() >= 10) // золотой рудник - добывает золото
                {
                    Buildgoldmine goldmine = new Buildgoldmine(Convert.ToByte(p.X), Convert.ToByte(p.Y), Calculation.DistanceCalc(treX, treY, StoneResources.GetX(), StoneResources.GetY(), Headquarters.GetX(), Headquarters.GetY()));
                    Village.SetForest(Convert.ToUInt16(Village.GetForest() - 10));
                    Village.SetStone(Convert.ToUInt16(Village.GetStone() - 10));
                    Thread goldthread = new Thread(delegate () { Gold(goldmine.GetDistance()); }); ;
                    goldthread.Start();
                    goldmine.SetImage();
                    label3.Text = Village.GetForest().ToString();
                    label4.Text = Village.GetStone().ToString();
                    BuildMap[p.X, p.Y] = goldmine.GetID();
                    Goldmine.Add(goldmine);
                }
                if (Village.GetChoose() == 5 && Village.GetForest() >= 10 && Village.GetStone() >= 5) // склад - увеличивает максимум хранимых ресурсов
                {
                    Buildstorage storage = new Buildstorage(Convert.ToByte(p.X), Convert.ToByte(p.Y), 100);
                    Village.SetForest(Convert.ToUInt16(Village.GetForest() - 10));
                    Village.SetStone(Convert.ToUInt16(Village.GetStone() - 5));
                    Village.SetEatMax(Convert.ToUInt16(Village.GetEatMax() + 30));
                    Village.SetForestMax(Convert.ToUInt16(Village.GetForestMax() + 10));
                    Village.SetStoneMax(Convert.ToUInt16(Village.GetStoneMax() + 10));
                    Village.SetGoldMax(Convert.ToUInt16(Village.GetGoldMax() + 5));
                    Village.SetBoardsMax(Convert.ToUInt16(Village.GetBoardsMax() + 20));
                    Village.SetBrickMax(Convert.ToUInt16(Village.GetBrickMax() + 20));
                    label3.Text = Village.GetForest().ToString();
                    label4.Text = Village.GetStone().ToString();
                    label11.Text = Village.GetEatMax().ToString();
                    label12.Text = Village.GetForestMax().ToString();
                    label13.Text = Village.GetStoneMax().ToString();
                    label14.Text = Village.GetGoldMax().ToString();
                    label9.Text = Village.GetBoardsMax().ToString();
                    label10.Text = Village.GetBrickMax().ToString();
                    storage.SetImage();
                    BuildMap[p.X, p.Y] = storage.GetID();
                    Storage.Add(storage);
                }
                if (Village.GetChoose() == 6 && Village.GetForest() >= 10 && Village.GetStone() >= 5) // пшеничное поле - ускоряет добычу еды
                {
                    Buildfield field = new Buildfield(Convert.ToByte(p.X), Convert.ToByte(p.Y), 100);
                    Village.SetForest(Convert.ToUInt16(Village.GetForest() - 10));
                    Village.SetStone(Convert.ToUInt16(Village.GetStone() - 5));
                    Village.SetSpeedPicking(Convert.ToUInt16(Village.GetSpeedPicking() - 100));
                    label3.Text = Village.GetForest().ToString();
                    label4.Text = Village.GetStone().ToString();
                    field.SetImage();
                    BuildMap[p.X, p.Y] = field.GetID();
                    Field.Add(field);
                }
                if (Village.GetChoose() == 7 && Village.GetForest() >= 10 && Village.GetStone() >= 5) // дом - обеспечивает максимум населения
                {
                    Buildhome home = new Buildhome(Convert.ToByte(p.X), Convert.ToByte(p.Y), 100);
                    Village.SetPopulationMax(Convert.ToUInt16(Village.GetPopulationMax() + 15));
                    Village.SetForest(Convert.ToUInt16(Village.GetForest() - 10));
                    Village.SetStone(Convert.ToUInt16(Village.GetStone() - 5));
                    label3.Text = Village.GetForest().ToString();
                    label4.Text = Village.GetStone().ToString();
                    label15.Text = Village.GetPopulationMax().ToString();
                    home.SetImage();
                    BuildMap[p.X, p.Y] = home.GetID();
                    Home.Add(home);
                }
                if (Village.GetChoose() == 8 && Village.GetStone() >= 15) // лесопилка
                {
                    WoodRec = new BuildWoodRec(Convert.ToByte(p.X), Convert.ToByte(p.Y), Calculation.DistanceCalc(treX, treY, Headquarters.GetX(), Headquarters.GetY()));
                    Village.SetStone(Convert.ToUInt16(Village.GetStone() - 15));
                    label4.Text = Village.GetStone().ToString();
                    Thread woodrecthread = new Thread(delegate () { Recforest(WoodRec.GetDistance()); }); ;
                    woodrecthread.Start();
                    WoodRec.SetImage();
                    BuildMap[p.X, p.Y] = WoodRec.GetID();
                }
                if (Village.GetChoose() == 9 && Village.GetForest() >= 15) // камнетесы - вытесывает блоки из булыжников
                {
                    StoneRec = new BuildStoneRec(Convert.ToByte(p.X), Convert.ToByte(p.Y), Calculation.DistanceCalc(treX, treY, Headquarters.GetX(), Headquarters.GetY()));
                    Village.SetForest(Convert.ToUInt16(Village.GetForest() - 15));
                    label3.Text = Village.GetForest().ToString();
                    Thread stonerecthread = new Thread(delegate () { Recstone(StoneRec.GetDistance()); }); ;
                    stonerecthread.Start();
                    StoneRec.SetImage();
                    BuildMap[p.X, p.Y] = StoneRec.GetID();
                }
                if (Village.GetChoose() == 10 && Village.GetForest() >= 15 && Village.GetStone() >= 15 && Village.GetGold() >= 5) // чеканка монет - чеканит деньги из золота
                {
                    GoldRec = new BuildGoldRec(Convert.ToByte(p.X), Convert.ToByte(p.Y), Calculation.DistanceCalc(treX, treY, Headquarters.GetX(), Headquarters.GetY()));
                    Village.SetForest(Convert.ToUInt16(Village.GetForest() - 15));
                    Village.SetStone(Convert.ToUInt16(Village.GetStone() - 15));
                    Village.SetGold(Convert.ToUInt16(Village.GetGold() - 5));
                    label3.Text = Village.GetForest().ToString();
                    label4.Text = Village.GetStone().ToString();
                    label5.Text = Village.GetGold().ToString();
                    Thread goldrecthread = new Thread(delegate () { Recgold(GoldRec.GetDistance()); }); ;
                    goldrecthread.Start();
                    GoldRec.SetImage();
                    BuildMap[p.X, p.Y] = GoldRec.GetID();
                }
                if (Village.GetChoose() == 11 && Village.GetBoards() >= 10 && Village.GetBrick() >= 5) // амбар - уменьшает шанс пропажи еды
                {
                    BuildBarn barn = new BuildBarn(Convert.ToByte(p.X), Convert.ToByte(p.Y), 70);
                    Village.SetBoards(Convert.ToUInt16(Village.GetBoards() - 10));
                    Village.SetBrick(Convert.ToUInt16(Village.GetStone() - 5));
                    label3.Text = Village.GetForest().ToString();
                    barn.SetImage();
                    BuildMap[p.X, p.Y] = barn.GetID();
                    Barn.Add(barn);
                }
                if (Village.GetChoose() == 12 && Village.GetBoards() >= 20 && Village.GetBrick() >= 10) // святилище - дает плюс к продвижении нужной веры
                {
                    BuildSanctuary sanctuary = new BuildSanctuary(Convert.ToByte(p.X), Convert.ToByte(p.Y), 70);
                    Village.SetBoards(Convert.ToUInt16(Village.GetForest() - 20));
                    Village.SetBrick(Convert.ToUInt16(Village.GetStone() - 10));
                    label3.Text = Village.GetForest().ToString();
                    sanctuary.SetImage();
                    BuildMap[p.X, p.Y] = sanctuary.GetID();
                    Sanctuary.Add(sanctuary);
                }
                if (Village.GetChoose() == 13 && Village.GetBrick() >= 5) // стена
                {
                    BuildWall walll = new BuildWall(Convert.ToByte(p.X), Convert.ToByte(p.Y), 50);
                    Village.SetBrick(Convert.ToUInt16(Village.GetBrick() - 5));
                    label3.Text = Village.GetForest().ToString();
                    int direction = 0;
                    int[] side = new int[4];
                    if (p.X != 29)
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
                    if (p.Y != 0)
                    {
                        if (wall[p.X, p.Y - 1] != 0)
                        {
                            side[2] = 1;
                            direction = 3;
                            WallBuild(p.X, p.Y - 1, direction);
                        }
                    }
                    if (p.Y != 16)
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
                    BuildMap[p.X, p.Y] = walll.GetID();
                    Wall.Add(walll);
                }
                if (Village.GetChoose() == 14 && Village.GetBoards() >= 30 && Village.GetBrick() >= 15) // порт - дает доступ к торговле с иноземцами
                {
                    Data.foreigners = 1;
                    Port = new BuildPort(Convert.ToByte(p.X), Convert.ToByte(p.Y), 100);
                    Village.SetBoards(Convert.ToUInt16(Village.GetBoards() - 30));
                    Village.SetBrick(Convert.ToUInt16(Village.GetBrick() - 15));
                    label3.Text = Village.GetForest().ToString();
                    Port.SetImage();
                    BuildMap[p.X, p.Y] = Port.GetID();
                }
                if (Village.GetChoose() == 15 && Village.GetBoards() >= 25 && Village.GetBrick() >= 20) // казармы - уменьшают шанс возникновения бунтов
                {
                    BuildBarracks barracks = new BuildBarracks(Convert.ToByte(p.X), Convert.ToByte(p.Y), 100);
                    Village.SetBoards(Convert.ToUInt16(Village.GetBoards() - 25));
                    Village.SetBrick(Convert.ToUInt16(Village.GetBrick() - 20));
                    label3.Text = Village.GetForest().ToString();
                    barracks.SetImage();
                    BuildMap[p.X, p.Y] = barracks.GetID();
                    Barracks.Add(barracks);
                }
                if (Village.GetChoose() == 16 && Village.GetBoards() >= 10 && Village.GetBrick() >= 10) // рынок купцов
                {
                    Market = new Buildmarket(Convert.ToByte(p.X), Convert.ToByte(p.Y), 100);
                    Village.SetBoards(Convert.ToUInt16(Village.GetForest() - 10));
                    Village.SetBrick(Convert.ToUInt16(Village.GetStone() - 10));
                    label3.Text = Village.GetForest().ToString();
                    Market.SetImage();
                    BuildMap[p.X, p.Y] = Market.GetID();
                    t.SetToolTip(arr[p.X, p.Y], "Рынок Купцов");
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
            if (BuildMap[p.X, p.Y] == 0)
                arr[p.X, p.Y].BackgroundImage = Image.FromFile("D:\\01Programms\\PHCS6\\Project\\Vikings\\builds\\tree_291.png");
            t.GetToolTip(arr[p.X, p.Y]);
        }

        private void b_MouseHover(object sender, EventArgs e)
        {
            Point p = (Point)(sender as Button).Tag;
            if (BuildMap[p.X, p.Y] == 0)
                arr[p.X, p.Y].BackgroundImage = Image.FromFile("D:\\01Programms\\PHCS6\\Project\\Vikings\\builds\\tree_291.png");
        }

        private void b_MouseLeave(object sender, EventArgs e)
        {
            Point p = (Point)(sender as Button).Tag;
            if (BuildMap[p.X, p.Y] == 0)
                arr[p.X, p.Y].BackgroundImage = Image.FromFile("D:\\01Programms\\PHCS6\\Project\\Vikings\\builds\\images\\tree_03.png");
        }

        // потоки

        private void UpdateToolTip() // поток отвечающий за обновление всплывающих подсказок
        {
            while (Village.GetPopulation() > 0)
            {
                Thread.Sleep(500);
                for(int i = 0; i < 29; i++)
                {
                    for(int j = 0; j < 16; j++)
                    {
                        switch (BuildMap[i, j])
                        {
                            case 10:
                                foreach (Buildfield k in Field)
                                    if (k.GetX() == i && k.GetY() == j)
                                    {
                                        Action action = () => t.SetToolTip(arr[i, j], "Пшеничное поле\nСостояние: " + k.GetHealth() + "\nУровень сбора: " + Village.GetSkilsEat(3));
                                        if (InvokeRequired)
                                            Invoke(action);
                                        else
                                            action();
                                    }
                                break;
                            case 11:
                                foreach (Buildgoldmine k in Goldmine)
                                    if (k.GetX() == i && k.GetY() == j)
                                    {
                                        Action action = () => t.SetToolTip(arr[i, j], "Золотой рудник\nРабочих: " + +Village.GetSkilsGold(2));
                                        if (InvokeRequired)
                                            Invoke(action);
                                        else
                                            action();
                                    }
                                break;
                            case 13:
                                foreach (Buildhome k in Home)
                                    if (k.GetX() == i && k.GetY() == j)
                                    {
                                        Action action = () => t.SetToolTip(arr[i, j], "Дом\nСостояние: " + k.GetHealth() + "\nУровень сбора: " + Village.GetSkilsPassiveBuilds(1));
                                        if (InvokeRequired)
                                            Invoke(action);
                                        else
                                            action();
                                    }
                                break;
                            case 15:
                                foreach (Buildquarry k in Quarry)
                                    if (k.GetX() == i && k.GetY() == j)
                                    {
                                        Action action = () => t.SetToolTip(arr[i, j], "Шахта\nРабочих: " + Village.GetSkilsStone(2));
                                        if (InvokeRequired)
                                            Invoke(action);
                                        else
                                            action();
                                    }
                                break;
                            case 16:
                                foreach (Buildsawmill k in Sawmill)
                                    if (k.GetX() == i && k.GetY() == j)
                                    {
                                        Action action = () => t.SetToolTip(arr[i, j], "Лагерь Лесорбуов\nnРабочих: " + Village.GetSkilsForest(2));
                                        if (InvokeRequired)
                                            Invoke(action);
                                        else
                                            action();
                                    }
                                break;
                            case 17:
                                foreach (BuildWall k in Wall)
                                    if (k.GetX() == i && k.GetY() == j) t.SetToolTip(arr[i, j], "Стена\nСостояние: " + k.GetHealth());
                                break;
                            case 18:
                                    if (WoodRec.GetX() == i && WoodRec.GetY() == j)
                                    {
                                        Action action = () => t.SetToolTip(arr[i, j], "Лесопилка\nВеличина переработки: " + Village.GetSkilsForestOut(1));
                                        if (InvokeRequired)
                                            Invoke(action);
                                        else
                                            action();
                                    }
                                break;
                            case 19:
                                    if (StoneRec.GetX() == i && StoneRec.GetY() == j)
                                    {
                                        Action action = () => t.SetToolTip(arr[i, j], "Камнетесы\nВеличина переработки: " + Village.GetSkilsStoneOut(1));
                                        if (InvokeRequired)
                                            Invoke(action);
                                        else
                                            action();
                                    }
                                break;
                            case 20:
                                    if (GoldRec.GetX() == i && GoldRec.GetY() == j)
                                    {
                                        Action action = () => t.SetToolTip(arr[i, j], "Плавильня монет\nВеличина переработки:: " + Village.GetSkilsGoldOut(1));
                                        if (InvokeRequired)
                                            Invoke(action);
                                        else
                                            action();
                                    }
                                break;
                            case 21:
                                foreach (BuildBarn k in Barn)
                                    if (k.GetX() == i && k.GetY() == j)
                                    {
                                        Action action = () => t.SetToolTip(arr[i, j], "Амбар\nУровень: " + Village.GetSkilsPassiveBuilds(2) + "\nСостояние; " + k.GetHealth());
                                        if (InvokeRequired)
                                            Invoke(action);
                                        else
                                            action();
                                    }
                                break;
                            case 22:
                                foreach (BuildBarracks k in Barracks)
                                    if (k.GetX() == i && k.GetY() == j)
                                    {
                                        Action action = () => t.SetToolTip(arr[i, j], "Казармы\nУровень: " + Village.GetSkilsPassiveBuilds(5) + "\nСостояние; " + k.GetHealth());
                                        if (InvokeRequired)
                                            Invoke(action);
                                        else
                                            action();
                                    }
                                break;
                            case 24:
                                foreach (BuildSanctuary k in Sanctuary)
                                    if (k.GetX() == i && k.GetY() == j)
                                    {
                                        Action action = () => t.SetToolTip(arr[i, j], "Казармы\nУровень: " + Village.GetSkilsPassiveBuilds(3) + "\nСостояние; " + k.GetHealth());
                                        if (InvokeRequired)
                                            Invoke(action);
                                        else
                                            action();
                                    }
                                break;
                            case 25:
                                foreach (Buildstorage k in Storage)
                                    if (k.GetX() == i && k.GetY() == j)
                                    {
                                        Action action = () => t.SetToolTip(arr[i, j], "Склад\nСостояние: " + k.GetHealth());
                                        if (InvokeRequired)
                                            Invoke(action);
                                        else
                                            action();
                                    }
                                break;
                            default:
                                break;
                        }
                    }
                }
            }
        }

        private void Consumption() // поток отвечающий за потребление
        {
            while (Village.GetPopulation() > 0)
            {
                Thread.Sleep(18000);
                if (Village.GetEat() - (3 * Village.GetPopulation()) < 0)
                    Village.SetEat(0);
                else
                    Village.SetEat(Convert.ToUInt16(Village.GetEat() - (3 * Village.GetPopulation())));
                if (Village.GetPopulation() > 0)
                {
                    Action action = () => label2.Text = Village.GetEat().ToString();
                    if (InvokeRequired)
                        Invoke(action);
                    else
                        action();
                }
            }
        }

        private void GameOver() // поток определяющий конец игры
        {
            while (Village.GetPopulation() > 0)
            {
                if (Village.GetEat() == 0)
                {
                    Thread.Sleep(1000);
                    Village.SetPopulation(Convert.ToUInt16(Village.GetPopulation() - 1));
                    Action action = () => label6.Text = Village.GetPopulation().ToString();
                    if (InvokeRequired)
                        Invoke(action);
                    else
                        action();
                }
                if (Village.GetPopulation() == 0 && Data.exit == 0)
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
                    Village.SetPopulation(0);
                    for (int i = 0; i < 30; i++)
                        for (int j = 0; j < 30; j++)
                            BuildMap[i, j] = 0;
                    Form5 f = new Form5();
                    f.ShowDialog();
                }
            }
        }

        private void Day() // пото считающий сутки
        {
            while (Village.GetPopulation() > 0)
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
                    Action action = () => label20.Text = Village.GetPassedDay().ToString();
                    if (InvokeRequired)
                        Invoke(action);
                    else
                        action();
                }
            }
        }

        private void Revolt() // поток возникновения революции при низкой устойчивости религии деревни
        {
            Random rd = new Random();
            int chance = 0;
            while (Village.GetPopulation() > 0)
            {
                Thread.Sleep(24000 + (Barracks.Count * 5000));
                if (Village.GetReligionStatic() < 50 && Village.GetReligionStatic() >= 25)
                {
                    chance = rd.Next(0, 100);
                    if ((Village.GetEat() == 0 && Village.GetPassedDay() >= 7) && chance > 85)
                    {
                        // окно с историей
                        LossCalcRevolt(1, 5, 0, 3, 2, chance);
                    }
                }
                else if (Village.GetReligionStatic() < 25 && Village.GetReligionStatic() >= 0)
                {
                    chance = rd.Next(0, 100);
                    if ((Village.GetEat() == 0 && Village.GetPassedDay() >= 7) && chance > 65)
                    {
                        // окно с историей
                        LossCalcRevolt(2, 10, 1, 5, 4, chance);
                    }
                }
                else if (Village.GetReligionStatic() < 0 && Village.GetReligionStatic() >= -25)
                {
                    chance = rd.Next(0, 100);
                    if ((Village.GetEat() == 0 && Village.GetPassedDay() >= 7) && chance > 25)
                    {
                        // окно с историей
                        LossCalcRevolt(5, 20, 2, 10, 6, chance);
                    }
                    chance = rd.Next(0, 100);
                    if (chance > 60)
                    {
                        if (Village.GetReligion() == 1) Village.SetReligion(0);
                        else Village.SetReligion(1);
                        Village.SetReligionStatic(100);
                    }

                }
                else if (Village.GetReligionStatic() < -25 && Village.GetReligionStatic() >= -100)
                {
                    chance = rd.Next(0, 100);
                    if ((Village.GetEat() == 0 && Village.GetPassedDay() >= 7) && chance > 10)
                    {
                        // окно с историей
                        LossCalcRevolt(10, 30, 7, 15, 12, chance);
                    }
                    chance = rd.Next(0, 100);
                    if (chance > 30)
                    {
                        if (Village.GetReligion() == 1) Village.SetReligion(0);
                        else Village.SetReligion(1);
                        Village.SetReligionStatic(100);
                    }
                }
            }
        }

        private void Spoiled() // поток испорченности еды
        {
            Random rd = new Random();
            int chance = 0;
            while (Village.GetPopulation() > 0)
            {
                byte numberBuild = Convert.ToByte(Barn.Count);
                Thread.Sleep(72000);
                chance = rd.Next(1, 100 - (numberBuild * 10));
                if (chance > rd.Next(10,30))
                {
                    chance = rd.Next(10 - numberBuild, 30 - numberBuild);
                    if (Village.GetEat() > chance) Village.SetEat(Convert.ToUInt16(Village.GetEat() - chance));
                    else Village.SetEat(0);
                }
            }
        }

        private void OtherReligion() // поток сравнивающий религию деревни и конунга
        {
            while (Village.GetPopulation() > 0)
            {
                Thread.Sleep(24000);
                if (Village.GetReligionKonung() != Village.GetReligion())
                    Village.SetReligionStatic(Convert.ToSByte(Village.GetReligionStatic() - 15 + Sanctuary.Count));
            }
        }

        private void BuildingAging() // поток сравнивающий религию деревни и конунга
        {
            while (Village.GetPopulation() > 0)
            {
                Thread.Sleep(72000);
                if (Barn.Count > 0)
                    foreach (BuildBarn i in Barn)
                    {
                        if (i.GetHealth() - 10 >= 0) i.SetHealth(Convert.ToByte(i.GetHealth() - 10));
                        else
                        {
                            i.SetDeleteImage();
                            BuildMap[i.GetX(), i.GetY()] = 0;
                            Barn.Remove(i);
                            break;
                        }
                    }
                if (Home.Count > 0)
                    foreach (Buildhome i in Home)
                    {
                        if (i.GetHealth() - 10 >= 0) i.SetHealth(Convert.ToByte(i.GetHealth() - 10));
                        else
                        {
                            i.SetDeleteImage();
                            Village.SetPopulationMax(Convert.ToUInt16(Village.GetPopulationMax() - 15));
                            BuildMap[i.GetX(), i.GetY()] = 0;
                            Home.Remove(i);
                            break;
                        }
                    }
                if (Field.Count > 0)
                    foreach (Buildfield i in Field)
                    {
                        if (i.GetHealth() - 10 >= 0) i.SetHealth(Convert.ToByte(i.GetHealth() - 10));
                        else
                        {
                            i.SetDeleteImage();
                            BuildMap[i.GetX(), i.GetY()] = 0;
                            Field.Remove(i);
                            break;
                        }
                    }
                if (Barracks.Count > 0)
                    foreach (BuildBarracks i in Barracks)
                    {
                        if (i.GetHealth() - 10 >= 0) i.SetHealth(Convert.ToByte(i.GetHealth() - 10));
                        else
                        {
                            i.SetDeleteImage();
                            BuildMap[i.GetX(), i.GetY()] = 0;
                            Barracks.Remove(i);
                            break;
                        }
                    }
                if (Sanctuary.Count > 0)
                    foreach (BuildSanctuary i in Sanctuary)
                    {
                        if (i.GetHealth() - 10 >= 0) i.SetHealth(Convert.ToByte(i.GetHealth() - 10));
                        else
                        {
                            i.SetDeleteImage();
                            BuildMap[i.GetX(), i.GetY()] = 0;
                            Sanctuary.Remove(i);
                            break;
                        }
                    }
                if (Wall.Count > 0)
                    foreach (BuildWall i in Wall)
                    {
                        if (i.GetHealth() - 10 >= 0) i.SetHealth(Convert.ToByte(i.GetHealth() - 10));
                        else
                        {
                            i.SetDeleteImage();
                            BuildMap[i.GetX(), i.GetY()] = 0;
                            Wall.Remove(i);
                            break;
                        }
                    }
                if (Storage.Count > 0)
                    foreach (Buildstorage i in Storage)
                    {
                        if (i.GetHealth() - 10 >= 0) i.SetHealth(Convert.ToByte(i.GetHealth() - 10));
                        else
                        {
                            Village.SetEatMax(Convert.ToUInt16(Village.GetEatMax() - 30));
                            Village.SetForestMax(Convert.ToUInt16(Village.GetForestMax() - 10));
                            Village.SetStoneMax(Convert.ToUInt16(Village.GetStoneMax() - 10));
                            Village.SetGoldMax(Convert.ToUInt16(Village.GetGoldMax() - 5));
                            Village.SetBoardsMax(Convert.ToUInt16(Village.GetGoldMax() - 20));
                            Village.SetBrickMax(Convert.ToUInt16(Village.GetGoldMax() - 20));
                            label3.Text = Village.GetForest().ToString();
                            label4.Text = Village.GetStone().ToString();
                            label11.Text = Village.GetEatMax().ToString();
                            label12.Text = Village.GetForestMax().ToString();
                            label13.Text = Village.GetStoneMax().ToString();
                            label14.Text = Village.GetGoldMax().ToString();
                            label9.Text = Village.GetBoardsMax().ToString();
                            label10.Text = Village.GetBrickMax().ToString();
                            i.SetDeleteImage();
                            BuildMap[i.GetX(), i.GetY()] = 0;
                            Storage.Remove(i);
                            break;
                        }
                    }
            }
        }

        private void Recforest(int a) // поток отвечающий за переработку древесины
        {
            int night = 0;
            while (Village.GetPopulation() > 0)
            {
                if (Village.GetClock() < 6 || Village.GetClock() > 21)
                    night = 2000;
                else
                    night = 0;
                Thread.Sleep(((a * 500) - (Village.GetSkilsForestOut(0) * 15)) + night);
                if (Village.GetForest() > 0)
                {
                    Village.SetForest(Convert.ToUInt16(Village.GetForest() - 1));
                    Action action = () => label3.Text = Village.GetForest().ToString();
                    if (InvokeRequired)
                        Invoke(action);
                    else
                        action();
                    Village.SetBoards(Convert.ToUInt16(Village.GetBoards() + Village.GetSkilsForestOut(1)));
                    action = () => label7.Text = Village.GetBoards().ToString();
                    if (InvokeRequired)
                        Invoke(action);
                    else
                        action();
                }
                if (Village.GetPopulation() > 0)
                {
                    Action action = () => label7.Text = Village.GetBoards().ToString();
                    if (InvokeRequired)
                        Invoke(action);
                    else
                        action();
                }
            }
        }

        private void Recstone(int a) // поток отвечающий за переработку камня
        {
            int night = 0;
            while (Village.GetPopulation() > 0)
            {
                if (Village.GetClock() < 6 || Village.GetClock() > 21)
                    night = 2000;
                else
                    night = 0;
                Thread.Sleep(((a * 500) - (Village.GetSkilsStoneOut(0) * 15)) + night);
                if (Village.GetStone() > 0)
                {
                    Village.SetStone(Convert.ToUInt16(Village.GetStone() - 1));
                    Action action = () => label4.Text = Village.GetStone().ToString();
                    if (InvokeRequired)
                        Invoke(action);
                    else
                        action();
                    Village.SetBrick(Convert.ToUInt16(Village.GetBrick() + Village.GetSkilsStoneOut(1)));
                    action = () => label8.Text = Village.GetBrick().ToString();
                    if (InvokeRequired)
                        Invoke(action);
                    else
                        action();
                }
                if (Village.GetPopulation() > 0)
                {
                    Action action = () => label8.Text = Village.GetBrick().ToString();
                    if (InvokeRequired)
                        Invoke(action);
                    else
                        action();
                }
            }
        }

        private void Recgold(int a) // поток отвечающий за переработку золота
        {
            int night = 0;
            while (Village.GetPopulation() > 0)
            {
                if (Village.GetClock() < 6 || Village.GetClock() > 21)
                    night = 2000;
                else
                    night = 0;
                Thread.Sleep(((a * 500) - (Village.GetSkilsGoldOut(0) * 15)) + night);
                if (Village.GetGold() > 0)
                {
                    Village.SetGold(Convert.ToUInt16(Village.GetGold() - 1));
                    Action action = () => label5.Text = Village.GetGold().ToString();
                    if (InvokeRequired)
                        Invoke(action);
                    else
                        action();
                    Village.SetMoney(Convert.ToUInt16(Village.GetMoney() + Village.GetSkilsStoneOut(1)));
                    action = () => label16.Text = Village.GetMoney().ToString();
                    if (InvokeRequired)
                        Invoke(action);
                    else
                        action();
                }
                if (Village.GetPopulation() > 0)
                {
                    Action action = () => label16.Text = Village.GetMoney().ToString();
                    if (InvokeRequired)
                        Invoke(action);
                    else
                        action();
                }
            }
        }

        private void Eat(int a) // поток отвечающий за добычу еды
        {
            int night = 0;
            while (Village.GetPopulation() > 0)
            {
                if (Village.GetClock() < 6 || Village.GetClock() > 21)
                    night = 2000;
                else
                    night = 0;
                Thread.Sleep((a * Village.GetSpeedPicking()) + night - (20 * Village.GetSkilsEat(0)));
                if (Village.GetEatMax() > Village.GetEat())
                    Village.SetEat(Convert.ToUInt16(Village.GetEat() + 1));
                if (Village.GetPopulation() > 0)
                {
                    Action action = () => label2.Text = Village.GetEat().ToString();
                    if (InvokeRequired)
                        Invoke(action);
                    else
                        action();
                }
            }
        }

        private void Forest(int a) // поток отвечающий за добычу дерева
        {
            int night = 0;
            while (Village.GetPopulation() > 0)
            {
                if (Village.GetClock() < 6 || Village.GetClock() > 21)
                    night = 2000;
                else
                    night = 0;
                Thread.Sleep((a * 1000) + night - (20 * Village.GetSkilsForest(0)));
                if (Village.GetForestMax() > Village.GetForest())
                    Village.SetForest(Convert.ToUInt16(Village.GetForest() + 1));
                if (Village.GetPopulation() > 0)
                {
                    Action action = () => label3.Text = Village.GetForest().ToString();
                    if (InvokeRequired)
                        Invoke(action);
                    else
                        action();
                }
            }
        }

        private void Stone(int a) // поток отвечающий за добычу камня
        {
            int night = 0;
            while (Village.GetPopulation() > 0)
            {
                if (Village.GetClock() < 6 || Village.GetClock() > 21)
                    night = 2000;
                else
                    night = 0;
                Thread.Sleep((a * 1000) + night - (20 * Village.GetSkilsStone(0)));
                if (Village.GetStoneMax() > Village.GetStone())
                    Village.SetStone(Convert.ToUInt16(Village.GetStone() + 1));
                if (Village.GetPopulation() > 0)
                {
                    Action action = () => label4.Text = Village.GetStone().ToString();
                    if (InvokeRequired)
                        Invoke(action);
                    else
                        action();
                }
            }
        }

        private void Gold(int a) // поток отвечающий за добычу золота
        {
            int night = 0;
            while (Village.GetPopulation() > 0)
            {
                if (Village.GetClock() < 6 || Village.GetClock() > 21)
                    night = 2000;
                else
                    night = 0;
                Thread.Sleep((a * 1000) + night - (20 * Village.GetSkilsGold(0)));
                if (Village.GetGoldMax() > Village.GetGold())
                    Village.SetGold(Convert.ToUInt16(Village.GetGold() + 1));
                if (Village.GetPopulation() > 0)
                {
                    Action action = () => label5.Text = Village.GetGold().ToString();
                    if (InvokeRequired)
                        Invoke(action);
                    else
                        action();
                }
            }
        }

        private void Population() // поток отвечающий за поплнение населения деревни
        {
            while (Village.GetPopulation() > 0)
            {
                Thread.Sleep(30000);
                if (Village.GetPopulationMax() > Village.GetPopulation())
                    Village.SetPopulation(Convert.ToUInt16(Village.GetPopulation() + 1));
                if (Village.GetPopulation() > 0)
                {
                    Action action = () => label6.Text = Village.GetPopulation().ToString();
                    if (InvokeRequired)
                        Invoke(action);
                    else
                        action();
                }
            }
        }

        // конец потоков

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            if (Village.GetChoose() == 0) Village.SetChoose(1);
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if (Headquarters.GetX() != 0)
            {
                Form3 f = new Form3();
                f.ShowDialog();
            }
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            if (Headquarters.GetX() != 0)
            {
                Form8 f = new Form8();
                f.ShowDialog();
            }
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            if(Headquarters.GetX() != 0)
            {
                Form9 f = new Form9();
                f.ShowDialog();
            }
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            if(Market.GetX() != 0)
            {
                Form10 f = new Form10();
                f.ShowDialog();
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Data.exit = 1;
            Village.SetPopulation(0);
            Form1 train = new Form1();
            this.Visible = false;
            train.ShowDialog();
            this.Close();
        }

        private void LossCalcRevolt(int populX, int populY, int eatX, int eatY, int goldY, int chance)
        {
            Random rd = new Random();
            int value = rd.Next(populX, populY);
            if (Village.GetPopulation() >= value) Village.SetPopulation(Convert.ToUInt16(Village.GetPopulation() - value));
            else Village.SetPopulation(0);
            value = rd.Next(eatX, eatY);
            if (Village.GetEat() >= value) Village.SetEat(Convert.ToUInt16(Village.GetEat() - value));
            else Village.SetEat(0);
            value = rd.Next(eatX, eatY);
            if (Village.GetForest() >= value) Village.SetForest(Convert.ToUInt16(Village.GetForest() - value));
            else Village.SetForest(0);
            value = rd.Next(eatX, eatY);
            if (Village.GetStone() >= value) Village.SetStone(Convert.ToUInt16(Village.GetStone() - value));
            else Village.SetStone(0);
            value = rd.Next(eatX, goldY);
            if (Village.GetGold() >= value) Village.SetGold(Convert.ToUInt16(Village.GetGold() - value));
            else Village.SetGold(0);
            value = rd.Next(populX, goldY);
            if (Village.GetBoards() >= value) Village.SetBoards(Convert.ToUInt16(Village.GetBoards() - value));
            else Village.SetBoards(0);
            value = rd.Next(populX, goldY);
            if (Village.GetBrick() >= value) Village.SetBrick(Convert.ToUInt16(Village.GetBrick() - rd.Next(populX, goldY)));
            else Village.SetBrick(0);
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            if(Village.GetForest() >= 10 && Village.GetStone() >= 5)
            {
                Village.SetForest(Convert.ToUInt16(Village.GetForest() - 10));
                Village.SetStone(Convert.ToUInt16(Village.GetStone() - 5));
                if (Barn.Count > 0)
                    foreach (BuildBarn i in Barn)
                        i.SetHealth(100);
                if (Home.Count > 0)
                    foreach (Buildhome i in Home)
                        i.SetHealth(100);
                if (Field.Count > 0)
                    foreach (Buildfield i in Field)
                        i.SetHealth(100);
                if (Barracks.Count > 0)
                    foreach (BuildBarracks i in Barracks)
                        i.SetHealth(100);
                if (Sanctuary.Count > 0)
                    foreach (BuildSanctuary i in Sanctuary)
                        i.SetHealth(100);
                if (Wall.Count > 0)
                    foreach (BuildWall i in Wall)
                        i.SetHealth(50);
                if (Storage.Count > 0)
                    foreach (Buildstorage i in Storage)
                        i.SetHealth(100);
            }
        }
    }

    static class Data
    {
        static public byte exit { get; set; } = 0;
        static public byte foreigners { get; set; } = 0;
    }
}