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

namespace Tarsasok_Asztali_Alkalmazas
{
    public partial class LogIn : Form
    {
        HttpClient client = new HttpClient();
        string endPoint = ReadSetting("endpointUrlLogin");

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
        public LogIn()
        {
            InitializeComponent();
        }

        // Form betöltése.
        private void LogIn_Load(object sender, EventArgs e)
        {

        }

        //Belépés az alkalmazásba, Log in gomb kattintási eseménye.
        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxEmail.Text))
            {
                MessageBox.Show("Email is required!");
                textBoxEmail.Focus();
                return;
            }
            if (string.IsNullOrEmpty(textBoxPassword.Text))
            {
                MessageBox.Show("Password is required!");
                textBoxPassword.Focus();
                return;
            }
            Employee employee = new Employee();
            employee.EEmail = textBoxEmail.Text;
            employee.EPassword = textBoxPassword.Text;
            var json = JsonConvert.SerializeObject(employee);
            var data = new StringContent(json, Encoding.UTF8, "application/json");
            var response = client.PostAsync(endPoint, data).Result;
            if (response.IsSuccessStatusCode)
            {
                
                this.Hide();
                Program.mainForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Incorrect email or password.");
                return;
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Program.mainForm.Close();
            this.Close();
        }
    }
}
