namespace GradingSystem
{
    partial class dashboardForm
    {
        private System.ComponentModel.IContainer components = null;

        // Form Controls
        private System.Windows.Forms.Panel pnlTopNav;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Panel pnlCenterStage;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Panel pnlLine;
        private System.Windows.Forms.Label lblActTitle;
        private System.Windows.Forms.Label lblActContent;

        // Navigation Buttons
        private System.Windows.Forms.Button btnNavLogout;
        private System.Windows.Forms.Button btnNavAbout;
        private System.Windows.Forms.Button btnNavReports;
        private System.Windows.Forms.Button btnNavDashboard;
        private System.Windows.Forms.Button btnEditProfile;
        private System.Windows.Forms.Button btnAdmin; // Added Admin

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();

            // Form Settings
            this.Size = new System.Drawing.Size(1200, 750);
            this.Text = "Grading System - Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.BackColor = System.Drawing.Color.FromArgb(235, 242, 250);
            this.Font = new System.Drawing.Font("Segoe UI", 9);

            // 1. Top Navigation Bar
            this.pnlTopNav = new System.Windows.Forms.Panel { 
                Dock = System.Windows.Forms.DockStyle.Top, 
                Height = 60, 
                BackColor = System.Drawing.Color.White 
            };
            
            this.lblLogo = new System.Windows.Forms.Label {
                Text = "📊 Grading System",
                Font = new System.Drawing.Font("Segoe UI Semibold", 12, System.Drawing.FontStyle.Bold),
                ForeColor = System.Drawing.Color.FromArgb(44, 62, 80),
                Location = new System.Drawing.Point(30, 18),
                AutoSize = true
            };

            // --- RECALIBRATED BUTTON POSITIONS (Right to Left) ---
            
            // Logout (Far Right)
            btnNavLogout = CreateNavBtn("Logout", 1160, System.Drawing.Color.FromArgb(243, 156, 18), true);

            // Profile (Next to Logout)
            this.btnEditProfile = new System.Windows.Forms.Button {
                Text = "Profile",
                Font = new System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold),
                Size = new System.Drawing.Size(85, 32),
                Location = new System.Drawing.Point(965, 15), 
                FlatStyle = System.Windows.Forms.FlatStyle.Flat,
                BackColor = System.Drawing.Color.Transparent,
                ForeColor = System.Drawing.Color.FromArgb(127, 140, 141),
                Cursor = System.Windows.Forms.Cursors.Hand
            };
            this.btnEditProfile.FlatAppearance.BorderSize = 0;

