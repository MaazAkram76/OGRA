using ograforms;
using otherDashboards;
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
    public partial class complaintlogin : Form
    {
        public complaintlogin()
        {
            InitializeComponent();
        }

        private void logincloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void complaintregisterbtn_Click(object sender, EventArgs e)
        {
            complaintregistration form = new complaintregistration();
            form.Show();
            this.Hide();
        }

        private void complaintresetLabel_Click(object sender, EventArgs e)
        {
            complaintemailbox.Clear();
            complaintpasswordbox.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }

        private void complaintloginBtn_Click(object sender, EventArgs e)
        {
            complaintpersonal form = new complaintpersonal();
            form.Show();
            this.Hide();
        }
    }
}
