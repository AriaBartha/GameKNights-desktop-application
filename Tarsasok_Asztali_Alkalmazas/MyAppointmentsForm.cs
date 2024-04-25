using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using Tarsasok_Asztali_Alkalmazas;
using Newtonsoft.Json;
using System.Globalization;

namespace Tarsasok_Asztali_Alkalmazas
{
    public partial class MyAppointmentsForm : Form
    {
        // Oldal a bejelentkezett munkavállaló időpontjainak lekérdezésére
       
        HttpClient client = new HttpClient();
        string endPoint = ReadSetting("endPointUrlAuthEmployeeAppointment");
        string endPointGuest = ReadSetting("endpointUrlGuest");
        string endPointBoardGame = ReadSetting("endpointUrlBoardGame");
        public string MyToken { get; set; }

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
        public MyAppointmentsForm()
        {
            InitializeComponent();
        }

        // Form betöltése.
        private void MyAppointmentsForm_Load(object sender, EventArgs e)
        {
            refreshAppointmentList();
        }

        // Lista frissítése.
        private async void refreshAppointmentList()
        {
            listBoxMyAppointments.Items.Clear();
            try
            {
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", MyToken);
                HttpResponseMessage response = await client.GetAsync(endPoint);
                if (response.IsSuccessStatusCode)
                {
                    string jsonString = await response.Content.ReadAsStringAsync();
                    var appointment = Appointment.FromJson(jsonString);
                    foreach (Appointment item in appointment)
                    {
                        listBoxMyAppointments.Items.Add(item);
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
        // Kiválasztott időpont adatainak betöltése az input mezőkbe.
        private async void listBoxMyAppointments_SelectedIndexChanged(object sender, EventArgs e)
        {
            clearInputs();
            Appointment appointment = (Appointment)listBoxMyAppointments.SelectedItem;

            textBoxAppointment.Text = appointment.AppointmentAppointment.ToString();

            if (appointment.NumberOfPlayers != null)
            {
                textBoxPlayers.Text = appointment.NumberOfPlayers.ToString();
            }
           
            if (appointment.GuestId != null)
            {
                HttpResponseMessage response = await client.GetAsync(endPointGuest);
                if (response.IsSuccessStatusCode)
                {
                    string jsonString = await response.Content.ReadAsStringAsync();
                    var guest = Guest.FromJson(jsonString);
                    foreach (Guest item in guest)
                    {
                        if (appointment.GuestId.ToString() == item.Id.ToString())
                        {
                            textBoxGuest.Text = item.GName;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Calling API/guest endpoint failed: " + response.ReasonPhrase);
                }
            }
            
            if (appointment.BoardGameId != null)
            {
                HttpResponseMessage responseBoardGame = await client.GetAsync(endPointBoardGame);
                if (responseBoardGame.IsSuccessStatusCode)
                {
                    string jsonStringBoardGame = await responseBoardGame.Content.ReadAsStringAsync();
                    var boardGame = BoardGame.FromJson(jsonStringBoardGame);
                    foreach (BoardGame item in boardGame)
                    {
                        if (appointment.BoardGameId.ToString() == item.Id.ToString())
                        {
                            textBoxBoardGame.Text = item.BgName;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Calling API/boardgame endpoint failed: " + responseBoardGame.ReasonPhrase);
                }
            }
        }

        // Lista frissítés gomb (Refresh List) kattintási eseménye.
        private void buttonRefresh_Click(object sender, EventArgs e)
        {

            clearInputs();
            refreshAppointmentList();
        }

        // Input mezők kiürítése.
        private void clearInputs()
        {
            textBoxAppointment.Text = string.Empty;
            textBoxPlayers.Text = string.Empty;
            textBoxGuest.Text = string.Empty;
            textBoxBoardGame.Text = string.Empty;
        }
    }
}
