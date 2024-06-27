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
    public partial class frmShowAllCurrencies : Form
    {
        public frmShowAllCurrencies()
        {
            InitializeComponent();
        }

        private void frmShowAllCurrencies_Load(object sender, EventArgs e)
        {
            dgvCurrencies.DataSource = clsCurrency.GetAllCurrencies();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchTerm = txtCurrencyCode.Text.Trim(); // Get the search term from the TextBox and remove leading/trailing spaces

            if (!string.IsNullOrEmpty(searchTerm)) // Check if the search term is not empty
            {
                DataTable allCurrencies = clsCurrency.GetAllCurrencies(); // Retrieve all currencies
                DataView dv = new DataView(allCurrencies); // Create a DataView to filter the currencies

                // Apply the filter to the DataView based on the CurrencyCode column
                dv.RowFilter = $"Code LIKE '{searchTerm}%'"; // Filter currencies where the Code starts with the search term

                dgvCurrencies.DataSource = dv.ToTable(); // Set the filtered data as the new data source for the DataGridView
            }
            else // If the search term is empty, show all currencies
            {
                dgvCurrencies.DataSource = clsCurrency.GetAllCurrencies(); // Reset the DataGridView to show all currencies
            }
        }
    }
}
