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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonToBoardGamesForm_Click(object sender, EventArgs e)
        {
            BoardGamesForm boardGamesForm = new BoardGamesForm();
            boardGamesForm.ShowDialog();
            //TODO: close Mainform when goes to BoardGamesForm
        }
    }
}
