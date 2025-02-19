using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class StudentForm : Form
    {
        private string connectionString = "Server=DESKTOP-DMGJN94;Database=Student;Integrated Security=True;";

        public StudentForm()
        {
            InitializeComponent();
            LoadStudents(); // Load students into DataGridView on form load
            PopulateGenderComboBox();

        }




        public void LoadStudents()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // SQL query to get all students from StudentFormTable
                    string query = "SELECT * FROM StudentFormTable";

                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt); // Fill the DataTable with the query results

                        // Bind the data to DataGridView
                        StudentFormDataGridView.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading student data: " + ex.Message);
            }
        }



        private void PopulateGenderComboBox()
        {
            Gender_comboBox.Items.Clear(); // Clear any existing items if any
            Gender_comboBox.Items.Add("Male");
            Gender_comboBox.Items.Add("Female");
            Gender_comboBox.Items.Add("Other");
            Gender_comboBox.SelectedIndex = 0; // Set default selection to "Male"
        }


        public void AddBtn_Click(object sender, EventArgs e)
        {
            string studentID = StudentID_textBox.Text.Trim();
            string name = Name_textBox.Text.Trim();
            DateTime dob = DateOfBirth_dateTimePicker.Value;
            string gender = Gender_comboBox.SelectedItem?.ToString();
            string email = Email_textBox.Text.Trim();
            string phone = Phone_textBox.Text.Trim();

            // Check if all fields are filled
            if (string.IsNullOrEmpty(studentID) || string.IsNullOrEmpty(name) || string.IsNullOrEmpty(gender) ||
                string.IsNullOrEmpty(email) || string.IsNullOrEmpty(phone))
            {
                MessageBox.Show("Please fill in all the fields.");
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Check if StudentID already exists
                    string checkQuery = "SELECT COUNT(*) FROM StudentFormTable WHERE StudentID = @studentID";
                    using (SqlCommand checkCmd = new SqlCommand(checkQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@studentID", studentID);
                        int count = (int)checkCmd.ExecuteScalar();

                        if (count > 0)
                        {
                            MessageBox.Show("Student ID already exists. Please enter a unique Student ID.");
                            return;
                        }
                    }

                    // SQL query to insert a new student
                    string query = "INSERT INTO StudentFormTable (StudentID, Name, DateOfBirth, Gender, Email, Phone) " +
                                   "VALUES (@studentID, @name, @dob, @gender, @email, @phone)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@studentID", studentID);
                        cmd.Parameters.AddWithValue("@name", name);
                        cmd.Parameters.AddWithValue("@dob", dob);
                        cmd.Parameters.AddWithValue("@gender", gender);
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@phone", phone);

                        cmd.ExecuteNonQuery(); // Execute the insert query
                        MessageBox.Show("Student added successfully!");

                        LoadStudents(); // Refresh DataGridView
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }





            // Update student count in DashboardForm
            DashboardForm dashboard = Application.OpenForms.OfType<DashboardForm>().FirstOrDefault();
            if (dashboard != null)
            {
                dashboard.UpdateStudentCount();
            }
      
        
        
        
        
        
        
        }

        public void RemoveBtn_Click(object sender, EventArgs e)
        {
            string studentID = StudentID_textBox.Text;

            // Check if StudentID is provided
            if (string.IsNullOrEmpty(studentID))
            {
                MessageBox.Show("Please enter a valid Student ID to remove.");
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // SQL query to delete student by StudentID
                    string query = "DELETE FROM StudentFormTable WHERE StudentID = @studentID";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Add parameter to prevent SQL injection
                        cmd.Parameters.AddWithValue("@studentID", studentID);

                        int rowsAffected = cmd.ExecuteNonQuery(); // Execute the delete query

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Student removed successfully!");
                            LoadStudents(); // Refresh DataGridView
                        }
                        else
                        {
                            MessageBox.Show("No student found with the given ID.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }

            // Refresh the total student count in DashboardForm
            DashboardForm dashboard = Application.OpenForms.OfType<DashboardForm>().FirstOrDefault();
            if (dashboard != null)
            {
                dashboard.UpdateStudentCount();
            }
        }

        public void SearchBtn_Click(object sender, EventArgs e)
        {
            string searchID = Search_textBox.Text.Trim(); // Get the ID from the search box

            if (string.IsNullOrEmpty(searchID))
            {
                MessageBox.Show("Please enter a Student ID to search.");
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // SQL query to search for a student by ID
                    string query = "SELECT * FROM StudentFormTable WHERE StudentID = @searchID";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@searchID", searchID);

                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt); // Fill DataTable with query result

                            if (dt.Rows.Count > 0)
                            {
                                StudentFormDataGridView.DataSource = dt; // Display the result in DataGridView
                            }
                            else
                            {
                                MessageBox.Show("No student found with the given ID.");
                                StudentFormDataGridView.DataSource = null; // Clear DataGridView
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while searching: " + ex.Message);
            }
        }




        private void StudentFormDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the clicked cell is not in the header row
            if (e.RowIndex >= 0)
            {
                // Get the clicked row
                DataGridViewRow row = StudentFormDataGridView.Rows[e.RowIndex];

                // Populate the textboxes with the values of the selected row
                StudentID_textBox.Text = row.Cells["StudentID"].Value.ToString();
                Name_textBox.Text = row.Cells["Name"].Value.ToString();
                DateOfBirth_dateTimePicker.Value = Convert.ToDateTime(row.Cells["DateOfBirth"].Value);
                Gender_comboBox.SelectedItem = row.Cells["Gender"].Value.ToString();
                Email_textBox.Text = row.Cells["Email"].Value.ToString();
                Phone_textBox.Text = row.Cells["Phone"].Value.ToString();
            }
        }



        private void StudentFormDataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the clicked row is valid
            if (e.RowIndex >= 0)
            {
                // Get the selected row's data
                DataGridViewRow row = StudentFormDataGridView.Rows[e.RowIndex];

                // Populate the textboxes with the selected row's data
                StudentID_textBox.Text = row.Cells["StudentID"].Value.ToString();
                Name_textBox.Text = row.Cells["Name"].Value.ToString();
                DateOfBirth_dateTimePicker.Value = Convert.ToDateTime(row.Cells["DateOfBirth"].Value);
                Gender_comboBox.SelectedItem = row.Cells["Gender"].Value.ToString();
                Email_textBox.Text = row.Cells["Email"].Value.ToString();
                Phone_textBox.Text = row.Cells["Phone"].Value.ToString();
            }
        }


        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            // Retrieve the updated data from textboxes
            string studentID = StudentID_textBox.Text; // New StudentID (can be changed)
            string name = Name_textBox.Text;
            DateTime dob = DateOfBirth_dateTimePicker.Value;
            string gender = Gender_comboBox.SelectedItem.ToString();
            string email = Email_textBox.Text;
            string phone = Phone_textBox.Text;

            // Check if all fields are filled
            if (string.IsNullOrEmpty(studentID) || string.IsNullOrEmpty(name) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(phone))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // SQL query to update the student's information
                    string query = "UPDATE StudentFormTable SET Name = @name, DateOfBirth = @dob, Gender = @gender, Email = @email, Phone = @phone WHERE StudentID = @studentID";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Add parameters for the query
                        cmd.Parameters.AddWithValue("@studentID", studentID); // Use StudentID to identify the record
                        cmd.Parameters.AddWithValue("@name", name);
                        cmd.Parameters.AddWithValue("@dob", dob);
                        cmd.Parameters.AddWithValue("@gender", gender);
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@phone", phone);

                        // Execute the update command
                        int rowsAffected = cmd.ExecuteNonQuery();

                        // Check if the update was successful
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Student updated successfully!");

                            // Refresh the DataGridView to reflect the changes
                            LoadStudents(); // Custom method to reload students from the database
                        }
                        else
                        {
                            MessageBox.Show("No student found with the given StudentID.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating student: " + ex.Message);
            }

            LoadStudents();



        }















    }
}
