using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class EnrollmentForm : Form
    {
        public EnrollmentForm()
        {
            InitializeComponent();
        }

        // Replace with your actual connection string
        string connectionString = @"Server=DESKTOP-DMGJN94;Database=Student;Integrated Security=True;";

        // Form Load event to populate combo boxes with data
        private void EnrollmentForm_Load_1(object sender, EventArgs e)
        {
            LoadStudentData();
            LoadCourseData();
            LoadEnrollmentData(); // Load existing enrollments
         

        }

        // Method to load enrollment data into DataGridView
        private void LoadEnrollmentData()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = @"SELECT 
                                CAST(E.StudentID AS INT) AS StudentID, 
                                CAST(E.CourseID AS INT) AS CourseID, 
                                C.CourseName 
                             FROM EnrollTable E 
                             JOIN CourseTable C ON E.CourseID = C.CourseID";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    // Ensure proper data binding
                    Enroll_dataGridView.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading enrollments: " + ex.Message);
                }
            }
        }

        
        
        
        private void LoadStudentData()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT StudentID FROM StudentFormTable";  // Fetch only StudentID
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    Select_StudentID_comboBox.DataSource = dt;
                    Select_StudentID_comboBox.DisplayMember = "StudentID";  // Display StudentID
                    Select_StudentID_comboBox.ValueMember = "StudentID";  // Set the value to StudentID
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading student data: " + ex.Message);
                }
            }
        }
        private void LoadCourseData()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT CourseID FROM CourseTable";  // Fetch only CourseID
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    Select_CourseID_comboBox.DataSource = dt;
                    Select_CourseID_comboBox.DisplayMember = "CourseID";  // Display CourseID
                    Select_CourseID_comboBox.ValueMember = "CourseID";  // Set the value to CourseID
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading course data: " + ex.Message);
                }
            }
        }

       






        
        // Method to handle when a student is selected from the Select_StudentID_comboBox






        private void Seletct_StudentID_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Select_StudentID_comboBox.SelectedIndex != -1)
            {
                // Access the selected value properly
                DataRowView selectedRow = (DataRowView)Select_StudentID_comboBox.SelectedItem;
                int selectedStudentID = Convert.ToInt32(selectedRow["StudentID"]);
                // Additional processing if needed when a student is selected
            }
        }

        private void Select_CourseID_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Select_CourseID_comboBox.SelectedIndex != -1)
            {
                // Access the selected value properly
                DataRowView selectedRow = (DataRowView)Select_CourseID_comboBox.SelectedItem;
                int selectedCourseID = Convert.ToInt32(selectedRow["CourseID"]);
                // Additional processing if needed when a course is selected
            }
        }






        ///               Buttons             ///  






        // Enroll Button 
        public void EnrollBtn_Click(object sender, EventArgs e)
        {
            if (Select_StudentID_comboBox.SelectedValue == null || Select_CourseID_comboBox.SelectedValue == null)
            {
                MessageBox.Show("Please select both Student and Course.");
                return;
            }

            int studentID = Convert.ToInt32(Select_StudentID_comboBox.SelectedValue);
            int courseID = Convert.ToInt32(Select_CourseID_comboBox.SelectedValue);

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // Check if enrollment already exists
                    string checkQuery = "SELECT COUNT(*) FROM EnrollTable WHERE StudentID = @StudentID AND CourseID = @CourseID";
                    using (SqlCommand checkCmd = new SqlCommand(checkQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@StudentID", studentID);
                        checkCmd.Parameters.AddWithValue("@CourseID", courseID);
                        int count = (int)checkCmd.ExecuteScalar();

                        if (count > 0)
                        {
                            MessageBox.Show("This student is already enrolled in the selected course.");
                            return;
                        }
                    }

                    // Insert enrollment
                    string query = "INSERT INTO EnrollTable (StudentID, CourseID) VALUES (@StudentID, @CourseID)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@StudentID", studentID);
                        cmd.Parameters.AddWithValue("@CourseID", courseID);
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Enrollment Successful!");

                    // Refresh DataGridView
                    LoadEnrollmentData();

                    // ✅ Update enrollment count in DashboardForm
                    DashboardForm dashboard = Application.OpenForms.OfType<DashboardForm>().FirstOrDefault();
                    if (dashboard != null)
                    {
                        dashboard.UpdateEnrollCount();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error enrolling student: " + ex.Message);
                }
            }
        }







        // Unroll Button
        public void UnrollBtn_Click(object sender, EventArgs e)
        {
            if (Enroll_dataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an enrollment to unroll.");
                return;
            }

            int studentID = Convert.ToInt32(Enroll_dataGridView.SelectedRows[0].Cells["StudentID"].Value);
            int courseID = Convert.ToInt32(Enroll_dataGridView.SelectedRows[0].Cells["CourseID"].Value);

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // Check if enrollment exists before deleting
                    string checkQuery = "SELECT COUNT(*) FROM EnrollTable WHERE StudentID = @StudentID AND CourseID = @CourseID";
                    using (SqlCommand checkCmd = new SqlCommand(checkQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@StudentID", studentID);
                        checkCmd.Parameters.AddWithValue("@CourseID", courseID);
                        int count = (int)checkCmd.ExecuteScalar();

                        if (count == 0)
                        {
                            MessageBox.Show("This enrollment does not exist.");
                            return;
                        }
                    }

                    // Delete enrollment
                    string query = "DELETE FROM EnrollTable WHERE StudentID = @StudentID AND CourseID = @CourseID";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@StudentID", studentID);
                        cmd.Parameters.AddWithValue("@CourseID", courseID);
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Student unrolled successfully!");

                    // Refresh DataGridView
                    LoadEnrollmentData();

                    // ✅ Update enrollment count in DashboardForm
                    DashboardForm dashboard = Application.OpenForms.OfType<DashboardForm>().FirstOrDefault();
                    if (dashboard != null)
                    {
                        dashboard.UpdateEnrollCount();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error unrolling student: " + ex.Message);
                }
            }
        }
















        // DataGridView cell content click event - Logic to handle any interaction with the DataGridView
        private void Enroll_dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Logic for cell content click will go here
        }















    }
}
