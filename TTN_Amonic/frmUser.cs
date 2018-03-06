using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TTN_Amonic.DAL;

namespace TTN_Amonic
{
    public partial class frmUser : Form
    {
        public string username = "";

        public frmUser()
        {
            InitializeComponent();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void loadLogs()
        {
            lvLogs.Items.Clear();
            DataTable dtLogs = FunctionSession1.getLogs();
            TimeSpan totalTimeSpentOnSystem = new TimeSpan();
            int numOfCashes = 0;
            for (int i = 0; i < dtLogs.Rows.Count - 1; i++)
            {
                DateTime loginTime = DateTime.Parse(dtLogs.Rows[i]["LoginTime"].ToString());
                string strLogoutTime = "**";
                //string strReason = "";
                string timeSpent = "**";
                if (!DBNull.Value.Equals(dtLogs.Rows[i]["LogoutTime"]))
                {
                    if (!TimeSpan.Parse(dtLogs.Rows[i]["LogoutTime"].ToString()).Equals(TimeSpan.Zero))
                    {
                        DateTime logoutTime = DateTime.Parse(dtLogs.Rows[i]["LogoutTime"].ToString());
                        strLogoutTime = loginTime.ToString("HH:mm");
                        TimeSpan timeS = logoutTime.Subtract(loginTime);
                        totalTimeSpentOnSystem = totalTimeSpentOnSystem.Add(timeS);
                        timeSpent = timeS.ToString(@"hh\:mm\:ss");
                    }

                }
                else
                {
                    numOfCashes++;
                }

                string[] arrayItem = {
                    DateTime.Parse(dtLogs.Rows[i]["DateLogin"].ToString()).ToString("dd/MM/yyyy"),
                    loginTime.ToString("HH:mm"),
                    strLogoutTime,
                    timeSpent,
                    dtLogs.Rows[i]["Reason"].ToString()
                };
                ListViewItem item = new ListViewItem(arrayItem);
                if (strLogoutTime == "**") item.BackColor = Color.Red;
                lvLogs.Items.Add(item);
            }

            lblTimeSpent.Text = "Time spent on system: " + totalTimeSpentOnSystem.ToString(@"hh\:mm\:ss");
            lblNumberOfCashes.Text = "Number of cashes: " + numOfCashes.ToString();
        }

        private void frmUser_Load(object sender, EventArgs e)
        {
            lblMessage.Text = "Hi " + GlobalClass.FirstName + ", Welcome to AMONIC Airlines";
            loadLogs();
        }

        private void frmUser_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if (MessageBox.Show("Do you want to exit ?", "Warning !!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
            //    e.Cancel = true;
            //else
            //{
            //    if (GlobalClass.UserID != -1)
            //        FunctionSession1.Logout(GlobalClass.UserID, GlobalClass.LoginTime);
            //}
        }
    }
}
