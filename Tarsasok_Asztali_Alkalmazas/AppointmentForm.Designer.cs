namespace Tarsasok_Asztali_Alkalmazas
{
    partial class AppointmentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppointmentForm));
            this.listBoxAppointments = new System.Windows.Forms.ListBox();
            this.textBoxEName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimeAppointment = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxIdAppointment = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonRefreshAppointments = new System.Windows.Forms.Button();
            this.buttonAddAppointment = new System.Windows.Forms.Button();
            this.buttonUpdateAppointment = new System.Windows.Forms.Button();
            this.buttonDeleteAppointment = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxAppointments
            // 
            this.listBoxAppointments.BackColor = System.Drawing.Color.MistyRose;
            this.listBoxAppointments.Dock = System.Windows.Forms.DockStyle.Left;
            this.listBoxAppointments.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listBoxAppointments.FormattingEnabled = true;
            this.listBoxAppointments.ItemHeight = 16;
            this.listBoxAppointments.Location = new System.Drawing.Point(0, 0);
            this.listBoxAppointments.Name = "listBoxAppointments";
            this.listBoxAppointments.Size = new System.Drawing.Size(290, 485);
            this.listBoxAppointments.TabIndex = 0;
            this.listBoxAppointments.SelectedIndexChanged += new System.EventHandler(this.listBoxAppointments_SelectedIndexChanged);
            // 
            // textBoxEName
            // 
            this.textBoxEName.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxEName.Location = new System.Drawing.Point(523, 201);
            this.textBoxEName.Name = "textBoxEName";
            this.textBoxEName.Size = new System.Drawing.Size(216, 20);
            this.textBoxEName.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.MistyRose;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(368, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Employee name:";
            // 
            // dateTimeAppointment
            // 
            this.dateTimeAppointment.CustomFormat = "yyyy-MM-dd hh:mm:ss";
            this.dateTimeAppointment.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateTimeAppointment.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeAppointment.Location = new System.Drawing.Point(523, 138);
            this.dateTimeAppointment.MinDate = new System.DateTime(2024, 4, 4, 0, 0, 0, 0);
            this.dateTimeAppointment.Name = "dateTimeAppointment";
            this.dateTimeAppointment.Size = new System.Drawing.Size(200, 22);
            this.dateTimeAppointment.TabIndex = 3;
            this.dateTimeAppointment.Value = new System.DateTime(2024, 4, 10, 10, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.MistyRose;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(390, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Appointment:";
            // 
            // textBoxIdAppointment
            // 
            this.textBoxIdAppointment.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxIdAppointment.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxIdAppointment.Location = new System.Drawing.Point(523, 78);
            this.textBoxIdAppointment.Name = "textBoxIdAppointment";
            this.textBoxIdAppointment.ReadOnly = true;
            this.textBoxIdAppointment.Size = new System.Drawing.Size(100, 22);
            this.textBoxIdAppointment.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.MistyRose;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(459, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id:";
            // 
            // buttonRefreshAppointments
            // 
            this.buttonRefreshAppointments.BackColor = System.Drawing.Color.PeachPuff;
            this.buttonRefreshAppointments.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonRefreshAppointments.Location = new System.Drawing.Point(353, 297);
            this.buttonRefreshAppointments.Name = "buttonRefreshAppointments";
            this.buttonRefreshAppointments.Size = new System.Drawing.Size(129, 38);
            this.buttonRefreshAppointments.TabIndex = 2;
            this.buttonRefreshAppointments.Text = "Refresh List";
            this.buttonRefreshAppointments.UseVisualStyleBackColor = false;
            this.buttonRefreshAppointments.Click += new System.EventHandler(this.buttonRefreshAppointments_Click);
            // 
            // buttonAddAppointment
            // 
            this.buttonAddAppointment.BackColor = System.Drawing.Color.PeachPuff;
            this.buttonAddAppointment.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonAddAppointment.Location = new System.Drawing.Point(600, 297);
            this.buttonAddAppointment.Name = "buttonAddAppointment";
            this.buttonAddAppointment.Size = new System.Drawing.Size(129, 38);
            this.buttonAddAppointment.TabIndex = 3;
            this.buttonAddAppointment.Text = "Add";
            this.buttonAddAppointment.UseVisualStyleBackColor = false;
            this.buttonAddAppointment.Click += new System.EventHandler(this.buttonAddAppointment_Click);
            // 
            // buttonUpdateAppointment
            // 
            this.buttonUpdateAppointment.BackColor = System.Drawing.Color.PeachPuff;
            this.buttonUpdateAppointment.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonUpdateAppointment.Location = new System.Drawing.Point(353, 378);
            this.buttonUpdateAppointment.Name = "buttonUpdateAppointment";
            this.buttonUpdateAppointment.Size = new System.Drawing.Size(129, 38);
            this.buttonUpdateAppointment.TabIndex = 4;
            this.buttonUpdateAppointment.Text = "Update";
            this.buttonUpdateAppointment.UseVisualStyleBackColor = false;
            this.buttonUpdateAppointment.Click += new System.EventHandler(this.buttonUpdateAppointment_Click);
            // 
            // buttonDeleteAppointment
            // 
            this.buttonDeleteAppointment.BackColor = System.Drawing.Color.PeachPuff;
            this.buttonDeleteAppointment.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonDeleteAppointment.ForeColor = System.Drawing.Color.Red;
            this.buttonDeleteAppointment.Location = new System.Drawing.Point(600, 378);
            this.buttonDeleteAppointment.Name = "buttonDeleteAppointment";
            this.buttonDeleteAppointment.Size = new System.Drawing.Size(129, 38);
            this.buttonDeleteAppointment.TabIndex = 5;
            this.buttonDeleteAppointment.Text = "Delete";
            this.buttonDeleteAppointment.UseVisualStyleBackColor = false;
            this.buttonDeleteAppointment.Click += new System.EventHandler(this.buttonDeleteAppointment_Click);
            // 
            // AppointmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 485);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxIdAppointment);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimeAppointment);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxEName);
            this.Controls.Add(this.buttonDeleteAppointment);
            this.Controls.Add(this.buttonUpdateAppointment);
            this.Controls.Add(this.buttonAddAppointment);
            this.Controls.Add(this.buttonRefreshAppointments);
            this.Controls.Add(this.listBoxAppointments);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(816, 524);
            this.MinimumSize = new System.Drawing.Size(816, 524);
            this.Name = "AppointmentForm";
            this.Text = "Appointments";
            this.Load += new System.EventHandler(this.AppointmentForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxAppointments;
        private System.Windows.Forms.DateTimePicker dateTimeAppointment;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxIdAppointment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxEName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonRefreshAppointments;
        private System.Windows.Forms.Button buttonAddAppointment;
        private System.Windows.Forms.Button buttonUpdateAppointment;
        private System.Windows.Forms.Button buttonDeleteAppointment;
    }
}