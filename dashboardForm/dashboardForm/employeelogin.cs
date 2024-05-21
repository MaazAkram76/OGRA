using ograforms;
using otherDashboards;
using registrationForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectDB
{
    public partial class employeelogin : Form
    {
        public employeelogin()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void employeeregisterbtn_Click(object sender, EventArgs e)
        {
            employeeregistration form = new employeeregistration();
            form.Show();
            this.Hide();
        }

        private void logincloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void employeeemailbox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void employeeresetLabel_Click(object sender, EventArgs e)
        {
            employeeemailbox.Clear();
            employeepasswordbox.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }

        private void employeeloginBtn_Click(object sender, EventArgs e)
        {
            employeepresonal form = new employeepresonal();
            form.Show();
            this.Hide();
        }
    }
}
