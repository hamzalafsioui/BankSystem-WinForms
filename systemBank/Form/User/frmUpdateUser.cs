using BankBusinessLayer;
using System;
using System.Windows.Forms;

namespace systemBank
{
	public partial class frmUpdateUser : Form
	{
		public frmUpdateUser()
		{
			InitializeComponent();
		}
		clsUser User = new clsUser();
		private void btnSearch_Click(object sender, EventArgs e)
		{
			if (clsUser.IsUserExists(txtUserName.Text.Trim()))
			{
				pnlInfo.Enabled = true;
				User = clsUser.FindByUserName(txtUserName.Text.Trim());
				FillControls(User);



			}
			else
			{
				MessageBox.Show("User Not Found");
			}
		}

		private int CalcPermission()
		{
			int permission = 0;
			if (chkManageClient.Checked)
				permission += 1;
			if (chkManageUser.Checked)
				permission += 2;
			if (chkTransactions.Checked)
				permission += 4;
			if (chkCurrency.Checked)
				permission += 8;

			return permission;
		}

		public void UploadInfo(ref clsUser User)
		{
			User.Permissions = CalcPermission();
			User.UserName = txtUserName.Text;
			User.FirstName = txtFirstName.Text;
			User.LastName = txtLastName.Text;
			User.Phone = txtPhone.Text;
			if (rbFemale.Checked)
				User.Gender = 'F';
			else
				User.Gender = 'M';
			User.Email = txtEmail.Text;
			User.DateOfBirth = dateTimePicker1.Value;

		}

		private void FillControls(clsUser User)
		{
			txtFirstName.Text = User.FirstName;
			txtLastName.Text = User.LastName;
			txtEmail.Text = User.Email;
			txtPassword.Text = User.Password;
			txtPhone.Text = User.Phone;
			dateTimePicker1.Value = User.DateOfBirth;
			if (User.Gender == 'M')
				rbMale.Checked = true;
			else
				rbFemale.Checked = true;

			chkManageClient.Checked = ((User.Permissions & 1) == 1);
			chkManageUser.Checked = ((User.Permissions & 2) == 2);
			chkTransactions.Checked = ((User.Permissions & 4) == 4);
			chkCurrency.Checked = ((User.Permissions & 8) == 8);


		}

		private void btnAddUser_Click(object sender, EventArgs e)
		{
			UploadInfo(ref User);
			if (User.Save())
			{
				MessageBox.Show("Update Successfully");
				pnlInfo.Enabled = false;
			}
			else
			{
				MessageBox.Show("Failed Update");
			}
		}


	}
}
