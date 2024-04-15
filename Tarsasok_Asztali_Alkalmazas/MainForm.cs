using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarsasok_Asztali_Alkalmazas
{
    // Az alkalmazás főoldala.

    public partial class MainForm : Form
    {
        // Inicializálás.
        public MainForm()
        {
            InitializeComponent();
        }

        // Board games gomb kattintási eseménye, megnyitja a BoardGamesForm ablakot.
        private void buttonToBoardGamesForm_Click(object sender, EventArgs e)
        {
            BoardGamesForm boardGamesForm = new BoardGamesForm();
            boardGamesForm.ShowDialog();
            //TODO: close Mainform when goes to BoardGamesForm
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
    }
}
