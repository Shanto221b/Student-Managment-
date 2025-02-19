namespace WindowsFormsApp1
{
    partial class PrintReport
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
            this.ID_txtBox = new System.Windows.Forms.TextBox();
            this.SrchStudentTB = new System.Windows.Forms.Label();
            this.Result_dataGridView = new System.Windows.Forms.DataGridView();
            this.PrintBtn = new System.Windows.Forms.Button();
            this.SearchBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Result_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ID_txtBox
            // 
            this.ID_txtBox.Location = new System.Drawing.Point(296, 96);
            this.ID_txtBox.Name = "ID_txtBox";
            this.ID_txtBox.Size = new System.Drawing.Size(233, 20);
            this.ID_txtBox.TabIndex = 0;
            // 
            // SrchStudentTB
            // 
            this.SrchStudentTB.AutoSize = true;
            this.SrchStudentTB.Location = new System.Drawing.Point(195, 99);
            this.SrchStudentTB.Name = "SrchStudentTB";
            this.SrchStudentTB.Size = new System.Drawing.Size(95, 13);
            this.SrchStudentTB.TabIndex = 1;
            this.SrchStudentTB.Text = "Search Student ID";
            // 
            // Result_dataGridView
            // 
            this.Result_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Result_dataGridView.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.Result_dataGridView.Location = new System.Drawing.Point(109, 142);
            this.Result_dataGridView.Name = "Result_dataGridView";
            this.Result_dataGridView.Size = new System.Drawing.Size(600, 193);
            this.Result_dataGridView.TabIndex = 2;
            this.Result_dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Result_dataGridView_CellContentClick);
            // 
            // PrintBtn
            // 
            this.PrintBtn.Location = new System.Drawing.Point(342, 353);
            this.PrintBtn.Name = "PrintBtn";
            this.PrintBtn.Size = new System.Drawing.Size(158, 45);
            this.PrintBtn.TabIndex = 3;
            this.PrintBtn.Text = "Print";
            this.PrintBtn.UseVisualStyleBackColor = true;
            this.PrintBtn.Click += new System.EventHandler(this.PrintBtn_Click);
            // 
            // SearchBtn
            // 
            this.SearchBtn.Location = new System.Drawing.Point(535, 85);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(92, 41);
            this.SearchBtn.TabIndex = 4;
            this.SearchBtn.Text = "Search";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // PrintReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.PrintBtn);
            this.Controls.Add(this.Result_dataGridView);
            this.Controls.Add(this.SrchStudentTB);
            this.Controls.Add(this.ID_txtBox);
            this.Name = "PrintReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PrintReport";
            ((System.ComponentModel.ISupportInitialize)(this.Result_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ID_txtBox;
        private System.Windows.Forms.Label SrchStudentTB;
        private System.Windows.Forms.DataGridView Result_dataGridView;
        private System.Windows.Forms.Button PrintBtn;
        private System.Windows.Forms.Button SearchBtn;
    }
}