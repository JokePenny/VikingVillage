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
    public partial class Form3 : Form
    {
        private static ResourceVillage Village = ResourceVillage.GetInstance();
        public Form3()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            ToolTip t = new ToolTip();
            t.SetToolTip(pictureBox3, "Шахта золотодобытчиков. Добывает ресурс - золото. Стоимость: 20 дерева, 20 камня");
            t.SetToolTip(pictureBox4, "Рынок купцов. Позволяет покупать ресурсы. Стоимость: 30 досок, 25 блоков");
            t.SetToolTip(pictureBox5, "Дом. +10 к максимуму населения. Стоимость: 10 дерева, 5 камня");
            t.SetToolTip(pictureBox6, "Рудник. Добывает ресурс - камень. Стоимость: 7 камня");
            t.SetToolTip(pictureBox7, "Каменаломня. Создает ресурс - каменный блок. Стоимость: 25 дерева, 20 камня");
            t.SetToolTip(pictureBox8, "Казарма. Улучшает стаблиность общества. Стоимость: 25 досок, 20 блоков");
            t.SetToolTip(pictureBox9, "Склад. Увеличивает максимум еда - 30, дерево - 10, камень - 10, золото - 5. Стоимость: 10 дерева, 5 камня");
            t.SetToolTip(pictureBox10, "Лагерь дровосеков. Добывает ресурс - дерево. Стоимость: 8 дерева");
            t.SetToolTip(pictureBox11, "Лесопилка. Создает ресурс - доски. Стоимость: 20 дерева, 25 камня");
            t.SetToolTip(pictureBox12, "Пашня. Ускоряет добычу пищи. Стоимость: 10 дерева, 5 камня");
            t.SetToolTip(pictureBox13, "Амбар. Увеличивает сохранность пищи. Стоимость: 10 досок, 5 блоков");

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if(Village.GetChoose() > 1)
                Village.SetChoose(4);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (Village.GetChoose() > 1)
                Village.SetChoose(16);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (Village.GetChoose() > 1)
                Village.SetChoose(7);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (Village.GetChoose() > 1)
                Village.SetChoose(3);
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if (Village.GetChoose() > 1)
                Village.SetChoose(9);
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            if (Village.GetChoose() > 1)
                Village.SetChoose(5);
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            if(Village.GetChoose() > 1)
                Village.SetChoose(5);
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            if (Village.GetChoose() > 1)
                Village.SetChoose(2);
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            if (Village.GetChoose() > 1)
                Village.SetChoose(8);
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            if (Village.GetChoose() > 1)
                Village.SetChoose(6);
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            if (Village.GetChoose() > 1)
                Village.SetChoose(11);
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            if (Village.GetChoose() > 1)
                Village.SetChoose(13);
        }
    }
}
