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
            refreshEmployeeList();
        }

        private async void refreshEmployeeList()
        {

            listBoxEmployees.Items.Clear();
            try
            {
                HttpResponseMessage response = await client.GetAsync(endPoint);
                if (response.IsSuccessStatusCode)
                {
                    string jsonString = await response.Content.ReadAsStringAsync();
                    var employee = Employee.FromJson(jsonString);
                    foreach (Employee item in employee)
                    {
                        listBoxEmployees.Items.Add(item);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void listBoxEmployees_SelectedIndexChanged(object sender, EventArgs e)
        {
            Employee employee = (Employee)listBoxEmployees.SelectedItem;
            textBoxIdEmployee.Text = employee.Id.ToString();
            textBoxNameEmployee.Text = employee.EName.ToString();
            textBoxEmailEmployee.Text = employee.EEmail.ToString();
            textBoxPasswordEmployee.Text = employee.EPassword.ToString();
        }

        private void buttonRefreshListEmloyee_Click(object sender, EventArgs e)
        {
            refreshEmployeeList();
        }

        private void buttonAddEmployee_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee();
            if (string.IsNullOrEmpty(textBoxNameEmployee.Text))
            {
                MessageBox.Show("Employee name is required");
                textBoxNameEmployee.Focus();
                return;
            }
            if (string.IsNullOrEmpty(textBoxEmailEmployee.Text))
            {
                MessageBox.Show("Email is required");
                textBoxEmailEmployee.Focus();
                return;
            }
            if (string.IsNullOrEmpty(textBoxPasswordEmployee.Text))
            {
                MessageBox.Show("Password is required");
                textBoxPasswordEmployee.Focus();
                return;
            }
            employee.EName = textBoxNameEmployee.Text;
            employee.EEmail = textBoxEmailEmployee.Text;
            employee.EPassword = textBoxPasswordEmployee.Text;
            var json = JsonConvert.SerializeObject(employee);
            var data = new StringContent(json, Encoding.UTF8, "application/json");
            var response = client.PostAsync(endPoint, data).Result;
            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("New employee has been added successfully");
                refreshEmployeeList();
            }
            else
            {
                MessageBox.Show("Failed! Could not add new employee to database.");
            }
            textBoxIdEmployee.Text = string.Empty;
            textBoxNameEmployee.Text = string.Empty;
            textBoxEmailEmployee.Text = string.Empty;
            textBoxPasswordEmployee.Text = string.Empty;
        }

        private void buttonUpdateEmployee_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxIdEmployee.Text))
            {
                MessageBox.Show("An employee must be selected!");
                return;
            }
            if (string.IsNullOrEmpty(textBoxNameEmployee.Text))
            {
                MessageBox.Show("Employee name is required");
                textBoxNameEmployee.Focus();
                return;
            }
            if (string.IsNullOrEmpty(textBoxEmailEmployee.Text))
            {
                MessageBox.Show("Email is required");
                textBoxEmailEmployee.Focus();
                return;
            }
            if (string.IsNullOrEmpty(textBoxPasswordEmployee.Text))
            {
                MessageBox.Show("Password is required");
                textBoxPasswordEmployee.Focus();
                return;
            }
            Employee employee = new Employee();

            employee.Id = long.Parse(textBoxIdEmployee.Text);
            employee.EName = textBoxNameEmployee.Text;
            employee.EEmail = textBoxEmailEmployee.Text;
            employee.EPassword = textBoxPasswordEmployee.Text;

            var json = JsonConvert.SerializeObject(employee);
            var data = new StringContent(json, Encoding.UTF8, "application/json");
            string endPointUpdate = $"{endPoint}/{employee.Id}";
            var response = client.PutAsync(endPointUpdate, data).Result;
            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Employee's data has been updated successfully");
                refreshEmployeeList();
            }
            else
            {
                MessageBox.Show("Employee's data update FAILED!");
            }
            textBoxIdEmployee.Text = string.Empty;
            textBoxNameEmployee.Text = string.Empty;
            textBoxEmailEmployee.Text = string.Empty;
            textBoxPasswordEmployee.Text = string.Empty;
        }

        private void buttonDeleteEmployee_Click(object sender, EventArgs e)
        {

        }
    }
}
