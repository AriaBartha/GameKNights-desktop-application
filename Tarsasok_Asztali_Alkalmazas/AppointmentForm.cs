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
using Tarsasok_Asztali_Alkalmazas;
using Newtonsoft.Json;


namespace Tarsasok_Asztali_Alkalmazas
{
    public partial class AppointmentForm : Form
    {
        HttpClient client = new HttpClient();
        string endPoint = ReadSetting("endpointUrlAppointment");

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
        public AppointmentForm()
        {
            InitializeComponent();
        }

        private void AppointmentForm_Load(object sender, EventArgs e)
        {
            refreshAppointmentList();
        }

        private async void refreshAppointmentList()
        {
            listBoxAppointments.Items.Clear();
            try
            {
                HttpResponseMessage response = await client.GetAsync(endPoint);
                if (response.IsSuccessStatusCode)
                {
                    string jsonString = await response.Content.ReadAsStringAsync();
                    var appointment = Appointment.FromJson(jsonString);
                    foreach (Appointment item in appointment)
                    {
                        listBoxAppointments.Items.Add(item);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void listBoxAppointments_SelectedIndexChanged(object sender, EventArgs e)
        {
            Appointment appointment = (Appointment)listBoxAppointments.SelectedItem;
            textBoxIdAppointment.Text = appointment.Id.ToString();
            dateTimeAppointment.Value = DateTime.Parse(appointment.AppointmentAppointment);
            textBoxEmployeeId.Text = appointment.EmployeeId.ToString(); 
        }
    }
}
