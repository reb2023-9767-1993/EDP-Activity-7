using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace GradingSystem
{
    public partial class PasswordRecoveryForm : Form
    {
        public PasswordRecoveryForm()
        {
            InitializeComponent();
        }

        private void btnRecover_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;

            if (string.IsNullOrWhiteSpace(email) || email == "Institutional Email")
            {
                MessageBox.Show("Please enter your registered email address.");
                return;
            }

            try
            {
                using (MySqlConnection conn = DbConfig.GetConnection())
                {
                    conn.Open();
                    // We query the 'users' table we created earlier
                    string query = "SELECT password FROM users WHERE email = @email";
                    
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@email", email);

                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        MessageBox.Show($"Recovery Successful!\n\nYour password is: {result.ToString()}", 
                                        "Password Recovery", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Email not found. Please make sure you entered the correct institutional email.", 
                                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Error: " + ex.Message);
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            // Reusing the same gradient as Login/Signup
            using (LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle, 
                   Color.FromArgb(101, 88, 203), Color.FromArgb(154, 116, 219), 45F))
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }
            base.OnPaint(e);
        }
    }
}