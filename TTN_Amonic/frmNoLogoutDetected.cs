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
    public partial class frmNoLogoutDetected : Form
    {
        public DateTime LastDateLogin { get; set; }
        public TimeSpan LastLoginTime { get; set; }

        public frmNoLogoutDetected()
        {
            InitializeComponent();
        }

        private void frmNoLogoutDetected_Load(object sender, EventArgs e)
        {
            lblMessage.Text = "No logout detected for your last login on " + LastDateLogin.ToString("dd/MM/yyyy") + " at " + LastLoginTime.ToString(@"hh\:mm");
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string reason = "";
            if (rdSoftwareCash.Checked)
            {
                reason += "Software cash!";
            }
            else if (rdSystemCash.Checked)
            {
                reason += "System cash!";
            }

            if (richTextBox1.Text != "")
            {
                reason += " " + richTextBox1.Text;
            }
            if (reason != "")
            {
                bool success = FunctionSession1.UpdateLogs(GlobalClass.UserID, LastLoginTime, TimeSpan.Zero, reason);
                this.Close();
            }
            else {
                MessageBox.Show("You must input the reason !!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void frmNoLogoutDetected_FormClosing(object sender, FormClosingEventArgs e)
        {
        }
    }   
}
