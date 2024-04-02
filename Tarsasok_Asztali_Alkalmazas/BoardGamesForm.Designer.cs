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
            this.listBoxBoardGames = new System.Windows.Forms.ListBox();
            this.buttonAddBG = new System.Windows.Forms.Button();
            this.buttonUpdateBG = new System.Windows.Forms.Button();
            this.buttonRefreshListBG = new System.Windows.Forms.Button();
            this.buttonDeleteBG = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxBoardGames
            // 
            this.listBoxBoardGames.Dock = System.Windows.Forms.DockStyle.Left;
            this.listBoxBoardGames.FormattingEnabled = true;
            this.listBoxBoardGames.Location = new System.Drawing.Point(0, 0);
            this.listBoxBoardGames.Name = "listBoxBoardGames";
            this.listBoxBoardGames.Size = new System.Drawing.Size(276, 450);
            this.listBoxBoardGames.TabIndex = 0;
            // 
            // buttonAddBG
            // 
            this.buttonAddBG.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonAddBG.Location = new System.Drawing.Point(329, 42);
            this.buttonAddBG.Name = "buttonAddBG";
            this.buttonAddBG.Size = new System.Drawing.Size(148, 43);
            this.buttonAddBG.TabIndex = 1;
            this.buttonAddBG.Text = "Add";
            this.buttonAddBG.UseVisualStyleBackColor = true;
            // 
            // buttonUpdateBG
            // 
            this.buttonUpdateBG.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonUpdateBG.Location = new System.Drawing.Point(329, 126);
            this.buttonUpdateBG.Name = "buttonUpdateBG";
            this.buttonUpdateBG.Size = new System.Drawing.Size(148, 43);
            this.buttonUpdateBG.TabIndex = 2;
            this.buttonUpdateBG.Text = "Update";
            this.buttonUpdateBG.UseVisualStyleBackColor = true;
            // 
            // buttonRefreshListBG
            // 
            this.buttonRefreshListBG.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonRefreshListBG.Location = new System.Drawing.Point(329, 202);
            this.buttonRefreshListBG.Name = "buttonRefreshListBG";
            this.buttonRefreshListBG.Size = new System.Drawing.Size(148, 43);
            this.buttonRefreshListBG.TabIndex = 3;
            this.buttonRefreshListBG.Text = "Refresh List";
            this.buttonRefreshListBG.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteBG
            // 
            this.buttonDeleteBG.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonDeleteBG.Location = new System.Drawing.Point(329, 285);
            this.buttonDeleteBG.Name = "buttonDeleteBG";
            this.buttonDeleteBG.Size = new System.Drawing.Size(148, 43);
            this.buttonDeleteBG.TabIndex = 4;
            this.buttonDeleteBG.Text = "Delete";
            this.buttonDeleteBG.UseVisualStyleBackColor = true;
            // 
            // BoardGamesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonDeleteBG);
            this.Controls.Add(this.buttonRefreshListBG);
            this.Controls.Add(this.buttonUpdateBG);
            this.Controls.Add(this.buttonAddBG);
            this.Controls.Add(this.listBoxBoardGames);
            this.Name = "BoardGamesForm";
            this.Text = "BoardGamesForm";
            this.Load += new System.EventHandler(this.BoardGamesForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxBoardGames;
        private System.Windows.Forms.Button buttonAddBG;
        private System.Windows.Forms.Button buttonUpdateBG;
        private System.Windows.Forms.Button buttonRefreshListBG;
        private System.Windows.Forms.Button buttonDeleteBG;
    }
}