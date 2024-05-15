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
    public partial class registration : Form
    {
        public registration()
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
            registeremailbox.Clear();
            registerusernamebox.Clear();
            registerpasswordbox.Clear();
            registerconfirmpasswordbox.Clear();
        }
    }
}
