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
        private void LoadUser(int officeId = -1)
        {
            dtgrvUser.DataBindings.Clear();
            dtgrvUser.DataSource = DataAccess.Query(
                @"SELECT u.ID, u.FirstName, u.LastName, DATEDIFF(YEAR, u.Birthdate, GETDATE()) Age, u.Email,
	                r.Title RoleTitle,
	                o.Title OfficeTitle
                FROM Users (NOLOCK) u
	                LEFT JOIN Roles (NOLOCK) r ON r.ID = u.RoleID
	                LEFT JOIN Offices (NOLOCK) o ON o.ID = u.OfficeID
                WHERE (@OfficeId = -1 OR u.OfficeId = @OfficeId)", new Dictionary<string, object>
                {
                    { "OfficeId", officeId }
                });
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
            dtgrvUser.AutoGenerateColumns = false;
            LoadUser();

            LoadOffice();
        }

        private void dtgrvUser_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
        }

        private void cbOfice_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!(cbOfice.SelectedValue is DataRowView))
                LoadUser(int.Parse(cbOfice.SelectedValue + string.Empty));
        }

        private void btnChangeRole_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection row = dtgrvUser.SelectedRows;
            int uid = int.Parse(row[0].Cells["ID"].Value.ToString());

            //MessageBox.Show(uid +"");
            frmChangeRole frmChangeRole = new frmChangeRole();
            frmChangeRole.Uid = uid;
            frmChangeRole.ShowDialog(this);
        }

        private void btnEnable_Click(object sender, EventArgs e)
        {

        }
    }
}
