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
    public partial class frmDeposit : Form
    {
        public frmDeposit()
        {
            InitializeComponent();
        }
        clsClient client = new clsClient();
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(clsClient.IsClientExists(txtAccountNumber.Text))
            {
                panel1.Visible = true;
                client = clsClient.FindByAccountNumber(txtAccountNumber.Text);
                txtAccountBalance.Text = client.AccountBalance.ToString();

            }
            else
            {
                MessageBox.Show("Client Not Found");
            }
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            if (client.Deposit(nudAmount.Value))
            {
                MessageBox.Show($"Operation Successfully Your Account Balance is {client.AccountBalance + nudAmount.Value}");
                panel1.Visible = false;
                txtAccountNumber.Text = "";
            }
            else
            {
                MessageBox.Show("Deposit Is Failed");
            }
            ShowAllDeposits();
        }

        private void frmDeposit_Load(object sender, EventArgs e)
        {
            ShowAllDeposits();
        }

        private void ShowAllDeposits()
        {
            dgvDeposit.DataSource = clsClient.GetAllDeposits();
            dgvDeposit.Columns[1].Width = 100;
            dgvDeposit.Columns[2].Width = 200;
            dgvDeposit.Columns[3].Width = 300;
        }
    }
}
