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
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
            CustomizeDesign();
        }
        clsUser User = new clsUser();
        public frmHome(clsUser user)
        {
            
            InitializeComponent();
            CustomizeDesign();
            User = user;
            if (User.Login())
            {
                MessageBox.Show("Welcome Back " + User.UserName);
            }
            else
            {
                MessageBox.Show("Failed Login");
                this.Close();
            }
            lblUser.Text = user.UserName;

        }
       
        private void CustomizeDesign()
        {
            pnlSideMenu.Visible = true;
            pnlClient.Visible = false;
            pnlUser.Visible = false;
            pnlTransactions.Visible = false;
            pnlCurrency.Visible = false;
        }

        void GiveAccesses(int Permission)
        {
            
            if ((Permission & 1) == 1)
                btnManageClient.Enabled = true;
            if ((Permission & 2) == 2)
                btnManageUser.Enabled = true;
            if ((Permission & 4) == 4)
                btnTransactions.Enabled = true;
            if ((Permission & 8) == 8)
                btnCurrency.Enabled = true;
        }


        private void hideSideMenu()
        {
            //if(pnlSideMenu.Visible == true) 
            //    pnlSideMenu.Visible = false;

            if(pnlClient.Visible == true)
                pnlClient.Visible=false;

            if (pnlTransactions.Visible == true)
                pnlTransactions.Visible = false;

            if(pnlCurrency.Visible == true)
                pnlCurrency.Visible = false;

            if(pnlUser.Visible == true) 
                pnlUser.Visible = false;

        }

        private void ShowSubMenu(Panel PanelName)
        {
            if (PanelName.Visible == false)
            {
                hideSideMenu();
                PanelName.Visible = true;
            }
            else
                PanelName.Visible = false;
        }


        
        // Tools Clients

        private void btnClient_Click(object sender, EventArgs e)
        {
            ShowSubMenu(pnlClient);
            lblTitle.Text = btnManageClient.Text.ToString();
        }

        private void btnShowAllClients_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmAllClients());
            lblTitle.Text = btnShowAllClients.Text.ToString();

            hideSideMenu();
        }

        private void btnAddNewClient_Click(object sender, EventArgs e)
        {
            // code
            OpenChildForm(new frmAddNewClient());
            lblTitle.Text = btnAddNewClient.Text.ToString();

            hideSideMenu();
        }

        private void btnUpdateClient_Click(object sender, EventArgs e)
        {
            // code
            OpenChildForm(new frmUpdateClient());
            lblTitle.Text = btnUpdateClient.Text.ToString();

            hideSideMenu();
        }

        private void btnDeleteClient_Click(object sender, EventArgs e)
        {
            // code
            OpenChildForm(new frmDeleteClient());
            lblTitle.Text = btnDeleteClient.Text.ToString();


            hideSideMenu();
        }

        // Tools Users

        private void btnUser_Click(object sender, EventArgs e)
        {
            ShowSubMenu(pnlUser);

        }

        private void btnShowAllUsers_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmAllUsers());
            lblTitle.Text = btnShowAllUsers.Text.ToString();

            hideSideMenu();
        }

        private void btnAddNewUser_Click(object sender, EventArgs e)
        {
            // code
            OpenChildForm(new frmAddNewUser());
            lblTitle.Text = btnAddNewUser.Text.ToString();

            hideSideMenu();
        }

        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            // code
            OpenChildForm(new frmUpdateUser());
            lblTitle.Text = btnUpdateUser.Text.ToString();

            hideSideMenu();
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            // code
            OpenChildForm(new frmDeleteUser());
            lblTitle.Text = btnDeleteUser.Text.ToString();

            hideSideMenu();
        }

        // Tools Transactions

        private void btnTransactions_Click(object sender, EventArgs e)
        {
            ShowSubMenu(pnlTransactions);

        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            // code
            OpenChildForm(new frmDeposit());
            lblTitle.Text = btnDeposit.Text.ToString();

            hideSideMenu();
        }

        private void btnWithDraw_Click(object sender, EventArgs e)
        {
            // code

            OpenChildForm(new frmWithDraw());
            lblTitle.Text = btnWithDraw.Text.ToString();

            hideSideMenu();
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            // code
            OpenChildForm(new frmTransfer());
            lblTitle.Text = btnTransfer.Text.ToString();
            hideSideMenu();
        }

        private void btnRegisterLogin_Click(object sender, EventArgs e)
        {
            // code
            OpenChildForm(new frmRegisterLogin());
            lblTitle.Text = btnRegisterLogin.Text.ToString();

            hideSideMenu();
        }

        // Tools Currency

        private void btnCurrency_Click(object sender, EventArgs e)
        {
            ShowSubMenu(pnlCurrency);

        }
        private void btnShowAllCurrencies_Click(object sender, EventArgs e)
        {
            // code
            OpenChildForm(new frmShowAllCurrencies());

            hideSideMenu();
        }

        private void btnUpdateCurrency_Click(object sender, EventArgs e)
        {
            // code

            OpenChildForm(new frmUpdateCurrency());
            lblTitle.Text = btnUpdateCurrency.Text.ToString();

            hideSideMenu();
        }

        private void btnCurrencyCalculator_Click(object sender, EventArgs e)
        {
            // code
            OpenChildForm(new frmCurrencyCalculator());
            lblTitle.Text = btnCurrencyCalculator.Text.ToString();

            hideSideMenu();
        }


        private Form ActiveForm = null;

        private void OpenChildForm(Form childForm)
        {
            if (ActiveForm != null)
            {
                ActiveForm.Close();
            }

            ActiveForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlChildForm.Controls.Add(childForm);
            pnlChildForm.Tag = childForm;  // Set Tag property to childForm, not just any Form
            childForm.BringToFront();
            childForm.Show();
        }

        private void pnlChildForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmHome_Load(object sender, EventArgs e)
        {
            if(User != null)
            {
                GiveAccesses(User.Permissions);
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            User = null; // Set User to null or perform any necessary cleanup

            // Close the current frmHome form
            this.Close();

            // Open a new instance of the frmLogin form
           // frmLogin frm = new frmLogin();
           // frm.Show();

        }
    }
}
