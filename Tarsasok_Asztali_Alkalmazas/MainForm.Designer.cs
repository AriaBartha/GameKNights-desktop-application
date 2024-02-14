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
            this.buttonToBoardgamesForm = new System.Windows.Forms.Button();
            this.buttonToAppointments = new System.Windows.Forms.Button();
            this.buttonLogOut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonToBoardgamesForm
            // 
            this.buttonToBoardgamesForm.Location = new System.Drawing.Point(306, 57);
            this.buttonToBoardgamesForm.Name = "buttonToBoardgamesForm";
            this.buttonToBoardgamesForm.Size = new System.Drawing.Size(155, 41);
            this.buttonToBoardgamesForm.TabIndex = 0;
            this.buttonToBoardgamesForm.Text = "Társasok";
            this.buttonToBoardgamesForm.UseVisualStyleBackColor = true;
            // 
            // buttonToAppointments
            // 
            this.buttonToAppointments.Location = new System.Drawing.Point(306, 147);
            this.buttonToAppointments.Name = "buttonToAppointments";
            this.buttonToAppointments.Size = new System.Drawing.Size(155, 41);
            this.buttonToAppointments.TabIndex = 1;
            this.buttonToAppointments.Text = "Időpontok";
            this.buttonToAppointments.UseVisualStyleBackColor = true;
            // 
            // buttonLogOut
            // 
            this.buttonLogOut.Location = new System.Drawing.Point(306, 229);
            this.buttonLogOut.Name = "buttonLogOut";
            this.buttonLogOut.Size = new System.Drawing.Size(155, 41);
            this.buttonLogOut.TabIndex = 2;
            this.buttonLogOut.Text = "Kilépés";
            this.buttonLogOut.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonLogOut);
            this.Controls.Add(this.buttonToAppointments);
            this.Controls.Add(this.buttonToBoardgamesForm);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonToBoardgamesForm;
        private System.Windows.Forms.Button buttonToAppointments;
        private System.Windows.Forms.Button buttonLogOut;
    }
}