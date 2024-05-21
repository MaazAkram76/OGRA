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
    public partial class clientlogin : Form
    {
        public clientlogin()
        {
            InitializeComponent();
        }

        private void clientregisterbtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You are successfully Registered");
        }

        private void clientresetLabel_Click(object sender, EventArgs e)
        {
            clientemailbox.Clear();
            clientpasswordbox.Clear();
        }

        private void logincloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }

        private void clientloginBtn_Click(object sender, EventArgs e)
        {
            clientpersonal form = new clientpersonal();
            form.Show();
            this.Hide();
        }
    }
}
