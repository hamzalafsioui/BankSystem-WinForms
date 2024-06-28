using BankBusinessLayer;
using System;
using System.Windows.Forms;

namespace systemBank
{
	public partial class frmAddNewUser : Form
	{
		public frmAddNewUser()
		{
			InitializeComponent();
		}
		clsUser User = new clsUser();
		private void btnAddUser_Click(object sender, EventArgs e)
		{
			if (!this.ValidateChildren())
			{
				//Here we don't continue because the form is not valid
				MessageBox.Show("Some fields are not valid!, put the mouse over the red icon(s) to see the erro",
					"Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			if (clsUser.IsUserExists(txtUserName.Text.Trim()))
			{
				MessageBox.Show("UserName Is Exists !!!");
				return;
			}
			else
			{
				UploadInfo(ref User);
				if (User.Save())
				{
					MessageBox.Show("Added Successfully");
					txtUserName.Clear();
					txtPhone.Clear();
					txtPassword.Clear();
					txtLastName.Clear();
					txtFirstName.Clear();
					txtPassword.Clear();

					chkCurrency.Checked = false;
					chkManageClient.Checked = false;
					chkManageUser.Checked = false;
					chkTransactions.Checked = false;

				}
				else
				{
					MessageBox.Show("Failed Update !!!");
					//EmptyControls();
				}
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
			User.Gender = (rbFemale.Checked) ? 'F' : 'M';
			User.DateOfBirth = dateTimePicker1.Value;
			User.Email = txtEmail.Text;
			User.Password = clsGlobal.ComputeHash(txtPassword.Text);

		}

		private void EmptyControls()
		{
			txtEmail.Clear();
			txtPassword.Clear();
			txtUserName.Clear();
			txtPhone.Clear();
			txtFirstName.Clear();
			txtLastName.Clear();
			chkCurrency.Checked = false;
			chkManageClient.Checked = false;
			chkManageUser.Checked = false;
			chkTransactions.Checked = false;

		}

		private void frmAddNewUser_Load(object sender, EventArgs e)
		{
			dateTimePicker1.MaxDate = DateTime.Now.AddYears(-18);
			dateTimePicker1.Value = DateTime.Now.AddYears(-20);
			rbMale.Checked = true;
		}

		private void txt_Validating(object sender, System.ComponentModel.CancelEventArgs e)
		{
			TextBox txt = (TextBox)sender;
			if (string.IsNullOrEmpty(txt.Text.Trim()))
			{
				e.Cancel = true;
				errorProvider1.SetError(txt, "This Field is required!");
			}
			else
			{
				errorProvider1.SetError(txt, null);
			}
		}
	}
}
