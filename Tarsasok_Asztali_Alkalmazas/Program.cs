using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarsasok_Asztali_Alkalmazas
{
    internal static class Program
    {
        public static MainForm mainForm = null;
        public static LogIn logInForm = null;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            mainForm = new MainForm();
            logInForm = new LogIn();
            Application.Run(new LogIn());
        }
    }
}
