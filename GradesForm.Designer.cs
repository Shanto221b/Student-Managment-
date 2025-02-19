namespace WindowsFormsApp1
{
    partial class GradesForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Select_CourseID_comboBox = new System.Windows.Forms.ComboBox();
            this.Select_StudentID_comboBox = new System.Windows.Forms.ComboBox();
            this.AddBtn = new System.Windows.Forms.Button();
            this.Grade_comboBox = new System.Windows.Forms.ComboBox();
            this.Grade_dataGridView = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Grade_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Select Course";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Select ID";
            // 
            // Select_CourseID_comboBox
            // 
            this.Select_CourseID_comboBox.FormattingEnabled = true;
            this.Select_CourseID_comboBox.Location = new System.Drawing.Point(143, 184);
            this.Select_CourseID_comboBox.Name = "Select_CourseID_comboBox";
            this.Select_CourseID_comboBox.Size = new System.Drawing.Size(163, 21);
            this.Select_CourseID_comboBox.TabIndex = 7;
            this.Select_CourseID_comboBox.SelectedIndexChanged += new System.EventHandler(this.Select_CourseID_comboBox_SelectedIndexChanged);
            // 
            // Select_StudentID_comboBox
            // 
            this.Select_StudentID_comboBox.FormattingEnabled = true;
            this.Select_StudentID_comboBox.Location = new System.Drawing.Point(143, 108);
            this.Select_StudentID_comboBox.Name = "Select_StudentID_comboBox";
            this.Select_StudentID_comboBox.Size = new System.Drawing.Size(163, 21);
            this.Select_StudentID_comboBox.TabIndex = 6;
            this.Select_StudentID_comboBox.SelectedIndexChanged += new System.EventHandler(this.Select_StudentID_comboBox_SelectedIndexChanged);
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(143, 360);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(148, 65);
            this.AddBtn.TabIndex = 10;
            this.AddBtn.Text = "Add";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // Grade_comboBox
            // 
            this.Grade_comboBox.FormattingEnabled = true;
            this.Grade_comboBox.Location = new System.Drawing.Point(143, 260);
            this.Grade_comboBox.Name = "Grade_comboBox";
            this.Grade_comboBox.Size = new System.Drawing.Size(163, 21);
            this.Grade_comboBox.TabIndex = 11;
            this.Grade_comboBox.SelectedIndexChanged += new System.EventHandler(this.Grade_comboBox_SelectedIndexChanged);
            // 
            // Grade_dataGridView
            // 
            this.Grade_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grade_dataGridView.Location = new System.Drawing.Point(364, 97);
            this.Grade_dataGridView.Name = "Grade_dataGridView";
            this.Grade_dataGridView.Size = new System.Drawing.Size(405, 243);
            this.Grade_dataGridView.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 268);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Grade";
            // 
            // GradesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Grade_dataGridView);
            this.Controls.Add(this.Grade_comboBox);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Select_CourseID_comboBox);
            this.Controls.Add(this.Select_StudentID_comboBox);
            this.Name = "GradesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GradesForm";
            this.Load += new System.EventHandler(this.GradesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grade_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Select_CourseID_comboBox;
        private System.Windows.Forms.ComboBox Select_StudentID_comboBox;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.ComboBox Grade_comboBox;
        private System.Windows.Forms.DataGridView Grade_dataGridView;
        private System.Windows.Forms.Label label3;
    }
}