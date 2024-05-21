using dashboardForm;
using ProjectDB;
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

namespace ograforms
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {

        }

        private void Label7_Click(object sender, EventArgs e)
        {
            adminemailbox.Clear();
            adminpasswordbox.Clear();
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void Label9_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void LoginAccountLabel_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click_1(object sender, EventArgs e)
        {

        }

        private void loginregisterbtn_Click(object sender, EventArgs e)
        {
            employeeregistration form = new employeeregistration();
            form.Show();
            this.Hide();
        }

        private void adminregisterbtn_Click(object sender, EventArgs e)
        {

        }

        private void logincloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void adminemailbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void adminresetLabel_Click(object sender, EventArgs e)
        {
            adminemailbox.Clear();
            adminpasswordbox.Clear();
        }

        private void adminpasswordbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void adminloginBtn_Click(object sender, EventArgs e)
        {
            homeDashboard form = new homeDashboard();
            form.Show();
            this.Hide();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

        }
    }
}
