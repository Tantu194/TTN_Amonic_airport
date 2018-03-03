namespace TTN_Amonic
{
    partial class frmAdmin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.addUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.cbOfice = new System.Windows.Forms.ComboBox();
            this.dtgrvUser = new System.Windows.Forms.DataGridView();
            this.btnChangeRole = new System.Windows.Forms.Button();
            this.btnEnable = new System.Windows.Forms.Button();
            this.usersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.session1DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colFName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userRole = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.office = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrvUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.session1DataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addUserToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(634, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // addUserToolStripMenuItem
            // 
            this.addUserToolStripMenuItem.Name = "addUserToolStripMenuItem";
            this.addUserToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.addUserToolStripMenuItem.Text = "&Add user";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem.Text = "&Exit";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Office: ";
            // 
            // cbOfice
            // 
            this.cbOfice.FormattingEnabled = true;
            this.cbOfice.Location = new System.Drawing.Point(78, 28);
            this.cbOfice.Name = "cbOfice";
            this.cbOfice.Size = new System.Drawing.Size(121, 24);
            this.cbOfice.TabIndex = 4;
            this.cbOfice.SelectedIndexChanged += new System.EventHandler(this.cbOfice_SelectedIndexChanged);
            // 
            // dtgrvUser
            // 
            this.dtgrvUser.AllowUserToAddRows = false;
            this.dtgrvUser.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dtgrvUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrvUser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colFName,
            this.ID,
            this.lastName,
            this.age,
            this.userRole,
            this.emal,
            this.office});
            this.dtgrvUser.Location = new System.Drawing.Point(15, 58);
            this.dtgrvUser.MultiSelect = false;
            this.dtgrvUser.Name = "dtgrvUser";
            this.dtgrvUser.RowHeadersVisible = false;
            this.dtgrvUser.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgrvUser.Size = new System.Drawing.Size(604, 302);
            this.dtgrvUser.TabIndex = 5;
            this.dtgrvUser.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dtgrvUser_CellFormatting);
            // 
            // btnChangeRole
            // 
            this.btnChangeRole.Location = new System.Drawing.Point(15, 366);
            this.btnChangeRole.Name = "btnChangeRole";
            this.btnChangeRole.Size = new System.Drawing.Size(105, 35);
            this.btnChangeRole.TabIndex = 6;
            this.btnChangeRole.Text = "Change Role";
            this.btnChangeRole.UseVisualStyleBackColor = true;
            this.btnChangeRole.Click += new System.EventHandler(this.btnChangeRole_Click);
            // 
            // btnEnable
            // 
            this.btnEnable.Location = new System.Drawing.Point(215, 366);
            this.btnEnable.Name = "btnEnable";
            this.btnEnable.Size = new System.Drawing.Size(167, 35);
            this.btnEnable.TabIndex = 6;
            this.btnEnable.Text = "Enable/Disable Login";
            this.btnEnable.UseVisualStyleBackColor = true;
            this.btnEnable.Click += new System.EventHandler(this.btnEnable_Click);
            // 
            // colFName
            // 
            this.colFName.DataPropertyName = "FirstName";
            this.colFName.HeaderText = "Name";
            this.colFName.MinimumWidth = 100;
            this.colFName.Name = "colFName";
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Visible = false;
            // 
            // lastName
            // 
            this.lastName.DataPropertyName = "LastName";
            this.lastName.HeaderText = "Last Name";
            this.lastName.MinimumWidth = 100;
            this.lastName.Name = "lastName";
            // 
            // age
            // 
            this.age.DataPropertyName = "Age";
            this.age.HeaderText = "Age";
            this.age.MinimumWidth = 50;
            this.age.Name = "age";
            // 
            // userRole
            // 
            this.userRole.DataPropertyName = "RoleTitle";
            this.userRole.HeaderText = "User Role";
            this.userRole.MinimumWidth = 100;
            this.userRole.Name = "userRole";
            // 
            // emal
            // 
            this.emal.DataPropertyName = "Email";
            this.emal.HeaderText = "Emal Address";
            this.emal.MinimumWidth = 100;
            this.emal.Name = "emal";
            // 
            // office
            // 
            this.office.DataPropertyName = "OfficeTitle";
            this.office.HeaderText = "Office";
            this.office.MinimumWidth = 100;
            this.office.Name = "office";
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 413);
            this.Controls.Add(this.btnEnable);
            this.Controls.Add(this.btnChangeRole);
            this.Controls.Add(this.dtgrvUser);
            this.Controls.Add(this.cbOfice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmAdmin";
            this.Text = "AMONIC Airllines Automation Systems";
            this.Load += new System.EventHandler(this.frmAdmin_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrvUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.session1DataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbOfice;
        private System.Windows.Forms.BindingSource usersBindingSource1;
        private System.Windows.Forms.BindingSource session1DataSetBindingSource;
        private System.Windows.Forms.DataGridView dtgrvUser;
        private System.Windows.Forms.Button btnChangeRole;
        private System.Windows.Forms.Button btnEnable;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn age;
        private System.Windows.Forms.DataGridViewTextBoxColumn userRole;
        private System.Windows.Forms.DataGridViewTextBoxColumn emal;
        private System.Windows.Forms.DataGridViewTextBoxColumn office;
    }
}

