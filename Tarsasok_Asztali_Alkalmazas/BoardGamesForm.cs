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

        private void buttonAddBG_Click(object sender, EventArgs e)
        {
            BoardGame boardGame = new BoardGame();
            if (string.IsNullOrEmpty(textBoxNameBG.Text))
            {
                MessageBox.Show("Board game name is required");
                textBoxNameBG.Focus();
                return;
            }
            if (string.IsNullOrEmpty(richTextBoxDescriptionBG.Text))
            {
                MessageBox.Show("Board game description is required");
                textBoxNameBG.Focus();
                return;
            }
            boardGame.BgName = textBoxNameBG.Text;
            boardGame.MinPlayers = (long)nuMinPlayerBG.Value;
            boardGame.MaxPlayers = (long)nuMaxPlayerBG.Value;
            boardGame.Description = richTextBoxDescriptionBG.Text;
            var json = JsonConvert.SerializeObject(boardGame);
            var data = new StringContent(json, Encoding.UTF8, "application/json");
            var response = client.PostAsync(endPoint, data).Result;
            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("New board game has been added successfully");
                listRefreshing();
            }
            else
            {
                MessageBox.Show("Failed! Could not add new board game to database.");
            }
            textBoxIdBG.Text = string.Empty;
            textBoxNameBG.Text = string.Empty;
            nuMinPlayerBG.Value = nuMinPlayerBG.Minimum;
            nuMaxPlayerBG.Value = nuMaxPlayerBG.Minimum;
            richTextBoxDescriptionBG.Text =string.Empty;
        }

        private void buttonUpdateBG_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonRefreshListBG_Click(object sender, EventArgs e)
        {
            listRefreshing();
        }
       
        private void buttonDeleteBG_Click(object sender, EventArgs e)
        {

            
        }

        private void listBoxBoardGames_SelectedIndexChanged(object sender, EventArgs e)
        {
            BoardGame boardGame = (BoardGame)listBoxBoardGames.SelectedItem;
            textBoxIdBG.Text = boardGame.Id.ToString();
            textBoxNameBG.Text = boardGame.BgName.ToString();
            nuMinPlayerBG.Value = boardGame.MinPlayers;
            nuMaxPlayerBG.Value = boardGame.MaxPlayers;
            richTextBoxDescriptionBG.Text = boardGame.Description.ToString();
        }
    }
}
