using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarsasok_Asztali_Alkalmazas
{
    public partial class BoardGamesForm : Form
    {
        HttpClient client = new HttpClient();
        public BoardGamesForm()
        {
            InitializeComponent();
        }

        private void BoardGamesForm_Load(object sender, EventArgs e)
        {
            client
        }
    }
}
