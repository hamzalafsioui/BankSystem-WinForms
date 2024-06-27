using BankBusinessLayer;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace systemBank
{
    public partial class frmAddNewClient : Form
    {
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

            clsClient client = new clsClient();
            client.AccountNumber = txtAccountNumber.Text;
            client.FirstName = txtFirstName.Text;
            client.LastName = txtLastName.Text;
            client.Email = txtEmail.Text;
            client.Phone = txtPhone.Text;
            client.AccountBalance = Convert.ToDecimal(nudAccountBalance.Value);
            client.PinCode = txtPinCode.Text;
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

        private void txtAccountNumber_Validating(object sender, CancelEventArgs e)
        {

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
    }
}
