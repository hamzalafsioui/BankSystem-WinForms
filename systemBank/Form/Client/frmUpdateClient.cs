using BankBusinessLayer;
using System;
using System.Windows.Forms;

namespace systemBank
{
	public partial class frmUpdateClient : Form
	{
		public frmUpdateClient()
		{
			InitializeComponent();
		}
		clsClient client;
		private void btnSearch_Click(object sender, EventArgs e)
		{
			if (clsClient.IsClientExists(txtAccountNumber.Text))
			{
				client = clsClient.FindByAccountNumber(txtAccountNumber.Text);
				pnlInfoUpdate.Enabled = true;
				txtEmail.Text = client.Email;
				txtFirstName.Text = client.FirstName;
				txtLastName.Text = client.LastName;
				txtPhone.Text = client.Phone;
				txtPinCode.Text = client.PinCode;
				dateTimePicker1.Value = client.DateOfBirth;
				if (client.Gender == 'M')
					rbMale.Checked = true;
				else
					rbFemale.Checked = true;
				nudAccountBalance.Value = client.AccountBalance;
			}
			else
			{
				MessageBox.Show("Client Not Found");
			}
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			client.FirstName = txtFirstName.Text;
			client.LastName = txtLastName.Text;
			client.Phone = txtPhone.Text;
			client.PinCode = txtPinCode.Text;
			client.AccountBalance = nudAccountBalance.Value;
			client.Email = txtEmail.Text;
			if (client.Save())
			{
				MessageBox.Show("Update Successfully");
				pnlInfoUpdate.Enabled = false;
				txtAccountNumber.Text = "";
				client = new clsClient();
			}
			else
			{
				MessageBox.Show("Failed");
			}
		}
	}
}
