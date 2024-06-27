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
    public partial class frmCurrencyCalculator : Form
    {
        public frmCurrencyCalculator()
        {
            InitializeComponent();
        }

        clsCurrency CurrencyFrom = new clsCurrency();
        clsCurrency CurrencyTo = new clsCurrency ();
        

        private void btnExchange_Click(object sender, EventArgs e)
        {
            if(! pnlTo.Enabled && ! pnlFrom.Enabled) {

                decimal Result = (  (Convert.ToDecimal(nudAmount.Value) * CurrencyTo.Rate)/ CurrencyFrom.Rate)  ;
                lblAmountTo.Text = Result.ToString("N2");
                lblAmountFrom.Text = nudAmount.Value.ToString();
            }
        }

        private void btnSearchF_Click(object sender, EventArgs e)
        {
            if (clsCurrency.IsCurrencyExistsByCode(txtCurrencyFrom.Text))
            {
                CurrencyFrom = clsCurrency.Find(txtCurrencyFrom.Text);
                pnlFrom.Enabled = false;
                lblCurrencyFrom.Text = txtCurrencyFrom.Text;
                if (pnlTo.Enabled == false)
                {
                    pnlExchange.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show("Currency Not Found");
            }
        }

        private void btnSearchT_Click(object sender, EventArgs e)
        {
            if (clsCurrency.IsCurrencyExistsByCode(txtCurrencyFrom.Text))
            {
                CurrencyTo = clsCurrency.Find(txtCurrencyTo.Text);
                pnlTo.Enabled = false;
                lblCurrencyTo.Text = txtCurrencyTo.Text;
                if(pnlFrom.Enabled==false)
                {
                    pnlExchange.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show("Currency Not Found");
            }
        }
    }
}
