using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dashboardForm
{
    public partial class licenseDashboard : Form
    {
        public licenseDashboard()
        {
            InitializeComponent();
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            homeDashboard form = new homeDashboard();
            form.Show();
            this.Hide();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void licenseDashboard_Load(object sender, EventArgs e)
        {

        }

        private void homeBtn_Click_1(object sender, EventArgs e)
        {
            homeDashboard form = new homeDashboard();
            form.Show();
            this.Hide();
        }

        private void departmentBtn_Click(object sender, EventArgs e)
        {
            departmentDashboard form = new departmentDashboard();
            form.Show();
            this.Hide();
        }

        private void complaintBtn_Click(object sender, EventArgs e)
        {
            complaintDashboard form = new complaintDashboard();
            form.Show();
            this.Hide();
        }

        private void CompanyBtn_Click(object sender, EventArgs e)
        {
            companyDashboard form = new companyDashboard();
            form.Show();
            this.Hide();
        }

        private void employeeBtn_Click(object sender, EventArgs e)
        {
            employeeDashboard form = new employeeDashboard();
            form.Show();
            this.Hide();
        }

        private void priceBtn_Click(object sender, EventArgs e)
        {
            priceDashboard form = new priceDashboard();
            form.Show();
            this.Hide();
        }

        private void licenseLabel_Click(object sender, EventArgs e)
        {

        }

        private void addLicenseBtn_Click(object sender, EventArgs e)
        {
            addlicenseForm form = new addlicenseForm();
            form.Show();
            this.Hide();
        }

        private void searchLicBtn_Click(object sender, EventArgs e)
        {
            searchlicenseForm form = new searchlicenseForm();
            form.Show();
            this.Hide();
        }
    }
}
