using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarsasok_Asztali_Alkalmazas
{
    //Oldal az időpontok adatainak részletes listázására.
    public partial class AppointmentsDetails : Form
    {
        HttpClient client = new HttpClient();
        string endPoint = ReadSetting("endpointUrlAppointment");
        string endPointEmployee = ReadSetting("endpointUrlEmployee");
        string endPointGuest = ReadSetting("endpointUrlGuest");

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
        public AppointmentsDetails()
        {
            InitializeComponent();
        }

        // Form betöltése.
        private void AppointmentsDetails_Load(object sender, EventArgs e)
        {
            setupDataGrid();
            refreshDataGrid();
        }

        // Táblázat megjelenés beállításai.
        private void setupDataGrid()
        {
            throw new NotImplementedException();
        }

        // Táblázat adatainak frissítése.
        private void refreshDataGrid()
        {
            throw new NotImplementedException();
        }
    }
}
