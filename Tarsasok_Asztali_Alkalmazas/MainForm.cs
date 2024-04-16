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
using Newtonsoft.Json;
using Tarsasok_Asztali_Alkalmazas;

namespace Tarsasok_Asztali_Alkalmazas
{
    // Az alkalmazás főoldala.
    public partial class MainForm : Form
    {
        HttpClient client = new HttpClient();
        string endPoint = ReadSetting("endpointUrlLogOut");
        string endPointAuthData = ReadSetting("endPointUrlAuthData");
        public string Token { get; set; }

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
        public MainForm()
        {
            InitializeComponent();
            buttonToEmployees.Visible = false;
        }

        // Form betöltése.
        private void MainForm_Load(object sender, EventArgs e)
        {
            CheckUser();
        }

        // Bejelentkezett felhasználó ellenőrzése, ha admin, akkor hozzáfér az Employee gombhoz
        private async void CheckUser()
        {
            
            var json = JsonConvert.SerializeObject(Token);
            var data = new StringContent(json, Encoding.UTF8, "application/json");
            var response = client.PostAsync(endPointAuthData, data).Result;
            if (response.IsSuccessStatusCode)
            {
                string jsonString = await response.Content.ReadAsStringAsync();
                var employee = Employee.FromJson(jsonString);
                foreach (Employee item in employee)
                {
                    if (item.EEmail == "admin@gkn.com")
                    {
                        buttonToEmployees.Visible=true;
                    }
                }
            }
        }

        // Board games gomb kattintási eseménye, megnyitja a BoardGamesForm ablakot.
        private void buttonToBoardGamesForm_Click(object sender, EventArgs e)
        {
            BoardGamesForm boardGamesForm = new BoardGamesForm();
            boardGamesForm.ShowDialog();
        }

        // Employees gomb kattintási eseménye, megnyitja az EmployeeForm ablakot.
        private void buttonToEmployees_Click(object sender, EventArgs e)
        {
            EmployeeForm employeesForm = new EmployeeForm();
            employeesForm.ShowDialog();
        }

        //Appointments gomb kattintási eseménye, megnyitja az AppointmentForm ablakot.
        private void buttonToAppointments_Click(object sender, EventArgs e)
        {
            AppointmentForm appointmentsForm = new AppointmentForm();
            appointmentsForm.ShowDialog();
        }

        // Guests' contact data gomb kattintási eseménye, megnyitja a GuestForm ablakot.
        private void buttonToGuestscontactData_Click(object sender, EventArgs e)
        {
            GuestForm guestForm = new GuestForm();
            guestForm.ShowDialog();
        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            //átküldeni a tokent, amit előtte el kéne tárolni mikor loginol és itt kell meghívni
           // var json = JsonConvert.SerializeObject(token);
           // var data = new StringContent(json, Encoding.UTF8, "application/json");
           // var response = client.PostAsync(endPoint, data).Result;
           // if (response.IsSuccessStatusCode)
           // {
           //     this.Hide();
            //    Program.logInForm.ShowDialog();
           // }
                
        }

        // A program bezárása, program futása leáll.
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (e.CloseReason == CloseReason.UserClosing)
            {

                DialogResult result = MessageBox.Show(
                    "Are you sure you want to close?",
                    "Confirm Close",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.No)
                {

                    e.Cancel = true;
                }
                else
                {
                    Application.Exit();
                }
            }
        }

       
    }
}
