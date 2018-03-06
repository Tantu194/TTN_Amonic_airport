using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Session2
{
    public partial class frmScheduleEdit : Form
    {
        public frmScheduleEdit()
        {
            InitializeComponent();
        }

        private void frmScheduleEdit_Load(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            updateEdit();
        }

        /// <summary>
        /// Update edit
        /// </summary>
        private void updateEdit()
        {
            if (checkAllField())
            {
                
            }
        }

        /// <summary>
        /// check all field
        /// </summary>
        /// <returns>true or false</returns>
        private bool checkAllField()
        {
            DateTime dt;
            TimeSpan tp;
            if (tbDate.Text.ToString() == "" || tbTime.Text.ToString() == "" || tbPrice.Text.ToString() == "")
            {
                MessageBox.Show("Fields must not be empty", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }  
            if (DateTime.TryParse(tbDate.Text, out dt))
            {
                tbDate.Text = String.Format("{0:yyyy/MM/dd}", dt);
            }
            else
            {
                MessageBox.Show("Invalid Date format (dd/mm/yyyy)", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbDate.Focus();
                return false;
            }
            if (TimeSpan.TryParse(tbTime.Text + ":00", out tp))
            {
                tbTime.Text = String.Format("{0:hh\\:mm}", tp);
            }
            else
            {
                MessageBox.Show("Invalid Time format (hh:mm)", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbTime.Focus();
                return false;
            }
            int price;
            if (int.TryParse(tbPrice.Text, out price))
            {
                tbPrice.Text = price+string.Empty;
            }
            else
            {
                MessageBox.Show("enter the number", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbPrice.Focus();
                return false;
            }
            return true;
        }
    }
}
