namespace WindowsFormsApp1
{
    partial class EnrollmentForm
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
            this.EnrollBtn = new System.Windows.Forms.Button();
            this.Select_StudentID_comboBox = new System.Windows.Forms.ComboBox();
            this.Select_CourseID_comboBox = new System.Windows.Forms.ComboBox();
            this.Enroll_dataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.UnrollBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Enroll_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // EnrollBtn
            // 
            this.EnrollBtn.Location = new System.Drawing.Point(27, 348);
            this.EnrollBtn.Name = "EnrollBtn";
            this.EnrollBtn.Size = new System.Drawing.Size(163, 67);
            this.EnrollBtn.TabIndex = 0;
            this.EnrollBtn.Text = "Enroll";
            this.EnrollBtn.UseVisualStyleBackColor = true;
            this.EnrollBtn.Click += new System.EventHandler(this.EnrollBtn_Click);
            // 
            // Select_StudentID_comboBox
            // 
            this.Select_StudentID_comboBox.FormattingEnabled = true;
            this.Select_StudentID_comboBox.Location = new System.Drawing.Point(134, 168);
            this.Select_StudentID_comboBox.Name = "Select_StudentID_comboBox";
            this.Select_StudentID_comboBox.Size = new System.Drawing.Size(163, 21);
            this.Select_StudentID_comboBox.TabIndex = 1;
            this.Select_StudentID_comboBox.SelectedIndexChanged += new System.EventHandler(this.Seletct_StudentID_comboBox_SelectedIndexChanged);
            // 
            // Select_CourseID_comboBox
            // 
            this.Select_CourseID_comboBox.FormattingEnabled = true;
            this.Select_CourseID_comboBox.Location = new System.Drawing.Point(134, 244);
            this.Select_CourseID_comboBox.Name = "Select_CourseID_comboBox";
            this.Select_CourseID_comboBox.Size = new System.Drawing.Size(163, 21);
            this.Select_CourseID_comboBox.TabIndex = 2;
            this.Select_CourseID_comboBox.SelectedIndexChanged += new System.EventHandler(this.Select_CourseID_comboBox_SelectedIndexChanged);
            // 
            // Enroll_dataGridView
            // 
            this.Enroll_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Enroll_dataGridView.Location = new System.Drawing.Point(397, 95);
            this.Enroll_dataGridView.Name = "Enroll_dataGridView";
            this.Enroll_dataGridView.Size = new System.Drawing.Size(367, 269);
            this.Enroll_dataGridView.TabIndex = 3;
            this.Enroll_dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Enroll_dataGridView_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Select ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 252);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Select Course";
            // 
            // UnrollBtn
            // 
            this.UnrollBtn.Location = new System.Drawing.Point(210, 348);
            this.UnrollBtn.Name = "UnrollBtn";
            this.UnrollBtn.Size = new System.Drawing.Size(163, 67);
            this.UnrollBtn.TabIndex = 6;
            this.UnrollBtn.Text = "Unroll";
            this.UnrollBtn.UseVisualStyleBackColor = true;
            this.UnrollBtn.Click += new System.EventHandler(this.UnrollBtn_Click);
            // 
            // EnrollmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.UnrollBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Enroll_dataGridView);
            this.Controls.Add(this.Select_CourseID_comboBox);
            this.Controls.Add(this.Select_StudentID_comboBox);
            this.Controls.Add(this.EnrollBtn);
            this.Name = "EnrollmentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EnrollmentForm";
            this.Load += new System.EventHandler(this.EnrollmentForm_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.Enroll_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button EnrollBtn;
        private System.Windows.Forms.ComboBox Select_StudentID_comboBox;
        private System.Windows.Forms.ComboBox Select_CourseID_comboBox;
        private System.Windows.Forms.DataGridView Enroll_dataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button UnrollBtn;
    }
}