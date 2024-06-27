namespace systemBank
{
    partial class frmDeleteUser
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
			this.txtUserName = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.pnlInfo = new System.Windows.Forms.Panel();
			this.gbPernissions = new System.Windows.Forms.GroupBox();
			this.chkCurrency = new System.Windows.Forms.CheckBox();
			this.chkTransactions = new System.Windows.Forms.CheckBox();
			this.chkManageUser = new System.Windows.Forms.CheckBox();
			this.chkManageClient = new System.Windows.Forms.CheckBox();
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.txtPhone = new System.Windows.Forms.TextBox();
			this.txtLastName = new System.Windows.Forms.TextBox();
			this.txtFirstName = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.btnSearch = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.rbFemale = new System.Windows.Forms.RadioButton();
			this.rbMale = new System.Windows.Forms.RadioButton();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.pnlInfo.SuspendLayout();
			this.gbPernissions.SuspendLayout();
			this.SuspendLayout();
			// 
			// txtUserName
			// 
			this.txtUserName.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtUserName.Location = new System.Drawing.Point(144, 19);
			this.txtUserName.Name = "txtUserName";
			this.txtUserName.Size = new System.Drawing.Size(153, 33);
			this.txtUserName.TabIndex = 41;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(44, 22);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(94, 21);
			this.label1.TabIndex = 40;
			this.label1.Text = "User Name";
			// 
			// pnlInfo
			// 
			this.pnlInfo.Controls.Add(this.label8);
			this.pnlInfo.Controls.Add(this.label7);
			this.pnlInfo.Controls.Add(this.rbFemale);
			this.pnlInfo.Controls.Add(this.rbMale);
			this.pnlInfo.Controls.Add(this.dateTimePicker1);
			this.pnlInfo.Controls.Add(this.gbPernissions);
			this.pnlInfo.Controls.Add(this.txtEmail);
			this.pnlInfo.Controls.Add(this.txtPhone);
			this.pnlInfo.Controls.Add(this.txtLastName);
			this.pnlInfo.Controls.Add(this.txtFirstName);
			this.pnlInfo.Controls.Add(this.label5);
			this.pnlInfo.Controls.Add(this.label4);
			this.pnlInfo.Controls.Add(this.label3);
			this.pnlInfo.Controls.Add(this.label2);
			this.pnlInfo.Enabled = false;
			this.pnlInfo.Location = new System.Drawing.Point(12, 63);
			this.pnlInfo.Name = "pnlInfo";
			this.pnlInfo.Size = new System.Drawing.Size(539, 359);
			this.pnlInfo.TabIndex = 39;
			// 
			// gbPernissions
			// 
			this.gbPernissions.Controls.Add(this.chkCurrency);
			this.gbPernissions.Controls.Add(this.chkTransactions);
			this.gbPernissions.Controls.Add(this.chkManageUser);
			this.gbPernissions.Controls.Add(this.chkManageClient);
			this.gbPernissions.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gbPernissions.Location = new System.Drawing.Point(351, 27);
			this.gbPernissions.Name = "gbPernissions";
			this.gbPernissions.Size = new System.Drawing.Size(177, 210);
			this.gbPernissions.TabIndex = 25;
			this.gbPernissions.TabStop = false;
			this.gbPernissions.Text = "Permissions";
			// 
			// chkCurrency
			// 
			this.chkCurrency.AutoSize = true;
			this.chkCurrency.Location = new System.Drawing.Point(26, 164);
			this.chkCurrency.Name = "chkCurrency";
			this.chkCurrency.Size = new System.Drawing.Size(94, 25);
			this.chkCurrency.TabIndex = 3;
			this.chkCurrency.Text = "Currency";
			this.chkCurrency.UseVisualStyleBackColor = true;
			// 
			// chkTransactions
			// 
			this.chkTransactions.AutoSize = true;
			this.chkTransactions.Location = new System.Drawing.Point(26, 124);
			this.chkTransactions.Name = "chkTransactions";
			this.chkTransactions.Size = new System.Drawing.Size(121, 25);
			this.chkTransactions.TabIndex = 2;
			this.chkTransactions.Text = "Transactions";
			this.chkTransactions.UseVisualStyleBackColor = true;
			// 
			// chkManageUser
			// 
			this.chkManageUser.AutoSize = true;
			this.chkManageUser.Location = new System.Drawing.Point(26, 86);
			this.chkManageUser.Name = "chkManageUser";
			this.chkManageUser.Size = new System.Drawing.Size(126, 25);
			this.chkManageUser.TabIndex = 1;
			this.chkManageUser.Text = "Manage User";
			this.chkManageUser.UseVisualStyleBackColor = true;
			// 
			// chkManageClient
			// 
			this.chkManageClient.AutoSize = true;
			this.chkManageClient.Location = new System.Drawing.Point(26, 44);
			this.chkManageClient.Name = "chkManageClient";
			this.chkManageClient.Size = new System.Drawing.Size(136, 25);
			this.chkManageClient.TabIndex = 0;
			this.chkManageClient.Text = "Manage Client";
			this.chkManageClient.UseVisualStyleBackColor = true;
			// 
			// txtEmail
			// 
			this.txtEmail.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtEmail.Location = new System.Drawing.Point(124, 204);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(153, 33);
			this.txtEmail.TabIndex = 23;
			// 
			// txtPhone
			// 
			this.txtPhone.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPhone.Location = new System.Drawing.Point(124, 148);
			this.txtPhone.Name = "txtPhone";
			this.txtPhone.Size = new System.Drawing.Size(153, 33);
			this.txtPhone.TabIndex = 22;
			// 
			// txtLastName
			// 
			this.txtLastName.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtLastName.Location = new System.Drawing.Point(124, 84);
			this.txtLastName.Name = "txtLastName";
			this.txtLastName.Size = new System.Drawing.Size(153, 33);
			this.txtLastName.TabIndex = 21;
			// 
			// txtFirstName
			// 
			this.txtFirstName.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtFirstName.Location = new System.Drawing.Point(124, 14);
			this.txtFirstName.Name = "txtFirstName";
			this.txtFirstName.Size = new System.Drawing.Size(153, 33);
			this.txtFirstName.TabIndex = 20;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(24, 216);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(50, 21);
			this.label5.TabIndex = 18;
			this.label5.Text = "Email";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(24, 151);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(55, 21);
			this.label4.TabIndex = 17;
			this.label4.Text = "Phone";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(24, 87);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(94, 21);
			this.label3.TabIndex = 16;
			this.label3.Text = "Last Name";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(24, 17);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(96, 21);
			this.label2.TabIndex = 15;
			this.label2.Text = "First Name";
			// 
			// btnSearch
			// 
			this.btnSearch.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSearch.Location = new System.Drawing.Point(549, 12);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(107, 41);
			this.btnSearch.TabIndex = 38;
			this.btnSearch.Text = "Search";
			this.btnSearch.UseVisualStyleBackColor = true;
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDelete.Location = new System.Drawing.Point(418, 12);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(107, 41);
			this.btnDelete.TabIndex = 42;
			this.btnDelete.Text = "Delete";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Visible = false;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(40, 309);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(116, 21);
			this.label8.TabIndex = 36;
			this.label8.Text = "Date Of Birth";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(40, 262);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(62, 21);
			this.label7.TabIndex = 35;
			this.label7.Text = "Gender";
			// 
			// rbFemale
			// 
			this.rbFemale.AutoSize = true;
			this.rbFemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rbFemale.Location = new System.Drawing.Point(205, 259);
			this.rbFemale.Name = "rbFemale";
			this.rbFemale.Size = new System.Drawing.Size(80, 24);
			this.rbFemale.TabIndex = 34;
			this.rbFemale.TabStop = true;
			this.rbFemale.Text = "Female";
			this.rbFemale.UseVisualStyleBackColor = true;
			// 
			// rbMale
			// 
			this.rbMale.AutoSize = true;
			this.rbMale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rbMale.Location = new System.Drawing.Point(132, 262);
			this.rbMale.Name = "rbMale";
			this.rbMale.Size = new System.Drawing.Size(61, 24);
			this.rbMale.TabIndex = 33;
			this.rbMale.TabStop = true;
			this.rbMale.Text = "Male";
			this.rbMale.UseVisualStyleBackColor = true;
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Location = new System.Drawing.Point(162, 309);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
			this.dateTimePicker1.TabIndex = 32;
			// 
			// frmDeleteUser
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(666, 436);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.txtUserName);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pnlInfo);
			this.Controls.Add(this.btnSearch);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "frmDeleteUser";
			this.Text = "frmDeleteUser";
			this.pnlInfo.ResumeLayout(false);
			this.pnlInfo.PerformLayout();
			this.gbPernissions.ResumeLayout(false);
			this.gbPernissions.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlInfo;
        private System.Windows.Forms.GroupBox gbPernissions;
        private System.Windows.Forms.CheckBox chkCurrency;
        private System.Windows.Forms.CheckBox chkTransactions;
        private System.Windows.Forms.CheckBox chkManageUser;
        private System.Windows.Forms.CheckBox chkManageClient;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.RadioButton rbFemale;
		private System.Windows.Forms.RadioButton rbMale;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
	}
}