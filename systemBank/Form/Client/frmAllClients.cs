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
    public partial class frmAllClients : Form
    {
        public frmAllClients()
        {
            InitializeComponent();
            ShowAllClients();
        }
        
        public void ShowAllClients()
        {
            dgvAllClients.DataSource = clsClient.GetAllClients();
        }
    }
}
