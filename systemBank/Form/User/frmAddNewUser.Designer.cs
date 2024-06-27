namespace systemBank
{
    partial class frmAddNewUser
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.txtUserName = new System.Windows.Forms.TextBox();
			this.txtFirstName = new System.Windows.Forms.TextBox();
			this.txtLastName = new System.Windows.Forms.TextBox();
			this.txtPhone = new System.Windows.Forms.TextBox();
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.gbPernissions = new System.Windows.Forms.GroupBox();
			this.chkCurrency = new System.Windows.Forms.CheckBox();
			this.chkTransactions = new System.Windows.Forms.CheckBox();
			this.chkManageUser = new System.Windows.Forms.CheckBox();
			this.chkManageClient = new System.Windows.Forms.CheckBox();
			this.btnAddUser = new System.Windows.Forms.Button();
			this.rbMale = new System.Windows.Forms.RadioButton();
			this.label7 = new System.Windows.Forms.Label();
			this.rbFemale = new System.Windows.Forms.RadioButton();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.label8 = new System.Windows.Forms.Label();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			this.gbPernissions.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(32, 33);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(94, 21);
			this.label1.TabIndex = 0;
			this.label1.Text = "User Name";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(32, 96);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(96, 21);
			this.label2.TabIndex = 1;
			this.label2.Text = "First Name";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(32, 166);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(94, 21);
			this.label3.TabIndex = 2;
			this.label3.Text = "Last Name";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(32, 230);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(55, 21);
			this.label4.TabIndex = 3;
			this.label4.Text = "Phone";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(32, 295);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(50, 21);
			this.label5.TabIndex = 4;
			this.label5.Text = "Email";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(32, 360);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(79, 21);
			this.label6.TabIndex = 5;
			this.label6.Text = "Password";
			// 
			// txtUserName
			// 
			this.txtUserName.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtUserName.Location = new System.Drawing.Point(132, 30);
			this.txtUserName.Name = "txtUserName";
			this.txtUserName.Size = new System.Drawing.Size(153, 33);
			this.txtUserName.TabIndex = 6;
			this.txtUserName.Validating += new System.ComponentModel.CancelEventHandler(this.txt_Validating);
			// 
			// txtFirstName
			// 
			this.txtFirstName.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtFirstName.Location = new System.Drawing.Point(132, 93);
			this.txtFirstName.Name = "txtFirstName";
			this.txtFirstName.Size = new System.Drawing.Size(153, 33);
			this.txtFirstName.TabIndex = 7;
			this.txtFirstName.Validating += new System.ComponentModel.CancelEventHandler(this.txt_Validating);
			// 
			// txtLastName
			// 
			this.txtLastName.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtLastName.Location = new System.Drawing.Point(132, 163);
			this.txtLastName.Name = "txtLastName";
			this.txtLastName.Size = new System.Drawing.Size(153, 33);
			this.txtLastName.TabIndex = 8;
			this.txtLastName.Validating += new System.ComponentModel.CancelEventHandler(this.txt_Validating);
			// 
			// txtPhone
			// 
			this.txtPhone.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPhone.Location = new System.Drawing.Point(132, 227);
			this.txtPhone.Name = "txtPhone";
			this.txtPhone.Size = new System.Drawing.Size(153, 33);
			this.txtPhone.TabIndex = 9;
			// 
			// txtEmail
			// 
			this.txtEmail.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtEmail.Location = new System.Drawing.Point(132, 283);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(153, 33);
			this.txtEmail.TabIndex = 10;
			this.txtEmail.Validating += new System.ComponentModel.CancelEventHandler(this.txt_Validating);
			// 
			// txtPassword
			// 
			this.txtPassword.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPassword.Location = new System.Drawing.Point(132, 348);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.Size = new System.Drawing.Size(153, 33);
			this.txtPassword.TabIndex = 11;
			this.txtPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txt_Validating);
			// 
			// gbPernissions
			// 
			this.gbPernissions.Controls.Add(this.chkCurrency);
			this.gbPernissions.Controls.Add(this.chkTransactions);
			this.gbPernissions.Controls.Add(this.chkManageUser);
			this.gbPernissions.Controls.Add(this.chkManageClient);
			this.gbPernissions.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gbPernissions.Location = new System.Drawing.Point(376, 128);
			this.gbPernissions.Name = "gbPernissions";
			this.gbPernissions.Size = new System.Drawing.Size(276, 210);
			this.gbPernissions.TabIndex = 13;
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
			// btnAddUser
			// 
			this.btnAddUser.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAddUser.Location = new System.Drawing.Point(389, 370);
			this.btnAddUser.Name = "btnAddUser";
			this.btnAddUser.Size = new System.Drawing.Size(107, 41);
			this.btnAddUser.TabIndex = 14;
			this.btnAddUser.Text = "Add";
			this.btnAddUser.UseVisualStyleBackColor = true;
			this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
			// 
			// rbMale
			// 
			this.rbMale.AutoSize = true;
			this.rbMale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rbMale.Location = new System.Drawing.Point(389, 32);
			this.rbMale.Name = "rbMale";
			this.rbMale.Size = new System.Drawing.Size(61, 24);
			this.rbMale.TabIndex = 15;
			this.rbMale.TabStop = true;
			this.rbMale.Text = "Male";
			this.rbMale.UseVisualStyleBackColor = true;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(306, 33);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(62, 21);
			this.label7.TabIndex = 16;
			this.label7.Text = "Gender";
			// 
			// rbFemale
			// 
			this.rbFemale.AutoSize = true;
			this.rbFemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rbFemale.Location = new System.Drawing.Point(462, 32);
			this.rbFemale.Name = "rbFemale";
			this.rbFemale.Size = new System.Drawing.Size(80, 24);
			this.rbFemale.TabIndex = 17;
			this.rbFemale.TabStop = true;
			this.rbFemale.Text = "Female";
			this.rbFemale.UseVisualStyleBackColor = true;
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Location = new System.Drawing.Point(452, 97);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
			this.dateTimePicker1.TabIndex = 18;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(306, 96);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(116, 21);
			this.label8.TabIndex = 19;
			this.label8.Text = "Date Of Birth";
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// frmAddNewUser
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(684, 435);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.dateTimePicker1);
			this.Controls.Add(this.rbFemale);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.rbMale);
			this.Controls.Add(this.btnAddUser);
			this.Controls.Add(this.gbPernissions);
			this.Controls.Add(this.txtPassword);
			this.Controls.Add(this.txtEmail);
			this.Controls.Add(this.txtPhone);
			this.Controls.Add(this.txtLastName);
			this.Controls.Add(this.txtFirstName);
			this.Controls.Add(this.txtUserName);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "frmAddNewUser";
			this.Text = "frmAddNewUser";
			this.Load += new System.EventHandler(this.frmAddNewUser_Load);
			this.gbPernissions.ResumeLayout(false);
			this.gbPernissions.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.GroupBox gbPernissions;
        private System.Windows.Forms.CheckBox chkCurrency;
        private System.Windows.Forms.CheckBox chkTransactions;
        private System.Windows.Forms.CheckBox chkManageUser;
        private System.Windows.Forms.CheckBox chkManageClient;
        private System.Windows.Forms.Button btnAddUser;
		private System.Windows.Forms.RadioButton rbMale;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.RadioButton rbFemale;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.ErrorProvider errorProvider1;
	}
}