using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnterprisePlanningSolution
{
    static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Für Testzwecke wird Login Page übersprungen
            //Application.Run(new LoginForm());
            Application.Run(new DashboardForm(true));
        }
    }
}
