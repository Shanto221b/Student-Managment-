namespace WindowsFormsApp1
{
    partial class CourseForm
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
            this.CourseID_textBox = new System.Windows.Forms.TextBox();
            this.CourseName_textBox = new System.Windows.Forms.TextBox();
            this.CourseCredit_textBox = new System.Windows.Forms.TextBox();
            this.CourseList_dataGridView = new System.Windows.Forms.DataGridView();
            this.AddCourse_Btn = new System.Windows.Forms.Button();
            this.RemoveCourse_Btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CourseList_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // CourseID_textBox
            // 
            this.CourseID_textBox.Location = new System.Drawing.Point(120, 128);
            this.CourseID_textBox.Name = "CourseID_textBox";
            this.CourseID_textBox.Size = new System.Drawing.Size(144, 20);
            this.CourseID_textBox.TabIndex = 0;
            this.CourseID_textBox.TextChanged += new System.EventHandler(this.CourseID_textBox_TextChanged);
            // 
            // CourseName_textBox
            // 
            this.CourseName_textBox.Location = new System.Drawing.Point(120, 191);
            this.CourseName_textBox.Name = "CourseName_textBox";
            this.CourseName_textBox.Size = new System.Drawing.Size(144, 20);
            this.CourseName_textBox.TabIndex = 1;
            this.CourseName_textBox.TextChanged += new System.EventHandler(this.CourseName_textBox_TextChanged);
            // 
            // CourseCredit_textBox
            // 
            this.CourseCredit_textBox.Location = new System.Drawing.Point(120, 254);
            this.CourseCredit_textBox.Name = "CourseCredit_textBox";
            this.CourseCredit_textBox.Size = new System.Drawing.Size(144, 20);
            this.CourseCredit_textBox.TabIndex = 2;
            this.CourseCredit_textBox.TextChanged += new System.EventHandler(this.CourseCredit_textBox_TextChanged);
            // 
            // CourseList_dataGridView
            // 
            this.CourseList_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CourseList_dataGridView.Location = new System.Drawing.Point(340, 101);
            this.CourseList_dataGridView.Name = "CourseList_dataGridView";
            this.CourseList_dataGridView.Size = new System.Drawing.Size(428, 259);
            this.CourseList_dataGridView.TabIndex = 3;
            this.CourseList_dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CourseList_dataGridView_CellContentClick);
            // 
            // AddCourse_Btn
            // 
            this.AddCourse_Btn.Location = new System.Drawing.Point(42, 341);
            this.AddCourse_Btn.Name = "AddCourse_Btn";
            this.AddCourse_Btn.Size = new System.Drawing.Size(108, 46);
            this.AddCourse_Btn.TabIndex = 4;
            this.AddCourse_Btn.Text = "Add Course";
            this.AddCourse_Btn.UseVisualStyleBackColor = true;
            this.AddCourse_Btn.Click += new System.EventHandler(this.AddCourse_Btn_Click);
            // 
            // RemoveCourse_Btn
            // 
            this.RemoveCourse_Btn.Location = new System.Drawing.Point(181, 341);
            this.RemoveCourse_Btn.Name = "RemoveCourse_Btn";
            this.RemoveCourse_Btn.Size = new System.Drawing.Size(134, 46);
            this.RemoveCourse_Btn.TabIndex = 5;
            this.RemoveCourse_Btn.Text = "Remove Course";
            this.RemoveCourse_Btn.UseVisualStyleBackColor = true;
            this.RemoveCourse_Btn.Click += new System.EventHandler(this.RemoveCourse_Btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Course ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Course Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 257);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Course Credit";
            // 
            // CourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RemoveCourse_Btn);
            this.Controls.Add(this.AddCourse_Btn);
            this.Controls.Add(this.CourseList_dataGridView);
            this.Controls.Add(this.CourseCredit_textBox);
            this.Controls.Add(this.CourseName_textBox);
            this.Controls.Add(this.CourseID_textBox);
            this.Name = "CourseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CourseForm";
            ((System.ComponentModel.ISupportInitialize)(this.CourseList_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CourseID_textBox;
        private System.Windows.Forms.TextBox CourseName_textBox;
        private System.Windows.Forms.TextBox CourseCredit_textBox;
        private System.Windows.Forms.DataGridView CourseList_dataGridView;
        private System.Windows.Forms.Button AddCourse_Btn;
        private System.Windows.Forms.Button RemoveCourse_Btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}