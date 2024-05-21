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
    public partial class departmentDashboard : Form
    {
        public departmentDashboard()
        {
            InitializeComponent();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            homeDashboard form = new homeDashboard();
            form.Show();
            this.Hide();
        }

        private void homeBtn_Click_1(object sender, EventArgs e)
        {
            homeDashboard form = new homeDashboard();
            form.Show();
            this.Hide();
        }

        private void employeeBtn_Click(object sender, EventArgs e)
        {
            employeeDashboard form = new employeeDashboard();
            form.Show();
            this.Hide();
        }

        private void complaintBtn_Click(object sender, EventArgs e)
        {
            complaintDashboard form = new complaintDashboard();
            form.Show();
            this.Hide();
        }

        private void companyBtn_Click(object sender, EventArgs e)
        {
            companyDashboard form = new companyDashboard();
            form.Show();
            this.Hide();
        }

        private void licenseBtn_Click(object sender, EventArgs e)
        {
            licenseDashboard form = new licenseDashboard();
            form.Show();
            this.Hide();
        }

        private void priceBtn_Click(object sender, EventArgs e)
        {
            priceDashboard form = new priceDashboard();
            form.Show();
            this.Hide();
        }

        private void addDepartmentBtn_Click(object sender, EventArgs e)
        {
            adddptForm form = new adddptForm();
            form.Show();
            this.Hide();
        }
    }
}
