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
    public partial class frmWithDraw : Form
    {
        public frmWithDraw()
        {
            InitializeComponent();
        }
        clsClient client = new clsClient();
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (clsClient.IsClientExists(txtAccountNumber.Text))
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

        private void btnWithDraw_Click(object sender, EventArgs e)
        {
            if (client.WithDraw(nudAmount.Value))
            {
                MessageBox.Show($"Operation Successfully Your Account Balance is {client.AccountBalance - nudAmount.Value}");
                panel1.Visible = false;
                txtAccountNumber.Text = "";
            }
            else
            {
                MessageBox.Show("Deposit Is Failed");
            }
            ShowAllWithDraws();

        }

        private void frmWithDraw_Load(object sender, EventArgs e)
        {
            ShowAllWithDraws();
        }

        private void ShowAllWithDraws()
        {
            dgvWithDraws.DataSource = clsClient.GetAllWithDraws();
        }
    }
}
