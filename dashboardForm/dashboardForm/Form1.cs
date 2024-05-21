using ograforms;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void adminBtn_Click(object sender, EventArgs e)
        {
            login form = new login();
            form.Show();
            this.Hide();
        }

        private void employeebtn_Click(object sender, EventArgs e)
        {
            employeelogin form = new employeelogin();
            form.Show();
            this.Hide();
        }

        private void Clientbtn_Click(object sender, EventArgs e)
        {
            clientlogin form = new clientlogin();
            form.Show();
            this.Hide();
        }

        private void complaintbtn_Click(object sender, EventArgs e)
        {
            complaintlogin form = new complaintlogin();
            form.Show();
            this.Hide();
        }

        private void frontcloseBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
