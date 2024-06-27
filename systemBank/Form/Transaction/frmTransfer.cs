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
    public partial class frmTransfer : Form
    {
        public frmTransfer()
        {
            InitializeComponent();
        }
        clsClient ClientF = new clsClient();
        clsClient ClientT = new clsClient();
        private void btnSearchF_Click(object sender, EventArgs e)
        {
            if (clsClient.IsClientExists(txtAccountNumberF.Text))
            {
                txtAccountBalanceF.Visible = true;
                ClientF = clsClient.FindByAccountNumber(txtAccountNumberF.Text);
                txtAccountBalanceF.Text = ClientF.AccountBalance.ToString();

            }
            else
            {
                MessageBox.Show("Client Not Found");
            }
        }

        private void btnSearchT_Click(object sender, EventArgs e)
        {
            if (clsClient.IsClientExists(txtAccountNumberT.Text))
            {
                txtAccountBalanceT.Visible = true;
                ClientT = clsClient.FindByAccountNumber(txtAccountNumberT.Text);
                txtAccountBalanceT.Text = ClientT.AccountBalance.ToString();

            }
            else
            {
                MessageBox.Show("Client Not Found");
            }
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
             if(txtAccountBalanceF.Visible && txtAccountBalanceT.Visible)
            {
                if (ClientF.Transfer(ClientT.AccountNumber, nudAmount.Value))
                {
                    txtAccountNumberF.Clear();
                    txtAccountNumberT.Clear();
                    txtAccountBalanceF.Clear();
                    txtAccountBalanceT.Clear();
                    txtAccountBalanceT.Visible = false;
                    txtAccountBalanceF.Visible = false;
                    MessageBox.Show("Operation Successfully");
                }
                else
                {
                    MessageBox.Show("Operation Failed");

                }
            }
            else
            {
                MessageBox.Show("Please fill Information ");
            }
            ShowAllTransfers();
        }

        private void ShowAllTransfers()
        {
            dgvTransfer.DataSource = clsClient.GetAllTransfers();
        }
        private void dgvTransfer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmTransfer_Load(object sender, EventArgs e)
        {
            ShowAllTransfers();
        }
    }
}
