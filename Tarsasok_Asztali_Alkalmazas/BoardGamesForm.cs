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
using System.Xml;
using System.Configuration;
using Tarsasok_Asztali_Alkalmazas;
using Newtonsoft.Json;
using System.IO;


namespace Tarsasok_Asztali_Alkalmazas
{
    public partial class BoardGamesForm : Form
    {
        HttpClient client = new HttpClient();
        string endPoint = ReadSetting("endpointUrlBoardGame");

        private static string ReadSetting(string keyName)
        {
            string result = null;
            try
            {
                var value = ConfigurationManager.AppSettings;
                result = value[keyName];
            }
            catch (ConfigurationException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return result;
        }

        public BoardGamesForm()
        {
            InitializeComponent();
        }

        private void BoardGamesForm_Load(object sender, EventArgs e)
        {
            listRefreshing();
        }

        private async void listRefreshing()
        {
            listBoxBoardGames.Items.Clear();
            try
            {
                HttpResponseMessage response = await client.GetAsync(endPoint);
                if (response.IsSuccessStatusCode)
                {
                    string jsonString = await response.Content.ReadAsStringAsync();
                    var boardGame = BoardGame.FromJson(jsonString);
                    foreach (BoardGame item in boardGame)
                    {
                        listBoxBoardGames.Items.Add(item);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
