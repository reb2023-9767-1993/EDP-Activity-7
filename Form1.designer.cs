namespace GradingSystem
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        // Controls
        private System.Windows.Forms.Panel card;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Panel pnlUser;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Panel pnlPass;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.LinkLabel lnkForgot;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.LinkLabel lnkSignup;

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
            this.lblDesc = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lnkForgot = new System.Windows.Forms.LinkLabel();
            this.btnClose = new System.Windows.Forms.Button();

            // Setup Main Form
            this.SuspendLayout();
            this.Size = new System.Drawing.Size(1000, 650);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;

            // Close Button
            this.btnClose.Text = "X";
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Font = new System.Drawing.Font("Arial", 10, System.Drawing.FontStyle.Bold);
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.Size = new System.Drawing.Size(30, 30);
            this.btnClose.Location = new System.Drawing.Point(960, 10);
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);

            // Card Panel
            this.card.Size = new System.Drawing.Size(380, 480);
            this.card.BackColor = System.Drawing.Color.White;
            this.card.Location = new System.Drawing.Point(310, 85);

            // Title
            this.lblTitle.Text = "Grading System";
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 18, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitle.Size = new System.Drawing.Size(340, 40);
            this.lblTitle.Location = new System.Drawing.Point(20, 40);

            // Description
            this.lblDesc.Text = "Welcome to the Academic Portal";
            this.lblDesc.Font = new System.Drawing.Font("Segoe UI", 10);
            this.lblDesc.ForeColor = System.Drawing.Color.FromArgb(127, 140, 141);
            this.lblDesc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDesc.Size = new System.Drawing.Size(340, 20);
            this.lblDesc.Location = new System.Drawing.Point(20, 85);

            // Username Input Panel
            this.pnlUser = CreateDesignerInputPanel(out txtUsername, "Username", 140);
            
            // Password Input Panel
            this.pnlPass = CreateDesignerInputPanel(out txtPassword, "Password", 205);

            // Login Button
            this.btnLogin.Text = "Login";
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI Semibold", 12, System.Drawing.FontStyle.Bold);
            this.btnLogin.Size = new System.Drawing.Size(320, 50);
            this.btnLogin.Location = new System.Drawing.Point(30, 280);
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(52, 152, 219);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);

            // Forgot Password Link
            this.lnkForgot.Text = "Forgot Password?";
            this.lnkForgot.Font = new System.Drawing.Font("Segoe UI", 9);
            this.lnkForgot.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lnkForgot.Size = new System.Drawing.Size(320, 20);
            this.lnkForgot.Location = new System.Drawing.Point(30, 350);
            this.lnkForgot.LinkColor = System.Drawing.Color.FromArgb(52, 152, 219);
            this.lnkForgot.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkForgot.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkForgot_LinkClicked);

            //Signup Link
            this.lnkSignup = new System.Windows.Forms.LinkLabel();
            this.lnkSignup.Text = "Don't have an account? Sign Up";
            this.lnkSignup.Location = new System.Drawing.Point(30, 380);
            this.lnkForgot.LinkColor = System.Drawing.Color.FromArgb(52, 152, 219); // Adjusted to be below 'Forgot Password'
            this.lnkSignup.Size = new System.Drawing.Size(320, 20);
            this.lnkSignup.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lnkSignup.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkSignup_LinkClicked);
            

            // Assembly
            this.card.Controls.Add(lblTitle);
            this.card.Controls.Add(lblDesc);
            this.card.Controls.Add(pnlUser);
            this.card.Controls.Add(pnlPass);
            this.card.Controls.Add(btnLogin);
            this.card.Controls.Add(lnkForgot);
            this.card.Controls.Add(lnkSignup);

            this.Controls.Add(btnClose);
            this.Controls.Add(card);
            this.ResumeLayout(false);
        }

        // Helper for designer-friendly panel creation
        private System.Windows.Forms.Panel CreateDesignerInputPanel(out System.Windows.Forms.TextBox t, string hint, int y)
        {
            var p = new System.Windows.Forms.Panel { Size = new System.Drawing.Size(320, 50), Location = new System.Drawing.Point(30, y), BackColor = System.Drawing.Color.White };
            var line = new System.Windows.Forms.Panel { Dock = System.Windows.Forms.DockStyle.Bottom, Height = 2, BackColor = System.Drawing.Color.FromArgb(220, 220, 220) };
            t = new System.Windows.Forms.TextBox {
                Text = hint,
                ForeColor = System.Drawing.Color.Gray,
                Font = new System.Drawing.Font("Segoe UI", 11),
                Size = new System.Drawing.Size(300, 30),
                Location = new System.Drawing.Point(10, 10),
                BorderStyle = System.Windows.Forms.BorderStyle.None
            };
            p.Controls.Add(line);
            p.Controls.Add(t);
            return p;
        }
    }
}