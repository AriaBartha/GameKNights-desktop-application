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

        private void buttonRefreshAppointments_Click(object sender, EventArgs e)
        {
            refreshAppointmentList();
        }

        private void buttonAddAppointment_Click(object sender, EventArgs e)
        {
            Appointment appointment = new Appointment();
            if (string.IsNullOrEmpty(textBoxEmployeeId.Text))
            {
                MessageBox.Show("Employee Id required!");
                textBoxEmployeeId.Focus();
                return;
            }
            if (dateTimeAppointment.Value == null)
            {
                MessageBox.Show("Appointment required!");
                dateTimeAppointment.Focus();
                return;
            }
            appointment.AppointmentAppointment = dateTimeAppointment.Value.ToString();
            appointment.EmployeeId = long.Parse(textBoxEmployeeId.Text);
            appointment.Booked = 0;
            var json = JsonConvert.SerializeObject(appointment);
            var data = new StringContent(json, Encoding.UTF8, "application/json");
            var response = client.PostAsync(endPoint, data).Result;
            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("New appointment has been added successfully");
                refreshAppointmentList();
            }
            else
            {
                MessageBox.Show("Failed! Could not add new appointment to database.");
            }
            textBoxIdAppointment.Text = string.Empty;
            textBoxEmployeeId.Text = string.Empty;
            dateTimeAppointment.Value = DateTime.Now;
        }

        private void buttonUpdateAppointment_Click(object sender, EventArgs e)
        {

        }

        private void buttonDeleteAppointment_Click(object sender, EventArgs e)
        {

        }
    }
}
