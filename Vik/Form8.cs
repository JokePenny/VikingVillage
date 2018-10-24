using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vik
{
    public partial class Form8 : Form
    {
        private static ResourceVillage Village = ResourceVillage.GetInstance();
        ToolTip t = new ToolTip();
        public Form8()
        {
            InitializeComponent();
            t.SetToolTip(label4, "Чем выше данный навык, тем быстрее\nпроцессы сбора и добычи будут проходить");
            t.SetToolTip(label5, "Здоровье Конунга увеличивает время его жизни!\nКонунг может заболеть и умереть, не забывайте об этом!");
            t.SetToolTip(label6, "Уровень репрессий Конунга влияет на то\nбудут ли возникать бунты");
            label1.Text = Village.GetNameKonung();
            label2.Text = Village.GetNameKonung() + "\n" + label2.Text;
            numericUpDown1.Value = Village.GetVillageManagment();
            numericUpDown2.Value = Village.GetHealthKonung();
            numericUpDown3.Value = Village.GetRepressionKonung();
            label8.Text = Calculation.ReligionChoose(Village.GetReligionKonung());
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (Village.GetMoney() >= PriceSkils(Convert.ToByte(numericUpDown1.Value), Village.GetVillageManagment()))
            {
                Village.SetMoney(Village.GetMoney() - PriceSkils(Convert.ToByte(numericUpDown1.Value), Village.GetVillageManagment()));
                Village.SetVillageManagment(Convert.ToByte(numericUpDown1.Value));
                numericUpDown1.Minimum = numericUpDown1.Value;
            }
            else numericUpDown1.Value = Village.GetVillageManagment();
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            if (Village.GetMoney() >= PriceSkils(Convert.ToByte(numericUpDown2.Value), Village.GetHealthKonung()))
            {
                Village.SetMoney(Village.GetMoney() - PriceSkils(Convert.ToByte(numericUpDown2.Value), Village.GetHealthKonung()));
                Village.SetHealthKonung(Convert.ToByte(numericUpDown2.Value));
                numericUpDown2.Minimum = numericUpDown2.Value;
            }
            else numericUpDown2.Value = Village.GetHealthKonung();
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            if (Village.GetMoney() >= PriceSkils(Convert.ToByte(numericUpDown3.Value), Village.GetRepressionKonung()))
            {
                Village.SetMoney(Village.GetMoney() - PriceSkils(Convert.ToByte(numericUpDown3.Value), Village.GetRepressionKonung()));
                Village.SetRepressionKonung(Convert.ToByte(numericUpDown3.Value));
                numericUpDown3.Minimum = numericUpDown3.Value;
            }
            else numericUpDown3.Value = Village.GetRepressionKonung();
        }

        private byte PriceSkils(byte level, byte check)
        {
            if(level > check)
            switch (level)
            {
                case 4:
                    return 50;
                case 5:
                    return 70;
                case 6:
                    return 90;
                case 7:
                    return 110;
                case 8:
                    return 130;
                case 9:
                    return 150;
                case 10:
                    return 200;
                default:
                    break;
            }
            return 0;
        }
    }
}
