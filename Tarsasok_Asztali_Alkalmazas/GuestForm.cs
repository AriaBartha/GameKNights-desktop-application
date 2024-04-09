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
    public partial class GuestForm : Form
    {
        public GuestForm()
        {
            InitializeComponent();
        }

        private void GuestForm_Load(object sender, EventArgs e)
        {
            setupDataGrid();
            //refreshDataGrid();
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

        // private void refreshDataGrid()
        // {
        //     throw new NotImplementedException();
        // }
    }
}
