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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GuestForm));
            this.dataGridViewGuests = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGuests)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewGuests
            // 
            this.dataGridViewGuests.AllowUserToAddRows = false;
            this.dataGridViewGuests.AllowUserToDeleteRows = false;
            this.dataGridViewGuests.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridViewGuests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGuests.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewGuests.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewGuests.Name = "dataGridViewGuests";
            this.dataGridViewGuests.ReadOnly = true;
            this.dataGridViewGuests.Size = new System.Drawing.Size(933, 556);
            this.dataGridViewGuests.TabIndex = 0;
            // 
            // GuestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 554);
            this.Controls.Add(this.dataGridViewGuests);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(949, 593);
            this.MinimumSize = new System.Drawing.Size(949, 593);
            this.Name = "GuestForm";
            this.Text = "Guests\' Data";
            this.Load += new System.EventHandler(this.GuestForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGuests)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewGuests;
    }
}