using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dashboardForm
{
    public partial class homeDashboard : Form
    {
        public homeDashboard()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            departmentDashboard form = new departmentDashboard();
            form.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            employeeDashboard form = new employeeDashboard();
            form.Show();
            this.Hide();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void License_Click(object sender, EventArgs e)
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
    }
}
