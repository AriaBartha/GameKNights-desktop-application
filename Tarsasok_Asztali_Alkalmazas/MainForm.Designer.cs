namespace Tarsasok_Asztali_Alkalmazas
{
    partial class MainForm
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
            this.buttonToBoardGamesForm = new System.Windows.Forms.Button();
            this.buttonToAppointments = new System.Windows.Forms.Button();
            this.buttonLogOut = new System.Windows.Forms.Button();
            this.buttonToGuestscontactData = new System.Windows.Forms.Button();
            this.buttonToEmployees = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonToBoardGamesForm
            // 
            this.buttonToBoardGamesForm.Location = new System.Drawing.Point(306, 31);
            this.buttonToBoardGamesForm.Name = "buttonToBoardGamesForm";
            this.buttonToBoardGamesForm.Size = new System.Drawing.Size(155, 41);
            this.buttonToBoardGamesForm.TabIndex = 0;
            this.buttonToBoardGamesForm.Text = "Board Games";
            this.buttonToBoardGamesForm.UseVisualStyleBackColor = true;
            this.buttonToBoardGamesForm.Click += new System.EventHandler(this.buttonToBoardGamesForm_Click);
            // 
            // buttonToAppointments
            // 
            this.buttonToAppointments.Location = new System.Drawing.Point(306, 101);
            this.buttonToAppointments.Name = "buttonToAppointments";
            this.buttonToAppointments.Size = new System.Drawing.Size(155, 41);
            this.buttonToAppointments.TabIndex = 1;
            this.buttonToAppointments.Text = "Appointments";
            this.buttonToAppointments.UseVisualStyleBackColor = true;
            this.buttonToAppointments.Click += new System.EventHandler(this.buttonToAppointments_Click);
            // 
            // buttonLogOut
            // 
            this.buttonLogOut.Location = new System.Drawing.Point(577, 338);
            this.buttonLogOut.Name = "buttonLogOut";
            this.buttonLogOut.Size = new System.Drawing.Size(155, 41);
            this.buttonLogOut.TabIndex = 2;
            this.buttonLogOut.Text = "Log out";
            this.buttonLogOut.UseVisualStyleBackColor = true;
            // 
            // buttonToGuestscontactData
            // 
            this.buttonToGuestscontactData.Location = new System.Drawing.Point(306, 181);
            this.buttonToGuestscontactData.Name = "buttonToGuestscontactData";
            this.buttonToGuestscontactData.Size = new System.Drawing.Size(155, 41);
            this.buttonToGuestscontactData.TabIndex = 3;
            this.buttonToGuestscontactData.Text = "Guest\'s contact data";
            this.buttonToGuestscontactData.UseVisualStyleBackColor = true;
            this.buttonToGuestscontactData.Click += new System.EventHandler(this.buttonToGuestscontactData_Click);
            // 
            // buttonToEmployees
            // 
            this.buttonToEmployees.Location = new System.Drawing.Point(306, 253);
            this.buttonToEmployees.Name = "buttonToEmployees";
            this.buttonToEmployees.Size = new System.Drawing.Size(155, 41);
            this.buttonToEmployees.TabIndex = 4;
            this.buttonToEmployees.Text = "Employees";
            this.buttonToEmployees.UseVisualStyleBackColor = true;
            this.buttonToEmployees.Click += new System.EventHandler(this.buttonToEmployees_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonToEmployees);
            this.Controls.Add(this.buttonToGuestscontactData);
            this.Controls.Add(this.buttonLogOut);
            this.Controls.Add(this.buttonToAppointments);
            this.Controls.Add(this.buttonToBoardGamesForm);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonToBoardGamesForm;
        private System.Windows.Forms.Button buttonToAppointments;
        private System.Windows.Forms.Button buttonLogOut;
        private System.Windows.Forms.Button buttonToGuestscontactData;
        private System.Windows.Forms.Button buttonToEmployees;
    }
}