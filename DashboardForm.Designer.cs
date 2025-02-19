namespace WindowsFormsApp1
{
    partial class DashboardForm
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
            this.CourseFormBtn = new System.Windows.Forms.Button();
            this.StudentFormBtn = new System.Windows.Forms.Button();
            this.EnrollmentFormBtn = new System.Windows.Forms.Button();
            this.GradesFormBtn = new System.Windows.Forms.Button();
            this.LogoutBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // CourseFormBtn
            // 
            this.CourseFormBtn.Location = new System.Drawing.Point(203, 155);
            this.CourseFormBtn.Name = "CourseFormBtn";
            this.CourseFormBtn.Size = new System.Drawing.Size(137, 110);
            this.CourseFormBtn.TabIndex = 1;
            this.CourseFormBtn.Text = "Course Form";
            this.CourseFormBtn.UseVisualStyleBackColor = true;
            this.CourseFormBtn.Click += new System.EventHandler(this.CourseFormBtn_Click);
            // 
            // StudentFormBtn
            // 
            this.StudentFormBtn.Location = new System.Drawing.Point(39, 155);
            this.StudentFormBtn.Name = "StudentFormBtn";
            this.StudentFormBtn.Size = new System.Drawing.Size(137, 110);
            this.StudentFormBtn.TabIndex = 2;
            this.StudentFormBtn.Text = "Student Form";
            this.StudentFormBtn.UseVisualStyleBackColor = true;
            this.StudentFormBtn.Click += new System.EventHandler(this.StudentFormBtn_Click);
            // 
            // EnrollmentFormBtn
            // 
            this.EnrollmentFormBtn.Location = new System.Drawing.Point(367, 155);
            this.EnrollmentFormBtn.Name = "EnrollmentFormBtn";
            this.EnrollmentFormBtn.Size = new System.Drawing.Size(137, 110);
            this.EnrollmentFormBtn.TabIndex = 3;
            this.EnrollmentFormBtn.Text = "Enrollment Form";
            this.EnrollmentFormBtn.UseVisualStyleBackColor = true;
            this.EnrollmentFormBtn.Click += new System.EventHandler(this.EnrollmentFormBtn_Click);
            // 
            // GradesFormBtn
            // 
            this.GradesFormBtn.Location = new System.Drawing.Point(538, 155);
            this.GradesFormBtn.Name = "GradesFormBtn";
            this.GradesFormBtn.Size = new System.Drawing.Size(137, 110);
            this.GradesFormBtn.TabIndex = 4;
            this.GradesFormBtn.Text = "Grades Form";
            this.GradesFormBtn.UseVisualStyleBackColor = true;
            this.GradesFormBtn.Click += new System.EventHandler(this.GradesFormBtn_Click);
            // 
            // LogoutBtn
            // 
            this.LogoutBtn.Location = new System.Drawing.Point(519, 391);
            this.LogoutBtn.Name = "LogoutBtn";
            this.LogoutBtn.Size = new System.Drawing.Size(137, 33);
            this.LogoutBtn.TabIndex = 5;
            this.LogoutBtn.Text = "Log Out";
            this.LogoutBtn.UseVisualStyleBackColor = true;
            this.LogoutBtn.Click += new System.EventHandler(this.LogoutBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(258, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Total Students :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(355, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "label1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(258, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Total Enroll :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(355, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "label5";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(640, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "label3";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.White;
            this.linkLabel1.Location = new System.Drawing.Point(49, 353);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(88, 13);
            this.linkLabel1.TabIndex = 13;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Print Report Card";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(709, 450);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LogoutBtn);
            this.Controls.Add(this.GradesFormBtn);
            this.Controls.Add(this.EnrollmentFormBtn);
            this.Controls.Add(this.StudentFormBtn);
            this.Controls.Add(this.CourseFormBtn);
            this.Name = "DashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DashboardForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CourseFormBtn;
        private System.Windows.Forms.Button StudentFormBtn;
        private System.Windows.Forms.Button EnrollmentFormBtn;
        private System.Windows.Forms.Button GradesFormBtn;
        private System.Windows.Forms.Button LogoutBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}