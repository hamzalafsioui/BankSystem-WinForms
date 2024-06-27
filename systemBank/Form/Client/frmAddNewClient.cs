using BankBusinessLayer;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace systemBank
{
	public partial class frmAddNewClient : Form
	{
		clsClient client;
		public frmAddNewClient()
		{
			InitializeComponent();
		}
		public frmAddNewClient(int ClientID)
		{
			InitializeComponent();

		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			if (!this.ValidateChildren())
			{
				return;
			}
			if (clsClient.IsClientExists(txtAccountNumber.Text))
			{
				MessageBox.Show("Account NUmber is Exist,Please Choose Other");
			}
			else
			{
				clsClient client = _FillClientInfo();

				if (client.Save())
				{
					MessageBox.Show("Operation Added Successfully");
					EmptyControls();
				}
				else
				{
					MessageBox.Show("Failed Added");
				}

			}

		}

		private clsClient _FillClientInfo()
		{

			client = new clsClient();
			client.AccountNumber = txtAccountNumber.Text;
			client.FirstName = txtFirstName.Text;
			client.LastName = txtLastName.Text;
			client.Email = txtEmail.Text;
			if(txtPhone.Text.Trim() !="" )
				client.Phone = txtPhone.Text;
			
			client.DateOfBirth = dateTimePicker1.Value;
			if (rbFemale.Checked)
				client.Gender = 'F';
			else
				client.Gender = 'M';
			client.AccountBalance = Convert.ToDecimal(nudAccountBalance.Value);
			client.PinCode = txtPinCode.Text.Trim();
			return client;
		}

		private void EmptyControls()
		{
			txtFirstName.Text = "";
			txtLastName.Text = "";
			txtPhone.Text = "";
			txtEmail.Text = "";
			txtPinCode.Text = "";
			txtAccountNumber.Text = "";
			nudAccountBalance.Value = 0;

		}




		private void textBox_Validating(object sender, CancelEventArgs e)
		{
			TextBox obj = sender as TextBox;
			if (string.IsNullOrEmpty(obj.Text))
			{
				errorProvider1.SetError(obj, "This element is requirement");
				e.Cancel = true;


			}
			else
			{
				errorProvider1.SetError(obj, "");
				e.Cancel = false;
			}
		}

		private void frmAddNewClient_Load(object sender, EventArgs e)
		{
			dateTimePicker1.MaxDate = DateTime.Now.AddYears(-18);
			dateTimePicker1.Value = dateTimePicker1.MaxDate.AddYears(-1);
		}
	}
}
