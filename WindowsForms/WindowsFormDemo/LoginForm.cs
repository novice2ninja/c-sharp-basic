using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormDemo
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string txtUserNameValue = txtUserName.Text;
            string txtPasswordValue = txtPassword.Text;

            // Compare both the values, if true, login successful, else failed
            if (String.Compare("admin", txtUserNameValue) == 0) {
                if (String.Compare("Admin@1234", txtPasswordValue) == 0) {
                    frmWelcome welcomeForm = new frmWelcome();
                    welcomeForm.Show();
                    return;
                }
            }

            MessageBox.Show("Login Failed");
        }
    }
}
