using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vik
{
    public partial class TreeSkils : Form
    {
        private ResourceVillage Village = ResourceVillage.GetInstance();
        ToolTip t = new ToolTip();

        public TreeSkils()
        {
            InitializeComponent();
            numericUpDown1.Maximum = Village.GetPopulation() - Village.GetSkilsForest(0) - Village.GetSkilsStone(0) - Village.GetSkilsGold(0);
            numericUpDown2.Maximum = Village.GetPopulation() - Village.GetSkilsEat(0) - Village.GetSkilsStone(0) - Village.GetSkilsGold(0);
            numericUpDown3.Maximum = Village.GetPopulation() - Village.GetSkilsForest(0) - Village.GetSkilsEat(0) - Village.GetSkilsGold(0);
            numericUpDown4.Maximum = Village.GetPopulation() - Village.GetSkilsForest(0) - Village.GetSkilsStone(0) - Village.GetSkilsEat(0);
            numericUpDown1.Value = Village.GetSkilsEat(0);
            numericUpDown2.Value = Village.GetSkilsForest(0);
            numericUpDown3.Value = Village.GetSkilsStone(0);
            numericUpDown4.Value = Village.GetSkilsGold(0);
            numericUpDown5.Value = Village.GetSkilsEat(2);
            numericUpDown6.Value = Village.GetSkilsEat(3);
            numericUpDown7.Value = Village.GetSkilsEat(4);
            numericUpDown8.Value = Village.GetSkilsForest(2);
            numericUpDown9.Value = Village.GetSkilsForest(3);
            numericUpDown10.Value = Village.GetSkilsForest(4);
            numericUpDown11.Value = Village.GetSkilsStone(2);
            numericUpDown12.Value = Village.GetSkilsStone(3);
            numericUpDown13.Value = Village.GetSkilsStone(4);
            numericUpDown14.Value = Village.GetSkilsGold(2);
            numericUpDown15.Value = Village.GetSkilsGold(3);
            numericUpDown16.Value = Village.GetSkilsGold(4);
            numericUpDown17.Value = Village.GetSkilsForestOut(0);
            numericUpDown20.Value = Village.GetSkilsForestOut(1);
            numericUpDown18.Value = Village.GetSkilsStoneOut(0);
            numericUpDown21.Value = Village.GetSkilsStoneOut(1);
            numericUpDown19.Value = Village.GetSkilsGoldOut(0);
            numericUpDown22.Value = Village.GetSkilsGoldOut(1);
            numericUpDown23.Value = Village.GetSkilsPassiveBuilds(0);
            numericUpDown24.Value = Village.GetSkilsPassiveBuilds(1);
            numericUpDown25.Value = Village.GetSkilsPassiveBuilds(2);
            numericUpDown26.Value = Village.GetSkilsPassiveBuilds(3);
            numericUpDown27.Value = Village.GetSkilsPassiveBuilds(4);
            numericUpDown28.Value = Village.GetSkilsPassiveBuilds(5);
            SetStaticPerson();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            Village.SetSkilsEat(Convert.ToUInt16(numericUpDown1.Value), 0);
            numericUpDown2.Maximum = Village.GetPopulation() - Village.GetSkilsEat(0) - Village.GetSkilsStone(0) - Village.GetSkilsGold(0);
            numericUpDown3.Maximum = Village.GetPopulation() - Village.GetSkilsForest(0) - Village.GetSkilsEat(0) - Village.GetSkilsGold(0);
            numericUpDown4.Maximum = Village.GetPopulation() - Village.GetSkilsForest(0) - Village.GetSkilsStone(0) - Village.GetSkilsEat(0);
            SetStaticPerson();
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            Village.SetSkilsForest(Convert.ToUInt16(numericUpDown2.Value), 0);
            numericUpDown1.Maximum = Village.GetPopulation() - Village.GetSkilsForest(0) - Village.GetSkilsStone(0) - Village.GetSkilsGold(0);
            numericUpDown3.Maximum = Village.GetPopulation() - Village.GetSkilsForest(0) - Village.GetSkilsEat(0) - Village.GetSkilsGold(0);
            numericUpDown4.Maximum = Village.GetPopulation() - Village.GetSkilsForest(0) - Village.GetSkilsStone(0) - Village.GetSkilsEat(0);
            SetStaticPerson();
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            Village.SetSkilsStone(Convert.ToUInt16(numericUpDown3.Value), 0);
            numericUpDown1.Maximum = Village.GetPopulation() - Village.GetSkilsForest(0) - Village.GetSkilsStone(0) - Village.GetSkilsGold(0);
            numericUpDown2.Maximum = Village.GetPopulation() - Village.GetSkilsEat(0) - Village.GetSkilsStone(0) - Village.GetSkilsGold(0);
            numericUpDown4.Maximum = Village.GetPopulation() - Village.GetSkilsForest(0) - Village.GetSkilsStone(0) - Village.GetSkilsEat(0);
            SetStaticPerson();
        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {
            Village.SetSkilsGold(Convert.ToUInt16(numericUpDown4.Value), 0);
            numericUpDown1.Maximum = Village.GetPopulation() - Village.GetSkilsForest(0) - Village.GetSkilsStone(0) - Village.GetSkilsGold(0);
            numericUpDown2.Maximum = Village.GetPopulation() - Village.GetSkilsEat(0) - Village.GetSkilsStone(0) - Village.GetSkilsGold(0);
            numericUpDown3.Maximum = Village.GetPopulation() - Village.GetSkilsForest(0) - Village.GetSkilsEat(0) - Village.GetSkilsGold(0);
            SetStaticPerson();
        }

        private void SetStaticPerson()
        {
            label4.Text = Convert.ToString(Village.GetPopulation());
            label5.Text = Convert.ToString(Village.GetPopulation() - (Village.GetSkilsEat(0) + Village.GetSkilsForest(0) + Village.GetSkilsStone(0) + Village.GetSkilsGold(0)));
            label6.Text = Convert.ToString(Village.GetSkilsEat(0) + Village.GetSkilsForest(0) + Village.GetSkilsStone(0) + Village.GetSkilsGold(0));
            t.SetToolTip(numericUpDown5, "Требуется " + Convert.ToString(PriceSkils(Convert.ToUInt16(numericUpDown5.Value + 1))) + " монет\nУвеличит максимум рабочих до " + Convert.ToString(PriceSkils(Convert.ToUInt16(numericUpDown5.Value + 1), 2)));
            t.SetToolTip(numericUpDown6, "Требуется " + Convert.ToString(PriceSkils(Convert.ToUInt16(numericUpDown6.Value + 1))) + " монет\nУвеличит скорость добычи на " + Convert.ToString(PriceSkils(Convert.ToUInt16(numericUpDown6.Value + 1), 3)));
            t.SetToolTip(numericUpDown7, "Требуется " + Convert.ToString(PriceSkils(Convert.ToUInt16(numericUpDown7.Value + 1))) + " монет\nВозможность возводить до " + Convert.ToString(PriceSkils(Convert.ToUInt16(numericUpDown7.Value + 1), 4)) + " построек");
            t.SetToolTip(numericUpDown8, "Требуется " + Convert.ToString(PriceSkils(Convert.ToUInt16(numericUpDown8.Value + 1))) + " монет\nУвеличит максимум рабочих до " + Convert.ToString(PriceSkils(Convert.ToUInt16(numericUpDown8.Value + 1), 2)));
            t.SetToolTip(numericUpDown9, "Требуется " + Convert.ToString(PriceSkils(Convert.ToUInt16(numericUpDown9.Value + 1))) + " монет\nУвеличит скорость добычи на " + Convert.ToString(PriceSkils(Convert.ToUInt16(numericUpDown9.Value + 1), 3)));
            t.SetToolTip(numericUpDown10, "Требуется " + Convert.ToString(PriceSkils(Convert.ToUInt16(numericUpDown10.Value + 1))) + " монет\nВозможность возводить до " + Convert.ToString(PriceSkils(Convert.ToUInt16(numericUpDown10.Value + 1), 4)) + " построек");
            t.SetToolTip(numericUpDown11, "Требуется " + Convert.ToString(PriceSkils(Convert.ToUInt16(numericUpDown11.Value + 1))) + " монет\nУвеличит максимум рабочих до " + Convert.ToString(PriceSkils(Convert.ToUInt16(numericUpDown11.Value + 1), 2)));
            t.SetToolTip(numericUpDown12, "Требуется " + Convert.ToString(PriceSkils(Convert.ToUInt16(numericUpDown12.Value + 1))) + " монет\nУвеличит скорость добычи на " + Convert.ToString(PriceSkils(Convert.ToUInt16(numericUpDown12.Value + 1), 3)));
            t.SetToolTip(numericUpDown13, "Требуется " + Convert.ToString(PriceSkils(Convert.ToUInt16(numericUpDown13.Value + 1))) + " монет\nВозможность возводить до " + Convert.ToString(PriceSkils(Convert.ToUInt16(numericUpDown13.Value + 1), 4)) + " построек");
            t.SetToolTip(numericUpDown14, "Требуется " + Convert.ToString(PriceSkils(Convert.ToUInt16(numericUpDown14.Value + 1))) + " монет\nУвеличит максимум рабочих до " + Convert.ToString(PriceSkils(Convert.ToUInt16(numericUpDown14.Value + 1), 2)));
            t.SetToolTip(numericUpDown15, "Требуется " + Convert.ToString(PriceSkils(Convert.ToUInt16(numericUpDown15.Value + 1))) + " монет\nУвеличит скорость добычи на " + Convert.ToString(PriceSkils(Convert.ToUInt16(numericUpDown15.Value + 1), 3)));
            t.SetToolTip(numericUpDown16, "Требуется " + Convert.ToString(PriceSkils(Convert.ToUInt16(numericUpDown16.Value + 1))) + " монет\nВозможность возводить до " + Convert.ToString(PriceSkils(Convert.ToUInt16(numericUpDown16.Value + 1), 4)) + " построек");
            t.SetToolTip(numericUpDown17, "Требуется " + Convert.ToString(PriceSkils(Convert.ToUInt16(numericUpDown17.Value + 1))) + " монет\nУвеличит скорость переработки на " + Convert.ToString(PriceSkils(Convert.ToByte(numericUpDown17.Value + 1), 0)));
            t.SetToolTip(numericUpDown18, "Требуется " + Convert.ToString(PriceSkils(Convert.ToUInt16(numericUpDown18.Value + 1))) + " монет\nУвеличит скорость переработки на " + Convert.ToString(PriceSkils(Convert.ToByte(numericUpDown18.Value + 1), 0)));
            t.SetToolTip(numericUpDown19, "Требуется " + Convert.ToString(PriceSkils(Convert.ToUInt16(numericUpDown19.Value + 1))) + " монет\nУвеличит скорость переработки на " + Convert.ToString(PriceSkils(Convert.ToByte(numericUpDown19.Value + 1), 0)));
            t.SetToolTip(numericUpDown20, "Требуется " + Convert.ToString(PriceSkils(Convert.ToUInt16(numericUpDown20.Value + 1))) + " монет\nУвеличит вывод ресурсов до " + Convert.ToString(PriceSkils(Convert.ToByte(numericUpDown20.Value + 1), 1)));
            t.SetToolTip(numericUpDown21, "Требуется " + Convert.ToString(PriceSkils(Convert.ToUInt16(numericUpDown21.Value + 1))) + " монет\nУвеличит вывод ресурсов до " + Convert.ToString(PriceSkils(Convert.ToByte(numericUpDown21.Value + 1), 1)));
            t.SetToolTip(numericUpDown22, "Требуется " + Convert.ToString(PriceSkils(Convert.ToUInt16(numericUpDown22.Value + 1))) + " монет\nУвеличит вывод ресурсов до " + Convert.ToString(PriceSkils(Convert.ToByte(numericUpDown22.Value + 1), 1)));
            t.SetToolTip(numericUpDown23, "Требуется " + Convert.ToString(PriceSkils(Convert.ToUInt16(numericUpDown23.Value + 1))) + " монет");
            t.SetToolTip(numericUpDown24, "Требуется " + Convert.ToString(PriceSkils(Convert.ToUInt16(numericUpDown24.Value + 1))) + " монет");
            t.SetToolTip(numericUpDown25, "Требуется " + Convert.ToString(PriceSkils(Convert.ToUInt16(numericUpDown25.Value + 1))) + " монет");
            t.SetToolTip(numericUpDown26, "Требуется " + Convert.ToString(PriceSkils(Convert.ToUInt16(numericUpDown26.Value + 1))) + " монет");
            t.SetToolTip(numericUpDown27, "Требуется " + Convert.ToString(PriceSkils(Convert.ToUInt16(numericUpDown27.Value + 1))) + " монет");
            t.SetToolTip(numericUpDown28, "Требуется " + Convert.ToString(PriceSkils(Convert.ToUInt16(numericUpDown28.Value + 1))) + " монет");
            label10.Text = Convert.ToString(Village.GetMoney());
            label35.Text = Convert.ToString(Village.GetSkilsEat(1));
            label36.Text = Convert.ToString(Village.GetSkilsForest(1));
            label37.Text = Convert.ToString(Village.GetSkilsStone(1));
            label38.Text = Convert.ToString(Village.GetSkilsGold(1));
        }

        private void BoostEat()
        {
            numericUpDown1.Value = Village.GetPopulation();
            numericUpDown2.Value = 0;
            numericUpDown3.Value = 0;
            numericUpDown4.Value = 0;
            SetStaticPerson();
        }

        private void BoostForest()
        {
            numericUpDown1.Value = 0;
            numericUpDown2.Value = Village.GetPopulation();
            numericUpDown3.Value = 0;
            numericUpDown4.Value = 0;
        }

        private void BoostStone()
        {
            numericUpDown1.Value = 0;
            numericUpDown2.Value = 0;
            numericUpDown3.Value = Village.GetPopulation();
            numericUpDown4.Value = 0;
        }

        private void BoostGold()
        {
            numericUpDown1.Value = 0;
            numericUpDown2.Value = 0;
            numericUpDown3.Value = 0;
            numericUpDown4.Value = Village.GetPopulation();
        }

        private void numericUpDown5_ValueChanged(object sender, EventArgs e)
        {
            if (Village.GetMoney() >= PriceSkils(Convert.ToUInt16(numericUpDown5.Value)))
            {
                Village.SetMoney(Village.GetMoney() - PriceSkils(Convert.ToUInt16(numericUpDown5.Value)));
                Village.SetSkilsEat(Convert.ToUInt16(numericUpDown5.Value), 2);
                Village.SetSkilsEat(PriceSkils(Convert.ToUInt16(numericUpDown5.Value), 1), 1);
                numericUpDown5.Minimum = numericUpDown5.Value;
                SetStaticPerson();
            }
            else numericUpDown5.Value = Village.GetSkilsEat(2);
        }

        private void numericUpDown6_ValueChanged(object sender, EventArgs e)
        {
            if (Village.GetMoney() >= PriceSkils(Convert.ToUInt16(numericUpDown6.Value)))
            {
                Village.SetMoney(Village.GetMoney() - PriceSkils(Convert.ToUInt16(numericUpDown6.Value)));
                Village.SetSkilsEat(Convert.ToUInt16(numericUpDown6.Value), 3);
                numericUpDown6.Minimum = numericUpDown6.Value;
                SetStaticPerson();
            }
            else numericUpDown6.Value = Village.GetSkilsEat(3);
        }

        private void numericUpDown7_ValueChanged(object sender, EventArgs e)
        {
            if (Village.GetMoney() >= PriceSkils(Convert.ToUInt16(numericUpDown7.Value)))
            {
                Village.SetMoney(Village.GetMoney() - PriceSkils(Convert.ToUInt16(numericUpDown7.Value)));
                Village.SetSkilsEat(Convert.ToUInt16(numericUpDown7.Value), 4);
                numericUpDown7.Minimum = numericUpDown7.Value;
                SetStaticPerson();
            }
            else numericUpDown7.Value = Village.GetSkilsEat(4);
        }

        private void numericUpDown8_ValueChanged(object sender, EventArgs e)
        {
            if (Village.GetMoney() >= PriceSkils(Convert.ToUInt16(numericUpDown8.Value)))
            {
                Village.SetMoney(Village.GetMoney() - PriceSkils(Convert.ToUInt16(numericUpDown8.Value)));
                Village.SetSkilsForest(Convert.ToUInt16(numericUpDown8.Value), 2);
                numericUpDown8.Minimum = numericUpDown8.Value;
                Village.SetSkilsForest(PriceSkils(Convert.ToUInt16(numericUpDown8.Value), 1), 1);
                SetStaticPerson();
            }
            else numericUpDown8.Value = Village.GetSkilsForest(2);
        }

        private void numericUpDown9_ValueChanged(object sender, EventArgs e)
        {
            if (Village.GetMoney() >= PriceSkils(Convert.ToUInt16(numericUpDown9.Value)))
            {
                Village.SetMoney(Village.GetMoney() - PriceSkils(Convert.ToUInt16(numericUpDown9.Value)));
                Village.SetSkilsForest(Convert.ToUInt16(numericUpDown9.Value), 3);
                numericUpDown9.Minimum = numericUpDown9.Value;
                SetStaticPerson();
            }
            else numericUpDown9.Value = Village.GetSkilsForest(3);
        }

        private void numericUpDown10_ValueChanged(object sender, EventArgs e)
        {
            if (Village.GetMoney() >= PriceSkils(Convert.ToUInt16(numericUpDown10.Value)))
            {
                Village.SetMoney(Village.GetMoney() - PriceSkils(Convert.ToUInt16(numericUpDown10.Value)));
                Village.SetSkilsForest(Convert.ToUInt16(numericUpDown10.Value), 4);
                numericUpDown10.Minimum = numericUpDown10.Value;
                SetStaticPerson();
            }
            else numericUpDown10.Value = Village.GetSkilsForest(4);
        }

        private void numericUpDown11_ValueChanged(object sender, EventArgs e)
        {
            if (Village.GetMoney() >= PriceSkils(Convert.ToUInt16(numericUpDown11.Value)))
            {
                Village.SetMoney(Village.GetMoney() - PriceSkils(Convert.ToUInt16(numericUpDown11.Value)));
                Village.SetSkilsStone(Convert.ToUInt16(numericUpDown11.Value), 2);
                numericUpDown11.Minimum = numericUpDown11.Value;
                Village.SetSkilsStone(PriceSkils(Convert.ToUInt16(numericUpDown11.Value), 1), 1);
                SetStaticPerson();
            }
            else numericUpDown11.Value = Village.GetSkilsStone(2);
        }

        private void numericUpDown12_ValueChanged(object sender, EventArgs e)
        {
            if (Village.GetMoney() >= PriceSkils(Convert.ToUInt16(numericUpDown12.Value)))
            {
                Village.SetMoney(Village.GetMoney() - PriceSkils(Convert.ToUInt16(numericUpDown12.Value)));
                Village.SetSkilsStone(Convert.ToUInt16(numericUpDown12.Value), 3);
                numericUpDown12.Minimum = numericUpDown12.Value;
                SetStaticPerson();
            }
            else numericUpDown12.Value = Village.GetSkilsStone(3);
        }

        private void numericUpDown13_ValueChanged(object sender, EventArgs e)
        {
            if (Village.GetMoney() >= PriceSkils(Convert.ToUInt16(numericUpDown13.Value)))
            {
                Village.SetMoney(Village.GetMoney() - PriceSkils(Convert.ToUInt16(numericUpDown13.Value)));
                Village.SetSkilsStone(Convert.ToUInt16(numericUpDown13.Value), 4);
                numericUpDown13.Minimum = numericUpDown13.Value;
                SetStaticPerson();
            }
            else numericUpDown3.Value = Village.GetSkilsStone(4);
        }

        private void numericUpDown14_ValueChanged(object sender, EventArgs e)
        {
            if (Village.GetMoney() >= PriceSkils(Convert.ToUInt16(numericUpDown14.Value)))
            {
                Village.SetMoney(Village.GetMoney() - PriceSkils(Convert.ToUInt16(numericUpDown14.Value)));
                Village.SetSkilsGold(Convert.ToUInt16(numericUpDown14.Value), 2);
                numericUpDown14.Minimum = numericUpDown14.Value;
                Village.SetSkilsGold(PriceSkils(Convert.ToUInt16(numericUpDown14.Value), 1), 1);
                SetStaticPerson();
            }
            else numericUpDown14.Value = Village.GetSkilsGold(2);
        }

        private void numericUpDown15_ValueChanged(object sender, EventArgs e)
        {
            if (Village.GetMoney() >= PriceSkils(Convert.ToUInt16(numericUpDown15.Value)))
            {
                Village.SetMoney(Village.GetMoney() - PriceSkils(Convert.ToUInt16(numericUpDown15.Value)));
                Village.SetSkilsGold(Convert.ToUInt16(numericUpDown14.Value), 3);
                numericUpDown15.Minimum = numericUpDown15.Value;
                SetStaticPerson();
            }
            else numericUpDown15.Value = Village.GetSkilsGold(3);
        }

        private void numericUpDown16_ValueChanged(object sender, EventArgs e)
        {
            if (Village.GetMoney() >= PriceSkils(Convert.ToUInt16(numericUpDown16.Value)))
            {
                Village.SetMoney(Village.GetMoney() - PriceSkils(Convert.ToUInt16(numericUpDown16.Value)));
                Village.SetSkilsGold(Convert.ToUInt16(numericUpDown14.Value), 4);
                numericUpDown16.Minimum = numericUpDown16.Value;
                SetStaticPerson();
            }
            else numericUpDown16.Value = Village.GetSkilsGold(4);
        }

        private void numericUpDown17_ValueChanged(object sender, EventArgs e)
        {
            if (Village.GetMoney() >= PriceSkils(Convert.ToByte(numericUpDown17.Value)))
            {
                Village.SetMoney(Village.GetMoney() - PriceSkils(Convert.ToByte(numericUpDown17.Value)));
                Village.SetSkilsForestOut(Convert.ToByte(numericUpDown17.Value), 0);
                numericUpDown17.Minimum = numericUpDown17.Value;
                SetStaticPerson();
            }
            else numericUpDown17.Value = Village.GetSkilsForestOut(0);
        }

        private void numericUpDown20_ValueChanged(object sender, EventArgs e)
        {
            if (Village.GetMoney() >= PriceSkils(Convert.ToByte(numericUpDown20.Value)))
            {
                Village.SetMoney(Village.GetMoney() - PriceSkils(Convert.ToByte(numericUpDown20.Value)));
                Village.SetSkilsForestOut(Convert.ToByte(numericUpDown20.Value), 1);
                numericUpDown20.Minimum = numericUpDown20.Value;
                SetStaticPerson();
            }
            else numericUpDown20.Value = Village.GetSkilsForestOut(1);
        }

        private void numericUpDown18_ValueChanged(object sender, EventArgs e)
        {
            if (Village.GetMoney() >= PriceSkils(Convert.ToByte(numericUpDown18.Value)))
            {
                Village.SetMoney(Village.GetMoney() - PriceSkils(Convert.ToByte(numericUpDown18.Value)));
                Village.SetSkilsStoneOut(Convert.ToByte(numericUpDown18.Value), 0);
                numericUpDown18.Minimum = numericUpDown18.Value;
                SetStaticPerson();
            }
            else numericUpDown18.Value = Village.GetSkilsStoneOut(0);
        }

        private void numericUpDown21_ValueChanged(object sender, EventArgs e)
        {
            if (Village.GetMoney() >= PriceSkils(Convert.ToByte(numericUpDown21.Value)))
            {
                Village.SetMoney(Village.GetMoney() - PriceSkils(Convert.ToByte(numericUpDown21.Value)));
                Village.SetSkilsStoneOut(Convert.ToByte(numericUpDown21.Value), 1);
                numericUpDown21.Minimum = numericUpDown21.Value;
                SetStaticPerson();
            }
            else numericUpDown21.Value = Village.GetSkilsStoneOut(1);
        }

        private void numericUpDown19_ValueChanged(object sender, EventArgs e)
        {
            if (Village.GetMoney() >= PriceSkils(Convert.ToByte(numericUpDown19.Value)))
            {
                Village.SetMoney(Village.GetMoney() - PriceSkils(Convert.ToByte(numericUpDown19.Value)));
                Village.SetSkilsGoldOut(Convert.ToByte(numericUpDown19.Value), 0);
                numericUpDown19.Minimum = numericUpDown19.Value;
                SetStaticPerson();
            }
            else numericUpDown19.Value = Village.GetSkilsGoldOut(0);
        }

        private void numericUpDown22_ValueChanged(object sender, EventArgs e)
        {
            if (Village.GetMoney() >= PriceSkils(Convert.ToByte(numericUpDown22.Value)))
            {
                Village.SetMoney(Village.GetMoney() - PriceSkils(Convert.ToByte(numericUpDown22.Value)));
                Village.SetSkilsGoldOut(Convert.ToByte(numericUpDown22.Value), 1);
                numericUpDown22.Minimum = numericUpDown22.Value;
                SetStaticPerson();
            }
            else numericUpDown22.Value = Village.GetSkilsGoldOut(1);
        }

        private void numericUpDown23_ValueChanged(object sender, EventArgs e)
        {
            if (Village.GetMoney() >= PriceSkils(Convert.ToByte(numericUpDown23.Value)))
            {
                Village.SetMoney(Village.GetMoney() - PriceSkils(Convert.ToByte(numericUpDown23.Value)));
                Village.SetSkilsPassiveBuilds(Convert.ToByte(numericUpDown23.Value), 0);
                numericUpDown23.Minimum = numericUpDown23.Value;
                SetStaticPerson();
            }
            else numericUpDown23.Value = Village.GetSkilsPassiveBuilds(0);
        }

        private void numericUpDown24_ValueChanged(object sender, EventArgs e)
        {
            if (Village.GetMoney() >= PriceSkils(Convert.ToByte(numericUpDown24.Value)))
            {
                Village.SetMoney(Village.GetMoney() - PriceSkils(Convert.ToByte(numericUpDown24.Value)));
                Village.SetSkilsPassiveBuilds(Convert.ToByte(numericUpDown24.Value), 1);
                numericUpDown24.Minimum = numericUpDown24.Value;
                SetStaticPerson();
            }
            else numericUpDown24.Value = Village.GetSkilsPassiveBuilds(1);
        }

        private void numericUpDown25_ValueChanged(object sender, EventArgs e)
        {
            if (Village.GetMoney() >= PriceSkils(Convert.ToByte(numericUpDown25.Value)))
            {
                Village.SetMoney(Village.GetMoney() - PriceSkils(Convert.ToByte(numericUpDown25.Value)));
                Village.SetSkilsPassiveBuilds(Convert.ToByte(numericUpDown25.Value), 2);
                numericUpDown25.Minimum = numericUpDown25.Value;
                SetStaticPerson();
            }
            else numericUpDown25.Value = Village.GetSkilsPassiveBuilds(2);
        }

        private void numericUpDown26_ValueChanged(object sender, EventArgs e)
        {
            if (Village.GetMoney() >= PriceSkils(Convert.ToByte(numericUpDown26.Value)))
            {
                Village.SetMoney(Village.GetMoney() - PriceSkils(Convert.ToByte(numericUpDown26.Value)));
                Village.SetSkilsPassiveBuilds(Convert.ToByte(numericUpDown26.Value), 3);
                numericUpDown26.Minimum = numericUpDown26.Value;
                SetStaticPerson();
            }
            else numericUpDown26.Value = Village.GetSkilsPassiveBuilds(3);
        }

        private void numericUpDown27_ValueChanged(object sender, EventArgs e)
        {
            if (Village.GetMoney() >= PriceSkils(Convert.ToByte(numericUpDown27.Value)))
            {
                Village.SetMoney(Village.GetMoney() - PriceSkils(Convert.ToByte(numericUpDown27.Value)));
                Village.SetSkilsPassiveBuilds(Convert.ToByte(numericUpDown27.Value), 4);
                numericUpDown27.Minimum = numericUpDown27.Value;
                SetStaticPerson();
            }
            else numericUpDown27.Value = Village.GetSkilsPassiveBuilds(4);
        }

        private void numericUpDown28_ValueChanged(object sender, EventArgs e)
        {
            if (Village.GetMoney() >= PriceSkils(Convert.ToByte(numericUpDown28.Value)))
            {
                Village.SetMoney(Village.GetMoney() - PriceSkils(Convert.ToByte(numericUpDown28.Value)));
                Village.SetSkilsPassiveBuilds(Convert.ToByte(numericUpDown28.Value), 5);
                numericUpDown28.Minimum = numericUpDown28.Value;
                SetStaticPerson();
                SetStaticPerson();
            }
            else numericUpDown28.Value = Village.GetSkilsPassiveBuilds(5);
        }

        private byte PriceSkils(ushort level)
        {
            switch (level)
            {
                case 2:
                    return 20;
                case 3:
                    return 30;
                case 4:
                    return 40;
                case 5:
                    return 50;
                case 6:
                    return 60;
                case 7:
                    return 70;
                case 8:
                    return 80;
                case 9:
                    return 90;
                case 10:
                    return 100;
                default:
                    break;
            }
            return 0;
        }

        private byte PriceSkils(byte level)
        {
            switch (level)
            {
                case 2:
                    return 20;
                case 3:
                    return 30;
                case 4:
                    return 40;
                case 5:
                    return 50;
                case 6:
                    return 60;
                case 7:
                    return 70;
                case 8:
                    return 80;
                case 9:
                    return 90;
                case 10:
                    return 100;
                default:
                    break;
            }
            return 0;
        }

        private byte PriceSkils(byte level, int index)
        {
            if (index == 0)
            {
                switch (level)
                {
                    case 2:
                        return 30;
                    case 3:
                        return 45;
                    case 4:
                        return 60;
                    case 5:
                        return 75;
                    case 6:
                        return 90;
                    case 7:
                        return 105;
                    case 8:
                        return 120;
                    case 9:
                        return 135;
                    case 10:
                        return 150;
                    default:
                        break;
                }
            }
            else if (index == 1)
            {
                switch (level)
                {
                    case 2:
                        return 2;
                    case 3:
                        return 3;
                    case 4:
                        return 4;
                    case 5:
                        return 5;
                    case 6:
                        return 6;
                    case 7:
                        return 7;
                    case 8:
                        return 8;
                    case 9:
                        return 9;
                    case 10:
                        return 10;
                    default:
                        break;
                }
            }
            return 0;
        }

        private byte PriceSkils(ushort level, int index)
        {
            if (index == 2 || index == 1)
            {
                switch (level)
                {
                    case 1:
                        return 5;
                    case 2:
                        return 10;
                    case 3:
                        return 15;
                    case 4:
                        return 20;
                    case 5:
                        return 25;
                    case 6:
                        return 30;
                    case 7:
                        return 35;
                    case 8:
                        return 40;
                    case 9:
                        return 45;
                    case 10:
                        return 50;
                    default:
                        break;
                }
            }
            else if (index == 3)
            {
                switch (level)
                {
                    case 2:
                        return 10;
                    case 3:
                        return 20;
                    case 4:
                        return 40;
                    case 5:
                        return 60;
                    case 6:
                        return 80;
                    case 7:
                        return 100;
                    case 8:
                        return 120;
                    case 9:
                        return 140;
                    case 10:
                        return 160;
                    default:
                        break;
                }
            }
            else if (index == 4)
            {
                switch (level)
                {
                    case 2:
                        return 2;
                    case 3:
                        return 3;
                    case 4:
                        return 4;
                    case 5:
                        return 5;
                    case 6:
                        return 6;
                    case 7:
                        return 7;
                    case 8:
                        return 8;
                    case 9:
                        return 9;
                    case 10:
                        return 10;
                    default:
                        break;
                }
            }
            return 0;
        }
	}
}
