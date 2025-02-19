using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class CourseForm : Form
    {
        public string connectionString = @"Server=DESKTOP-DMGJN94;Database=Student;Integrated Security=True";

        public CourseForm()
        {
            InitializeComponent();
            LoadCourses();
        }

        private void CourseForm_Load(object sender, EventArgs e)
        {
            LoadCourses(); // Load courses when the form loads
        }

        private void LoadCourses()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM CourseTable";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    CourseList_dataGridView.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading courses: " + ex.Message);
                }
            }
        }

        // Add a new course
        private void AddCourse_Btn_Click(object sender, EventArgs e)
        {
            string courseID = CourseID_textBox.Text;
            string courseName = CourseName_textBox.Text;
            string courseCredits = CourseCredit_textBox.Text;

            if (string.IsNullOrEmpty(courseID) || string.IsNullOrEmpty(courseName) || string.IsNullOrEmpty(courseCredits))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            // Insert the new course into the database
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "INSERT INTO CourseTable (CourseID, CourseName, Credits) VALUES (@CourseID, @CourseName, @Credits)";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@CourseID", courseID);
                    command.Parameters.AddWithValue("@CourseName", courseName);
                    command.Parameters.AddWithValue("@Credits", courseCredits);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Course added successfully!");
                    LoadCourses();  // Reload the DataGridView with the updated course list
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error adding course: " + ex.Message);
                }
            }
        }

        // Remove course when the "Remove" button is clicked
        private void RemoveCourse_Btn_Click(object sender, EventArgs e)
        {
            if (CourseList_dataGridView.SelectedRows.Count > 0)
            {
                try
                {
                    // Get the selected course ID
                    int courseID = Convert.ToInt32(CourseList_dataGridView.SelectedRows[0].Cells["CourseID"].Value);

                    // Delete the selected course from the database
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        string query = "DELETE FROM CourseTable WHERE CourseID = @CourseID";
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@CourseID", courseID);
                        command.ExecuteNonQuery();
                        MessageBox.Show("Course removed successfully!");
                        LoadCourses();  // Reload the DataGridView after removing the course
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error removing course: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please select a course to remove.");
            }
        }

        // Event handler to handle double-click on a row and load data into textboxes
        private void CourseList_dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Get the course details from the clicked row
                DataGridViewRow row = CourseList_dataGridView.Rows[e.RowIndex];

                // Load the course data into the textboxes
                CourseID_textBox.Text = row.Cells["CourseID"].Value.ToString();
                CourseName_textBox.Text = row.Cells["CourseName"].Value.ToString();
                CourseCredit_textBox.Text = row.Cells["Credits"].Value.ToString();
            }
        }

        // Event handler for DataGridView cell click (remove course)
        private void CourseList_dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // You can handle this event if needed, but it's no longer required for removal since we already handle it in the Remove button.
        }

        // Event handlers for textboxes (optional, but currently empty)
        private void CourseID_textBox_TextChanged(object sender, EventArgs e) { }
        private void CourseName_textBox_TextChanged(object sender, EventArgs e) { }
        private void CourseCredit_textBox_TextChanged(object sender, EventArgs e) { }
    }





}
