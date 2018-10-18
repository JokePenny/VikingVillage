using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Vik
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            SoundPlayer Simple = new SoundPlayer(@"D:\01Programms\VS\Repository\Wik\Vik\Vik\Properties\Resources\click.wav");
            Simple.Play();
            Form2 train = new Form2();
            this.Visible = false;
            train.ShowDialog();
            this.Close();
            Simple.Stop();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            SoundPlayer Simpl = new SoundPlayer(@"D:\01Programms\VS\Repository\Wik\Vik\Vik\Properties\Resources\click.wav");
            Simpl.Play();
            Form6 train = new Form6();
            this.Visible = false;
            train.ShowDialog();
            this.Close();
            this.Dispose();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            SoundPlayer Simple = new SoundPlayer(@"D:\01Programms\VS\Repository\Wik\Vik\Vik\Properties\Resources\click.wav");
            Simple.Play();
            Application.Exit();
        }

        private void label1_MouseHover(object sender, EventArgs e)
        {
            SoundPlayer Simple = new SoundPlayer(@"D:\01Programms\VS\Repository\Wik\Vik\Vik\Properties\Resources\click.wav");
            Simple.Play();
            label1.ForeColor = Color.Black;
        }

        private void label2_MouseHover(object sender, EventArgs e)
        {
            SoundPlayer Simple = new SoundPlayer(@"D:\01Programms\VS\Repository\Wik\Vik\Vik\Properties\Resources\click.wav");
            Simple.Play();
            label2.ForeColor = Color.Black;
        }

        private void label3_MouseHover(object sender, EventArgs e)
        {
            SoundPlayer Simple = new SoundPlayer(@"D:\01Programms\VS\Repository\Wik\Vik\Vik\Properties\Resources\click.wav");
            Simple.Play();
            label3.ForeColor = Color.Black;
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            label3.ForeColor = Color.White;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label1.ForeColor = Color.White;
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            label2.ForeColor = Color.White;
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            label1.ForeColor = Color.Black;
        }

        private void label2_MouseMove(object sender, MouseEventArgs e)
        {
            label2.ForeColor = Color.Black;
        }

        private void label3_MouseMove(object sender, MouseEventArgs e)
        {
            label3.ForeColor = Color.Black;
        }
    }
}
