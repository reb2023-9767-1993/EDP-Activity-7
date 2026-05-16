namespace GradingSystem
{
    partial class aboutForm
    {
        private System.ComponentModel.IContainer components = null;

        // UI Components
        private System.Windows.Forms.Panel pnlTopNav;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Panel pnlCenter;
        private System.Windows.Forms.Label lblSection;
        private System.Windows.Forms.Panel pnlLine;
        private System.Windows.Forms.Panel infoCard;
        private System.Windows.Forms.Panel accentStrip;
        private System.Windows.Forms.Button btnClose;

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
            this.SuspendLayout();

            // 1. Form Settings
            this.Size = new System.Drawing.Size(1100, 750);
            this.Text = "About - Academic Grading System";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.BackColor = System.Drawing.Color.FromArgb(235, 242, 250);

            // 2. Top Nav Bar
            this.pnlTopNav = new System.Windows.Forms.Panel { Dock = System.Windows.Forms.DockStyle.Top, Height = 60, BackColor = System.Drawing.Color.White };
            this.lblLogo = new System.Windows.Forms.Label {
                Text = "📊 Grading System | About",
                Font = new System.Drawing.Font("Segoe UI Semibold", 12, System.Drawing.FontStyle.Bold),
                Location = new System.Drawing.Point(30, 18),
                AutoSize = true
            };
            pnlTopNav.Controls.Add(lblLogo);

            // 3. Center Container
            this.pnlCenter = new System.Windows.Forms.Panel {
                Width = 950,
                Height = 500,
                BackColor = System.Drawing.Color.Transparent,
                Location = new System.Drawing.Point((this.Width - 950) / 2, 80)
            };

            this.lblSection = new System.Windows.Forms.Label {
                Text = "About",
                Font = new System.Drawing.Font("Segoe UI Semibold", 20, System.Drawing.FontStyle.Bold),
                ForeColor = System.Drawing.Color.FromArgb(52, 73, 94),
                Location = new System.Drawing.Point(10, 10),
                AutoSize = true
            };

            this.pnlLine = new System.Windows.Forms.Panel { 
                BackColor = System.Drawing.Color.FromArgb(52, 152, 219), 
                Height = 2, Width = 930, 
                Location = new System.Drawing.Point(15, 55) 
            };

            // 4. Info Card
            this.infoCard = new System.Windows.Forms.Panel {
                Size = new System.Drawing.Size(850, 250),
                Location = new System.Drawing.Point(20, 90),
                BackColor = System.Drawing.Color.White
            };

            this.accentStrip = new System.Windows.Forms.Panel {
                Dock = System.Windows.Forms.DockStyle.Left,
                Width = 6,
                BackColor = System.Drawing.Color.FromArgb(52, 152, 219)
            };
            infoCard.Controls.Add(accentStrip);

            // Populate Info Details
            AddDetail(infoCard, "System Name:", "Academic Grading System", 30);
            AddDetail(infoCard, "Version:", "v4.0", 70);
            AddDetail(infoCard, "Description:", "A streamlined, accessible academic management platform designed to simplify grading workflows, track student performance metrics, and generate secure, data-driven end-of-semester reports.", 110, true);
            AddDetail(infoCard, "Developer:", "Rowena E. Bornilla", 200);

            // 5. Back Button
            this.btnClose = new System.Windows.Forms.Button {
                Text = "Back to Dashboard",
                Location = new System.Drawing.Point(740, 440),
                Size = new System.Drawing.Size(130, 40),
                BackColor = System.Drawing.Color.FromArgb(149, 165, 166),
                ForeColor = System.Drawing.Color.White,
                FlatStyle = System.Windows.Forms.FlatStyle.Flat,
                Font = new System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold),
                Cursor = System.Windows.Forms.Cursors.Hand
            };
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);

            // Assembly
            pnlCenter.Controls.AddRange(new System.Windows.Forms.Control[] { lblSection, pnlLine, infoCard, btnClose });
            this.Controls.AddRange(new System.Windows.Forms.Control[] { pnlTopNav, pnlCenter });

            this.ResumeLayout(false);
        }

        private void AddDetail(System.Windows.Forms.Panel parent, string label, string value, int y, bool multiLine = false)
        {
            System.Windows.Forms.Label lblKey = new System.Windows.Forms.Label {
                Text = label,
                Font = new System.Drawing.Font("Segoe UI", 10, System.Drawing.FontStyle.Bold),
                ForeColor = System.Drawing.Color.FromArgb(44, 62, 80),
                Location = new System.Drawing.Point(30, y),
                Width = 120
            };

            System.Windows.Forms.Label lblVal = new System.Windows.Forms.Label {
                Text = value,
                Font = multiLine ? new System.Drawing.Font("Segoe UI", 9) : new System.Drawing.Font("Segoe UI", 10),
                ForeColor = System.Drawing.Color.FromArgb(80, 80, 80),
                Location = new System.Drawing.Point(150, y),
                Size = multiLine ? new System.Drawing.Size(650, 80) : new System.Drawing.Size(650, 30)
            };

            parent.Controls.Add(lblKey);
            parent.Controls.Add(lblVal);
        }
    }
}