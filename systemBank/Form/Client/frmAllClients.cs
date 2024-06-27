using BankBusinessLayer;
using System.Windows.Forms;

namespace systemBank
{
	public partial class frmAllClients : Form
	{
		public frmAllClients()
		{
			InitializeComponent();
			ShowAllClients();
		}

		public void ShowAllClients()
		{
			dgvAllClients.DataSource = clsClient.GetAllClients();
			dgvAllClients.Columns[0].HeaderText = "ID";
			dgvAllClients.Columns[0].Width = 50;
			dgvAllClients.Columns[1].HeaderText = "Account Number";
			dgvAllClients.Columns[1].Width = 120;
			dgvAllClients.Columns[2].HeaderText = "Full Name";
			dgvAllClients.Columns[3].Width = 60;
			dgvAllClients.Columns[4].Width = 160;
			dgvAllClients.Columns[6].HeaderText = "Date Of Birth";
			dgvAllClients.Columns[7].HeaderText = "Balance ";
		}
	}
}
