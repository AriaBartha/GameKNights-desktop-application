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

namespace Tarsasok_Asztali_Alkalmazas
{
    //Oldal az időpontok adatainak részletes listázására.
    public partial class AppointmentsDetails : Form
    {
        HttpClient client = new HttpClient();
        string endPoint = ReadSetting("endpointUrlAppointment");
        string endPointEmployee = ReadSetting("endpointUrlEmployee");
        string endPointGuest = ReadSetting("endpointUrlGuest");
        string endPointBoardGame = ReadSetting("endpointUrlBoardGame");

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
        public AppointmentsDetails()
        {
            InitializeComponent();
        }

        // Form betöltése.
        private void AppointmentsDetails_Load(object sender, EventArgs e)
        {
            setupDataGrid();
            refreshDataGrid();
        }

        // Táblázat megjelenés beállításai.
        private void setupDataGrid()
        {
            // Globális beállítások.

            dataGridViewAppointmentsData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewAppointmentsData.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewAppointmentsData.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            dataGridViewAppointmentsData.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridViewAppointmentsData.ColumnHeadersDefaultCellStyle.Font = new Font(this.Font, FontStyle.Bold);
            dataGridViewAppointmentsData.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewAppointmentsData.MultiSelect = false;
            dataGridViewAppointmentsData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Oszlop beállítások.

            DataGridViewColumn columnDateAndTime = new DataGridViewColumn();
            {
                columnDateAndTime.Name = "Date and time";
                columnDateAndTime.DataPropertyName = "dateAndTime";
                columnDateAndTime.CellTemplate = new DataGridViewTextBoxCell();
            }
            dataGridViewAppointmentsData.Columns.Add(columnDateAndTime);
            //---------------------------------------------------------
            DataGridViewColumn columnEmployeeName = new DataGridViewColumn();
            {
                columnEmployeeName.Name = "Employee";
                columnEmployeeName.DataPropertyName = "employee";
                columnEmployeeName.CellTemplate = new DataGridViewTextBoxCell();
            }
            dataGridViewAppointmentsData.Columns.Add(columnEmployeeName);
            //---------------------------------------------------------
            DataGridViewColumn columnGuestName = new DataGridViewColumn();
            {
                columnGuestName.Name = "Guest's name";
                columnGuestName.DataPropertyName = "guestName";
                columnGuestName.CellTemplate = new DataGridViewTextBoxCell();
            }
            dataGridViewAppointmentsData.Columns.Add(columnGuestName);
            //---------------------------------------------------------
            DataGridViewColumn columnBoardGame = new DataGridViewColumn();
            {
                columnBoardGame.Name = "Board game";
                columnBoardGame.DataPropertyName = "boardGame";
                columnBoardGame.CellTemplate = new DataGridViewTextBoxCell();
            }
            dataGridViewAppointmentsData.Columns.Add(columnBoardGame);
            //---------------------------------------------------------
            DataGridViewColumn columnPlayersNumber = new DataGridViewColumn();
            {
                columnPlayersNumber.Name = "Number of players";
                columnPlayersNumber.DataPropertyName = "numberOfPlayers";
                columnPlayersNumber.CellTemplate = new DataGridViewTextBoxCell();
            }
            dataGridViewAppointmentsData.Columns.Add(columnPlayersNumber);
            //----------------------------------------------------------
        }

        // Táblázat adatainak frissítése.


        //-- TODO: To list the data in the grid a view must be created in the backend.
        //-- Have to get Employee's name from emplyee table
        //-- Have to get Guest's name from guest table
        //-- Have to get Board game's name from board game table
        private async void refreshDataGrid()
         {
            dataGridViewAppointmentsData.Rows.Clear();

            try
            {
                HttpResponseMessage response = await client.GetAsync(endPoint);
                if (response.IsSuccessStatusCode)
                {
                    string jsonString = await response.Content.ReadAsStringAsync();
                    var details = Appointment.FromJson(jsonString);
                    foreach (Appointment item in details)
                    {

                        int number = dataGridViewAppointmentsData.Rows.Add();
                        DataGridViewRow row = dataGridViewAppointmentsData.Rows[number];
                        row.Cells["date and time"].Value = item.AppointmentAppointment;
                        row.Cells["employee"].Value = item.EmployeeId;
                        row.Cells["guest's name"].Value = item.GuestId;
                        row.Cells["board game"].Value = item.BoardGameId;
                        row.Cells["number of players"].Value = item.NumberOfPlayers;
                        
                    }
                }
                else
                {
                    MessageBox.Show("Calling Appointment's API endpoint failed: " + response.ReasonPhrase);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Calling API endpoint failed: " + ex.Message);
            }
         }
    }
}
