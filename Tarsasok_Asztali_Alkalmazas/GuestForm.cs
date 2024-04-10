using System;
using System.Collections;
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
using static System.Windows.Forms.LinkLabel;

namespace Tarsasok_Asztali_Alkalmazas
{
    public partial class GuestForm : Form
    {
        HttpClient client = new HttpClient();
        string endPoint = ReadSetting("endpointUrlGuest");

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
        public GuestForm()
        {
            InitializeComponent();
        }

        private void GuestForm_Load(object sender, EventArgs e)
        {
            setupDataGrid();
            refreshDataGrid();
        }

        private void setupDataGrid()
        {
            //--data grid global setup
            dataGridViewGuests.AutoSizeColumnsMode=DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewGuests.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewGuests.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            dataGridViewGuests.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridViewGuests.ColumnHeadersDefaultCellStyle.Font = new Font(this.Font, FontStyle.Bold);
            dataGridViewGuests.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewGuests.MultiSelect = false;
            dataGridViewGuests.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            //-- column setup
            DataGridViewColumn columnUsername = new DataGridViewColumn();
            {
                columnUsername.Name = "Username";
                columnUsername.DataPropertyName = "username";
                columnUsername.CellTemplate = new DataGridViewTextBoxCell();
            }
            dataGridViewGuests.Columns.Add(columnUsername);
            //---------------------------------------------------------
            DataGridViewColumn columnName = new DataGridViewColumn();
            {
                columnName.Name = "Name";
                columnName.DataPropertyName = "name";
                columnName.CellTemplate = new DataGridViewTextBoxCell();
            }
            dataGridViewGuests.Columns.Add(columnName);
            //-----------------------------------------------------------
            DataGridViewColumn columnEmail = new DataGridViewColumn();
            {
                columnEmail.Name = "Email";
                columnEmail.DataPropertyName = "email";
                columnEmail.CellTemplate = new DataGridViewTextBoxCell();
            }
            dataGridViewGuests.Columns.Add(columnEmail);
            //-----------------------------------------------------------
            DataGridViewColumn columnPhoneNumber = new DataGridViewColumn();
            {
                columnPhoneNumber.Name = "Phone number";
                columnPhoneNumber.DataPropertyName = "phoneNumber";
                columnPhoneNumber.CellTemplate = new DataGridViewTextBoxCell();
            }
            dataGridViewGuests.Columns.Add(columnPhoneNumber);
        }

         private async void refreshDataGrid()
         {
            dataGridViewGuests.Rows.Clear();

            try
            {
                HttpResponseMessage response = await client.GetAsync(endPoint);
                if (response.IsSuccessStatusCode)
                {
                    string jsonString = await response.Content.ReadAsStringAsync();
                    var guest = Guest.FromJson(jsonString);
                    foreach (Guest item in guest)
                    {
                        
                        int number = dataGridViewGuests.Rows.Add();
                        DataGridViewRow row = dataGridViewGuests.Rows[number];
                        row.Cells["username"].Value = item.GUsername;
                        row.Cells["name"].Value = item.GName;
                        row.Cells["email"].Value = item.GEmail;
                        row.Cells["phone number"].Value = item.GPhoneNumber;
                        
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
    }
}
