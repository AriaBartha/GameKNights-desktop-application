using System.Drawing;

namespace Tarsasok_Asztali_Alkalmazas
{
    partial class BoardGamesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BoardGamesForm));
            this.listBoxBoardGames = new System.Windows.Forms.ListBox();
            this.buttonAddBG = new System.Windows.Forms.Button();
            this.buttonUpdateBG = new System.Windows.Forms.Button();
            this.buttonRefreshListBG = new System.Windows.Forms.Button();
            this.buttonDeleteBG = new System.Windows.Forms.Button();
            this.groupBoxBG = new System.Windows.Forms.GroupBox();
            this.nuMaxPlayerBG = new System.Windows.Forms.NumericUpDown();
            this.nuMinPlayerBG = new System.Windows.Forms.NumericUpDown();
            this.richTextBoxDescriptionBG = new System.Windows.Forms.RichTextBox();
            this.textBoxNameBG = new System.Windows.Forms.TextBox();
            this.textBoxIdBG = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxBG.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuMaxPlayerBG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuMinPlayerBG)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxBoardGames
            // 
            this.listBoxBoardGames.BackColor = System.Drawing.SystemColors.Window;
            this.listBoxBoardGames.Dock = System.Windows.Forms.DockStyle.Left;
            this.listBoxBoardGames.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listBoxBoardGames.FormattingEnabled = true;
            this.listBoxBoardGames.ItemHeight = 16;
            this.listBoxBoardGames.Location = new System.Drawing.Point(0, 0);
            this.listBoxBoardGames.Name = "listBoxBoardGames";
            this.listBoxBoardGames.Size = new System.Drawing.Size(276, 485);
            this.listBoxBoardGames.TabIndex = 0;
            this.listBoxBoardGames.SelectedIndexChanged += new System.EventHandler(this.listBoxBoardGames_SelectedIndexChanged);
            // 
            // buttonAddBG
            // 
            this.buttonAddBG.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonAddBG.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonAddBG.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(51)))), ((int)(((byte)(43)))));
            this.buttonAddBG.Location = new System.Drawing.Point(421, 440);
            this.buttonAddBG.Name = "buttonAddBG";
            this.buttonAddBG.Size = new System.Drawing.Size(106, 29);
            this.buttonAddBG.TabIndex = 1;
            this.buttonAddBG.Text = "Add";
            this.buttonAddBG.UseVisualStyleBackColor = false;
            this.buttonAddBG.Click += new System.EventHandler(this.buttonAddBG_Click);
            // 
            // buttonUpdateBG
            // 
            this.buttonUpdateBG.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonUpdateBG.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonUpdateBG.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(51)))), ((int)(((byte)(43)))));
            this.buttonUpdateBG.Location = new System.Drawing.Point(550, 440);
            this.buttonUpdateBG.Name = "buttonUpdateBG";
            this.buttonUpdateBG.Size = new System.Drawing.Size(92, 29);
            this.buttonUpdateBG.TabIndex = 2;
            this.buttonUpdateBG.Text = "Update";
            this.buttonUpdateBG.UseVisualStyleBackColor = false;
            this.buttonUpdateBG.Click += new System.EventHandler(this.buttonUpdateBG_Click);
            // 
            // buttonRefreshListBG
            // 
            this.buttonRefreshListBG.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonRefreshListBG.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonRefreshListBG.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(51)))), ((int)(((byte)(43)))));
            this.buttonRefreshListBG.Location = new System.Drawing.Point(290, 440);
            this.buttonRefreshListBG.Name = "buttonRefreshListBG";
            this.buttonRefreshListBG.Size = new System.Drawing.Size(115, 29);
            this.buttonRefreshListBG.TabIndex = 3;
            this.buttonRefreshListBG.Text = "Refresh List";
            this.buttonRefreshListBG.UseVisualStyleBackColor = false;
            this.buttonRefreshListBG.Click += new System.EventHandler(this.buttonRefreshListBG_Click);
            // 
            // buttonDeleteBG
            // 
            this.buttonDeleteBG.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonDeleteBG.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonDeleteBG.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(51)))), ((int)(((byte)(43)))));
            this.buttonDeleteBG.Location = new System.Drawing.Point(670, 440);
            this.buttonDeleteBG.Name = "buttonDeleteBG";
            this.buttonDeleteBG.Size = new System.Drawing.Size(92, 29);
            this.buttonDeleteBG.TabIndex = 4;
            this.buttonDeleteBG.Text = "Delete";
            this.buttonDeleteBG.UseVisualStyleBackColor = false;
            this.buttonDeleteBG.Click += new System.EventHandler(this.buttonDeleteBG_Click);
            // 
            // groupBoxBG
            // 
            this.groupBoxBG.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBoxBG.Controls.Add(this.nuMaxPlayerBG);
            this.groupBoxBG.Controls.Add(this.nuMinPlayerBG);
            this.groupBoxBG.Controls.Add(this.richTextBoxDescriptionBG);
            this.groupBoxBG.Controls.Add(this.textBoxNameBG);
            this.groupBoxBG.Controls.Add(this.textBoxIdBG);
            this.groupBoxBG.Controls.Add(this.label5);
            this.groupBoxBG.Controls.Add(this.label4);
            this.groupBoxBG.Controls.Add(this.label3);
            this.groupBoxBG.Controls.Add(this.label2);
            this.groupBoxBG.Controls.Add(this.label1);
            this.groupBoxBG.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxBG.Location = new System.Drawing.Point(276, 0);
            this.groupBoxBG.Name = "groupBoxBG";
            this.groupBoxBG.Size = new System.Drawing.Size(524, 405);
            this.groupBoxBG.TabIndex = 5;
            this.groupBoxBG.TabStop = false;
            // 
            // nuMaxPlayerBG
            // 
            this.nuMaxPlayerBG.BackColor = System.Drawing.SystemColors.Control;
            this.nuMaxPlayerBG.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nuMaxPlayerBG.Location = new System.Drawing.Point(131, 126);
            this.nuMaxPlayerBG.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nuMaxPlayerBG.Name = "nuMaxPlayerBG";
            this.nuMaxPlayerBG.Size = new System.Drawing.Size(120, 20);
            this.nuMaxPlayerBG.TabIndex = 19;
            this.nuMaxPlayerBG.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nuMinPlayerBG
            // 
            this.nuMinPlayerBG.BackColor = System.Drawing.SystemColors.Control;
            this.nuMinPlayerBG.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nuMinPlayerBG.Location = new System.Drawing.Point(131, 92);
            this.nuMinPlayerBG.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nuMinPlayerBG.Name = "nuMinPlayerBG";
            this.nuMinPlayerBG.Size = new System.Drawing.Size(120, 20);
            this.nuMinPlayerBG.TabIndex = 18;
            this.nuMinPlayerBG.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // richTextBoxDescriptionBG
            // 
            this.richTextBoxDescriptionBG.BackColor = System.Drawing.SystemColors.Control;
            this.richTextBoxDescriptionBG.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.richTextBoxDescriptionBG.Location = new System.Drawing.Point(127, 163);
            this.richTextBoxDescriptionBG.Name = "richTextBoxDescriptionBG";
            this.richTextBoxDescriptionBG.Size = new System.Drawing.Size(331, 219);
            this.richTextBoxDescriptionBG.TabIndex = 17;
            this.richTextBoxDescriptionBG.Text = "";
            // 
            // textBoxNameBG
            // 
            this.textBoxNameBG.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxNameBG.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxNameBG.Location = new System.Drawing.Point(131, 57);
            this.textBoxNameBG.Name = "textBoxNameBG";
            this.textBoxNameBG.Size = new System.Drawing.Size(327, 22);
            this.textBoxNameBG.TabIndex = 16;
            // 
            // textBoxIdBG
            // 
            this.textBoxIdBG.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxIdBG.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxIdBG.Location = new System.Drawing.Point(131, 27);
            this.textBoxIdBG.Name = "textBoxIdBG";
            this.textBoxIdBG.ReadOnly = true;
            this.textBoxIdBG.Size = new System.Drawing.Size(100, 22);
            this.textBoxIdBG.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(51)))), ((int)(((byte)(43)))));
            this.label5.Location = new System.Drawing.Point(43, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "Description:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(51)))), ((int)(((byte)(43)))));
            this.label4.Location = new System.Drawing.Point(43, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Max. players:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(51)))), ((int)(((byte)(43)))));
            this.label3.Location = new System.Drawing.Point(43, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Min. players:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(51)))), ((int)(((byte)(43)))));
            this.label2.Location = new System.Drawing.Point(43, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(51)))), ((int)(((byte)(43)))));
            this.label1.Location = new System.Drawing.Point(43, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Id:";
            // 
            // BoardGamesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(800, 485);
            this.Controls.Add(this.groupBoxBG);
            this.Controls.Add(this.buttonDeleteBG);
            this.Controls.Add(this.buttonRefreshListBG);
            this.Controls.Add(this.buttonUpdateBG);
            this.Controls.Add(this.buttonAddBG);
            this.Controls.Add(this.listBoxBoardGames);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BoardGamesForm";
            this.Text = "Board Games";
            this.Load += new System.EventHandler(this.BoardGamesForm_Load);
            this.groupBoxBG.ResumeLayout(false);
            this.groupBoxBG.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuMaxPlayerBG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuMinPlayerBG)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxBoardGames;
        private System.Windows.Forms.Button buttonAddBG;
        private System.Windows.Forms.Button buttonUpdateBG;
        private System.Windows.Forms.Button buttonRefreshListBG;
        private System.Windows.Forms.Button buttonDeleteBG;
        private System.Windows.Forms.GroupBox groupBoxBG;
        private System.Windows.Forms.NumericUpDown nuMaxPlayerBG;
        private System.Windows.Forms.NumericUpDown nuMinPlayerBG;
        private System.Windows.Forms.RichTextBox richTextBoxDescriptionBG;
        private System.Windows.Forms.TextBox textBoxNameBG;
        private System.Windows.Forms.TextBox textBoxIdBG;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}