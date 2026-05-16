using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace GradingSystem
{
    public partial class SignupForm : Form
    {
        public SignupForm()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            // Match the validation to your new table columns
            if (string.IsNullOrWhiteSpace(txtUsername.Text) || txtUsername.Text == "Username")
            {
                MessageBox.Show("Please enter a valid Username.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtPass.Text) || txtPass.Text == "Password")
            {
                MessageBox.Show("Please enter a password.");
                return;
            }

            try
            {
                using (MySqlConnection conn = DbConfig.GetConnection())
                {
                    conn.Open();
                    // Query targeting the new 'users' table
                    string query = "INSERT INTO users (username, password, email, full_name, status) " +
                                   "VALUES (@user, @pass, @email, @fullname, 'Active')";
                    
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@user", txtUsername.Text);
                    cmd.Parameters.AddWithValue("@pass", txtPass.Text);
                    cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                    // Combines first and last name for the 'full_name' column in users table
                    cmd.Parameters.AddWithValue("@fullname", txtFName.Text + " " + txtLName.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Account successfully created! You can now log in.", "Success");
                    this.Close();
                }
            }
            catch (MySqlException ex)
            {
                if (ex.Number == 1062) // Duplicate entry error code
                    MessageBox.Show("Username or Email already exists.");
                else
                    MessageBox.Show("Database Error: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            // Matches your Form1 Gradient exactly
            using (LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle, 
                   Color.FromArgb(101, 88, 203), Color.FromArgb(154, 116, 219), 45F))
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }
            base.OnPaint(e);
        }
    }
}