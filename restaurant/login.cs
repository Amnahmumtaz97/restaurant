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
            if (MainClass.isValidUser(txtUser.Text, txtPass.Text) == false)
            {
                guna2MessageDialog1.Show("Invalid username or password!");
                return;
            
            }
            else
            {
                this.Hide();    
                frmMain frm = new frmMain();
                frm.Show();
            }

        } 

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2CheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
