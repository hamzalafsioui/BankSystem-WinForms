using BankBusinessLayer;
using System.Windows.Forms;

namespace systemBank
{
	public partial class frmAllUsers : Form
	{

		public frmAllUsers()
		{
			InitializeComponent();
			ShowAllUsers();
		}

		private void ShowAllUsers()
		{
			dgvAllUsers.DataSource = clsUser.GetAllUsers();
			dgvAllUsers.Columns[0].HeaderText = "User ID";
			dgvAllUsers.Columns[1].HeaderText = "User Name";
			dgvAllUsers.Columns[2].HeaderText = "Full Name";
		}

	}
}
