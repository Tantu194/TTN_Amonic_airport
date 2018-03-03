namespace TTN_Amonic
{
    partial class frmUser
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
            this.lblMessage = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblTimeSpent = new System.Windows.Forms.Label();
            this.lblNumberOfCashes = new System.Windows.Forms.Label();
            this.lvLogs = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(106)))), ((int)(((byte)(166)))));
            this.lblMessage.Location = new System.Drawing.Point(14, 37);
            this.lblMessage.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(260, 16);
            this.lblMessage.TabIndex = 1;
            this.lblMessage.Text = "Hi admin, Welcome to AMONIC Airlines";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(776, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem.Text = "&Exit";
            // 
            // lblTimeSpent
            // 
            this.lblTimeSpent.AutoSize = true;
            this.lblTimeSpent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(106)))), ((int)(((byte)(166)))));
            this.lblTimeSpent.Location = new System.Drawing.Point(277, 67);
            this.lblTimeSpent.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTimeSpent.Name = "lblTimeSpent";
            this.lblTimeSpent.Size = new System.Drawing.Size(217, 16);
            this.lblTimeSpent.TabIndex = 3;
            this.lblTimeSpent.Text = "Time spent on system: 9:00:00";
            // 
            // lblNumberOfCashes
            // 
            this.lblNumberOfCashes.AutoSize = true;
            this.lblNumberOfCashes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(148)))), ((int)(((byte)(32)))));
            this.lblNumberOfCashes.Location = new System.Drawing.Point(522, 67);
            this.lblNumberOfCashes.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblNumberOfCashes.Name = "lblNumberOfCashes";
            this.lblNumberOfCashes.Size = new System.Drawing.Size(145, 16);
            this.lblNumberOfCashes.TabIndex = 4;
            this.lblNumberOfCashes.Text = "Number of cashes: 1";
            // 
            // lvLogs
            // 
            this.lvLogs.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lvLogs.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvLogs.Location = new System.Drawing.Point(16, 103);
            this.lvLogs.Name = "lvLogs";
            this.lvLogs.Size = new System.Drawing.Size(744, 366);
            this.lvLogs.TabIndex = 5;
            this.lvLogs.UseCompatibleStateImageBehavior = false;
            this.lvLogs.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Date";
            this.columnHeader1.Width = 95;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Login time";
            this.columnHeader2.Width = 110;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Logout Time";
            this.columnHeader3.Width = 131;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Time spent on system";
            this.columnHeader4.Width = 164;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Unsuccessful logout reason";
            this.columnHeader5.Width = 247;
            // 
            // frmUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 483);
            this.Controls.Add(this.lvLogs);
            this.Controls.Add(this.lblNumberOfCashes);
            this.Controls.Add(this.lblTimeSpent);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.Name = "frmUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AMONIC Airlines Automation System";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmUser_FormClosing);
            this.Load += new System.EventHandler(this.frmUser_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label lblTimeSpent;
        private System.Windows.Forms.Label lblNumberOfCashes;
        private System.Windows.Forms.ListView lvLogs;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}