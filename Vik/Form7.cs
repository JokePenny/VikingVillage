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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Data.konung = 1;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Data.konung = 2;
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Data.konung = 3;
            this.Close();
        }
    }
}
