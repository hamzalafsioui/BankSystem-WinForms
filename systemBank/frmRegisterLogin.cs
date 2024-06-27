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
    public partial class frmRegisterLogin : Form
    {
        public frmRegisterLogin()
        {
            InitializeComponent();
        }

        private void frmRegisterLogin_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = clsUser.GetAllRegisterLogin();
        }
    }
}
