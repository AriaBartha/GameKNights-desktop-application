namespace Tarsasok_Asztali_Alkalmazas
{
    partial class GuestForm
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
            this.dataGridViewGuests = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGuests)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewGuests
            // 
            this.dataGridViewGuests.AllowUserToAddRows = false;
            this.dataGridViewGuests.AllowUserToDeleteRows = false;
            this.dataGridViewGuests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGuests.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewGuests.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewGuests.Name = "dataGridViewGuests";
            this.dataGridViewGuests.ReadOnly = true;
            this.dataGridViewGuests.Size = new System.Drawing.Size(800, 450);
            this.dataGridViewGuests.TabIndex = 0;
            // 
            // GuestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewGuests);
            this.Name = "GuestForm";
            this.Text = "GuestForm";
            this.Load += new System.EventHandler(this.GuestForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGuests)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewGuests;
    }
}