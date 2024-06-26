﻿using System;
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
    // Oldal a társasjátékok adatainak kezelésére.
    public partial class BoardGamesForm : Form
    {
        HttpClient client = new HttpClient();
        string endPoint = ReadSetting("endpointUrlBoardGame");

        // Alkalmazás beállítások olvasása.
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
                MessageBox.Show("Error reading app settings! " + ex.Message);
            }
            return result;
        }

        // Inicializálás.
        public BoardGamesForm()
        {
            InitializeComponent();
        }

        // Form betöltése.
        private void BoardGamesForm_Load(object sender, EventArgs e)
        {
            listRefreshing();
        }

        // Lista frissítése.
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
                else
                {
                    MessageBox.Show("Calling API endpoint failed: " + response.ReasonPhrase);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Calling API endpoint failed: " + ex.Message);
            }
            
        }

        // Kiválasztott társasjáték adatainak betöltése az input mezőkbe.
        private void listBoxBoardGames_SelectedIndexChanged(object sender, EventArgs e)
        {
            BoardGame boardGame = (BoardGame)listBoxBoardGames.SelectedItem;
            textBoxIdBG.Text = boardGame.Id.ToString();
            textBoxNameBG.Text = boardGame.BgName.ToString();
            nuMinPlayerBG.Value = boardGame.MinPlayers;
            nuMaxPlayerBG.Value = boardGame.MaxPlayers;
            richTextBoxDescriptionBG.Text = boardGame.Description.ToString();
        }

        // Lista frissítés gomb (Refresh List) kattintási eseménye.
        private void buttonRefreshListBG_Click(object sender, EventArgs e)
        {
            clearInputs();
            listRefreshing();
        }

        // Új társasjáték hozzáadása az adatbázishoz, Add gomb kattintási eseménye.
        private void buttonAddBG_Click(object sender, EventArgs e)
        {
            try
            {
                BoardGame boardGame = new BoardGame();
                if (string.IsNullOrEmpty(textBoxNameBG.Text))
                {
                    MessageBox.Show("Board game name is required");
                    textBoxNameBG.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(nuMinPlayerBG.Text))
                {
                    MessageBox.Show("Min. players number is required");
                    nuMinPlayerBG.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(nuMaxPlayerBG.Text))
                {
                    MessageBox.Show("Max. players number is required");
                    nuMaxPlayerBG.Focus();
                    return;
                }
                if (int.Parse(nuMinPlayerBG.Text) > int.Parse(nuMaxPlayerBG.Text))
                {
                    MessageBox.Show("Min. players number can't be smaller than Max. players number.");
                    nuMinPlayerBG.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(richTextBoxDescriptionBG.Text))
                {
                    MessageBox.Show("Board game description is required");
                    richTextBoxDescriptionBG.Focus();
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
                    MessageBox.Show("Failed! Could not add new board game to database. " + response.ReasonPhrase);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Calling API endpoint failed: " + ex.Message);
            }
            clearInputs();
        }

        // Kiválasztott társasjáték adatainak módosítása az adatbázisban, Update gomb kattintási eseménye.
        private void buttonUpdateBG_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(textBoxIdBG.Text))
                {
                    MessageBox.Show("A board game must be selected!");
                    return;
                }
                if (string.IsNullOrEmpty(textBoxNameBG.Text))
                {
                    MessageBox.Show("Board game name is required");
                    textBoxNameBG.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(nuMinPlayerBG.Text))
                {
                    MessageBox.Show("Min. players number is required");
                    nuMinPlayerBG.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(nuMaxPlayerBG.Text))
                {
                    MessageBox.Show("Max. players number is required");
                    nuMaxPlayerBG.Focus();
                    return;
                }
                if (int.Parse(nuMinPlayerBG.Text) > int.Parse(nuMaxPlayerBG.Text))
                {
                    MessageBox.Show("Min. players number can't be smaller than Max. players number.");
                    nuMinPlayerBG.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(richTextBoxDescriptionBG.Text))
                {
                    MessageBox.Show("Board game description is required");
                    richTextBoxDescriptionBG.Focus();
                    return;
                }
                BoardGame boardGame = new BoardGame();

                boardGame.Id = long.Parse(textBoxIdBG.Text);
                boardGame.BgName = textBoxNameBG.Text;
                boardGame.MinPlayers = (long)nuMinPlayerBG.Value;
                boardGame.MaxPlayers = (long)nuMaxPlayerBG.Value;
                boardGame.Description = richTextBoxDescriptionBG.Text;

                var json = JsonConvert.SerializeObject(boardGame);
                var data = new StringContent(json, Encoding.UTF8, "application/json");
                string endPointUpdate = $"{endPoint}/{boardGame.Id}";
                var response = client.PutAsync(endPointUpdate, data).Result;
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Board game has been updated successfully");
                    listRefreshing();
                }
                else
                {
                    MessageBox.Show("Board game update FAILED! " + response.ReasonPhrase);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Calling API endpoint failed: " + ex.Message);
            }
            clearInputs();

        }

        // Kiválasztott társasjáték törlése az adatbázisból, Delete gomb kattintási eseménye.
        private void buttonDeleteBG_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(textBoxIdBG.Text))
                {
                    MessageBox.Show("A board game must be selected!");
                    return;
                }
                if (MessageBox.Show("Are you sure you want to delete the selected item?", "Confirm delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    return;
                }
                else
                {
                    BoardGame boardGame = new BoardGame();

                    boardGame.Id = long.Parse(textBoxIdBG.Text);
                    boardGame.BgName = textBoxNameBG.Text;
                    boardGame.MinPlayers = (long)nuMinPlayerBG.Value;
                    boardGame.MaxPlayers = (long)nuMaxPlayerBG.Value;
                    boardGame.Description = richTextBoxDescriptionBG.Text;

                    string endPointDelete = $"{endPoint}/{boardGame.Id}";
                    var response = client.DeleteAsync(endPointDelete).Result;
                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Delete is successful!");
                        listRefreshing();
                    }
                    else
                    {
                        MessageBox.Show("Delete failed! " + response.ReasonPhrase);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Calling API endpoint failed: " + ex.Message);
            }
            clearInputs();
        }

        // Input mezők kiürítése.
        private void clearInputs()
        {
            textBoxIdBG.Text = string.Empty;
            textBoxNameBG.Text = string.Empty;
            nuMinPlayerBG.Value = nuMinPlayerBG.Minimum;
            nuMaxPlayerBG.Value = nuMaxPlayerBG.Minimum;
            richTextBoxDescriptionBG.Text = string.Empty;
        }
    }
}
