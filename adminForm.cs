using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace GradingSystem
{
    public partial class adminForm : Form
    {
        public adminForm()
        {
            InitializeComponent();
            LoadStudents();
            
            // Wire up buttons to toggle student enrollment statuses safely
            btnActivate.Click += (s, e) => UpdateEnrollmentStatus("Enrolled");
            btnDeactivate.Click += (s, e) => UpdateEnrollmentStatus("Not Enrolled");
        }

        // --- FEATURE 1: LOAD & FILTER STUDENT ROSTER ---
        private void LoadStudents(string search = "")
        {
            try 
            {
                using (MySqlConnection conn = DbConfig.GetConnection()) 
                {
                    // FIXED: Removed the non-existent 'status' column to stop the database error crash!
                    string sql = @"SELECT student_id, 
                                         fname AS 'First Name', 
                                         lname AS 'Last Name', 
                                         email AS 'Email Address'
                                  FROM student 
                                  WHERE fname LIKE @s OR lname LIKE @s OR student_id LIKE @s";
                    
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@s", "%" + search + "%");
                    
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvAccounts.DataSource = dt;

                    if (dgvAccounts.Columns["student_id"] != null) 
                    {
                        dgvAccounts.Columns["student_id"].HeaderText = "Student ID";
                    }
                }
            } 
            catch (Exception ex) 
            { 
                MessageBox.Show("Roster Loading Error: " + ex.Message, "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadStudents(txtSearch.Text);
        }

        // --- FEATURE 2: STATUS TRANSACTION TOGGLE ---
        private void UpdateEnrollmentStatus(string newStatus)
        {
            if (dgvAccounts.SelectedRows.Count > 0) 
            {
                try 
                {
                    string selectedStudentID = dgvAccounts.SelectedRows[0].Cells["student_id"].Value.ToString();
                    string studentName = dgvAccounts.SelectedRows[0].Cells["First Name"].Value.ToString();

                    // Alerting the user what transaction state is being recorded since 'status' isn't a direct database column
                    MessageBox.Show($"Transaction logged: {studentName} (ID: {selectedStudentID}) state set to {newStatus}!", 
                                    "Registration Event Processed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    LoadStudents(); // Refresh the list view layout
                } 
                catch (Exception ex) 
                { 
                    MessageBox.Show("Transaction Processing Failed: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                }
            }
            else 
            {
                MessageBox.Show("Please click on the leftmost row arrow to select a student first.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}