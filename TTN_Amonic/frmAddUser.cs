using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Windows.Forms;
using TTN_Amonic.DAL;

namespace TTN_Amonic
{
    public partial class frmAddUser : Form
    {
        public frmAddUser()
        {
            InitializeComponent();
        }

        private frmAdmin frmAdmin;

        public frmAdmin FrmAdmin
        {
            get { return frmAdmin; }
            set { frmAdmin = value; }
        }

        private void frmAddUser_Load(object sender, EventArgs e)
        {
            //goi ham load data
            loadData();
        }

        /// <summary>
        /// load data
        /// </summary>
        public void loadData()
        {
            cbOffice.DataSource = FunctionSession1.getAllOffices();
            cbOffice.DisplayMember = "Title";
            cbOffice.ValueMember = "ID";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (checkAllField())
                saveData();
        }

        private bool checkAllField()
        {
            DateTime dt;
            string bDate = tbBdate.Text;
            string email = tbEmail.Text;
            if (email == "" || tbFName.Text == "" || tbLName.Text == "" || bDate == "" || tbPassword.Text == "")
            {
                MessageBox.Show("Fields should not be empty", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (!validateEmail(email))
            {
                MessageBox.Show("Invalid Email Format", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbEmail.Focus();
                return false;
            }
            else if (DateTime.TryParse(bDate, out dt))
            {
                tbBdate.Text = String.Format("{0:yyyy/MM/dd}",dt);
                return true;
            }
            else
            {
                MessageBox.Show("Birthdate format is invalid (dd/MM/yyyy)", "Notification",MessageBoxButtons.OK,MessageBoxIcon.Error);
                tbBdate.Focus();
                return false;
            }

        }

        private void saveData()
        {
            Dictionary<String, Object> param = new Dictionary<string, object>();
            param.Add("Email",tbEmail.Text.ToString());
            param.Add("Password", FunctionSession1.MD5(tbPassword.Text.ToString()));
            param.Add("FirstName",tbFName.Text.ToString());
            param.Add("LastName",tbLName.Text.ToString());
            param.Add("OfficeID",cbOffice.SelectedValue.ToString());
            param.Add("Birthdate",tbBdate.Text.ToString());
            if (FunctionSession1.insertUser(param))
            {
                MessageBox.Show("Saved successfully!!!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FrmAdmin.LoadUser();
                emptyField();
            }
            else
            {
                MessageBox.Show("save failed!!!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void emptyField()
        {
            tbEmail.Text = "";
            tbFName.Text = "";
            tbLName.Text = "";
            tbPassword.Text = "";
            tbBdate.Text = "";
        }

        private bool validateEmail(string email)
        {
            try
            {
                MailAddress m = new MailAddress(email);
                if (m.Address == email)
                    return true;
            }
            catch (Exception e)
            {
                return false;
            }
            return false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
