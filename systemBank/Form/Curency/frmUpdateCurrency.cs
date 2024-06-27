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
    public partial class frmUpdateCurrency : Form
    {
        public frmUpdateCurrency()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(txtCurrencyCode.Text != "")
            {
                if(clsCurrency.IsCurrencyExistsByCode(txtCurrencyCode.Text))
                {
                    panel1.Visible = true;
                    txtCurrencyCode.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Currency Code Not Found");
                }
            }
            else
            {
                MessageBox.Show("Please fill ....");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (clsCurrency.IsCurrencyExistsByCode(txtCurrencyCode.Text))
            {
                if (clsCurrency.UpdateCurrency(txtCurrencyCode.Text, Convert.ToDecimal( txtNewRate.Text)))
                {
                    MessageBox.Show("Update Successfully");
                    panel1.Visible = false;
                    txtCurrencyCode.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Update Failed");

                }
            }
            else
            {
                MessageBox.Show("Currency Code Not Found");
            }
        }
    }
}
