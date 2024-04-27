namespace Tarsasok_Asztali_Alkalmazas
{
    partial class EmployeeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeForm));
            this.listBoxEmployees = new System.Windows.Forms.ListBox();
            this.groupBoxEmployees = new System.Windows.Forms.GroupBox();
            this.textBoxPasswordEmployee = new System.Windows.Forms.TextBox();
            this.textBoxEmailEmployee = new System.Windows.Forms.TextBox();
            this.textBoxNameEmployee = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxIdEmployee = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonRefreshListEmloyee = new System.Windows.Forms.Button();
            this.buttonAddEmployee = new System.Windows.Forms.Button();
            this.buttonUpdateEmployee = new System.Windows.Forms.Button();
            this.buttonDeleteEmployee = new System.Windows.Forms.Button();
            this.groupBoxEmployees.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxEmployees
            // 
            this.listBoxEmployees.BackColor = System.Drawing.SystemColors.ControlLight;
            this.listBoxEmployees.Dock = System.Windows.Forms.DockStyle.Left;
            this.listBoxEmployees.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listBoxEmployees.FormattingEnabled = true;
            this.listBoxEmployees.ItemHeight = 16;
            this.listBoxEmployees.Location = new System.Drawing.Point(0, 0);
            this.listBoxEmployees.Name = "listBoxEmployees";
            this.listBoxEmployees.Size = new System.Drawing.Size(359, 485);
            this.listBoxEmployees.TabIndex = 0;
            this.listBoxEmployees.SelectedIndexChanged += new System.EventHandler(this.listBoxEmployees_SelectedIndexChanged);
            // 
            // groupBoxEmployees
            // 
            this.groupBoxEmployees.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBoxEmployees.BackgroundImage")));
            this.groupBoxEmployees.Controls.Add(this.textBoxPasswordEmployee);
            this.groupBoxEmployees.Controls.Add(this.textBoxEmailEmployee);
            this.groupBoxEmployees.Controls.Add(this.textBoxNameEmployee);
            this.groupBoxEmployees.Controls.Add(this.label4);
            this.groupBoxEmployees.Controls.Add(this.label3);
            this.groupBoxEmployees.Controls.Add(this.label2);
            this.groupBoxEmployees.Controls.Add(this.textBoxIdEmployee);
            this.groupBoxEmployees.Controls.Add(this.label1);
            this.groupBoxEmployees.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxEmployees.Location = new System.Drawing.Point(359, 0);
            this.groupBoxEmployees.Name = "groupBoxEmployees";
            this.groupBoxEmployees.Size = new System.Drawing.Size(441, 301);
            this.groupBoxEmployees.TabIndex = 1;
            this.groupBoxEmployees.TabStop = false;
            // 
            // textBoxPasswordEmployee
            // 
            this.textBoxPasswordEmployee.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxPasswordEmployee.Location = new System.Drawing.Point(175, 200);
            this.textBoxPasswordEmployee.Name = "textBoxPasswordEmployee";
            this.textBoxPasswordEmployee.Size = new System.Drawing.Size(211, 22);
            this.textBoxPasswordEmployee.TabIndex = 7;
            // 
            // textBoxEmailEmployee
            // 
            this.textBoxEmailEmployee.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxEmailEmployee.Location = new System.Drawing.Point(175, 148);
            this.textBoxEmailEmployee.Name = "textBoxEmailEmployee";
            this.textBoxEmailEmployee.Size = new System.Drawing.Size(211, 22);
            this.textBoxEmailEmployee.TabIndex = 6;
            // 
            // textBoxNameEmployee
            // 
            this.textBoxNameEmployee.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxNameEmployee.Location = new System.Drawing.Point(175, 97);
            this.textBoxNameEmployee.Name = "textBoxNameEmployee";
            this.textBoxNameEmployee.Size = new System.Drawing.Size(211, 22);
            this.textBoxNameEmployee.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(29, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(54, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Email:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(53, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name:";
            // 
            // textBoxIdEmployee
            // 
            this.textBoxIdEmployee.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxIdEmployee.Location = new System.Drawing.Point(175, 50);
            this.textBoxIdEmployee.Name = "textBoxIdEmployee";
            this.textBoxIdEmployee.ReadOnly = true;
            this.textBoxIdEmployee.Size = new System.Drawing.Size(112, 22);
            this.textBoxIdEmployee.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(78, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id:";
            // 
            // buttonRefreshListEmloyee
            // 
            this.buttonRefreshListEmloyee.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonRefreshListEmloyee.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonRefreshListEmloyee.Location = new System.Drawing.Point(441, 323);
            this.buttonRefreshListEmloyee.Name = "buttonRefreshListEmloyee";
            this.buttonRefreshListEmloyee.Size = new System.Drawing.Size(108, 48);
            this.buttonRefreshListEmloyee.TabIndex = 2;
            this.buttonRefreshListEmloyee.Text = "Refresh List";
            this.buttonRefreshListEmloyee.UseVisualStyleBackColor = false;
            this.buttonRefreshListEmloyee.Click += new System.EventHandler(this.buttonRefreshListEmloyee_Click);
            // 
            // buttonAddEmployee
            // 
            this.buttonAddEmployee.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonAddEmployee.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonAddEmployee.Location = new System.Drawing.Point(609, 323);
            this.buttonAddEmployee.Name = "buttonAddEmployee";
            this.buttonAddEmployee.Size = new System.Drawing.Size(108, 48);
            this.buttonAddEmployee.TabIndex = 3;
            this.buttonAddEmployee.Text = "Add";
            this.buttonAddEmployee.UseVisualStyleBackColor = false;
            this.buttonAddEmployee.Click += new System.EventHandler(this.buttonAddEmployee_Click);
            // 
            // buttonUpdateEmployee
            // 
            this.buttonUpdateEmployee.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonUpdateEmployee.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonUpdateEmployee.Location = new System.Drawing.Point(441, 404);
            this.buttonUpdateEmployee.Name = "buttonUpdateEmployee";
            this.buttonUpdateEmployee.Size = new System.Drawing.Size(108, 48);
            this.buttonUpdateEmployee.TabIndex = 4;
            this.buttonUpdateEmployee.Text = "Update";
            this.buttonUpdateEmployee.UseVisualStyleBackColor = false;
            this.buttonUpdateEmployee.Click += new System.EventHandler(this.buttonUpdateEmployee_Click);
            // 
            // buttonDeleteEmployee
            // 
            this.buttonDeleteEmployee.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonDeleteEmployee.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonDeleteEmployee.ForeColor = System.Drawing.Color.Red;
            this.buttonDeleteEmployee.Location = new System.Drawing.Point(609, 404);
            this.buttonDeleteEmployee.Name = "buttonDeleteEmployee";
            this.buttonDeleteEmployee.Size = new System.Drawing.Size(108, 48);
            this.buttonDeleteEmployee.TabIndex = 5;
            this.buttonDeleteEmployee.Text = "Delete";
            this.buttonDeleteEmployee.UseVisualStyleBackColor = false;
            this.buttonDeleteEmployee.Click += new System.EventHandler(this.buttonDeleteEmployee_Click);
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 485);
            this.Controls.Add(this.buttonDeleteEmployee);
            this.Controls.Add(this.buttonUpdateEmployee);
            this.Controls.Add(this.buttonAddEmployee);
            this.Controls.Add(this.buttonRefreshListEmloyee);
            this.Controls.Add(this.groupBoxEmployees);
            this.Controls.Add(this.listBoxEmployees);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(816, 524);
            this.MinimumSize = new System.Drawing.Size(816, 524);
            this.Name = "EmployeeForm";
            this.Text = "Employees";
            this.Load += new System.EventHandler(this.EmployeeForm_Load);
            this.groupBoxEmployees.ResumeLayout(false);
            this.groupBoxEmployees.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxEmployees;
        private System.Windows.Forms.GroupBox groupBoxEmployees;
        private System.Windows.Forms.TextBox textBoxIdEmployee;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxEmailEmployee;
        private System.Windows.Forms.TextBox textBoxNameEmployee;
        private System.Windows.Forms.TextBox textBoxPasswordEmployee;
        private System.Windows.Forms.Button buttonRefreshListEmloyee;
        private System.Windows.Forms.Button buttonAddEmployee;
        private System.Windows.Forms.Button buttonUpdateEmployee;
        private System.Windows.Forms.Button buttonDeleteEmployee;
    }
}