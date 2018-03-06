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
    public partial class frmAdmin : Form
    {
        int selectPos = 0;

        public void LoadUser(int officeId = -1)
        {
            lvUser.Items.Clear();
            DataTable dt = FunctionSession1.getAllUser(officeId);
            foreach(DataRow r in dt.Rows)
            {
                ListViewItem item = new ListViewItem();
                item.Text = r["FirstName"] + string.Empty;
                item.SubItems.Add(r["LastName"] + string.Empty);
                item.SubItems.Add(r["Age"] + string.Empty);
                item.SubItems.Add(r["RoleTitle"] + string.Empty);
                item.SubItems.Add(r["Email"] + string.Empty);              
                item.SubItems.Add(r["OfficeTitle"] + string.Empty);
                item.SubItems.Add(r["ID"] + string.Empty);
                item.SubItems.Add(r["Active"] + string.Empty);
                if (!bool.Parse(r["Active"] + string.Empty))
                {
                    item.BackColor = Color.Red;
                    item.ForeColor = Color.White;
                }
                lvUser.Items.Add(item);
            }
            if(lvUser.Items.Count > 0)
                lvUser.Items[selectPos].Selected = true;
        }

        private void LoadOffice()
        {
            var offices = DataAccess.Query(@"SELECT -1 AS ID, 'All office' Title
UNION SELECT ID, Title
FROM Offices (NOLOCK)");

            cbOfice.DataBindings.Clear();
            cbOfice.DataSource = offices;
            cbOfice.DisplayMember = "Title";
            cbOfice.ValueMember = "ID";
        }

        public frmAdmin()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void frmAdmin_Load(object sender, EventArgs e)
        {
            
            LoadUser();

            LoadOffice();
        }

        private void cbOfice_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!(cbOfice.SelectedValue is DataRowView))
                LoadUser(int.Parse(cbOfice.SelectedValue + string.Empty));
        }

        private void btnChangeRole_Click(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection row = lvUser.SelectedItems;
            int uid = int.Parse(row[0].SubItems[6].Text+string.Empty);
            //MessageBox.Show(uid +"");
            frmChangeRole frmChangeRole = new frmChangeRole();
            frmChangeRole.Uid = uid;
            frmChangeRole.ShowDialog(this);
        }

        private void btnEnable_Click(object sender, EventArgs e)
        {
            enableUser();
        }

        /// <summary>
        ///enable or disable user 
        /// </summary>
        private void enableUser()
        {
            ListView.SelectedListViewItemCollection row = lvUser.SelectedItems;
            int uid = Convert.ToInt32(row[0].SubItems[6].Text + string.Empty);
            int active = bool.Parse(row[0].SubItems[7].Text + string.Empty)?0:1;
            FunctionSession1.enableUser(uid, active);
            selectPos = row[0].Index;
            LoadUser();
        }

        private void addUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddUser addUser = new frmAddUser();
            addUser.FrmAdmin = this;
            addUser.ShowDialog();
        }

    }
}
