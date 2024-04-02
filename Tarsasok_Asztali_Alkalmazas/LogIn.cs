using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarsasok_Asztali_Alkalmazas
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            //TODO: login if email and password are ok OR error message
            //TODO: check if admin loginig in
            MainForm mainForm = new MainForm();
            mainForm.ShowDialog();
            //TODO: Close LogIn form when MainForm opens
        }
    }
}
