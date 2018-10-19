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
    public partial class Form10 : Form
    {
        private static ResourceVillage Village = ResourceVillage.GetInstance();

        public Form10()
        {
            InitializeComponent();
            if(Village.GetReligion() == 0)
            {
                label43.Text = Convert.ToString(Convert.ToByte(label43.Text) - 50);
                label44.Text = Convert.ToString(Convert.ToByte(label44.Text) - 50);
                label45.Text = Convert.ToString(Convert.ToByte(label45.Text) - 50);
                label46.Text = Convert.ToString(Convert.ToByte(label46.Text) - 50);
                label47.Text = Convert.ToString(Convert.ToByte(label47.Text) - 50);
                label48.Text = Convert.ToString(Convert.ToByte(label48.Text) - 50);
                label37.Text = Convert.ToString(Convert.ToByte(label37.Text) + 50);
                label38.Text = Convert.ToString(Convert.ToByte(label38.Text) + 50);
                label39.Text = Convert.ToString(Convert.ToByte(label39.Text) + 50);
                label40.Text = Convert.ToString(Convert.ToByte(label40.Text) + 50);
                label41.Text = Convert.ToString(Convert.ToByte(label41.Text) + 50);
                label42.Text = Convert.ToString(Convert.ToByte(label42.Text) + 50);
            }
            else
            {
                label43.Text = Convert.ToString(Convert.ToByte(label43.Text) + 50);
                label44.Text = Convert.ToString(Convert.ToByte(label44.Text) + 50);
                label45.Text = Convert.ToString(Convert.ToByte(label45.Text) + 50);
                label46.Text = Convert.ToString(Convert.ToByte(label46.Text) + 50);
                label47.Text = Convert.ToString(Convert.ToByte(label47.Text) + 50);
                label48.Text = Convert.ToString(Convert.ToByte(label48.Text) + 50);
                label37.Text = Convert.ToString(Convert.ToByte(label37.Text) - 50);
                label38.Text = Convert.ToString(Convert.ToByte(label38.Text) - 50);
                label39.Text = Convert.ToString(Convert.ToByte(label39.Text) - 50);
                label40.Text = Convert.ToString(Convert.ToByte(label40.Text) - 50);
                label41.Text = Convert.ToString(Convert.ToByte(label41.Text) - 50);
                label42.Text = Convert.ToString(Convert.ToByte(label42.Text) - 50);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Village.SetCoef(Calculation.CoeffCalcul(Convert.ToSByte(label37.Text)));
            ShowMarket();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Village.SetCoef(Calculation.CoeffCalcul(Convert.ToSByte(label38.Text)));
            ShowMarket();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Village.SetCoef(Calculation.CoeffCalcul(Convert.ToSByte(label39.Text)));
            ShowMarket();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Village.SetCoef(Calculation.CoeffCalcul(Convert.ToSByte(label40.Text)));
            ShowMarket();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Village.SetCoef(Calculation.CoeffCalcul(Convert.ToSByte(label41.Text)));
            ShowMarket();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Village.SetCoef(Calculation.CoeffCalcul(Convert.ToSByte(label42.Text)));
            ShowMarket();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Village.SetCoef(Calculation.CoeffCalcul(Convert.ToSByte(label43.Text)));
            ShowMarket();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Village.SetCoef(Calculation.CoeffCalcul(Convert.ToSByte(label44.Text)));
            ShowMarket();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Village.SetCoef(Calculation.CoeffCalcul(Convert.ToSByte(label45.Text)));
            ShowMarket();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            Village.SetCoef(Calculation.CoeffCalcul(Convert.ToSByte(label46.Text)));
            ShowMarket();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            Village.SetCoef(Calculation.CoeffCalcul(Convert.ToSByte(label47.Text)));
            ShowMarket();
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            Village.SetCoef(Calculation.CoeffCalcul(Convert.ToSByte(label48.Text)));
            ShowMarket();
        }

        private void ShowMarket()
        {
            MarketForm train = new MarketForm();
            this.Visible = false;
            train.ShowDialog();
            this.Close();
        }
    }
}
