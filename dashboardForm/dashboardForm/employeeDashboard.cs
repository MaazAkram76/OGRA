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
    public partial class employeeDashboard : Form
    {
        public employeeDashboard()
        {
            InitializeComponent();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void employeeDashboard_Load(object sender, EventArgs e)
        {

        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            homeDashboard form = new homeDashboard();
            form.Show();
            this.Hide();
        }

        private void addEmployeeBtn_Click(object sender, EventArgs e)
        {
            searchempForm form = new searchempForm();
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

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void alotdptBtn_Click(object sender, EventArgs e)
        {
            alotdptDashboard form = new alotdptDashboard();
            form.Show();
            this.Hide();
        }
    }
}
