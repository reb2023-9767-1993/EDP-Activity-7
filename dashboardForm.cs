using System;
using System.Drawing;
using System.Windows.Forms;

namespace GradingSystem
{
    public partial class dashboardForm : Form
    {
        public dashboardForm()
        {
            InitializeComponent();
            SetupDashboardEvents();
        }

        private void SetupDashboardEvents()
        {
            if (btnNavAbout != null)
                btnNavAbout.Click += (s, e) => new aboutForm().ShowDialog();

            if (btnNavReports != null)
                btnNavReports.Click += (s, e) => new reportForm().ShowDialog();

            if (btnNavDashboard != null)
                btnNavDashboard.Click += (s, e) => this.Refresh();

            // Link the Edit Profile button to your method
            if (btnEditProfile != null)
                btnEditProfile.Click += new EventHandler(this.btnEditProfile_Click);

            if (btnNavLogout != null)
            {
                btnNavLogout.Click += (s, e) => {
                    // It's better to Logout to Login screen instead of closing app
                    Form1 login = new Form1();
                    login.Show();
                    this.Close();
                };
            }

            if (btnAdmin != null)
            {
                btnAdmin.Click += (s, e) => {
                    adminForm adminPanel = new adminForm();
                    adminPanel.ShowDialog();
                };
                
                // Add hover effect to match the others
                btnAdmin.MouseEnter += (s, e) => btnAdmin.ForeColor = Color.FromArgb(52, 152, 219);
                btnAdmin.MouseLeave += (s, e) => btnAdmin.ForeColor = Color.FromArgb(127, 140, 141);
            }
            
        }


        private void btnEditProfile_Click(object sender, EventArgs e)
        {
            ProfileForm prof = new ProfileForm();
            prof.ShowDialog();
           
        }
    }
}