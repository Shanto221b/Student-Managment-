using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        // Database connection string
        private string connectionString = "Server=DESKTOP-DMGJN94;Database=Student;Integrated Security=True;";

        public Form1()
        {
            InitializeComponent();
        }



        // Login Button click event handler

        public void LoginBtn_Click(object sender, EventArgs e)
        {
            string userID = IdTextBox.Text; // Using IdTextBox for User ID input
            string password = Password.Text; // Using Password for Password input

            // Check if both User ID and Password are provided
            
            if (string.IsNullOrEmpty(userID) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both User ID and Password.");
                return;
            }

            try
            {
                // Create a SQL connection
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // SQL query to check if the user exists with the provided ID and Password
                    string query = "SELECT COUNT(*) FROM UserTable WHERE ID = @userID AND Password = @password";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Add parameters to prevent SQL injection
                        cmd.Parameters.AddWithValue("@userID", userID);
                        cmd.Parameters.AddWithValue("@password", password);

                        // Execute the query and get the result
                        int count = (int)cmd.ExecuteScalar();

                        // Check if count is greater than 0 (user exists)
                        if (count > 0)
                        {
                           
                            this.Hide(); // Hide the login form
                            DashboardForm dashboard = new DashboardForm(); // Open the dashboard form
                            dashboard.Show();
                        }
                        else
                        {
                            MessageBox.Show("Invalid ID or password.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle any errors that occur during the login process
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }





        private void IdTextBox_TextChanged(object sender, EventArgs e)
        {
            // Optionally, you can handle events when the text changes in the user ID textbox
        }
        private void Password_TextChanged(object sender, EventArgs e)
        {
            // Optionally, you can handle events when the text changes in the password textbox
        }

        
        
        
        
        // Create Admin Button click event handler (opens CreateNewAdmin form)
        private void CreateBtn_Click(object sender, EventArgs e)
        {
            CreateNewAdmin createAdminForm = new CreateNewAdmin();
            createAdminForm.Show();
        }

        


        
        
        // Show Admin Button click event handler (fetches and displays admin data)
        public void ShowAdminBtn_Click(object sender, EventArgs e)
        {
            // Create a SQL connection
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // SQL query to get all users from UserTable
                    string query = "SELECT ID, Password FROM UserTable";

                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt); // Fill the DataTable with the query results

                        // Bind the data to DataGridView
                        ShowAllAdmins_dataGridview.DataSource = dt; // Assuming your DataGridView is named ShowAllAdmins_dataGridview
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        
        
        
        // DataGridView Cell Content Click event handler (optional, for any further action when a cell is clicked)
        private void ShowAllAdmins_dataGridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // You can add functionality here if you want to take action when a cell is clicked in the DataGridView.
        
        
        
        }
    
    
    
    
    
    
    
    
    
    
    
    }
}
