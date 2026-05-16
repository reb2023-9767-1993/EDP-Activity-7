namespace GradingSystem
{
    partial class PasswordRecoveryForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel card;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnRecover;
        private System.Windows.Forms.Label lblTitle, lblDesc;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.card = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.btnRecover = new System.Windows.Forms.Button();

            this.SuspendLayout();
            this.Size = new System.Drawing.Size(450, 400);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "Recover Password";

            // Card Panel
            this.card.Size = new System.Drawing.Size(350, 280);
            this.card.BackColor = System.Drawing.Color.White;
            this.card.Location = new System.Drawing.Point(45, 45);

            // Title
            this.lblTitle.Text = "Forgot Password?";
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 16, FontStyle.Bold);
            this.lblTitle.Size = new System.Drawing.Size(310, 35);
            this.lblTitle.Location = new System.Drawing.Point(20, 25);
            this.lblTitle.TextAlign = ContentAlignment.MiddleCenter;

            // Description
            this.lblDesc.Text = "Enter your email below to retrieve your account password.";
            this.lblDesc.Font = new System.Drawing.Font("Segoe UI", 9);
            this.lblDesc.Size = new System.Drawing.Size(310, 40);
            this.lblDesc.Location = new System.Drawing.Point(20, 65);
            this.lblDesc.TextAlign = ContentAlignment.MiddleCenter;
            this.lblDesc.ForeColor = Color.DimGray;

            // Email Input
            this.card.Controls.Add(CreateInput(out txtEmail, "Institutional Email", 120));

            // Button
            this.btnRecover.Text = "Retrieve Password";
            this.btnRecover.Size = new System.Drawing.Size(270, 45);
            this.btnRecover.Location = new System.Drawing.Point(40, 200);
            this.btnRecover.BackColor = System.Drawing.Color.FromArgb(101, 88, 203);
            this.btnRecover.ForeColor = Color.White;
            this.btnRecover.FlatStyle = FlatStyle.Flat;
            this.btnRecover.Font = new System.Drawing.Font("Segoe UI Semibold", 10);
            this.btnRecover.Click += new System.EventHandler(this.btnRecover_Click);

            this.card.Controls.Add(lblTitle);
            this.card.Controls.Add(lblDesc);
            this.card.Controls.Add(btnRecover);
            this.Controls.Add(card);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel CreateInput(out TextBox t, string hint, int y)
        {
            var p = new System.Windows.Forms.Panel { Size = new Size(270, 50), Location = new Point(40, y), BackColor = Color.White };
            var line = new System.Windows.Forms.Panel { Dock = DockStyle.Bottom, Height = 2, BackColor = Color.FromArgb(220, 220, 220) };
            
            TextBox localTxt = new TextBox { 
                Text = hint, ForeColor = Color.Gray, Font = new Font("Segoe UI", 11), 
                Size = new Size(250, 30), Location = new Point(10, 10), BorderStyle = BorderStyle.None 
            };

            localTxt.Enter += (s, e) => { if (localTxt.Text == hint) { localTxt.Text = ""; localTxt.ForeColor = Color.Black; } };
            localTxt.Leave += (s, e) => { if (string.IsNullOrWhiteSpace(localTxt.Text)) { localTxt.Text = hint; localTxt.ForeColor = Color.Gray; } };

            t = localTxt;
            p.Controls.Add(line); p.Controls.Add(t);
            return p;
        }
    }
}