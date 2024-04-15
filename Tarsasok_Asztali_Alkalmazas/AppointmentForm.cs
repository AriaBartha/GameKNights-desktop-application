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
    // Oldal az időpontok adatainak kezelésére.
    public partial class AppointmentForm : Form
    {
        HttpClient client = new HttpClient();
        string endPoint = ReadSetting("endpointUrlAppointment");
        string endpointEmployee = ReadSetting("endpointUrlEmployee");

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
        public AppointmentForm()
        {
            InitializeComponent();
        }

        // Form betöltése.
        private void AppointmentForm_Load(object sender, EventArgs e)
        {
            refreshAppointmentList();
        }

        // Lista frissítése.
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
        private async void listBoxAppointments_SelectedIndexChanged(object sender, EventArgs e)
        {
            Appointment appointment = (Appointment)listBoxAppointments.SelectedItem;

            dateTimeAppointment.Format = DateTimePickerFormat.Custom;
            dateTimeAppointment.CustomFormat = "yyyy-MM-dd hh:mm:ss";

            textBoxIdAppointment.Text = appointment.Id.ToString();
            dateTimeAppointment.Value = DateTime.Parse(appointment.AppointmentAppointment);
            //dateTimeAppointment.Value = appointment.AppointmentAppointment;
            textBoxEmployeeId.Text = appointment.EmployeeId.ToString();

            HttpResponseMessage response = await client.GetAsync(endpointEmployee);
            if (response.IsSuccessStatusCode)
            {
                string jsonString = await response.Content.ReadAsStringAsync();
                var employee = Employee.FromJson(jsonString);
                foreach (Employee item in employee)
                {
                    if (Int64.Parse(textBoxEmployeeId.Text) == item.Id)
                    {
                        textBoxEName.Text = item.EName;
                    }
                } 
            }
            else
            {
                MessageBox.Show("Calling API endpoint failed: " + response.ReasonPhrase);
            }
        }

        // Lista frissítés gomb (Refresh List) kattintási eseménye.
        private void buttonRefreshAppointments_Click(object sender, EventArgs e)
        {
            clearInputs();
            refreshAppointmentList();
        }

        // Új időpont hozzáadása az adatbázishoz, Add gomb kattintási eseménye.
        private async void buttonAddAppointment_Click(object sender, EventArgs e)
        {
            Appointment appointment = new Appointment();
           
            if (string.IsNullOrEmpty(textBoxEName.Text))
            {
                MessageBox.Show("Employee name required!");
                textBoxEName.Focus();
                return;
            }
            if (dateTimeAppointment.Value == null)
            {
                MessageBox.Show("Appointment required!");
                dateTimeAppointment.Focus();
                return;
            }

            dateTimeAppointment.Format = DateTimePickerFormat.Custom;
            dateTimeAppointment.CustomFormat = "yyyy-MM-dd hh:mm:ss";
            appointment.AppointmentAppointment = dateTimeAppointment.Value.ToString("yyyy-MM-dd hh:mm:ss");
            HttpResponseMessage responseGet = await client.GetAsync(endpointEmployee);
            if (responseGet.IsSuccessStatusCode)
            {
                string jsonString = await responseGet.Content.ReadAsStringAsync();
                var employee = Employee.FromJson(jsonString);
                foreach (Employee item in employee)
                {
                    if(item.EName == textBoxEName.Text)
                    {
                        textBoxEmployeeId.Text = item.Id.ToString();
                    }
                }
            }
            else
            {
                MessageBox.Show("Calling API endpoint failed: " + responseGet.ReasonPhrase);
            }

            appointment.EmployeeId = long.Parse(textBoxEmployeeId.Text);
            appointment.Booked = 0;
            //appointment.GuestId = null;
            //appointment.BoardGameId = null;
            //appointment.NumberOfPlayers = null;

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
                MessageBox.Show("Failed! Could not add new appointment to database. " + response.ReasonPhrase);
            }
            clearInputs();
        }

        // Kiválasztott időpont adatainak módosítása az adatbázisban, Update gomb kattintási eseménye.
        private async void buttonUpdateAppointment_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxIdAppointment.Text))
            {
                MessageBox.Show("An appointment must be selected!");
                return;
            }
            if (string.IsNullOrEmpty(textBoxEName.Text))
            {
                MessageBox.Show("Employee name required!");
                textBoxEName.Focus();
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

            Appointment appointment = new Appointment();
            appointment.Id =long.Parse(textBoxIdAppointment.Text);
            dateTimeAppointment.Format = DateTimePickerFormat.Custom;
            dateTimeAppointment.CustomFormat = "yyyy-MM-dd hh:mm:ss";

            appointment.AppointmentAppointment = dateTimeAppointment.Value.ToString("yyyy-MM-dd hh:mm:ss");
            HttpResponseMessage responseGet = await client.GetAsync(endpointEmployee);
            if (responseGet.IsSuccessStatusCode)
            {
                string jsonString = await responseGet.Content.ReadAsStringAsync();
                var employee = Employee.FromJson(jsonString);
                foreach (Employee item in employee)
                {
                    if (item.EName == textBoxEName.Text)
                    {
                        textBoxEmployeeId.Text = item.Id.ToString();
                    }
                }
            }
            else
            {
                MessageBox.Show("Calling API endpoint failed: " + responseGet.ReasonPhrase);
            }
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
                MessageBox.Show("Failed! Could not update appointment! " + response.ReasonPhrase);
            }
            clearInputs();
        }

        // Kiválasztott időpont törlése az adatbázisból, Delete gomb kattintási eseménye.
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
                appointment.AppointmentAppointment = dateTimeAppointment.Value.ToString();
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
                    MessageBox.Show("Failed! Could not delete appointment! " + response.ReasonPhrase);
                }
            } 
            clearInputs();
        }

        // Input mezők kiürítése.
        private void clearInputs()
        {
            textBoxIdAppointment.Text = string.Empty;
            textBoxEmployeeId.Text = string.Empty;
            textBoxEName.Text = string.Empty;
            dateTimeAppointment.Value = DateTime.Now;
        }
    }
}
