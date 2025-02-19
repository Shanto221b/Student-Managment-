using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class PrintReport : Form
    {
        public PrintReport()
        {
            InitializeComponent();
        }

        // Connection string
        string connectionString = @"Server=DESKTOP-DMGJN94;Database=Student;Integrated Security=True;";

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            // Get the Student ID from the TextBox
            string studentID = ID_txtBox.Text.Trim();

            if (string.IsNullOrEmpty(studentID))
            {
                MessageBox.Show("Please enter a Student ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // SQL query to fetch the required data by using LEFT JOIN
            string query = @"
        SELECT s.StudentID, s.Name AS StudentName, c.CourseName, g.Grade, c.Credits
        FROM StudentFormTable s
        LEFT JOIN EnrollTable e ON s.StudentID = e.StudentID
        LEFT JOIN CourseTable c ON e.CourseID = c.CourseID
        LEFT JOIN GradeTable g ON e.StudentID = g.StudentID AND e.CourseID = g.CourseID
        WHERE s.StudentID = @StudentID";

            // DataTable to hold the search results
            DataTable dt = new DataTable();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Add parameter to the query to prevent SQL injection
                        cmd.Parameters.AddWithValue("@StudentID", studentID);

                        // Use SqlDataAdapter to fill DataTable
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        adapter.Fill(dt);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error searching for student: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            // Check if there are any results
            if (dt.Rows.Count > 0)
            {
                // Bind the result to the DataGridView
                Result_dataGridView.DataSource = dt;
            }
            else
            {
                MessageBox.Show("No data found for the given Student ID.", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Result_dataGridView.DataSource = null; // Clear the grid if no data is found
            }
        }

        // Print Button Click Event
        private void PrintBtn_Click(object sender, EventArgs e)
        {
            // Check if the DataGridView has data to print
            if (Result_dataGridView.Rows.Count > 0)
            {
                PrintDocument printDocument = new PrintDocument();
                printDocument.PrintPage += PrintDocument_PrintPage;
                printDocument.Print();
            }
            else
            {
                MessageBox.Show("No data available to print.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // PrintPage event handler
        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            // Setting up the font and starting position for printing
            Font printFont = new Font("Arial", 10);
            int x = 50;
            int y = 50;
            int rowHeight = 30;

            // Print the column headers
            foreach (DataGridViewColumn column in Result_dataGridView.Columns)
            {
                e.Graphics.DrawString(column.HeaderText, printFont, Brushes.Black, x, y);
                x += 150; // Adjust the width between columns
            }

            y += rowHeight; // Move to the next line after printing headers

            // Print the rows of data
            foreach (DataGridViewRow row in Result_dataGridView.Rows)
            {
                if (row.Index == Result_dataGridView.Rows.Count - 1) break; // Skip the last empty row
                x = 50; // Reset the starting x position for each row
                foreach (DataGridViewCell cell in row.Cells)
                {
                    e.Graphics.DrawString(cell.Value?.ToString(), printFont, Brushes.Black, x, y);
                    x += 150; // Adjust the width between columns
                }
                y += rowHeight; // Move to the next line for the next row
            }
        }

        private void Result_dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Empty event, can be removed if not used
        }
    }
}
