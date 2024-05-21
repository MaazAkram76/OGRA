using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace otherDashboards
{
    public partial class clientpersonal : Form
    {
        public clientpersonal()
        {
            InitializeComponent();
        }

        private void logincloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
