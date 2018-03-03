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
            apply();
        }
        /// <summary>
        /// thuc thi thay doi
        /// </summary>
        private void apply()
        {
            int roleID = 1;
            if (rdUser.Checked)
            {
                roleID = 2;
            }
            
            try
            {
                if(DataAccess.Execute(@"update Users set RoleID = @roleID where id = @uid", new Dictionary<string, object> {
                    { "roleID", roleID},
                    {"uid", uid}
                }))
                {
                    MessageBox.Show("Thay đổi thành công!", "Thông báo", MessageBoxButtons.OK,MessageBoxIcon.Information);
                    loadData();
                }
                else
                {
                    MessageBox.Show("Thay đổi Thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi: khong nap duoc du lieu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
