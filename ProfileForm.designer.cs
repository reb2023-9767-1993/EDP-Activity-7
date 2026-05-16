namespace GradingSystem
{
    partial class ProfileForm
    {
        private System.Windows.Forms.Panel card;
        private System.Windows.Forms.TextBox txtFullName, txtEmail, txtPass;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblTitle;

        private void InitializeComponent()
        {
            this.card = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();

            this.SuspendLayout();
            this.Size = new System.Drawing.Size(450, 500);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.StartPosition = FormStartPosition.CenterParent;

            this.card.Size = new System.Drawing.Size(350, 380);
            this.card.BackColor = System.Drawing.Color.White;
            this.card.Location = new System.Drawing.Point(42, 40);

            this.lblTitle.Text = "Update Profile";
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 16, FontStyle.Bold);
            this.lblTitle.Size = new System.Drawing.Size(310, 40);
            this.lblTitle.Location = new System.Drawing.Point(20, 20);
            this.lblTitle.TextAlign = ContentAlignment.MiddleCenter;

            this.card.Controls.Add(CreateInput(out txtFullName, "Full Name", 100));
            this.card.Controls.Add(CreateInput(out txtEmail, "Email Address", 170));
            this.card.Controls.Add(CreateInput(out txtPass, "New Password", 240));

            this.btnUpdate.Text = "Save Changes";
            this.btnUpdate.Size = new System.Drawing.Size(270, 45);
            this.btnUpdate.Location = new System.Drawing.Point(40, 310);
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(101, 88, 203);
            this.btnUpdate.ForeColor = Color.White;
            this.btnUpdate.FlatStyle = FlatStyle.Flat;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);

            this.card.Controls.Add(lblTitle);
            this.card.Controls.Add(btnUpdate);
            this.Controls.Add(card);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel CreateInput(out TextBox t, string hint, int y)
        {
            var p = new System.Windows.Forms.Panel { Size = new Size(270, 50), Location = new Point(40, y), BackColor = Color.White };
            var line = new System.Windows.Forms.Panel { Dock = DockStyle.Bottom, Height = 2, BackColor = Color.FromArgb(220, 220, 220) };
            t = new TextBox { Font = new Font("Segoe UI", 11), Size = new Size(250, 30), Location = new Point(10, 10), BorderStyle = BorderStyle.None };
            p.Controls.Add(line); p.Controls.Add(t);
            return p;
        }
    }
}