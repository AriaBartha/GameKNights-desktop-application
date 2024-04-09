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
using System.Globalization;


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

            //TODO: JSON format egyezzen meg az adatbáziosban lévővel
            dateTimeAppointment.Format = DateTimePickerFormat.Custom;
            dateTimeAppointment.CustomFormat = "yyyy-MM-dd hh:mm:ss";

            textBoxIdAppointment.Text = appointment.Id.ToString();
            //dateTimeAppointment.Value = DateTime.Parse(appointment.AppointmentAppointment);
            dateTimeAppointment.Value = appointment.AppointmentAppointment;
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

            //TODO: JSON format egyezzen meg az adatbáziosban lévővel
            dateTimeAppointment.Format = DateTimePickerFormat.Custom;
            dateTimeAppointment.CustomFormat = "yyyy-MM-dd hh:mm:ss";

            appointment.AppointmentAppointment = dateTimeAppointment.Value;
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
            if (string.IsNullOrEmpty(textBoxIdAppointment.Text))
            {
                MessageBox.Show("An appointment must be selected!");
                return;
            }
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
            //TODO: datetime to string, make update work

            Appointment appointment = new Appointment();
            appointment.Id =long.Parse(textBoxIdAppointment.Text);
            //TODO: JSON format egyezzen meg az adatbáziosban lévővel
            dateTimeAppointment.Format = DateTimePickerFormat.Custom;
            dateTimeAppointment.CustomFormat = "yyyy-MM-dd hh:mm:ss";

            appointment.AppointmentAppointment = dateTimeAppointment.Value;
            appointment.EmployeeId = long.Parse(textBoxEmployeeId.Text);
            

            var json = JsonConvert.SerializeObject(appointment);
            var data = new StringContent(json, Encoding.UTF8, "application/json");
            string endPointUpdate = $"{endPoint}/{appointment.Id}";
            var response = client.PutAsync(endPointUpdate, data).Result;
            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Appointment has been updated successfully!");
                refreshAppointmentList();
            }
            else
            {
                MessageBox.Show("Failed! Could not update appointment!");
            }
            textBoxIdAppointment.Text = string.Empty;
            textBoxEmployeeId.Text = string.Empty;
            dateTimeAppointment.Value = DateTime.Now;
        }

        private void buttonDeleteAppointment_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxIdAppointment.Text))
            {
                MessageBox.Show("An appointment must be selected!");
                return;
            }
            if (MessageBox.Show("Are you sure, you want to delete the selected item?") == DialogResult.OK)
            {
                Appointment appointment = new Appointment();
                appointment.Id = long.Parse(textBoxIdAppointment.Text);
                appointment.AppointmentAppointment = dateTimeAppointment.Value;
                appointment.EmployeeId = long.Parse(textBoxEmployeeId.Text);
                                
                string endPointDelete = $"{endPoint}/{appointment.Id}";
                var response = client.DeleteAsync(endPointDelete).Result;
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Appointment has been deleted successfully!");
                    refreshAppointmentList();
                }
                else
                {
                    MessageBox.Show("Failed! Could not delete appointment!");
                }
            } 
            textBoxIdAppointment.Text = string.Empty;
            textBoxEmployeeId.Text = string.Empty;
            dateTimeAppointment.Value = DateTime.Now;
        }
    }
}
