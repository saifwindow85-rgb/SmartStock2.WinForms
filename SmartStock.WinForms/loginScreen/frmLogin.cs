using SmartStock.BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartStock.WinForms.loginScreen
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }


        private void CheckLogIn()
        {
            string UserName = txtUserName.Text.Trim();
            string Password = txtPassword.Text.Trim();
            ClsUser User = ClsUser.Find(UserName, Password);
            if(User == null)
            {
                MessageBox.Show("Invalid UserName/Password", "Logging Faield", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            frmMain frm = new frmMain();
            frm.ShowDialog();
        }


       
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(!this.ValidateChildren())
            {
                MessageBox.Show("All Fields Are Requierd !!","Empty Fields",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            CheckLogIn();
        }

        private void txtUserName_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrEmpty(txtUserName.Text.Trim()))
            {
                errorProvider1.SetError(txtUserName, "This Field Is Requierd !");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtUserName, null);
            }
        }

        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtPassword.Text.Trim()))
            {
                errorProvider1.SetError(txtPassword, "This Field Is Requierd !");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtPassword, null);
            }
        }
    }
}
