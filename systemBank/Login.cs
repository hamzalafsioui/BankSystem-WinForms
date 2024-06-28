using BankBusinessLayer;
using System;
using System.IO;
using System.Windows.Forms;

namespace systemBank
{
	public partial class frmLogin : Form
	{
		public frmLogin()
		{
			InitializeComponent();
		}

		//bool IsUserClosing = true;
		private void btnLogin_Click(object sender, EventArgs e)
		{
			string username = txtUserName.Text.Trim();
			//string password = txtPassword.Text;
			string password = clsGlobal.ComputeHash(txtPassword.Text);


			clsGlobal.GlobalUser = clsUser.FindByUserNameAndPassword(username, password);

			if (clsGlobal.GlobalUser != null)
			{
				if (chkRememberMe.Checked)
				{
					clsGlobal.RememberUsernameAndPasswordInRegistry(username, txtPassword.Text);
				}
				else
				{
					//store empty username and password
					clsGlobal.RemoveStoredCredentialFromRegistry();
				}
				frmHome frm = new frmHome(clsGlobal.GlobalUser);

				this.Hide();
				//this.Visible = false;
				frm.ShowDialog();
				this.Visible = true;

				// txtUserName.Text = "";
				//txtPassword.Text = "";
			}
			else
			{
				MessageBox.Show("Incorrect username or password");
			}
		}

		private void frmLogin_Load(object sender, EventArgs e)
		{
			string UserName = "", Password = "";

			if (clsGlobal.GetStoredCredentialFromRegistry(ref UserName, ref Password))
			{
				txtUserName.Text = UserName;
				txtPassword.Text = Password;
				chkRememberMe.Checked = true;
			}
			else
				chkRememberMe.Checked = false;
		}
	}
}
