using System;
using System.Drawing;
using System.Windows.Forms;
using System.Media;

namespace Vik
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            SoundPlayer Simple = new SoundPlayer(@"D:\01Programms\VS\Repository\Wik\Vik\Vik\Properties\Resources\click.wav");
            Simple.Play();
			Data.exit = 0;
            Game train = new Game();
            this.Visible = false;
            train.ShowDialog();
            this.Close();
            Simple.Stop();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            SoundPlayer Simpl = new SoundPlayer(@"D:\01Programms\VS\Repository\Wik\Vik\Vik\Properties\Resources\click.wav");
            Simpl.Play();
            Training train = new Training();
            this.Visible = false;
            train.ShowDialog();
            this.Close();
            this.Dispose();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            SoundPlayer Simple = new SoundPlayer(@"D:\01Programms\VS\Repository\Wik\Vik\Vik\Properties\Resources\click.wav");
            Simple.Play();
            Application.Exit();
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox1.BackgroundImage = Image.FromFile("C:\\Users\\IMP\\Desktop\\игра\\images\\tomswallpapers_03.png");
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.BackgroundImage = Image.FromFile("C:\\Users\\IMP\\Desktop\\игра\\images\\1_03.png");
        }

        private void pictureBox2_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox2.BackgroundImage = Image.FromFile("C:\\Users\\IMP\\Desktop\\игра\\images\\tomswallpapers_04.png");
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.BackgroundImage = Image.FromFile("C:\\Users\\IMP\\Desktop\\игра\\images\\1_04.png");
        }

        private void pictureBox3_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox3.BackgroundImage = Image.FromFile("C:\\Users\\IMP\\Desktop\\игра\\images\\tomswallpapers_05.png");
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.BackgroundImage = Image.FromFile("C:\\Users\\IMP\\Desktop\\игра\\images\\1_05.png");
        }

        private void pictureBox4_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox4.BackgroundImage = Image.FromFile("C:\\Users\\IMP\\Desktop\\игра\\images\\tomswallpapers_06.png");
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            pictureBox4.BackgroundImage = Image.FromFile("C:\\Users\\IMP\\Desktop\\игра\\images\\1_06.png");
        }
    }
}
