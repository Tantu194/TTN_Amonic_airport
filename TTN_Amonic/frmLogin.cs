using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.Net.Mail;

namespace TTN_Amonic
{
    public partial class frmLogin : Form
    {
        bool isValidate = false;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void frmUser_Load(object sender, EventArgs e)
        {
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            isValidate = true;
            this.ValidateChildren();
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            ConnectDB db = new ConnectDB();
            DataTable dtUser = db.Login(username, password);
            if (dtUser.Rows.Count > 0)
            {
                // Login successful :D
                int role = Int32.Parse(dtUser.Rows[0]["RoleID"].ToString());
                if (role == 1)
                {
                    MessageBox.Show("Login successful. You're Admin");
                }
                else
                {
                    MessageBox.Show("Login successful. You're Officer");
                }
            }
            else
            {
                MessageBox.Show("Username or password was wrong !!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            isValidate = false;
        }

        private void txtUsername_Validating(object sender, CancelEventArgs e)
        {
            if (isValidate == false) return;
            if (txtUsername.Text == "")
            {
                errorProvider.SetError(txtUsername, "Please enter username !!!");
                e.Cancel = true;
            }
            else
            {
                errorProvider.Clear();
            }
        }

        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            if (isValidate == false) return;
            if (txtPassword.Text == "")
            {
                errorProvider.SetError(txtPassword, "Please enter password !!!");
                e.Cancel = true;
            }
            else
            {
                errorProvider.Clear();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to exit ?", "Warning !!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                Application.Exit();
        }

        private void frmUser_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Do you want to exit ?", "Warning !!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                e.Cancel = true; 
        }
    }
}
