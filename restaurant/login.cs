using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace restaurant
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

    
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUser.Text) || string.IsNullOrWhiteSpace(txtPass.Text))
            {
                ToolTip toolTip1 = new ToolTip();
                toolTip1.ToolTipTitle = "Invalid Entry";
                toolTip1.IsBalloon = true; // Makes it look like a speech bubble
                toolTip1.Show("Invalid username entered", txtUser, 0, -50, 2000); // Shows above the username textbox

            }


        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
    }
}
