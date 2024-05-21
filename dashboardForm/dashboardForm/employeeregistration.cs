using ProjectDB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace registrationForm
{
    public partial class employeeregistration : Form
    {
        public employeeregistration()
        {
            InitializeComponent();
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void LoginEmailTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void resetLabel_Click(object sender, EventArgs e)
        {
            regempemailbox.Clear();
            regempnamebox.Clear();
            regempdobbox.Clear();
            regempcontact1box.Clear();
            regempcontact2box.Clear();
            regemprolebox.Clear();
            regemppasswordbox.Clear();
            regempconfirmpasswordbox.Clear();
            regemppro.Clear();
            regempcity.Clear();
            regemparea.Clear();
            regempstreet.Clear();
            regemphno.Clear();
           
        }

        private void empregisterBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You are successfully Registered");
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            employeelogin form = new employeelogin();
            form.Show();
            this.Hide();
        }

        private void employeeregistration_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
