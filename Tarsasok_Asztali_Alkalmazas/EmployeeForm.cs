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
using System.Text.RegularExpressions;

namespace Tarsasok_Asztali_Alkalmazas
{
    // Oldal a munkavállalók adatainak kezelésére.
    public partial class EmployeeForm : Form
    {
        HttpClient client = new HttpClient();
        string endPoint = ReadSetting("endpointUrlEmployee");

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
        public EmployeeForm()
        {
            InitializeComponent();
        }

        // Form betöltése.
        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            refreshEmployeeList();
        }

        // Lista frissítése.
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

        // Kiválasztott munkavállaló adatainak betöltése az input mezőkbe.
        private void listBoxEmployees_SelectedIndexChanged(object sender, EventArgs e)
        {
            Employee employee = (Employee)listBoxEmployees.SelectedItem;
            textBoxIdEmployee.Text = employee.Id.ToString();
            textBoxNameEmployee.Text = employee.EName.ToString();
            textBoxEmailEmployee.Text = employee.EEmail.ToString();
            textBoxPasswordEmployee.Text = employee.EPassword.ToString();
        }

        // Lista frissítés gomb (Refresh List) kattintási eseménye.
        private void buttonRefreshListEmloyee_Click(object sender, EventArgs e)
        {
            clearInputs();
            refreshEmployeeList();
        }

        // Új munkavállaló hozzáadása az adatbázishoz, "Add" gomb kattintási eseménye.
        private void buttonAddEmployee_Click(object sender, EventArgs e)
        {
            try
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
                if (!IsValidEmail(textBoxEmailEmployee.Text))
                {
                    MessageBox.Show("Email address must be valid.");
                    textBoxEmailEmployee.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(textBoxPasswordEmployee.Text))
                {
                    MessageBox.Show("Password is required");
                    textBoxPasswordEmployee.Focus();
                    return;
                }
                string password = textBoxPasswordEmployee.Text;
                if (password.Length < 8)
                {
                    MessageBox.Show("Password must be at least 8 characters.");
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
                    MessageBox.Show("Failed! Could not add new employee to database. " + response.ReasonPhrase);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Calling API endpoint failed: " + ex.Message);
            }
            clearInputs();
        }

        // Kiválasztott munkavállaló adatainak módosítása az adatbázisban, "Update" gomb kattintási eseménye.
        private void buttonUpdateEmployee_Click(object sender, EventArgs e)
        {
            try
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
                if (!IsValidEmail(textBoxEmailEmployee.Text))
                {
                    MessageBox.Show("Email address must be valid.");
                    textBoxEmailEmployee.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(textBoxPasswordEmployee.Text))
                {
                    MessageBox.Show("Password is required");
                    textBoxPasswordEmployee.Focus();
                    return;
                }
                string password = textBoxPasswordEmployee.Text;
                if (password.Length < 8)
                {
                    MessageBox.Show("Password must be at least 8 characters.");
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
                    MessageBox.Show("Employee's data update FAILED! " + response.ReasonPhrase);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Calling API endpoint failed: " + ex.Message);
            }
            clearInputs();
        }

        // Kiválasztott munkavállaló törlése az adatbázisból, "Delete" gomb kattintási eseménye.
        private void buttonDeleteEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(textBoxIdEmployee.Text))
                {
                    MessageBox.Show("An employee must be selected!");
                    return;
                }
                if (MessageBox.Show("Are you sure you want to delete the selected item?", "Confirm delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    return;
                }
                else
                {
                    Employee employee = new Employee();

                    employee.Id = long.Parse(textBoxIdEmployee.Text);
                    employee.EName = textBoxNameEmployee.Text;
                    employee.EEmail = textBoxEmailEmployee.Text;
                    employee.EPassword = textBoxPasswordEmployee.Text;

                    string endPointDelete = $"{endPoint}/{employee.Id}";
                    var response = client.DeleteAsync(endPointDelete).Result;
                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Delete is successful!");
                        refreshEmployeeList();
                    }
                    else
                    {
                        MessageBox.Show("Delete FAILED! " + response.ReasonPhrase);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Calling API endpoint failed: " + ex.Message);
            }
            clearInputs();
        }

        // Input mezők kiürítése.
        private void clearInputs()
        {
            textBoxIdEmployee.Text = string.Empty;
            textBoxNameEmployee.Text = string.Empty;
            textBoxEmailEmployee.Text = string.Empty;
            textBoxPasswordEmployee.Text = string.Empty;
        }

        //Email cím validálás.
        public static bool IsValidEmail(string email)
        {
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            var regex = new Regex(pattern, RegexOptions.IgnoreCase);
            return regex.IsMatch(email);
        }
    }
}
