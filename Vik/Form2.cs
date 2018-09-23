using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;


namespace Vik
{
    public partial class Form2 : Form
    {
        private static Build Building = new Build();

        int[,] matrix = new int[30, 30];
        int[] buildX = new int[100];
        int[] buildY = new int[100];
        int[] enemyX = new int[50];
        int[] enemyY = new int[50];
        int[,] wall = new int[30, 30];
        public Form2()
        {
            InitializeComponent();
            Building.Goldmine = new Buildgoldmine[10];
            Building.Quarry = new Buildquarry[10];
            Building.Sawmill = new Buildsawmill[10];
            Building.Watchtower = new Buildwatchtower[30];
            Building.Field = new Buildfield[20];
            Building.Headquarters = new Buildheadquarters[1];
            Building.Home = new Buildhome[30];
            Building.Market = new Buildmarket[1];
            Building.Wall = new BuildWall[200];

            this.WindowState = FormWindowState.Maximized;
            ToolTip t = new ToolTip();
            //t.SetToolTip(button2, "Подсказка для TextBox");
            int i = 0;
            for (; i < 30; i++)
            {

                arr[i, 0] = addButton(i, 0);

                for (int i2 = 1; i2 < 17; i2++)
                {
                    arr[i, i2] = addButton(i, i2);

                }
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

        Button[,] arr = new Button[30, 30];
        PictureBox[,] pic = new PictureBox[30, 30];

        private void b_Click(object sender, EventArgs e)
        {
            Point p = (Point)(sender as Button).Tag;
            if (matrix[p.X, p.Y] == 0)
            {
                if (Data.vibor == 1 && Data.builds == 0)
                {
                    Form7 f = new Form7();
                    f.ShowDialog();
                    int schet = 0;
                    int x = 1;
                    int treY = p.Y;
                    int treX = p.X;
                    for (int i = 0; i < x; i++)
                    {
                        if (treY > Data.keyY)
                            treY--;
                        else if (treY < Data.keyY)
                            treY++;
                        if (treX > Data.keyX)
                            treX--;
                        else if (treX < Data.keyX)
                            treX++;
                        if (treY == 0 && treX == 0)
                        {
                            schet++;
                        }
                        else
                        {
                            x++;
                            schet++;
                        }
                    }
                    Data.keyX = p.X;
                    Data.keyY = p.Y;
                    Thread eatthread = new Thread(delegate () { Eat(schet); }); ;
                    eatthread.Start();
                    Thread populationthread = new Thread(Population);
                    populationthread.Start();
                    Thread consumptionthread = new Thread(Consumption);
                    consumptionthread.Start();
                    Thread daythread = new Thread(Day);
                    daythread.Start();
                    Thread gameoverthread = new Thread(GameOver);
                    gameoverthread.Start();
                    arr[p.X, p.Y].BackgroundImage = Image.FromFile("D:\\01Programms\\PHCS6\\Project\\Vikings\\builds\\r.png");
                    arr[p.X, p.Y].Enabled = false;
                    matrix[p.X, p.Y] = 5;
                    buildX[Data.builds] = p.X;
                    buildY[Data.builds] = p.Y;
                    Data.builds++;
                }
                if (Data.vibor == 2 && Data.tree >= 8)
                {
                    Data.tree -= 8;/////////////
                    label3.Text = Data.tree.ToString();
                    int schet = 0;
                    int x = 1;
                    int treY = 16;
                    int treX = 0;
                    for (int i = 0; i < x; i++)
                    {
                        if (treY > p.Y)
                            treY--;
                        if (treX < p.X)
                            treX++;
                        if (treY == p.Y && treX == p.X)
                        {
                            schet++;
                        }
                        else
                        {
                            x++;
                            schet++;
                        }
                    }
                    x = 1;
                    for (int i = 0; i < x; i++)
                    {
                        if (treY > Data.keyY)
                            treY--;
                        else if (treY < Data.keyY)
                            treY++;
                        if (treX > Data.keyX)
                            treX--;
                        else if (treX < Data.keyX)
                            treX++;
                        if (treY == Data.keyY && treX == Data.keyX)
                        {
                            schet++;
                        }
                        else
                        {
                            x++;
                            schet++;
                        }
                    }
                    Thread forestthread = new Thread(delegate () { Forest(schet); }); ;
                    forestthread.Start();
                    arr[p.X, p.Y].BackgroundImage = Image.FromFile("D:\\01Programms\\PHCS6\\Project\\Vikings\\builds\\images\\tree_218.png");
                    arr[p.X, p.Y].Enabled = false;
                    matrix[p.X, p.Y] = 2;
                    buildX[Data.builds] = p.X;
                    buildY[Data.builds] = p.Y;
                    Data.builds++;
                }
                if (Data.vibor == 3 && Data.rock >= 7)
                {
                    Data.rock -= 7;
                    label4.Text = Data.rock.ToString();
                    int schet = 0;
                    int x = 1;
                    int treY = 0;
                    int treX = 29;
                    for (int i = 0; i < x; i++)
                    {
                        if (treY < p.Y)
                            treY++;
                        if (treX > p.X)
                            treX--;
                        if (treY == p.Y && treX == p.X)
                        {
                            schet++;
                        }
                        else
                        {
                            x++;
                            schet++;
                        }
                    }
                    x = 1;
                    for (int i = 0; i < x; i++)
                    {
                        if (treY > Data.keyY)
                            treY--;
                        else if (treY < Data.keyY)
                            treY++;
                        if (treX > Data.keyX)
                            treX--;
                        else if (treX < Data.keyX)
                            treX++;
                        if (treY == Data.keyY && treX == Data.keyX)
                        {
                            schet++;
                        }
                        else
                        {
                            x++;
                            schet++;
                        }
                    }
                    Thread stonethread = new Thread(delegate () { Stone(schet); }); ;
                    stonethread.Start();
                    arr[p.X, p.Y].BackgroundImage = Image.FromFile("D:\\01Programms\\PHCS6\\Project\\Vikings\\builds\\images\\tree_155.png");
                    arr[p.X, p.Y].Enabled = false;
                    matrix[p.X, p.Y] = 2;
                    buildX[Data.builds] = p.X;
                    buildY[Data.builds] = p.Y;
                    Data.builds++;
                }
                if (Data.vibor == 4 && Data.tree >= 20 && Data.rock >= 20)
                {
                    Data.tree -= 20;
                    Data.rock -= 20;
                    int schet = 0;
                    int x = 1;
                    int treY = 16;
                    int treX = 0;
                    for (int i = 0; i < x; i++)
                    {
                        if (treY > p.Y)
                            treY--;
                        if (treX < p.X)
                            treX++;
                        if (treY == p.Y && treX == p.X)
                        {
                            schet++;
                        }
                        else
                        {
                            x++;
                            schet++;
                        }
                    }
                    x = 1;
                    for (int i = 0; i < x; i++)
                    {
                        if (treY > Data.keyY)
                            treY--;
                        if (treX > Data.keyX)
                            treX--;
                        if (treY == Data.keyY && treX == Data.keyX)
                        {
                            schet++;
                        }
                        else
                        {
                            x++;
                            schet++;
                        }
                    }
                    Thread goldthread = new Thread(delegate () { Gold(schet); }); ;
                    goldthread.Start();
                    arr[p.X, p.Y].BackgroundImage = Image.FromFile("D:\\01Programms\\PHCS6\\Project\\Vikings\\builds\\images\\tree_279.png");
                    arr[p.X, p.Y].Enabled = false;
                    label3.Text = Data.tree.ToString();
                    label4.Text = Data.rock.ToString();
                    matrix[p.X, p.Y] = 2;
                    buildX[Data.builds] = p.X;
                    buildY[Data.builds] = p.Y;
                    Data.builds++;
                }
                if (Data.vibor == 5 && Data.tree >= 10 && Data.rock >= 5)
                {
                    Data.tree -= 10;
                    Data.rock -= 5;
                    Data.eatMax += 30;
                    Data.treeMax += 10;
                    Data.rockMax += 10;
                    Data.moneyMax += 5;
                    label3.Text = Data.tree.ToString();
                    label4.Text = Data.rock.ToString();
                    label11.Text = Data.eatMax.ToString();
                    label12.Text = Data.treeMax.ToString();
                    label13.Text = Data.rockMax.ToString();
                    label14.Text = Data.moneyMax.ToString();
                    arr[p.X, p.Y].BackgroundImage = Image.FromFile("D:\\01Programms\\PHCS6\\Project\\Vikings\\builds\\images\\tree_126.png");
                    arr[p.X, p.Y].Enabled = false;
                    matrix[p.X, p.Y] = 2;
                    buildX[Data.builds] = p.X;
                    buildY[Data.builds] = p.Y;
                    Data.builds++;
                }
                if (Data.vibor == 6 && Data.tree >= 10 && Data.rock >= 5)
                {
                    Data.tree -= 10;
                    Data.rock -= 5;
                    Data.wheat -= 100;
                    label3.Text = Data.tree.ToString();
                    label4.Text = Data.rock.ToString();
                    arr[p.X, p.Y].Enabled = false;
                    matrix[p.X, p.Y] = 2;
                    arr[p.X, p.Y].BackgroundImage = Image.FromFile("D:\\01Programms\\PHCS6\\Project\\Vikings\\builds\\images\\tree_94.png");
                    buildX[Data.builds] = p.X;
                    buildY[Data.builds] = p.Y;
                    Data.builds++;
                }
                if (Data.vibor == 7 && Data.tree >= 10 && Data.rock >= 5)
                {
                    Data.populationMax += 10;
                    Data.tree -= 10;
                    Data.rock -= 5;
                    label3.Text = Data.tree.ToString();
                    label4.Text = Data.rock.ToString();
                    label15.Text = Data.populationMax.ToString();
                    arr[p.X, p.Y].BackgroundImage = Image.FromFile("D:\\01Programms\\PHCS6\\Project\\Vikings\\builds\\images\\tree_124.png");
                    arr[p.X, p.Y].Enabled = false;
                    matrix[p.X, p.Y] = 2;
                    buildX[Data.builds] = p.X;
                    buildY[Data.builds] = p.Y;
                    Data.builds++;
                }
                if (Data.vibor == 8)
                {
                    Thread towerthread = new Thread(delegate () { Tower(p.X, p.Y); }); ;
                    towerthread.Start();
                    arr[p.X, p.Y].Text = "T";
                    arr[p.X, p.Y].Enabled = false;
                    matrix[p.X, p.Y] = 7;
                    buildX[Data.builds] = p.X;
                    buildY[Data.builds] = p.Y;
                    Data.builds++;
                }
                if (Data.vibor == 9 && Data.tree >= 15)
                {
                    Data.tree -= 15;
                    label3.Text = Data.tree.ToString();
                    Data.wheat -= 100;
                    arr[p.X, p.Y].BackgroundImage = Image.FromFile("D:\\01Programms\\PHCS6\\Project\\Vikings\\builds\\images\\tree_186.png");
                    arr[p.X, p.Y].Enabled = false;
                    matrix[p.X, p.Y] = 7;
                    buildX[Data.builds] = p.X;
                    buildY[Data.builds] = p.Y;
                    Data.builds++;
                }
                if (Data.vibor == 10 && Data.tree >= 15)
                {
                    Data.tree -= 15;
                    label3.Text = Data.tree.ToString();
                    Data.wheat -= 100;
                    arr[p.X, p.Y].BackgroundImage = Image.FromFile("D:\\01Programms\\PHCS6\\Project\\Vikings\\builds\\images\\tree_245.png");///////////////////
                    arr[p.X, p.Y].Enabled = false;
                    matrix[p.X, p.Y] = 7;
                    buildX[Data.builds] = p.X;
                    buildY[Data.builds] = p.Y;
                    Data.builds++;
                }
                if (Data.vibor == 11 && Data.tree >= 15)
                {
                    Data.tree -= 15;
                    label3.Text = Data.tree.ToString();
                    Data.wheat -= 100;
                    arr[p.X, p.Y].BackgroundImage = Image.FromFile("D:\\01Programms\\PHCS6\\Project\\Vikings\\builds\\images\\tree_215.png");
                    arr[p.X, p.Y].Enabled = false;
                    matrix[p.X, p.Y] = 7;
                    buildX[Data.builds] = p.X;
                    buildY[Data.builds] = p.Y;
                    Data.builds++;
                }
                if (Data.vibor == 12 && Data.tree >= 15)
                {
                    Data.tree -= 15;
                    label3.Text = Data.tree.ToString();
                    Data.wheat -= 100;
                    arr[p.X, p.Y].BackgroundImage = Image.FromFile("D:\\01Programms\\PHCS6\\Project\\Vikings\\builds\\images\\tree_219.png");
                    arr[p.X, p.Y].Enabled = false;
                    matrix[p.X, p.Y] = 7;
                    buildX[Data.builds] = p.X;
                    buildY[Data.builds] = p.Y;
                    Data.builds++;
                }
                if (Data.vibor == 13 && Data.tree >= 1)
                {
                    Data.tree -= 1;
                    label3.Text = Data.tree.ToString();
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
                    buildX[Data.builds] = p.X;
                    buildY[Data.builds] = p.Y;
                    Data.builds++;
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
                Data.eat -= 3 * Data.population;
                if(Data.exit == 0)
                    label2.Invoke(new Action(() => label2.Text = Data.eat.ToString()));
            }
        }

        private void GameOver()
        {
            while(Data.endgame == 0 && Data.exit == 0)
            {
                if(Data.eat < 0)
                {
                    Thread.Sleep(1000);
                    Data.population -= 1;
                    label6.Invoke(new Action(() => label6.Text = Data.population.ToString()));
                }
                if (Data.population <= 0)
                {
                    Data.endgame = 1;
                    Data.exit = 1;

                    Data.vibor = 0;
                    Data.eat = 100;
                    Data.eatMax = 100;
                    Data.tree = 10;
                    Data.treeMax = 10;
                    Data.rock = 10;
                    Data.rockMax = 10;
                    Data.money = 0;
                    Data.moneyMax = 0;
                    Data.population = 5;
                    Data.populationMax = 10;
                    Data.clock = 21;
                    Data.daypassed = 6;
                    Data.wheat = 2000;
                    Data.healthenemy = 10;
                    Data.enemyOn = 1;
                    Data.enemyVolume = 3;
                    Data.enemyCount = 0;
                    Data.builds = 0;

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
                if (Data.clock < 23)
                {
                    Data.clock++;
                    if (Data.clock == 12)
                        pictureBox4.BackgroundImage = Image.FromFile("D:\\01Programms\\PHCS6\\Project\\Vikings\\clock\\1.png");
                    if (Data.clock == 13)
                        pictureBox4.BackgroundImage = Image.FromFile("D:\\01Programms\\PHCS6\\Project\\Vikings\\clock\\2.png");
                    if (Data.clock == 14)
                        pictureBox4.BackgroundImage = Image.FromFile("D:\\01Programms\\PHCS6\\Project\\Vikings\\clock\\3.png");
                    if (Data.clock == 15)
                        pictureBox4.BackgroundImage = Image.FromFile("D:\\01Programms\\PHCS6\\Project\\Vikings\\clock\\4.png");
                    if (Data.clock == 16)
                        pictureBox4.BackgroundImage = Image.FromFile("D:\\01Programms\\PHCS6\\Project\\Vikings\\clock\\5.png");
                    if (Data.clock == 17)
                        pictureBox4.BackgroundImage = Image.FromFile("D:\\01Programms\\PHCS6\\Project\\Vikings\\clock\\6.png");
                    if (Data.clock == 18)
                        pictureBox4.BackgroundImage = Image.FromFile("D:\\01Programms\\PHCS6\\Project\\Vikings\\clock\\7.png");
                    if (Data.clock == 19)
                        pictureBox4.BackgroundImage = Image.FromFile("D:\\01Programms\\PHCS6\\Project\\Vikings\\clock\\8.png");
                    if (Data.clock == 20)
                        pictureBox4.BackgroundImage = Image.FromFile("D:\\01Programms\\PHCS6\\Project\\Vikings\\clock\\9.png");
                    if (Data.clock == 21)
                        pictureBox4.BackgroundImage = Image.FromFile("D:\\01Programms\\PHCS6\\Project\\Vikings\\clock\\10.png");
                    if (Data.clock == 22)
                        pictureBox4.BackgroundImage = Image.FromFile("D:\\01Programms\\PHCS6\\Project\\Vikings\\clock\\11.png");
                    if (Data.clock == 23)
                        pictureBox4.BackgroundImage = Image.FromFile("D:\\01Programms\\PHCS6\\Project\\Vikings\\clock\\12.png");
                    if (Data.clock == 1)
                        pictureBox4.BackgroundImage = Image.FromFile("D:\\01Programms\\PHCS6\\Project\\Vikings\\clock\\13.png");
                    if (Data.clock == 2)
                        pictureBox4.BackgroundImage = Image.FromFile("D:\\01Programms\\PHCS6\\Project\\Vikings\\clock\\14.png");
                    if (Data.clock == 3)
                        pictureBox4.BackgroundImage = Image.FromFile("D:\\01Programms\\PHCS6\\Project\\Vikings\\clock\\15.png");
                    if (Data.clock == 4)
                        pictureBox4.BackgroundImage = Image.FromFile("D:\\01Programms\\PHCS6\\Project\\Vikings\\clock\\16.png");
                    if (Data.clock == 5)
                        pictureBox4.BackgroundImage = Image.FromFile("D:\\01Programms\\PHCS6\\Project\\Vikings\\clock\\17.png");
                    if (Data.clock == 6)
                        pictureBox4.BackgroundImage = Image.FromFile("D:\\01Programms\\PHCS6\\Project\\Vikings\\clock\\18.png");
                    if (Data.clock == 7)
                        pictureBox4.BackgroundImage = Image.FromFile("D:\\01Programms\\PHCS6\\Project\\Vikings\\clock\\19.png");
                    if (Data.clock == 8)
                        pictureBox4.BackgroundImage = Image.FromFile("D:\\01Programms\\PHCS6\\Project\\Vikings\\clock\\20.png");
                    if (Data.clock == 9)
                        pictureBox4.BackgroundImage = Image.FromFile("D:\\01Programms\\PHCS6\\Project\\Vikings\\clock\\21.png");
                    if (Data.clock == 10)
                        pictureBox4.BackgroundImage = Image.FromFile("D:\\01Programms\\PHCS6\\Project\\Vikings\\clock\\22.png");
                    if (Data.clock == 11)
                        pictureBox4.BackgroundImage = Image.FromFile("D:\\01Programms\\PHCS6\\Project\\Vikings\\clock\\23.png");
                }
                else
                {
                    Data.clock = 0;
                    Data.daypassed++;
                    label20.Invoke(new Action(() => label20.Text = Data.daypassed.ToString()));
                }
                if (Data.daypassed == 7 && Data.enemyOn == 1)
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
                if (Data.clock < 6 || Data.clock > 21)
                    night = 2000;
                else
                    night = 0;
                Thread.Sleep((a * Data.wheat) + night);
                if (Data.eatMax > Data.eat)
                    Data.eat++;
                if (Data.exit == 0)
                    label2.Invoke(new Action(() => label2.Text = Data.eat.ToString()));
            }
        }

        private void Forest(int a)
        {
            int night = 0;
            while (Data.exit != 1)
            {
                if (Data.clock < 6 || Data.clock > 21)
                    night = 2000;
                else
                    night = 0;
                Thread.Sleep((a * 1000) + night);
                if(Data.treeMax > Data.tree)
                    Data.tree++;
                if (Data.exit == 0)
                    label3.Invoke(new Action(() => label3.Text = Data.tree.ToString()));
            }
        }

        private void Stone(int a)
        {
            int night = 0;
            while (Data.exit != 1)
            {
                if (Data.clock < 6 || Data.clock > 21)
                    night = 2000;
                else
                    night = 0;
                Thread.Sleep((a * 1000) + night);
                if (Data.rockMax > Data.rock)
                    Data.rock++;
                if (Data.exit == 0)
                    label4.Invoke(new Action(() => label4.Text = Data.rock.ToString()));
            }
        }

        private void Gold(int a)
        {
            int night = 0;
            while (Data.exit != 1)
            {
                if (Data.clock < 6 || Data.clock > 21)
                    night = 2000;
                else
                    night = 0;
                Thread.Sleep((a * 1000) + night);
                if (Data.moneyMax > Data.money)
                    Data.money++;
                if (Data.exit == 0)
                    label5.Invoke(new Action(() => label5.Text = Data.money.ToString()));
            }
        }

        private void Population()
        {
            while (Data.exit != 1)
            {
                Thread.Sleep(30000);
                if (Data.populationMax > Data.population)
                    Data.population++;
                if(Data.exit == 0)
                    label6.Invoke(new Action(() => label6.Text = Data.population.ToString()));
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            if(Data.vibor == 0)
                Data.vibor = 1;
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
            Data.vibor = 0;
            Data.eat = 100;
            Data.eatMax = 100;
            Data.tree = 10;
            Data.treeMax = 10;
            Data.rock = 10;
            Data.rockMax = 10;
            Data.money = 0;
            Data.moneyMax = 0;
            Data.population = 5;
            Data.populationMax = 10;
            Data.clock = 21;
            Data.daypassed = 6;
            Data.wheat = 2000;
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
        static public int vibor { get; set; } = 0;
        static public int eat { get; set; } = 100;
        static public int eatMax { get; set; } = 100;
        static public int tree { get; set; } = 1000;
        static public int treeMax { get; set; } = 1000;
        static public int rock { get; set; } = 10;
        static public int rockMax { get; set; } = 10;
        static public int money { get; set; } = 0;
        static public int moneyMax { get; set; } = 0;
        static public int population { get; set; } = 5;
        static public int populationMax { get; set; } = 10;
        static public int clock { get; set; } = 12;
        static public int daypassed { get; set; } = 0;
        static public int wheat { get; set; } = 1000;
        static public int healthenemy { get; set; } = 10;
        static public int enemyOn { get; set; } = 1;
        static public int enemyVolume { get; set; } = 3;
        static public int enemyCount { get; set; } = 0;
        static public int builds { get; set; } = 0;
        static public int endgame { get; set; } = 0;
        static public int konung { get; set; } = 0;

        static public int keyX { get; set; } = 0;
        static public int keyY { get; set; } = 0;
        static public int level { get; set; } = 1;
        static public int music { get; set; } = 1;
        static public int exit { get; set; } = 0;
        static public int teach { get; set; } = 0;
    }
}