            // Admin (Next to Profile)
            this.btnAdmin = new System.Windows.Forms.Button {
                Text = "Admin",
                Font = new System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold),
                Size = new System.Drawing.Size(85, 32),
                Location = new System.Drawing.Point(880, 15), 
                FlatStyle = System.Windows.Forms.FlatStyle.Flat,
                BackColor = System.Drawing.Color.Transparent,
                ForeColor = System.Drawing.Color.FromArgb(127, 140, 141),
                Cursor = System.Windows.Forms.Cursors.Hand
            };
            this.btnAdmin.FlatAppearance.BorderSize = 0;

            // About, Reports, Dashboard (Clustered towards the center)
            btnNavAbout = CreateNavBtn("About", 870, System.Drawing.Color.Transparent, false);
            btnNavReports = CreateNavBtn("Reports", 770, System.Drawing.Color.Transparent, false);
            btnNavDashboard = CreateNavBtn("Dashboard", 670, System.Drawing.Color.FromArgb(52, 152, 219), true);

            // Assembly to Panel (Order doesn't matter here, but consistency does)
            pnlTopNav.Controls.AddRange(new System.Windows.Forms.Control[] { 
                lblLogo, btnNavDashboard, btnNavReports, btnNavAbout, btnAdmin, btnEditProfile, btnNavLogout 
            });

            // 2. Center Stage Container
            this.pnlCenterStage = new System.Windows.Forms.Panel {
                Width = 950,
                Height = 550,
                BackColor = System.Drawing.Color.Transparent,
                Location = new System.Drawing.Point((this.Width - 950) / 2, 80)
            };

            this.lblHeader = new System.Windows.Forms.Label {
                Text = "Dashboard",
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

            // 3. Stats Cards
            CreateModernCard(pnlCenterStage, "150", "Students", 10, 80, System.Drawing.Color.FromArgb(52, 152, 219));
            CreateModernCard(pnlCenterStage, "12", "Courses", 325, 80, System.Drawing.Color.FromArgb(46, 204, 113));
            CreateModernCard(pnlCenterStage, "88%", "Passing Rate", 640, 80, System.Drawing.Color.FromArgb(155, 89, 182));

            // 4. Recent Activity
            this.lblActTitle = new System.Windows.Forms.Label {
                Text = "Recent Activity",
                Font = new System.Drawing.Font("Segoe UI Bold", 12, System.Drawing.FontStyle.Bold),
                ForeColor = System.Drawing.Color.FromArgb(44, 62, 80),
                Location = new System.Drawing.Point(15, 250),
                AutoSize = true
            };

            string activities = "• System Update: Authentication modules verified\n\n• User Database: Profile update features enabled\n\n• Admin Module: User Management ready";
            this.lblActContent = new System.Windows.Forms.Label {
                Text = activities,
                Font = new System.Drawing.Font("Segoe UI", 10),
                ForeColor = System.Drawing.Color.FromArgb(127, 140, 141),
                Location = new System.Drawing.Point(30, 290),
                Size = new System.Drawing.Size(600, 150)
            };

            pnlCenterStage.Controls.AddRange(new System.Windows.Forms.Control[] { lblHeader, pnlLine, lblActTitle, lblActContent });

            this.Controls.Add(pnlCenterStage);
            this.Controls.Add(pnlTopNav);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button CreateNavBtn(string text, int x, System.Drawing.Color bg, bool filled)
        {
            var b = new System.Windows.Forms.Button {
                Text = text,
                Left = x - 100,
                Top = 15,
                Size = new System.Drawing.Size(95, 32),
                FlatStyle = System.Windows.Forms.FlatStyle.Flat,
                BackColor = bg,
                ForeColor = filled ? System.Drawing.Color.White : System.Drawing.Color.FromArgb(127, 140, 141),
                Font = new System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold),
                Cursor = System.Windows.Forms.Cursors.Hand
            };
            b.FlatAppearance.BorderSize = 0;
            return b;
        }

        private void CreateModernCard(System.Windows.Forms.Panel parent, string val, string title, int x, int y, System.Drawing.Color accent)
        {
            System.Windows.Forms.Panel card = new System.Windows.Forms.Panel {
                Size = new System.Drawing.Size(280, 140),
                Location = new System.Drawing.Point(x, y),
                BackColor = System.Drawing.Color.White
            };
            System.Windows.Forms.Panel accentTop = new System.Windows.Forms.Panel { Dock = System.Windows.Forms.DockStyle.Top, Height = 4, BackColor = accent };
            System.Windows.Forms.Label lVal = new System.Windows.Forms.Label {
                Text = val, Font = new System.Drawing.Font("Segoe UI", 28, System.Drawing.FontStyle.Bold),
                ForeColor = System.Drawing.Color.FromArgb(52, 152, 219), TextAlign = System.Drawing.ContentAlignment.MiddleCenter,
                Dock = System.Windows.Forms.DockStyle.Top, Height = 90
            };
            System.Windows.Forms.Label lTitle = new System.Windows.Forms.Label {
                Text = title, Font = new System.Drawing.Font("Segoe UI", 10),
                ForeColor = System.Drawing.Color.Gray, TextAlign = System.Drawing.ContentAlignment.MiddleCenter,
                Dock = System.Windows.Forms.DockStyle.Fill
            };
            card.Controls.Add(lTitle); card.Controls.Add(lVal); card.Controls.Add(accentTop);
            parent.Controls.Add(card);
        }
    }
}