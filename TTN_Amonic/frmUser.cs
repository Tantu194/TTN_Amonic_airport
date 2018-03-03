using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

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

        private void frmUser_Load(object sender, EventArgs e)
        {
            lblMessage.Text = "Hi " + username + ", Welcome to AMONIC Airlines";
        }
    }
}
