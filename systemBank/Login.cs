using BankBusinessLayer;
using System;
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
			string password = txtPassword.Text;

			clsUser user = clsUser.FindByUserNameAndPassword(username, password);

			if (user != null)
			{
				frmHome frm = new frmHome(user);

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

			txtUserName.Text = "User";
			txtPassword.Text = "1234";
		}
	}
}
