using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace GradingSystem
{
    public partial class ProfileForm : Form
    {
        public ProfileForm()
        {
            InitializeComponent();
            LoadUserData();
        }

        private void LoadUserData()
        {
            try {
                using (MySqlConnection conn = DbConfig.GetConnection()) {
                    conn.Open();
                    string query = "SELECT * FROM users WHERE username = @user";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@user", UserSession.CurrentUsername);

                    using (MySqlDataReader reader = cmd.ExecuteReader()) {
                        if (reader.Read()) {
                            txtFullName.Text = reader["full_name"].ToString();
                            txtEmail.Text = reader["email"].ToString();
                            txtPass.Text = reader["password"].ToString();
                            
                            // Adjust colors because they aren't placeholders anymore
                            txtFullName.ForeColor = Color.Black;
                            txtEmail.ForeColor = Color.Black;
                            txtPass.ForeColor = Color.Black;
                        }
                    }
                }
            } catch (Exception ex) { MessageBox.Show("Error loading profile: " + ex.Message); }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try {
                using (MySqlConnection conn = DbConfig.GetConnection()) {
                    conn.Open();
                    string query = "UPDATE users SET full_name=@name, email=@email, password=@pass WHERE username=@user";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@name", txtFullName.Text);
                    cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@pass", txtPass.Text);
                    cmd.Parameters.AddWithValue("@user", UserSession.CurrentUsername);

                    cmd.ExecuteNonQuery();
                    UserSession.CurrentFullName = txtFullName.Text; // Update session
                    MessageBox.Show("Profile updated successfully!", "Success");
                    this.Close();
                }
            } catch (Exception ex) { MessageBox.Show("Update failed: " + ex.Message); }
        }

        protected override void OnPaint(PaintEventArgs e) {
            using (LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle, 
                   Color.FromArgb(101, 88, 203), Color.FromArgb(154, 116, 219), 45F)) {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }
            base.OnPaint(e);
        }
    }
}