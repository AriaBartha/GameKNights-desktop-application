namespace Tarsasok_Asztali_Alkalmazas
{
    partial class MyAppointmentsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyAppointmentsForm));
            this.listBoxMyAppointments = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxAppointment = new System.Windows.Forms.TextBox();
            this.textBoxPlayers = new System.Windows.Forms.TextBox();
            this.textBoxGuest = new System.Windows.Forms.TextBox();
            this.textBoxBoardGame = new System.Windows.Forms.TextBox();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxMyAppointments
            // 
            this.listBoxMyAppointments.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.listBoxMyAppointments.Dock = System.Windows.Forms.DockStyle.Left;
            this.listBoxMyAppointments.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listBoxMyAppointments.FormattingEnabled = true;
            this.listBoxMyAppointments.ItemHeight = 16;
            this.listBoxMyAppointments.Location = new System.Drawing.Point(0, 0);
            this.listBoxMyAppointments.Name = "listBoxMyAppointments";
            this.listBoxMyAppointments.Size = new System.Drawing.Size(311, 485);
            this.listBoxMyAppointments.TabIndex = 0;
            this.listBoxMyAppointments.SelectedIndexChanged += new System.EventHandler(this.listBoxMyAppointments_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(361, 222);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Board Game:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(399, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Guest:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(329, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Number of players:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(364, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Appointment:";
            // 
            // textBoxAppointment
            // 
            this.textBoxAppointment.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.textBoxAppointment.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxAppointment.Location = new System.Drawing.Point(505, 56);
            this.textBoxAppointment.Name = "textBoxAppointment";
            this.textBoxAppointment.ReadOnly = true;
            this.textBoxAppointment.Size = new System.Drawing.Size(160, 22);
            this.textBoxAppointment.TabIndex = 5;
            // 
            // textBoxPlayers
            // 
            this.textBoxPlayers.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.textBoxPlayers.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxPlayers.Location = new System.Drawing.Point(505, 107);
            this.textBoxPlayers.Name = "textBoxPlayers";
            this.textBoxPlayers.ReadOnly = true;
            this.textBoxPlayers.Size = new System.Drawing.Size(160, 22);
            this.textBoxPlayers.TabIndex = 6;
            // 
            // textBoxGuest
            // 
            this.textBoxGuest.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.textBoxGuest.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxGuest.Location = new System.Drawing.Point(505, 163);
            this.textBoxGuest.Name = "textBoxGuest";
            this.textBoxGuest.ReadOnly = true;
            this.textBoxGuest.Size = new System.Drawing.Size(160, 22);
            this.textBoxGuest.TabIndex = 7;
            // 
            // textBoxBoardGame
            // 
            this.textBoxBoardGame.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.textBoxBoardGame.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxBoardGame.Location = new System.Drawing.Point(505, 222);
            this.textBoxBoardGame.Name = "textBoxBoardGame";
            this.textBoxBoardGame.ReadOnly = true;
            this.textBoxBoardGame.Size = new System.Drawing.Size(160, 22);
            this.textBoxBoardGame.TabIndex = 8;
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.BackColor = System.Drawing.Color.LightSalmon;
            this.buttonRefresh.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonRefresh.Location = new System.Drawing.Point(441, 319);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(118, 50);
            this.buttonRefresh.TabIndex = 9;
            this.buttonRefresh.Text = "Refresh List";
            this.buttonRefresh.UseVisualStyleBackColor = false;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // MyAppointmentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 485);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.textBoxBoardGame);
            this.Controls.Add(this.textBoxGuest);
            this.Controls.Add(this.textBoxPlayers);
            this.Controls.Add(this.textBoxAppointment);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxMyAppointments);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(816, 524);
            this.MinimumSize = new System.Drawing.Size(816, 524);
            this.Name = "MyAppointmentsForm";
            this.Text = "My Appointments ";
            this.Load += new System.EventHandler(this.MyAppointmentsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxMyAppointments;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxAppointment;
        private System.Windows.Forms.TextBox textBoxPlayers;
        private System.Windows.Forms.TextBox textBoxGuest;
        private System.Windows.Forms.TextBox textBoxBoardGame;
        private System.Windows.Forms.Button buttonRefresh;
    }
}