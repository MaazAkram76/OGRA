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
    public partial class complaintregistration : Form
    {
        public complaintregistration()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void resetLabel_Click(object sender, EventArgs e)
        {
            regcomnamebox.Clear();
            regcomemailbox.Clear();
            regcomdobbox.Clear();
            regcomcontactbox.Clear();
            regcomcnicbox.Clear();
            regcomcatagorybox.Clear();
            regcompasswordbox.Clear();
            regcomconfirmpasswordbox.Clear();
            regcompro.Clear();
            regcomcity.Clear();
            regcomarea.Clear();
            regcomstreet.Clear();
            regcomhno.Clear();
           
        }

        private void comregisterBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You are successfully Registered");

        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            complaintlogin form = new complaintlogin();
            form.Show();
            this.Hide();
        }
    }
}
