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
    public partial class CreateNewAdmin : Form
    {
        // Database connection string
        private string connectionString = "Server=DESKTOP-DMGJN94;Database=Student;Integrated Security=True;";

        public CreateNewAdmin()
        {
            InitializeComponent();
        }



        private void AddAdminBtn_Click(object sender, EventArgs e)
        {
            string userID = ID_textBox.Text;
            string password = Password_textBox.Text;

            if (string.IsNullOrEmpty(userID) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both User ID and Password.");
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "INSERT INTO UserTable (ID, Password) VALUES (@userID, @password)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@userID", userID);
                        cmd.Parameters.AddWithValue("@password", password);
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("New admin created successfully!");

                            // Refresh DataGridView in Form1 after adding a new admin
                            Form1 mainForm = Application.OpenForms.OfType<Form1>().FirstOrDefault();
                            if (mainForm != null)
                            {
                                mainForm.ShowAdminBtn_Click(null, null); // Reload admin list
                            }

                            this.Close(); // Close the CreateNewAdmin form
                        }
                        else
                        {
                            MessageBox.Show("Failed to create new admin. Please try again.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }














        // Optional: Handle text changes in ID and Password textboxes
        private void ID_textBox_TextChanged(object sender, EventArgs e)
        {
            // Optionally, you can handle events when the text changes in the ID textbox
        }

        private void Password_textBox_TextChanged(object sender, EventArgs e)
        {
            // Optionally, handle events when the text changes in the Password textbox
        }
    
    
    
    
    
    }
}
