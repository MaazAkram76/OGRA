﻿using ograforms;
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
    public partial class startingPage : Form
    {
        public startingPage()
        {
            InitializeComponent();
        }

        private void adminBtn_Click(object sender, EventArgs e)
        {
            login form = new login();
            form.Show();
            this.Hide();
        }
    }
}