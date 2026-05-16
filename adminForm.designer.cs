namespace GradingSystem
{
    partial class adminForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvAccounts;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnActivate;
        private System.Windows.Forms.Button btnDeactivate;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Label lblTitleHeader; // Added modern descriptor header

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dgvAccounts = new System.Windows.Forms.DataGridView();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnActivate = new System.Windows.Forms.Button();
            this.btnDeactivate = new System.Windows.Forms.Button();
            this.lblSearch = new System.Windows.Forms.Label();
            this.lblTitleHeader = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccounts)).BeginInit();
            this.SuspendLayout();

            // Form Settings
            this.Size = new System.Drawing.Size(800, 520);
            this.Text = "Registrar Panel - Student Enrollment Management";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.BackColor = System.Drawing.Color.FromArgb(245, 247, 250);

            // Descriptive Section Header Label
            this.lblTitleHeader.Text = "Student Enrollment Master Roster";
            this.lblTitleHeader.Location = new System.Drawing.Point(20, 15);
            this.lblTitleHeader.Size = new System.Drawing.Size(400, 30);
            this.lblTitleHeader.Font = new System.Drawing.Font("Segoe UI Semibold", 14, System.Drawing.FontStyle.Bold);
            this.lblTitleHeader.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80);

            // Search Label Prompt
            this.lblSearch.Text = "Search Student:";
            this.lblSearch.Location = new System.Drawing.Point(20, 63);
            this.lblSearch.Font = new System.Drawing.Font("Segoe UI", 10);
            this.lblSearch.AutoSize = true;

            // Search Input TextBox
            this.txtSearch.Location = new System.Drawing.Point(135, 60);
            this.txtSearch.Size = new System.Drawing.Size(280, 25);
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 10);
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);

            // DataGridView Canvas Mapping Layout
            this.dgvAccounts.Location = new System.Drawing.Point(20, 105);
            this.dgvAccounts.Size = new System.Drawing.Size(745, 300);
            this.dgvAccounts.BackgroundColor = System.Drawing.Color.White;
            this.dgvAccounts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAccounts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAccounts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAccounts.ReadOnly = true;
            this.dgvAccounts.AllowUserToAddRows = false;
            this.dgvAccounts.RowHeadersVisible = false;

            // Set Enrolled Transaction Button
            this.btnActivate.Text = "Set Enrolled ✔";
            this.btnActivate.Location = new System.Drawing.Point(20, 425);
            this.btnActivate.Size = new System.Drawing.Size(140, 38);
            this.btnActivate.BackColor = System.Drawing.Color.FromArgb(46, 204, 113);
            this.btnActivate.ForeColor = System.Drawing.Color.White;
            this.btnActivate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActivate.Font = new System.Drawing.Font("Segoe UI Bold", 9, System.Drawing.FontStyle.Bold);
            this.btnActivate.Cursor = System.Windows.Forms.Cursors.Hand;

            // Set Not Enrolled Transaction Button
            this.btnDeactivate.Text = "Set Not Enrolled ✖";
            this.btnDeactivate.Location = new System.Drawing.Point(175, 425);
            this.btnDeactivate.Size = new System.Drawing.Size(140, 38);
            this.btnDeactivate.BackColor = System.Drawing.Color.FromArgb(231, 76, 60);
            this.btnDeactivate.ForeColor = System.Drawing.Color.White;
            this.btnDeactivate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeactivate.Font = new System.Drawing.Font("Segoe UI Bold", 9, System.Drawing.FontStyle.Bold);
            this.btnDeactivate.Cursor = System.Windows.Forms.Cursors.Hand;

            // Add Controls to Container Window Workspace
            this.Controls.AddRange(new System.Windows.Forms.Control[] { 
                this.lblTitleHeader, this.lblSearch, this.txtSearch, this.dgvAccounts, this.btnActivate, this.btnDeactivate 
            });

            ((System.ComponentModel.ISupportInitialize)(this.dgvAccounts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}