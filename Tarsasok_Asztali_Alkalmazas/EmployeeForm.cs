using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tarsasok_Asztali_Alkalmazas;
using Newtonsoft.Json;
using System.Configuration;
using System.Net.Http;

namespace Tarsasok_Asztali_Alkalmazas
{
    public partial class EmployeeForm : Form
    {
        HttpClient client = new HttpClient();
        string endPoint = ReadSetting("endpointUrlEmployee");

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
        public EmployeeForm()
        {
            InitializeComponent();
        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {

        }

        private void listBoxEmployees_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonRefreshListEmloyee_Click(object sender, EventArgs e)
        {

        }

        private void buttonAddEmployee_Click(object sender, EventArgs e)
        {

        }

        private void buttonUpdateEmployee_Click(object sender, EventArgs e)
        {

        }

        private void buttonDeleteEmployee_Click(object sender, EventArgs e)
        {

        }
    }
}
