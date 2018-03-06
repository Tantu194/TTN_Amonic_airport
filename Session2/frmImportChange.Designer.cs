namespace Session2
{
    partial class frmImportChange
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbFilePath = new System.Windows.Forms.TextBox();
            this.btnImport = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbReMissField = new System.Windows.Forms.Label();
            this.lbSucceChaAppli = new System.Windows.Forms.Label();
            this.lbDupReDiscard = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(307, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please select the text file with the changes";
            // 
            // tbFilePath
            // 
            this.tbFilePath.Location = new System.Drawing.Point(25, 55);
            this.tbFilePath.Name = "tbFilePath";
            this.tbFilePath.Size = new System.Drawing.Size(350, 24);
            this.tbFilePath.TabIndex = 1;
            // 
            // btnImport
            // 
            this.btnImport.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImport.Location = new System.Drawing.Point(381, 55);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(80, 24);
            this.btnImport.TabIndex = 2;
            this.btnImport.Text = " Import";
            this.btnImport.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbSucceChaAppli);
            this.groupBox1.Controls.Add(this.lbDupReDiscard);
            this.groupBox1.Controls.Add(this.lbReMissField);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(25, 100);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(436, 164);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Results";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(209, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Successful Changes Applies:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(214, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Duplicate Records Discarded:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(268, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Records with missing field discarded:";
            // 
            // lbReMissField
            // 
            this.lbReMissField.AutoSize = true;
            this.lbReMissField.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lbReMissField.Location = new System.Drawing.Point(294, 120);
            this.lbReMissField.Name = "lbReMissField";
            this.lbReMissField.Size = new System.Drawing.Size(56, 17);
            this.lbReMissField.TabIndex = 2;
            this.lbReMissField.Text = "[xxxx]";
            // 
            // lbSucceChaAppli
            // 
            this.lbSucceChaAppli.AutoSize = true;
            this.lbSucceChaAppli.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lbSucceChaAppli.Location = new System.Drawing.Point(294, 32);
            this.lbSucceChaAppli.Name = "lbSucceChaAppli";
            this.lbSucceChaAppli.Size = new System.Drawing.Size(56, 17);
            this.lbSucceChaAppli.TabIndex = 2;
            this.lbSucceChaAppli.Text = "[xxxx]";
            // 
            // lbDupReDiscard
            // 
            this.lbDupReDiscard.AutoSize = true;
            this.lbDupReDiscard.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lbDupReDiscard.Location = new System.Drawing.Point(294, 77);
            this.lbDupReDiscard.Name = "lbDupReDiscard";
            this.lbDupReDiscard.Size = new System.Drawing.Size(56, 17);
            this.lbDupReDiscard.TabIndex = 2;
            this.lbDupReDiscard.Text = "[xxxx]";
            // 
            // frmImportChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 281);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.tbFilePath);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(106)))), ((int)(((byte)(166)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmImportChange";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Apply Schedule Changes";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbFilePath;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbSucceChaAppli;
        private System.Windows.Forms.Label lbDupReDiscard;
        private System.Windows.Forms.Label lbReMissField;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}