namespace Tarsasok_Asztali_Alkalmazas
{
    partial class BoardGamesActionsForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxIdBG = new System.Windows.Forms.TextBox();
            this.textBoxNameBG = new System.Windows.Forms.TextBox();
            this.richTextBoxDescriptionBG = new System.Windows.Forms.RichTextBox();
            this.nuMinPlayerBG = new System.Windows.Forms.NumericUpDown();
            this.nuMaxPlayerBG = new System.Windows.Forms.NumericUpDown();
            this.buttonActionBG = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nuMinPlayerBG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuMaxPlayerBG)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(79, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(79, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(79, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Min. players:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(79, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Max. players:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(79, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Description:";
            // 
            // textBoxIdBG
            // 
            this.textBoxIdBG.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxIdBG.Location = new System.Drawing.Point(167, 37);
            this.textBoxIdBG.Name = "textBoxIdBG";
            this.textBoxIdBG.ReadOnly = true;
            this.textBoxIdBG.Size = new System.Drawing.Size(100, 22);
            this.textBoxIdBG.TabIndex = 5;
            // 
            // textBoxNameBG
            // 
            this.textBoxNameBG.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxNameBG.Location = new System.Drawing.Point(167, 65);
            this.textBoxNameBG.Name = "textBoxNameBG";
            this.textBoxNameBG.Size = new System.Drawing.Size(327, 22);
            this.textBoxNameBG.TabIndex = 6;
            // 
            // richTextBoxDescriptionBG
            // 
            this.richTextBoxDescriptionBG.Location = new System.Drawing.Point(163, 163);
            this.richTextBoxDescriptionBG.Name = "richTextBoxDescriptionBG";
            this.richTextBoxDescriptionBG.Size = new System.Drawing.Size(331, 168);
            this.richTextBoxDescriptionBG.TabIndex = 7;
            this.richTextBoxDescriptionBG.Text = "";
            // 
            // nuMinPlayerBG
            // 
            this.nuMinPlayerBG.Location = new System.Drawing.Point(167, 97);
            this.nuMinPlayerBG.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nuMinPlayerBG.Name = "nuMinPlayerBG";
            this.nuMinPlayerBG.Size = new System.Drawing.Size(120, 20);
            this.nuMinPlayerBG.TabIndex = 8;
            this.nuMinPlayerBG.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nuMaxPlayerBG
            // 
            this.nuMaxPlayerBG.Location = new System.Drawing.Point(167, 129);
            this.nuMaxPlayerBG.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nuMaxPlayerBG.Name = "nuMaxPlayerBG";
            this.nuMaxPlayerBG.Size = new System.Drawing.Size(120, 20);
            this.nuMaxPlayerBG.TabIndex = 9;
            this.nuMaxPlayerBG.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // buttonActionBG
            // 
            this.buttonActionBG.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonActionBG.Location = new System.Drawing.Point(278, 369);
            this.buttonActionBG.Name = "buttonActionBG";
            this.buttonActionBG.Size = new System.Drawing.Size(107, 44);
            this.buttonActionBG.TabIndex = 10;
            this.buttonActionBG.Text = "button1";
            this.buttonActionBG.UseVisualStyleBackColor = true;
            // 
            // BoardGamesActionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonActionBG);
            this.Controls.Add(this.nuMaxPlayerBG);
            this.Controls.Add(this.nuMinPlayerBG);
            this.Controls.Add(this.richTextBoxDescriptionBG);
            this.Controls.Add(this.textBoxNameBG);
            this.Controls.Add(this.textBoxIdBG);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "BoardGamesActionsForm";
            this.Text = "BoardGamesActionsForm";
            ((System.ComponentModel.ISupportInitialize)(this.nuMinPlayerBG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuMaxPlayerBG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxIdBG;
        private System.Windows.Forms.TextBox textBoxNameBG;
        private System.Windows.Forms.RichTextBox richTextBoxDescriptionBG;
        private System.Windows.Forms.NumericUpDown nuMinPlayerBG;
        private System.Windows.Forms.NumericUpDown nuMaxPlayerBG;
        private System.Windows.Forms.Button buttonActionBG;
    }
}