namespace systemBank
{
    partial class frmAddNewClient
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
			this.label7 = new System.Windows.Forms.Label();
			this.txtAccountNumber = new System.Windows.Forms.TextBox();
			this.btnSave = new System.Windows.Forms.Button();
			this.txtPinCode = new System.Windows.Forms.TextBox();
			this.txtFirstName = new System.Windows.Forms.TextBox();
			this.txtLastName = new System.Windows.Forms.TextBox();
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.txtPhone = new System.Windows.Forms.TextBox();
			this.nudAccountBalance = new System.Windows.Forms.NumericUpDown();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.rbMale = new System.Windows.Forms.RadioButton();
			this.rbFemale = new System.Windows.Forms.RadioButton();
			((System.ComponentModel.ISupportInitialize)(this.nudAccountBalance)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(38, 11);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(137, 21);
			this.label1.TabIndex = 0;
			this.label1.Text = "Account Number";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(274, 11);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(69, 21);
			this.label2.TabIndex = 1;
			this.label2.Text = "PinCode";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(38, 87);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(96, 21);
			this.label3.TabIndex = 2;
			this.label3.Text = "First Name";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(274, 87);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(94, 21);
			this.label4.TabIndex = 3;
			this.label4.Text = "Last Name";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(38, 175);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(50, 21);
			this.label5.TabIndex = 4;
			this.label5.Text = "Email";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(274, 175);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(55, 21);
			this.label6.TabIndex = 5;
			this.label6.Text = "Phone";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(49, 313);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(131, 21);
			this.label7.TabIndex = 6;
			this.label7.Text = "Account Balance";
			// 
			// txtAccountNumber
			// 
			this.txtAccountNumber.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtAccountNumber.Location = new System.Drawing.Point(42, 47);
			this.txtAccountNumber.Name = "txtAccountNumber";
			this.txtAccountNumber.Size = new System.Drawing.Size(167, 38);
			this.txtAccountNumber.TabIndex = 7;
			this.txtAccountNumber.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_Validating);
			// 
			// btnSave
			// 
			this.btnSave.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSave.Location = new System.Drawing.Point(289, 341);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(91, 43);
			this.btnSave.TabIndex = 13;
			this.btnSave.Text = "Save";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// txtPinCode
			// 
			this.txtPinCode.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPinCode.Location = new System.Drawing.Point(258, 46);
			this.txtPinCode.Name = "txtPinCode";
			this.txtPinCode.Size = new System.Drawing.Size(176, 38);
			this.txtPinCode.TabIndex = 14;
			this.txtPinCode.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_Validating);
			// 
			// txtFirstName
			// 
			this.txtFirstName.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtFirstName.Location = new System.Drawing.Point(47, 125);
			this.txtFirstName.Name = "txtFirstName";
			this.txtFirstName.Size = new System.Drawing.Size(162, 38);
			this.txtFirstName.TabIndex = 15;
			this.txtFirstName.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_Validating);
			// 
			// txtLastName
			// 
			this.txtLastName.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtLastName.Location = new System.Drawing.Point(258, 125);
			this.txtLastName.Name = "txtLastName";
			this.txtLastName.Size = new System.Drawing.Size(176, 38);
			this.txtLastName.TabIndex = 16;
			this.txtLastName.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_Validating);
			// 
			// txtEmail
			// 
			this.txtEmail.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtEmail.Location = new System.Drawing.Point(47, 209);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(162, 38);
			this.txtEmail.TabIndex = 17;
			this.txtEmail.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_Validating);
			// 
			// txtPhone
			// 
			this.txtPhone.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPhone.Location = new System.Drawing.Point(258, 209);
			this.txtPhone.Name = "txtPhone";
			this.txtPhone.Size = new System.Drawing.Size(183, 38);
			this.txtPhone.TabIndex = 18;
			// 
			// nudAccountBalance
			// 
			this.nudAccountBalance.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.nudAccountBalance.Location = new System.Drawing.Point(58, 350);
			this.nudAccountBalance.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			this.nudAccountBalance.Name = "nudAccountBalance";
			this.nudAccountBalance.Size = new System.Drawing.Size(162, 33);
			this.nudAccountBalance.TabIndex = 20;
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Location = new System.Drawing.Point(258, 271);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
			this.dateTimePicker1.TabIndex = 21;
			// 
			// rbMale
			// 
			this.rbMale.AutoSize = true;
			this.rbMale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rbMale.Location = new System.Drawing.Point(59, 270);
			this.rbMale.Name = "rbMale";
			this.rbMale.Size = new System.Drawing.Size(61, 24);
			this.rbMale.TabIndex = 22;
			this.rbMale.TabStop = true;
			this.rbMale.Text = "Male";
			this.rbMale.UseVisualStyleBackColor = true;
			// 
			// rbFemale
			// 
			this.rbFemale.AutoSize = true;
			this.rbFemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rbFemale.Location = new System.Drawing.Point(141, 270);
			this.rbFemale.Name = "rbFemale";
			this.rbFemale.Size = new System.Drawing.Size(80, 24);
			this.rbFemale.TabIndex = 23;
			this.rbFemale.TabStop = true;
			this.rbFemale.Text = "Female";
			this.rbFemale.UseVisualStyleBackColor = true;
			// 
			// frmAddNewClient
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.AppWorkspace;
			this.ClientSize = new System.Drawing.Size(668, 396);
			this.Controls.Add(this.rbFemale);
			this.Controls.Add(this.rbMale);
			this.Controls.Add(this.dateTimePicker1);
			this.Controls.Add(this.nudAccountBalance);
			this.Controls.Add(this.txtPhone);
			this.Controls.Add(this.txtEmail);
			this.Controls.Add(this.txtLastName);
			this.Controls.Add(this.txtFirstName);
			this.Controls.Add(this.txtPinCode);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.txtAccountNumber);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "frmAddNewClient";
			this.Text = "frmAddNewClient";
			this.Load += new System.EventHandler(this.frmAddNewClient_Load);
			((System.ComponentModel.ISupportInitialize)(this.nudAccountBalance)).EndInit();
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
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAccountNumber;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtPinCode;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.NumericUpDown nudAccountBalance;
        private System.Windows.Forms.ErrorProvider errorProvider1;
		private System.Windows.Forms.RadioButton rbMale;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.RadioButton rbFemale;
	}
}