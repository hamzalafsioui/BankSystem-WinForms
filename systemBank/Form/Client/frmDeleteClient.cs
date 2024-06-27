using BankBusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace systemBank
{
    public partial class frmDeleteClient : Form
    {
        public frmDeleteClient()
        {
            InitializeComponent();
        }
        clsClient client = new clsClient();
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(clsClient.IsClientExists(txtAccountNumber.Text))
            {
                client = clsClient.FindByAccountNumber(txtAccountNumber.Text);
                btnDelete.Enabled = true;
                txtEmail.Text = client.Email;
                txtFirstName.Text = client.FirstName;
                txtLastName.Text = client.LastName;
                txtPhone.Text = client.Phone;
                txtPinCode.Text = client.PinCode;
                nudAccountBalance.Value = client.AccountBalance;
            }
            else
            {
                MessageBox.Show("Client Not Exists");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (clsClient.DeleteClientByAccountNumber(txtAccountNumber.Text))
            {
                MessageBox.Show("Delete Successfully");
                btnDelete.Enabled = false;
                txtAccountNumber.Text = "";
            }
            else
            {
                MessageBox.Show("Delete Failed");
            }
        }
    }
}
