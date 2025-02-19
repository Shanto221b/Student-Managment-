using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class GradesForm : Form
    {
        public GradesForm()
        {
            InitializeComponent();
        }

        string connectionString = @"Server=DESKTOP-DMGJN94;Database=Student;Integrated Security=True;";

        private void GradesForm_Load(object sender, EventArgs e)
        {
            LoadStudentData();
            LoadCourseData();
            LoadGrades(); // Manually load grades into the Grade_comboBox
            LoadGradeData(); // Ensure Grade_dataGridView loads existing grades
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

        public void LoadGrades()
        {
            Grade_comboBox.Items.Clear(); // Clear existing items if any
            List<string> grades = new List<string> { "A+", "A", "B+", "B", "C+", "C", "D", "F" };

            foreach (var grade in grades)
            {
                Grade_comboBox.Items.Add(grade);
            }
        }

        private void LoadGradeData()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = @"
                        SELECT g.StudentID, c.CourseName, g.Grade 
                        FROM GradeTable g 
                        JOIN CourseTable c ON g.CourseID = c.CourseID";  // Join CourseTable to show CourseName

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    Grade_dataGridView.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading grade data: " + ex.Message);
                }
            }
        }

        private void Select_StudentID_comboBox_SelectedIndexChanged(object sender, EventArgs e)
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

        private void Grade_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            /* 
             ✅ The grade values are manually added in LoadGrades(), so no extra processing is needed when a user selects a grade.
             ✅ You're not fetching grades from the database, so no data needs to be updated dynamically.
            */
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            // Check if all ComboBoxes have valid selections
            if (Select_StudentID_comboBox.SelectedIndex == -1 ||
                Select_CourseID_comboBox.SelectedIndex == -1 ||
                Grade_comboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a Student, Course, and Grade before adding.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Get selected values
                int selectedStudentID = Convert.ToInt32(Select_StudentID_comboBox.SelectedValue);
                int selectedCourseID = Convert.ToInt32(Select_CourseID_comboBox.SelectedValue);
                string selectedGrade = Grade_comboBox.SelectedItem.ToString();

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "INSERT INTO GradeTable (StudentID, CourseID, Grade) VALUES (@StudentID, @CourseID, @Grade)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@StudentID", selectedStudentID);
                        cmd.Parameters.AddWithValue("@CourseID", selectedCourseID);
                        cmd.Parameters.AddWithValue("@Grade", selectedGrade);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Grade added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadGradeData(); // Refresh DataGridView after adding a grade
                        }
                        else
                        {
                            MessageBox.Show("Failed to add grade.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding grade: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
   
    
    
    
    
    
    
    
    
    
    
    
    
    }
}
