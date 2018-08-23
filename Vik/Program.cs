using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vik
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Form4 first = new Form4();
            DateTime end = DateTime.Now + TimeSpan.FromSeconds(4);
            first.Show();
            while (end > DateTime.Now)
                Application.DoEvents();
            first.Close();
            first.Dispose();
            Application.Run(new Form1());
        }
    }
}
