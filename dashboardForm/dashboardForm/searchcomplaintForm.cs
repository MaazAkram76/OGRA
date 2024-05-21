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
    public partial class searchcomplaintForm : Form
    {
        public searchcomplaintForm()
        {
            InitializeComponent();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            complaintDashboard form = new complaintDashboard();
            form.Show();
            this.Hide();
        }

        private void searchcomplaintgridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
