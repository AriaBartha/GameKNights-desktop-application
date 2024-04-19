namespace Tarsasok_Asztali_Alkalmazas
{
    partial class AppointmentsDetails
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridViewAppointmentsData = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAppointmentsData)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewAppointmentsData
            // 
            this.dataGridViewAppointmentsData.AllowUserToAddRows = false;
            this.dataGridViewAppointmentsData.AllowUserToDeleteRows = false;
            this.dataGridViewAppointmentsData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAppointmentsData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewAppointmentsData.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewAppointmentsData.Name = "dataGridViewAppointmentsData";
            this.dataGridViewAppointmentsData.ReadOnly = true;
            this.dataGridViewAppointmentsData.Size = new System.Drawing.Size(800, 450);
            this.dataGridViewAppointmentsData.TabIndex = 0;
            // 
            // AppointmentsDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewAppointmentsData);
            this.Name = "AppointmentsDetails";
            this.Text = "AppointmentsDetails";
            this.Load += new System.EventHandler(this.AppointmentsDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAppointmentsData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewAppointmentsData;
    }
}