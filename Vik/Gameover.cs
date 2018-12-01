using System;
using System.Windows.Forms;

namespace Vik
{
    public partial class Gameover : Form
    {
        public Gameover()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
