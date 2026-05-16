namespace GradingSystem
{
    partial class reportForm
    {
        private System.ComponentModel.IContainer components = null;

        // Visual Panels and Static Output Prompts
        private System.Windows.Forms.Panel pnlTopNav;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Panel pnlCenter;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView dgvReports;
        private System.Windows.Forms.Button btnPrint;
        
        // Transaction Management Inputs
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Button btnPass;
        private System.Windows.Forms.Button btnFail;

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
            System.Windows.Forms.DataGridViewCellStyle headerStyle = new System.Windows.Forms.DataGridViewCellStyle();
            
            this.pnlTopNav = new System.Windows.Forms.Panel();
            this.lblLogo = new System.Windows.Forms.Label();
            this.pnlCenter = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.dgvReports = new System.Windows.Forms.DataGridView();
            this.btnPrint = new System.Windows.Forms.Button();
            
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.btnPass = new System.Windows.Forms.Button();
            this.btnFail = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.dgvReports)).BeginInit();
            this.pnlTopNav.SuspendLayout();
            this.pnlCenter.SuspendLayout();
            this.SuspendLayout();

            // Window Layout Properties
            this.Size = new System.Drawing.Size(1100, 750);
            this.Text = "Grade Reports - Grading Information System";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.BackColor = System.Drawing.Color.FromArgb(235, 242, 250);

            // Banner Title Bar Decoration
            this.pnlTopNav.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopNav.Height = 60;
            this.pnlTopNav.BackColor = System.Drawing.Color.White;
            this.lblLogo.Text = "📊 Grading System | Management Reports";
            this.lblLogo.Font = new System.Drawing.Font("Segoe UI Semibold", 12, System.Drawing.FontStyle.Bold);
            this.lblLogo.Location = new System.Drawing.Point(30, 18);
            this.lblLogo.AutoSize = true;
            this.pnlTopNav.Controls.Add(lblLogo);

            // Main Background Panel Containers
            this.pnlCenter.Size = new System.Drawing.Size(1000, 620);
            this.pnlCenter.Location = new System.Drawing.Point((this.Width - 1000) / 2, 70);
            this.pnlCenter.BackColor = System.Drawing.Color.Transparent;

            this.lblTitle.Text = "Student Performance Analytics Report";
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 18, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(10, 10);
            this.lblTitle.AutoSize = true;

            // Search Filter Label Prompt
            this.lblSearch.Text = "Search Student:";
            this.lblSearch.Font = new System.Drawing.Font("Segoe UI", 10, System.Drawing.FontStyle.Regular);
            this.lblSearch.Location = new System.Drawing.Point(12, 63);
            this.lblSearch.AutoSize = true;

            // Real-Time Search Box
            this.txtSearch.Location = new System.Drawing.Point(125, 60);
            this.txtSearch.Size = new System.Drawing.Size(260, 25);
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 10);
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);

            // Grid View Column Alignment Target Configuration
            this.dgvReports.Location = new System.Drawing.Point(10, 100);
            this.dgvReports.Size = new System.Drawing.Size(980, 420);
            this.dgvReports.BackgroundColor = System.Drawing.Color.White;
            this.dgvReports.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvReports.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReports.EnableHeadersVisualStyles = false;
            this.dgvReports.RowHeadersVisible = false;
            this.dgvReports.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReports.AllowUserToAddRows = false;

            headerStyle.BackColor = System.Drawing.Color.FromArgb(52, 152, 219);
            headerStyle.ForeColor = System.Drawing.Color.White;
            headerStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 10);
            this.dgvReports.ColumnHeadersDefaultCellStyle = headerStyle;
            this.dgvReports.ColumnHeadersHeight = 40;

            // Transaction Option 1 Button: Mark Passed
            this.btnPass.Text = "Mark Passed ✔";
            this.btnPass.Location = new System.Drawing.Point(10, 540);
            this.btnPass.Size = new System.Drawing.Size(140, 40);
            this.btnPass.BackColor = System.Drawing.Color.FromArgb(52, 152, 219);
            this.btnPass.ForeColor = System.Drawing.Color.White;
            this.btnPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPass.Font = new System.Drawing.Font("Segoe UI Bold", 9, System.Drawing.FontStyle.Bold);
            this.btnPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPass.Click += new System.EventHandler(this.btnPass_Click);

            // Transaction Option 2 Button: Mark Failed
            this.btnFail.Text = "Mark Failed ✖";
            this.btnFail.Location = new System.Drawing.Point(160, 540);
            this.btnFail.Size = new System.Drawing.Size(140, 40);
            this.btnFail.BackColor = System.Drawing.Color.FromArgb(231, 76, 60);
            this.btnFail.ForeColor = System.Drawing.Color.White;
            this.btnFail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFail.Font = new System.Drawing.Font("Segoe UI Bold", 9, System.Drawing.FontStyle.Bold);
            this.btnFail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFail.Click += new System.EventHandler(this.btnFail_Click);

            // Multi-sheet Spreadsheet Export Template Generation Action Trigger
            this.btnPrint.Text = "Export Report Template";
            this.btnPrint.Location = new System.Drawing.Point(810, 540);
            this.btnPrint.Size = new System.Drawing.Size(180, 40);
            this.btnPrint.BackColor = System.Drawing.Color.FromArgb(46, 204, 113);
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Segoe UI Bold", 9, System.Drawing.FontStyle.Bold);
            this.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);

            // Assemble UI Elements
            this.pnlCenter.Controls.AddRange(new System.Windows.Forms.Control[] { 
                this.lblTitle, this.lblSearch, this.txtSearch, this.dgvReports, this.btnPass, this.btnFail, this.btnPrint 
            });
            this.Controls.AddRange(new System.Windows.Forms.Control[] { this.pnlTopNav, this.pnlCenter });

            ((System.ComponentModel.ISupportInitialize)(this.dgvReports)).EndInit();
            this.pnlTopNav.ResumeLayout(false);
            this.pnlTopNav.PerformLayout();
            this.pnlCenter.ResumeLayout(false);
            this.pnlCenter.PerformLayout();
            this.ResumeLayout(false);
        }
    }
}