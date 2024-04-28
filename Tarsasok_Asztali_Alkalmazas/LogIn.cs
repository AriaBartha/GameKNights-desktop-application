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
    //Belépés az alkalmazásba autentikációval.
    public partial class LogIn : Form
    {
        HttpClient client = new HttpClient();
        string endPoint = ReadSetting("endpointUrlLogIn");

        // Osztály a token definiálására
        public string token { get; set; }
        

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
            //email validálás
            try
            {
                new System.Net.Mail.MailAddress(textBoxEmail.Text);
            }
            catch (ArgumentException)
            {
                //ha nem ad meg semmit a felhasználó
                MessageBox.Show("Email is required!");
                textBoxEmail.Focus();
                return;
            }
            catch (FormatException)
            {
                //ha nem email formátumot ad meg a felhasználó
                MessageBox.Show("Valid email is required!");
                textBoxEmail.Focus();
                return;
            }
            // ha nem ad meg jelszót a felhasználó
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
                token = response.Content.ReadAsStringAsync().Result;
                string[] splitObject = token.Split(':');
                string getToken = splitObject[1].Replace("\"", "");
                string authToken = getToken.Replace("}", "");
                Program.mainForm.Token = authToken;
                this.Hide();
                Program.mainForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Incorrect email or password.");
                return;
            }
        }

        // A program bezárása, program futása leáll. Exit gomb kattintási eseménye.
        private void buttonExit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to exit?", "Exit Application", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
            
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
