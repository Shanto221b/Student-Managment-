using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; // Added for database connection

namespace WindowsFormsApp1
{
    public partial class DashboardForm : Form
    {
        private string connectionString = "Data Source=DESKTOP-DMGJN94;Initial Catalog=Student;Integrated Security=True;";

        public DashboardForm()
        {
            InitializeComponent();
            // LoadTotalStudentCount(); // Load total count when the form opens


            UpdateStudentCount(); // Load total count when the form opens
            UpdateEnrollCount();
            {
                string connectionString = @"Server=DESKTOP-DMGJN94;Database=Student;Integrated Security=True;";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();
                        string query = "SELECT COUNT(*) FROM EnrollTable";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        int totalEnrollments = (int)cmd.ExecuteScalar();

                        label3.Text = "Total Enrollments: " + totalEnrollments.ToString();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error updating enrollment count: " + ex.Message);
                    }
                }
            }


        }

        private void StudentFormBtn_Click(object sender, EventArgs e)
        {
            StudentForm studentForm = new StudentForm();
            studentForm.Show();
        }

        private void CourseFormBtn_Click(object sender, EventArgs e)
        {
            CourseForm courseForm = new CourseForm();
            courseForm.Show();
        }

        private void EnrollmentFormBtn_Click(object sender, EventArgs e)
        {
            EnrollmentForm enrollmentForm = new EnrollmentForm();
            enrollmentForm.Show();
        }

        private void GradesFormBtn_Click(object sender, EventArgs e)
        {
            GradesForm gradesForm = new GradesForm();
            gradesForm.Show();
        }

        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            // Show the login form again
            Form1 loginForm = new Form1();
            loginForm.Show();

            // Close the dashboard form
            this.Close();
        }

        //////////////////////////////////////////////////////////////


        public void UpdateStudentCount()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT COUNT(*) FROM StudentFormTable";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        int count = (int)cmd.ExecuteScalar();
                        label1.Text = " " + count; // Update label with total count
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating student count: " + ex.Message);
            }
        }

        public void UpdateEnrollCount()
        {
            string connectionString = @"Server=DESKTOP-DMGJN94;Database=Student;Integrated Security=True;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT COUNT(*) FROM EnrollTable";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    int totalEnrollments = (int)cmd.ExecuteScalar();
                    label5.Text = totalEnrollments.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating enrollment count: " + ex.Message);
                }
            }
        }

        private void PrintBtn_Click(object sender, EventArgs e)
        {
            // Create an instance of the PrintReport form
            PrintReport printReportForm = new PrintReport();

            // Show the PrintReport form (use ShowDialog() for a modal window)
            printReportForm.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PrintReport printReportForm = new PrintReport();

            // Show the PrintReport form (use ShowDialog() for a modal window)
            printReportForm.Show();
        }
    }


}
