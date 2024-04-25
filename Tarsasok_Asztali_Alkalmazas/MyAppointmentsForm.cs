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

namespace Tarsasok_Asztali_Alkalmazas
{
    public partial class MyAppointmentsForm : Form
    {
        // Oldal a bejelentkezett munkavállaló időpontjainak lekérdezésére
       
        HttpClient client = new HttpClient();
        string endPoint = ReadSetting("endPointUrlAuthEmployeeAppointment");
        string endpointGuest = ReadSetting("endpointUrlGuest");
        string endpointBoardGame = ReadSetting("endpointUrlBoardGame");
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
        public MyAppointmentsForm()
        {
            InitializeComponent();
        }

        private void MyAppointmentsForm_Load(object sender, EventArgs e)
        {
            refreshAppointmentList();
        }

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
                    MessageBox.Show(MyToken);
                    //MessageBox.Show("Calling API endpoint failed: " + response.ReasonPhrase);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Calling API endpoint failed: " + ex.Message);
            }
        }
    }
}
