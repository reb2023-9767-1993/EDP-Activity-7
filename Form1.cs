using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using MySql.Data.MySqlClient;

namespace GradingSystem
{
    public partial class Form1 : Form
    {
        // For making the form draggable
        [DllImport("user32.dll")] public static extern bool ReleaseCapture();
        [DllImport("user32.dll")] public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        // UI Colors
        private Color colorBackground = Color.FromArgb(101, 88, 203);
        private Color colorBackgroundEnd = Color.FromArgb(154, 116, 219);
        private Color colorInputText = Color.FromArgb(70, 70, 70);
        private Color colorButton = Color.FromArgb(52, 152, 219);

        public Form1()
        {
            InitializeComponent();
            SetupCustomLogic();
        }

        private void SetupCustomLogic()
        {
            // Placeholder logic for Username
            txtUsername.Enter += (s, e) => { 
                if (txtUsername.Text == "Username") { 
                    txtUsername.Text = ""; 
                    txtUsername.ForeColor = colorInputText; 
                } 
            };
            txtUsername.Leave += (s, e) => { 
                if (string.IsNullOrWhiteSpace(txtUsername.Text)) { 
                    txtUsername.Text = "Username"; 
                    txtUsername.ForeColor = Color.Gray; 
                } 
            };

            // Placeholder logic for Password
            txtPassword.Enter += (s, e) => { 
                if (txtPassword.Text == "Password") { 
                    txtPassword.Text = ""; 
                    txtPassword.ForeColor = colorInputText; 
                    txtPassword.UseSystemPasswordChar = true; 
                } 
            };
            txtPassword.Leave += (s, e) => { 
                if (string.IsNullOrWhiteSpace(txtPassword.Text)) { 
                    txtPassword.Text = "Password"; 
                    txtPassword.ForeColor = Color.Gray; 
                    txtPassword.UseSystemPasswordChar = false; 
                } 
            };

            // Dragging Logic
            this.MouseDown += (s, e) => { 
                if (e.Button == MouseButtons.Left) { 
                    ReleaseCapture(); 
                    SendMessage(Handle, 0xA1, 0x2, 0); 
                } 
            };
        }

                private void btnLogin_Click(object sender, EventArgs e)
        {
            string user = txtUsername.Text;
            string pass = txtPassword.Text;

            if (user == "Username" || string.IsNullOrEmpty(user)) {
                MessageBox.Show("Please enter a username.");
                return;
            }

            try {
                using (MySqlConnection conn = DbConfig.GetConnection()) {
                    conn.Open();
                    // We check for Username, Password, and if the account is 'Active'
                    string query = "SELECT * FROM users WHERE username=@user AND password=@pass AND status='Active'";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@user", user);
                    cmd.Parameters.AddWithValue("@pass", pass);

                    using (MySqlDataReader reader = cmd.ExecuteReader()) {
                        if (reader.Read()) {
                            UserSession.CurrentUsername = reader["username"].ToString();
                            UserSession.CurrentFullName = reader["full_name"].ToString();
                            dashboardForm dash = new dashboardForm();
                            dash.Show();
                            this.Hide();
                        } else {
                            MessageBox.Show("Invalid login or account is inactive.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex) {
                MessageBox.Show("Database Error: " + ex.Message);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lnkForgot_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PasswordRecoveryForm recovery = new PasswordRecoveryForm();
            recovery.ShowDialog();
        }

        private void lnkSignup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignupForm signup = new SignupForm();
            signup.ShowDialog(); // Opens as a pop-up
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            using (LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle, colorBackground, colorBackgroundEnd, 45F))
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }
            base.OnPaint(e);
        }
    }
}