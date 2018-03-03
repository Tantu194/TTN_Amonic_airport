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
    public partial class frmChangeRole : Form
    {

        private int uid;

        public frmChangeRole()
        {
            InitializeComponent();
        }

        private void frmChangeRole_Load(object sender, EventArgs e)
        {
            //goi ham load data
            loadData();
        }

        /// <summary>
        /// load data
        /// </summary>
        private void loadData()
        {
            DataTable dt = DataAccess.Query(@"select Users.*,Offices.Title from Users, Offices where Users.OfficeID = Offices.ID and Users.ID = @id",new Dictionary<string, object> { {"id",uid } });
            try
            {
                tbEmail.Text = dt.Rows[0]["Email"].ToString();
                tbFName.Text = dt.Rows[0]["FirstName"].ToString();
                tbLName.Text = dt.Rows[0]["LastName"].ToString();
                cbOffice.SelectedText = dt.Rows[0]["Title"].ToString();
                if (dt.Rows[0]["RoleID"].ToString() == "1")
                {
                    rdAdmin.Checked = true;
                }
                else
                {
                    rdUser.Checked = true;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi: khong nap duoc du lieu","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
        }

        public int Uid
        {
            get { return uid; }
            set { uid = value; }
        }

        private void btnApply_Click(object sender, EventArgs e)
        {

        }
    }
}
