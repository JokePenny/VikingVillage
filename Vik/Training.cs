using System;
using System.Drawing;
using System.Windows.Forms;

namespace Vik
{
    public partial class Training : Form
    {
        private byte teach;
        public Training()
        {
            InitializeComponent();
            teach = 0;
            this.WindowState = FormWindowState.Maximized;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (teach < 2)
            {
                teach++;
                if(teach == 0)
                {
                    pictureBox2.BackgroundImage = Image.FromFile("D:\\01Programms\\PHCS6\\Project\\Vikings\\fon\\Новая папка (2)\\images\\fon1_03.png");
                    label2.Text = "1 - Количество прожитых дней, чем больше тем ты круче\n2 - Панель в которой хранятся здания, которые можно возводить\n3 - Ваш Штаб, лучше его ставить ближе к еде, т.к.расстояние от еды влияет на скорость ее добычи\n4 - Кнопка выхода в меню\n5 - Панель с вашими ресурсами(с верху вниз) Еда, Дерево, Камень, Золото, Население, Доски, Каменные блоки\n6 - Правая колонка обозначет максимум, который вы можете хранить у себя в Штабе. Левая колонка обозначает сколько у Вас ресурсов сейчас.";
                }
                if (teach == 1)
                {
                    pictureBox2.BackgroundImage = Image.FromFile("D:\\01Programms\\PHCS6\\Project\\Vikings\\fon\\Новая папка (3)\\images\\fon1_03.png");
                    label2.Text = "1 - Ресурс деревов, добывается с помощью здания - Лагерь лесорубов\n2 - Самый важный ресурс -Еда, добывается вашим Штабом\n3 - Ресурс камень, добывается зданием Рудник\n4 - Ресурс золото, добывается зданием Шахта Золотодобытчиков";
                }
                if (teach == 2)
                {
                    pictureBox2.BackgroundImage = Image.FromFile("D:\\01Programms\\PHCS6\\Project\\Vikings\\fon\\Новая папка (5)\\images\\fon1_03.png");
                    label2.Text = "Это панель доступных зданий\n1 - Здания относящиеся к еде - Поля, Таверна\n2 - Здания относящиеся к дереву - Лагерь Лесорубов, Лесопилка\n3 - Здания относящиеся к камню - Рудник, Каменоломня, Склад, Кузня\n4 - Здания относящиеся к населению - Дом\n5 - Здания относящиеся к золоту - Шахта Золотодобытчиков, Рынок Купцов\nПодробнее про здания можно прочитать в самой панельки, навести\nпри этом курсор на само здание";
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (teach != 0)
            {
                teach--;
                if (teach == 0)
                {
                    pictureBox2.BackgroundImage = Image.FromFile("D:\\01Programms\\PHCS6\\Project\\Vikings\\fon\\Новая папка (2)\\images\\fon1_03.png");
                    label2.Text = "1 - Количество прожитых дне, чем больше тем ты круче\n2 - Панель в которой хранятся здания, которые можно возводить\n3 - Ваш Штаб, лучше его ставить ближе к еде, т.к.расстояние от еды влияет на скорость ее добычи\n4 - Кнопка выхода в меню\n5 - Панель с вашими ресурсами(с верху вниз) Еда, Дерево, Камень, Золото, Население, Доски, Каменные блоки\n6 - Правая колонка обозначет максимум, который вы можете хранить у себя в Штабе. Левая колонка обозначает сколько у Вас ресурсов сейчас.";
                }
                if (teach == 1)
                {
                    pictureBox2.BackgroundImage = Image.FromFile("D:\\01Programms\\PHCS6\\Project\\Vikings\\fon\\Новая папка (3)\\images\\fon1_03.png");
                    label2.Text = "1 - Ресурс деревов, добывается с помощью здания - Лагерь лесорубов\n2 - Самый важный ресурс -Еда, добывается вашим Штабом\n3 - Ресурс камень, добывается зданием Рудник\n4 - Ресурс золото, добывается зданием Шахта Золотодобытчиков";
                }
                if (teach == 2)
                {
                    pictureBox2.BackgroundImage = Image.FromFile("D:\\01Programms\\PHCS6\\Project\\Vikings\\fon\\Новая папка (5)\\images\\fon1_03.png");
                    label2.Text = "Это панель доступных зданий\n1 - Здания относящиеся к еде - Поля, Таверна\n2 - Здания относящиеся к дереву - Лагерь Лесорубов, Лесопилка\n3 - Здания относящиеся к камню - Рудник, Каменоломня, Склад, Кузня\n4 - Здания относящиеся к населению - Дом\n5 - Здания относящиеся к золоту - Шахта Золотодобытчиков, Рынок Купцов\nПодробнее про здания можно прочитать в самой панельки, навести\nпри этом курсор на само здание";
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Menu train = new Menu();
            this.Visible = false;
            train.ShowDialog();
            this.Close();
            this.Dispose();
        }


        private void label1_MouseHover(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Black;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label1.ForeColor = Color.White;
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            label1.ForeColor = Color.Black;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
