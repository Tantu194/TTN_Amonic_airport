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
using TTN_Amonic.DAL;

namespace TTN_Amonic
{
    public partial class frmLogin : Form
    {
        bool isValidate = false;
        int loginCount = 0;
        int timeCountDown = 10;

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
            DataTable dtUser = FunctionSession1.Login(username, password);
            if (dtUser.Rows.Count > 0)
            {
                // Login successful :D
                int role = Int32.Parse(dtUser.Rows[0]["RoleID"].ToString());
                GlobalClass.RoleID = role;
                GlobalClass.FirstName = dtUser.Rows[0]["FirstName"].ToString();
                GlobalClass.UserID = Int32.Parse(dtUser.Rows[0]["ID"].ToString());
                GlobalClass.LoginTime = DateTime.Now.TimeOfDay;
                Boolean isActive = Boolean.Parse(dtUser.Rows[0]["Active"].ToString());

                if (isActive)
                {
                    DataTable userLogs = FunctionSession1.getLogByUserId(GlobalClass.UserID);
                    int logsCount = userLogs.Rows.Count;
                    if (logsCount >= 1 && DBNull.Value.Equals(userLogs.Rows[logsCount - 1]["LogoutTime"]))
                    {
                        this.Hide();
                        frmNoLogoutDetected frmReport = new frmNoLogoutDetected();
                        frmReport.LastDateLogin = DateTime.Parse(userLogs.Rows[logsCount - 1]["DateLogin"].ToString());
                        frmReport.LastLoginTime = TimeSpan.Parse(userLogs.Rows[logsCount - 1]["LoginTime"].ToString());
                        frmReport.ShowDialog();
                    }

                    if (role == 1)
                    {
                        MessageBox.Show("Login successful. You're Admin");
                    }
                    else
                    {
                        
                        bool success = FunctionSession1.InsertLogs(GlobalClass.UserID, DateTime.Now.Date, GlobalClass.LoginTime);
                        if (success)
                        {
                            this.Hide();
                            frmUser frmUser = new frmUser();
                            frmUser.Show();
                        }
                        else
                        {
                            MessageBox.Show("Cannot write the logs to database !!!");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Your account was disabled !!!");
                }
            }
            else
            {
                loginCount++;
                if (loginCount >= 3)
                {
                    txtUsername.Enabled = false;
                    txtPassword.Enabled = false;
                    btnLogin.Enabled = false;
                    timer.Enabled = true;
                    loginCount = 0;
                }
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
            {
                if (GlobalClass.UserID != -1)
                    FunctionSession1.Logout(GlobalClass.UserID, GlobalClass.LoginTime);
                this.Close();
            }

        }

        private void frmUser_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if (MessageBox.Show("Do you want to exit ?", "Warning !!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
            //    e.Cancel = true;
            //else
            //{
            //    if (GlobalClass.UserID != -1)
            //        FunctionSession1.Logout(GlobalClass.UserID, GlobalClass.LoginTime);
            //    this.Close();
            //}
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(sender, e);
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            lblMessage.Text = "You will login continue after: " + timeCountDown.ToString() + " seconds";
            timeCountDown--;
            if (timeCountDown <= 0)
            {
                txtUsername.Enabled = true;
                txtPassword.Enabled = true;
                btnLogin.Enabled = true;
                timer.Enabled = false;
                lblMessage.Text = "";
            }
        }
    }
}
