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
    public partial class clientregistration : Form
    {
        public clientregistration()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void resetLabel_Click(object sender, EventArgs e)
        {
            regclinamebox.Clear();
            regcliemailbox.Clear();
            regclidobbox.Clear();
            regclicontactbox.Clear();
            regclicompanynamebox.Clear();
            regcliownershipebox.Clear();
            recliorganizationbox.Clear();
            regclipasswordbox.Clear();
            regcliconfirmpasswordbox.Clear();
            regclipro.Clear();
            regclicity.Clear();
            regcliarea.Clear();
            regclistreet.Clear();
            regclihno.Clear();
        }

        private void cliregisterBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You are successfully Registered");
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clientlogin form = new clientlogin();
            form.Show();
            this.Hide();
        }

        private void regcliownershiptype_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void clientregistration_Load(object sender, EventArgs e)
        {

        }
    }
}
