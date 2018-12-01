using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;

namespace Vik
{
    public partial class ChoseKonung : Form
    {
        private ResourceVillage Village = ResourceVillage.GetInstance();
        private Random rnd = new Random();
        private byte[] arrHealthKonung = new byte[3];
        private byte[] arrVillageManagment = new byte[3];
        private byte[] arrReligionKonung = new byte[3];
        private byte[] arrRepressionKonung = new byte[3];
        public ChoseKonung()
        {
            InitializeComponent();
            ToolTip t = new ToolTip();
            for(byte i = 0; i < 3; i++)
            {
                arrHealthKonung[i] = Convert.ToByte(rnd.Next(4, 9));
                arrVillageManagment[i] = Convert.ToByte(rnd.Next(4, 9));
                arrReligionKonung[i] = Convert.ToByte(rnd.Next(0, 1));
                arrRepressionKonung[i] = Convert.ToByte(rnd.Next(4, 9));
            }
            t.SetToolTip(pictureBox1, "Здоровье конунга: " + arrHealthKonung[0].ToString() + "\n Управленчиские навыки: "+ arrVillageManagment[0].ToString() + "\n Уровень репрессии: " + arrRepressionKonung[0].ToString() +"\n Религия: "+ Calculation.ReligionChoose(arrReligionKonung[0]));
            t.SetToolTip(pictureBox2, "Здоровье конунга: " + arrHealthKonung[1].ToString() + "\n Управленчиские навыки: " + arrVillageManagment[1].ToString() + "\n Уровень репрессии: " + arrRepressionKonung[1].ToString() + "\n Религия: " + Calculation.ReligionChoose(arrReligionKonung[1]));
            t.SetToolTip(pictureBox3, "Здоровье конунга: " + arrHealthKonung[2].ToString() + "\n Управленчиские навыки: " + arrVillageManagment[2].ToString() + "\n Уровень репрессии: " + arrRepressionKonung[2].ToString() + "\n Религия: " + Calculation.ReligionChoose(arrReligionKonung[2]));
            using (StreamReader sr = new StreamReader("NameKonung.txt", System.Text.Encoding.Default))
            {
                var list = new List<string>();
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    list.Add(line);
                }          
                var arrTheoria = list.ToArray();
                Random rnd = new Random();
                byte value = Convert.ToByte(rnd.Next(0, 94));
                byte value1 = Convert.ToByte(rnd.Next(0, 94));
                byte value2 = Convert.ToByte(rnd.Next(0, 94));
                label1.Text = arrTheoria[value];
                label2.Text = arrTheoria[value1];
                label3.Text = arrTheoria[value2];
            }

            using (StreamReader sr = new StreamReader("NameSecondKonung.txt", System.Text.Encoding.Default))
            {
                var list = new List<string>();
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    list.Add(line);
                }          
                var arrTheoria = list.ToArray();
                Random rnd = new Random();
                byte value = Convert.ToByte(rnd.Next(0, 94));
                byte value1 = Convert.ToByte(rnd.Next(0, 94));
                byte value2 = Convert.ToByte(rnd.Next(0, 94));
                label1.Text += "\n";
                label2.Text += "\n";
                label3.Text += "\n";
                label1.Text += arrTheoria[value];
                label2.Text += arrTheoria[value1];
                label3.Text += arrTheoria[value2];
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Village.SetHealthKonung(arrHealthKonung[0]);
            Village.SetVillageManagment(arrVillageManagment[0]);
            Village.SetReligionKonung(arrReligionKonung[0]);
            Village.SetRepressionKonung(arrRepressionKonung[0]);
            Village.SetNameKonung(label1.Text);
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Village.SetHealthKonung(arrHealthKonung[1]);
            Village.SetVillageManagment(arrVillageManagment[1]);
            Village.SetReligionKonung(arrReligionKonung[1]);
            Village.SetRepressionKonung(arrRepressionKonung[1]);
            Village.SetNameKonung(label2.Text);
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Village.SetHealthKonung(arrHealthKonung[2]);
            Village.SetVillageManagment(arrVillageManagment[2]);
            Village.SetReligionKonung(arrReligionKonung[2]);
            Village.SetRepressionKonung(arrRepressionKonung[2]);
            Village.SetNameKonung(label3.Text);
            this.Close();
        }
    }
}
