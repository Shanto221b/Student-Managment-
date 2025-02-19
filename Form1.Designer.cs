namespace WindowsFormsApp1
{
    partial class Form1
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
            this.ID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.IdTextBox = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.LoginBtn = new System.Windows.Forms.Button();
            this.CreateBtn = new System.Windows.Forms.Button();
            this.ShowAllAdmins_dataGridview = new System.Windows.Forms.DataGridView();
            this.ShowAdminBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ShowAllAdmins_dataGridview)).BeginInit();
            this.SuspendLayout();
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Location = new System.Drawing.Point(347, 160);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(18, 13);
            this.ID.TabIndex = 0;
            this.ID.Text = "ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(338, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Password";
            // 
            // IdTextBox
            // 
            this.IdTextBox.Location = new System.Drawing.Point(420, 153);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.Size = new System.Drawing.Size(178, 20);
            this.IdTextBox.TabIndex = 2;
            this.IdTextBox.TextChanged += new System.EventHandler(this.IdTextBox_TextChanged);
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(420, 203);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(178, 20);
            this.Password.TabIndex = 3;
            this.Password.TextChanged += new System.EventHandler(this.Password_TextChanged);
            // 
            // LoginBtn
            // 
            this.LoginBtn.Location = new System.Drawing.Point(377, 280);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LoginBtn.Size = new System.Drawing.Size(75, 23);
            this.LoginBtn.TabIndex = 4;
            this.LoginBtn.Text = "Login";
            this.LoginBtn.UseVisualStyleBackColor = true;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // CreateBtn
            // 
            this.CreateBtn.Location = new System.Drawing.Point(474, 280);
            this.CreateBtn.Name = "CreateBtn";
            this.CreateBtn.Size = new System.Drawing.Size(75, 23);
            this.CreateBtn.TabIndex = 5;
            this.CreateBtn.Text = "Create";
            this.CreateBtn.UseVisualStyleBackColor = true;
            this.CreateBtn.Click += new System.EventHandler(this.CreateBtn_Click);
            // 
            // ShowAllAdmins_dataGridview
            // 
            this.ShowAllAdmins_dataGridview.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.ShowAllAdmins_dataGridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ShowAllAdmins_dataGridview.GridColor = System.Drawing.SystemColors.Highlight;
            this.ShowAllAdmins_dataGridview.Location = new System.Drawing.Point(34, 153);
            this.ShowAllAdmins_dataGridview.Name = "ShowAllAdmins_dataGridview";
            this.ShowAllAdmins_dataGridview.Size = new System.Drawing.Size(240, 150);
            this.ShowAllAdmins_dataGridview.TabIndex = 6;
            this.ShowAllAdmins_dataGridview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ShowAllAdmins_dataGridview_CellContentClick);
            // 
            // ShowAdminBtn
            // 
            this.ShowAdminBtn.Location = new System.Drawing.Point(59, 124);
            this.ShowAdminBtn.Name = "ShowAdminBtn";
            this.ShowAdminBtn.Size = new System.Drawing.Size(182, 23);
            this.ShowAdminBtn.TabIndex = 7;
            this.ShowAdminBtn.Text = "Show Admins";
            this.ShowAdminBtn.UseVisualStyleBackColor = true;
            this.ShowAdminBtn.Click += new System.EventHandler(this.ShowAdminBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(657, 432);
            this.Controls.Add(this.ShowAdminBtn);
            this.Controls.Add(this.ShowAllAdmins_dataGridview);
            this.Controls.Add(this.CreateBtn);
            this.Controls.Add(this.LoginBtn);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.IdTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ID);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ShowAllAdmins_dataGridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox IdTextBox;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Button LoginBtn;
        private System.Windows.Forms.Button CreateBtn;
        private System.Windows.Forms.DataGridView ShowAllAdmins_dataGridview;
        private System.Windows.Forms.Button ShowAdminBtn;
    }
}

