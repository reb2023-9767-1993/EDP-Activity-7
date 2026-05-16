using System;
using System.Drawing;
using System.Windows.Forms;

namespace GradingSystem
{
    partial class SignupForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel card;
        // Renamed txtID to txtUsername to match the new users table structure
        private System.Windows.Forms.TextBox txtUsername, txtFName, txtLName, txtEmail, txtPass;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label lblTitle;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.card = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();

            this.SuspendLayout();
            this.Size = new System.Drawing.Size(500, 650);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "Sign Up";

            // White Card Panel 
            this.card.Size = new System.Drawing.Size(400, 530);
            this.card.BackColor = System.Drawing.Color.White;
            this.card.Location = new System.Drawing.Point(45, 40);

            // Title
            this.lblTitle.Text = "Create Account";
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 18, FontStyle.Bold);
            this.lblTitle.Size = new System.Drawing.Size(360, 40);
            this.lblTitle.Location = new System.Drawing.Point(20, 30);
            this.lblTitle.TextAlign = ContentAlignment.MiddleCenter;

            // Inputs 
            this.card.Controls.Add(CreateInput(out txtUsername, "Username", 100));
            this.card.Controls.Add(CreateInput(out txtFName, "First Name", 170));
            this.card.Controls.Add(CreateInput(out txtLName, "Last Name", 240));
            this.card.Controls.Add(CreateInput(out txtEmail, "Institutional Email", 310));
            this.card.Controls.Add(CreateInput(out txtPass, "Password", 380));

            // Set Password character for the password field
            this.txtPass.UseSystemPasswordChar = true;

            // Register Button
            this.btnRegister.Text = "Register Account";
            this.btnRegister.Size = new System.Drawing.Size(320, 50);
            this.btnRegister.Location = new System.Drawing.Point(40, 450);
            this.btnRegister.BackColor = System.Drawing.Color.FromArgb(101, 88, 203); // Matches login theme
            this.btnRegister.ForeColor = Color.White;
            this.btnRegister.FlatStyle = FlatStyle.Flat;
            this.btnRegister.Font = new System.Drawing.Font("Segoe UI", 11, FontStyle.Bold);
            this.btnRegister.Cursor = Cursors.Hand;
            this.btnRegister.Click += new EventHandler(this.btnRegister_Click);

            this.card.Controls.Add(lblTitle);
            this.card.Controls.Add(btnRegister);
            this.Controls.Add(card);
            this.ResumeLayout(false);
        }

        private Panel CreateInput(out TextBox t, string hint, int y)
        {
            var p = new Panel { Size = new Size(320, 50), Location = new Point(40, y), BackColor = Color.White };
            var line = new Panel { Dock = DockStyle.Bottom, Height = 2, BackColor = Color.FromArgb(220, 220, 220) };
            
            // 1. Create a local variable first (this fixes the red underline)
            TextBox localTextBox = new TextBox { 
                Text = hint, 
                ForeColor = Color.Gray, 
                Font = new Font("Segoe UI", 11), 
                Size = new Size(300, 30), 
                Location = new Point(10, 10), 
                BorderStyle = BorderStyle.None 
            };

            // 2. Add placeholder behavior to the local variable
            localTextBox.Enter += (s, e) => {
                if (localTextBox.Text == hint) {
                    localTextBox.Text = "";
                    localTextBox.ForeColor = Color.Black;
                    if (hint == "Password") localTextBox.UseSystemPasswordChar = true;
                }
            };

            localTextBox.Leave += (s, e) => {
                if (string.IsNullOrWhiteSpace(localTextBox.Text)) {
                    localTextBox.Text = hint;
                    localTextBox.ForeColor = Color.Gray;
                    if (hint == "Password") localTextBox.UseSystemPasswordChar = false;
                }
            };

            // 3. Assign the local variable to the 'out' parameter
            t = localTextBox;

            p.Controls.Add(line); 
            p.Controls.Add(t);
            return p;
        }
    }
}