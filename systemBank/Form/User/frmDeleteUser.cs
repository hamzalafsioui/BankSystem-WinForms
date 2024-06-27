using BankBusinessLayer;
using System;
using System.Windows.Forms;

namespace systemBank
{
	public partial class frmDeleteUser : Form
	{
		public frmDeleteUser()
		{
			InitializeComponent();
		}
		clsUser User = new clsUser();
		private void btnSearch_Click(object sender, EventArgs e)
		{
			if (clsUser.IsUserExists(txtUserName.Text))
			{
				User = clsUser.FindByUserName(txtUserName.Text);
				btnDelete.Visible = true;
				btnDelete.Enabled = true;
				txtPhone.Text = User.Phone;
				txtEmail.Text = User.Email;
				txtFirstName.Text = User.FirstName;
				txtLastName.Text = User.LastName;
				dateTimePicker1.Value = User.DateOfBirth;
				if (User.Gender == 'M')
					rbMale.Checked = true;
				else
					rbFemale.Checked = true;

			}
			else
			{
				MessageBox.Show("User Not Found");
			}
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			if (clsUser.DeleteUserByUserName(User.UserName))
			{
				MessageBox.Show("Delete Successfully");
			}
			else
			{
				MessageBox.Show("You can't delete this User because he was enter to our system !!", "Delete User", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}
	}
}
