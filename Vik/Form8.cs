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
        private string Religion;
        public Form8()
        {
            InitializeComponent();
            label1.Text = Village.GetNameKonung();
            numericUpDown1.Value = Village.GetVillageManagment();
            numericUpDown2.Value = Village.GetHealthKonung();
            numericUpDown3.Value = Village.GetRepressionKonung();
            Religion = Calculation.ReligionChoose(Village.GetReligionKonung());
            label8.Text = Religion;
        }
    }
}
