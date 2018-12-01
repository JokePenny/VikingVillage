using System;
using System.Windows.Forms;

namespace Vik
{
    public partial class MarketForm : Form
    {
        private ResourceVillage Village = ResourceVillage.GetInstance();

        public MarketForm()
        {
            InitializeComponent();
            label37.Text = Village.GetEat().ToString();
            label38.Text = Village.GetForest().ToString();
            label39.Text = Village.GetStone().ToString();
            label40.Text = Village.GetBoards().ToString();
            label41.Text = Village.GetBrick().ToString();
            label42.Text = Village.GetMoney().ToString();
            label30.Text = Village.GetCoef().ToString();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            numericUpDown1.Maximum = Village.GetEatMax();
            label16.Text = Convert.ToString(numericUpDown1.Value * 3 * Village.GetCoef());
            PriceProduct();
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            numericUpDown2.Maximum = Village.GetForestMax();
            label17.Text = Convert.ToString(numericUpDown2.Value * 2 * Village.GetCoef());
            PriceProduct();
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            numericUpDown3.Maximum = Village.GetStoneMax();
            label18.Text = Convert.ToString(numericUpDown3.Value * 2 * Village.GetCoef());
            PriceProduct();
        }

        private void numericUpDown7_ValueChanged(object sender, EventArgs e)
        {
            numericUpDown7.Maximum = Village.GetBoardsMax();
            label25.Text = Convert.ToString(numericUpDown7.Value * 3 * Village.GetCoef());
            PriceProduct(label25.Text);
        }

        private void numericUpDown8_ValueChanged(object sender, EventArgs e)
        {
            numericUpDown8.Maximum = Village.GetBrickMax();
            label26.Text = Convert.ToString(numericUpDown8.Value * 3 * Village.GetCoef());
            PriceProduct(label26.Text);
        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {
            numericUpDown4.Maximum = Village.GetEat();
            label13.Text = Convert.ToString(numericUpDown4.Value * 2 / Village.GetCoef());
        }

        private void numericUpDown5_ValueChanged(object sender, EventArgs e)
        {
            numericUpDown5.Maximum = Village.GetForest();
            label14.Text = Convert.ToString(numericUpDown5.Value * 1 / Village.GetCoef());
        }

        private void numericUpDown6_ValueChanged(object sender, EventArgs e)
        {
            numericUpDown6.Maximum = Village.GetStone();
            label15.Text = Convert.ToString(numericUpDown6.Value * 1 / Village.GetCoef());
        }

        private void numericUpDown9_ValueChanged(object sender, EventArgs e)
        {
            numericUpDown9.Maximum = Village.GetBoards();
            label27.Text = Convert.ToString(numericUpDown9.Value * 1 / (Village.GetCoef() * 2));
        }

        private void numericUpDown10_ValueChanged(object sender, EventArgs e)
        {
            numericUpDown10.Maximum = Village.GetBrick();
            label28.Text = Convert.ToString(numericUpDown10.Value * 1 / (Village.GetCoef() * 2));
        }


        private void PriceProduct()
        {
            label43.Text = Calculation.Price(Convert.ToUInt16(label16.Text), Convert.ToUInt16(label17.Text), Convert.ToUInt16(label18.Text), Village.GetMoney());
        }

        private void PriceProduct(string buy)
        {
            label44.Text = Calculation.Price(Convert.ToUInt16(buy), Convert.ToUInt16(label17.Text), Village.GetMoney());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

		private void button1_Click(object sender, EventArgs e)
		{
			ushort price;
			price = Convert.ToUInt16(Convert.ToUInt16(label16.Text) + Convert.ToUInt16(label17.Text) + Convert.ToUInt16(label18.Text));
			Village.SetMoney(Village.GetMoney() - price);
			if(numericUpDown1.Value != 0) Village.SetEat(Convert.ToUInt16(numericUpDown1.Value + Village.GetEat()));
			if (numericUpDown2.Value != 0) Village.SetForest(Convert.ToUInt16(numericUpDown2.Value + Village.GetForest()));
			if (numericUpDown3.Value != 0) Village.SetStone(Convert.ToUInt16(numericUpDown3.Value + Village.GetStone()));
			numericUpDown1.Value = 0;
			numericUpDown2.Value = 0;
			numericUpDown3.Value = 0;
		}

		private void button3_Click(object sender, EventArgs e)
		{
			int price;
			price = Convert.ToUInt16(label25.Text) + Convert.ToUInt16(label26.Text);
			Village.SetMoney(Village.GetMoney() - price);
			if (numericUpDown7.Value != 0) Village.SetBoards(Convert.ToUInt16(numericUpDown7.Value + Village.GetBoards()));
			if (numericUpDown8.Value != 0) Village.SetBrick(Convert.ToUInt16(numericUpDown8.Value + Village.GetBrick()));
			numericUpDown7.Value = 0;
			numericUpDown8.Value = 0;
		}

		private void button2_Click(object sender, EventArgs e)
		{
			int price;
			price = Convert.ToUInt16(label13.Text) + Convert.ToUInt16(label14.Text) + Convert.ToUInt16(label15.Text);
			Village.SetMoney(Village.GetMoney() + price);
			if (numericUpDown4.Value != 0) Village.SetEat(Convert.ToUInt16(Village.GetEat() - Convert.ToUInt16(numericUpDown4.Value)));
			if (numericUpDown5.Value != 0) Village.SetForest(Convert.ToUInt16(Village.GetForest() - Convert.ToUInt16(numericUpDown5.Value)));
			if (numericUpDown6.Value != 0) Village.SetStone(Convert.ToUInt16(Village.GetStone() - Convert.ToUInt16(numericUpDown6.Value)));
			numericUpDown4.Value = 0;
			numericUpDown5.Value = 0;
			numericUpDown6.Value = 0;
		}

		private void button4_Click(object sender, EventArgs e)
		{
			int price;
			price = Convert.ToUInt16(label27.Text) + Convert.ToUInt16(label28.Text);
			Village.SetMoney(Village.GetMoney() + price);
			if (numericUpDown9.Value != 0) Village.SetBoards(Convert.ToUInt16(Village.GetBoards() - Convert.ToUInt16(numericUpDown9.Value)));
			if (numericUpDown10.Value != 0) Village.SetBrick(Convert.ToUInt16(Village.GetBrick() - Convert.ToUInt16(numericUpDown10.Value)));
			numericUpDown9.Value = 0;
			numericUpDown10.Value = 0;
		}
	}
}
