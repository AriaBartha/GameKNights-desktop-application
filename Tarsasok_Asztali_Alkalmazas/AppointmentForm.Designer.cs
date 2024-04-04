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
            this.listBoxAppointments = new System.Windows.Forms.ListBox();
            this.groupBoxAppointments = new System.Windows.Forms.GroupBox();
            this.textBoxEName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxEmployeeId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimeAppointment = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxIdAppointment = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonRefreshAppointments = new System.Windows.Forms.Button();
            this.buttonAddAppointment = new System.Windows.Forms.Button();
            this.buttonUpdateAppointment = new System.Windows.Forms.Button();
            this.buttonDeleteAppointment = new System.Windows.Forms.Button();
            this.groupBoxAppointments.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxAppointments
            // 
            this.listBoxAppointments.Dock = System.Windows.Forms.DockStyle.Left;
            this.listBoxAppointments.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listBoxAppointments.FormattingEnabled = true;
            this.listBoxAppointments.ItemHeight = 16;
            this.listBoxAppointments.Location = new System.Drawing.Point(0, 0);
            this.listBoxAppointments.Name = "listBoxAppointments";
            this.listBoxAppointments.Size = new System.Drawing.Size(290, 450);
            this.listBoxAppointments.TabIndex = 0;
            this.listBoxAppointments.SelectedIndexChanged += new System.EventHandler(this.listBoxAppointments_SelectedIndexChanged);
            // 
            // groupBoxAppointments
            // 
            this.groupBoxAppointments.Controls.Add(this.textBoxEName);
            this.groupBoxAppointments.Controls.Add(this.label4);
            this.groupBoxAppointments.Controls.Add(this.textBoxEmployeeId);
            this.groupBoxAppointments.Controls.Add(this.label3);
            this.groupBoxAppointments.Controls.Add(this.dateTimeAppointment);
            this.groupBoxAppointments.Controls.Add(this.label2);
            this.groupBoxAppointments.Controls.Add(this.textBoxIdAppointment);
            this.groupBoxAppointments.Controls.Add(this.label1);
            this.groupBoxAppointments.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxAppointments.Location = new System.Drawing.Point(290, 0);
            this.groupBoxAppointments.Name = "groupBoxAppointments";
            this.groupBoxAppointments.Size = new System.Drawing.Size(510, 227);
            this.groupBoxAppointments.TabIndex = 1;
            this.groupBoxAppointments.TabStop = false;
            this.groupBoxAppointments.Text = "groupBoxAppointments";
            // 
            // textBoxEName
            // 
            this.textBoxEName.Location = new System.Drawing.Point(172, 163);
            this.textBoxEName.Name = "textBoxEName";
            this.textBoxEName.Size = new System.Drawing.Size(216, 20);
            this.textBoxEName.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(37, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Employee name:";
            // 
            // textBoxEmployeeId
            // 
            this.textBoxEmployeeId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxEmployeeId.Location = new System.Drawing.Point(172, 121);
            this.textBoxEmployeeId.Name = "textBoxEmployeeId";
            this.textBoxEmployeeId.Size = new System.Drawing.Size(100, 22);
            this.textBoxEmployeeId.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(60, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Employee Id:";
            // 
            // dateTimeAppointment
            // 
            this.dateTimeAppointment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateTimeAppointment.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimeAppointment.Location = new System.Drawing.Point(172, 78);
            this.dateTimeAppointment.MinDate = new System.DateTime(2024, 4, 4, 0, 0, 0, 0);
            this.dateTimeAppointment.Name = "dateTimeAppointment";
            this.dateTimeAppointment.Size = new System.Drawing.Size(200, 22);
            this.dateTimeAppointment.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(61, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Appointment:";
            // 
            // textBoxIdAppointment
            // 
            this.textBoxIdAppointment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxIdAppointment.Location = new System.Drawing.Point(172, 40);
            this.textBoxIdAppointment.Name = "textBoxIdAppointment";
            this.textBoxIdAppointment.ReadOnly = true;
            this.textBoxIdAppointment.Size = new System.Drawing.Size(100, 22);
            this.textBoxIdAppointment.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(125, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id:";
            // 
            // buttonRefreshAppointments
            // 
            this.buttonRefreshAppointments.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonRefreshAppointments.Location = new System.Drawing.Point(318, 246);
            this.buttonRefreshAppointments.Name = "buttonRefreshAppointments";
            this.buttonRefreshAppointments.Size = new System.Drawing.Size(129, 35);
            this.buttonRefreshAppointments.TabIndex = 2;
            this.buttonRefreshAppointments.Text = "Refresh List";
            this.buttonRefreshAppointments.UseVisualStyleBackColor = true;
            // 
            // buttonAddAppointment
            // 
            this.buttonAddAppointment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonAddAppointment.Location = new System.Drawing.Point(485, 246);
            this.buttonAddAppointment.Name = "buttonAddAppointment";
            this.buttonAddAppointment.Size = new System.Drawing.Size(129, 35);
            this.buttonAddAppointment.TabIndex = 3;
            this.buttonAddAppointment.Text = "Add";
            this.buttonAddAppointment.UseVisualStyleBackColor = true;
            // 
            // buttonUpdateAppointment
            // 
            this.buttonUpdateAppointment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonUpdateAppointment.Location = new System.Drawing.Point(318, 322);
            this.buttonUpdateAppointment.Name = "buttonUpdateAppointment";
            this.buttonUpdateAppointment.Size = new System.Drawing.Size(129, 35);
            this.buttonUpdateAppointment.TabIndex = 4;
            this.buttonUpdateAppointment.Text = "Update";
            this.buttonUpdateAppointment.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteAppointment
            // 
            this.buttonDeleteAppointment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonDeleteAppointment.Location = new System.Drawing.Point(485, 322);
            this.buttonDeleteAppointment.Name = "buttonDeleteAppointment";
            this.buttonDeleteAppointment.Size = new System.Drawing.Size(129, 35);
            this.buttonDeleteAppointment.TabIndex = 5;
            this.buttonDeleteAppointment.Text = "Delete";
            this.buttonDeleteAppointment.UseVisualStyleBackColor = true;
            // 
            // AppointmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonDeleteAppointment);
            this.Controls.Add(this.buttonUpdateAppointment);
            this.Controls.Add(this.buttonAddAppointment);
            this.Controls.Add(this.buttonRefreshAppointments);
            this.Controls.Add(this.groupBoxAppointments);
            this.Controls.Add(this.listBoxAppointments);
            this.Name = "AppointmentForm";
            this.Text = "AppointmentForm";
            this.Load += new System.EventHandler(this.AppointmentForm_Load);
            this.groupBoxAppointments.ResumeLayout(false);
            this.groupBoxAppointments.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxAppointments;
        private System.Windows.Forms.GroupBox groupBoxAppointments;
        private System.Windows.Forms.DateTimePicker dateTimeAppointment;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxIdAppointment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxEmployeeId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxEName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonRefreshAppointments;
        private System.Windows.Forms.Button buttonAddAppointment;
        private System.Windows.Forms.Button buttonUpdateAppointment;
        private System.Windows.Forms.Button buttonDeleteAppointment;
    }
}