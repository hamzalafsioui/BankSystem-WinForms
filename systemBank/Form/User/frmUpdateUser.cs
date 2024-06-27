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
    public partial class frmUpdateUser : Form
    {
        public frmUpdateUser()
        {
            InitializeComponent();
        }
        clsUser User = new clsUser();
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(clsUser.IsUserExists(txtUserName.Text))
            {
                pnlInfo.Enabled = true;
                User = clsUser.FindByUserName(txtUserName.Text);
                FillControls(User);



            }
            else
            {
                MessageBox.Show("User Not Found");
            }
        }

        private int CalcPermission()
        {
            int permission = 0;
            if (chkManageClient.Checked)
                permission += 1;
            if (chkManageUser.Checked)
                permission += 2;
            if (chkTransactions.Checked)
                permission += 4;
            if (chkCurrency.Checked)
                permission += 8;

            return permission;
        }

        public void UploadInfo(ref clsUser User)
        {
            User.Permissions = CalcPermission();
            User.UserName = txtUserName.Text;
            User.FirstName = txtFirstName.Text;
            User.LastName = txtLastName.Text;
            User.Phone = txtPhone.Text;
            User.Email = txtEmail.Text;
            User.Password = txtPassword.Text;

        }

        private void FillControls(clsUser User)
        {
            txtEmail.Text = User.Email;
            txtFirstName.Text = User.FirstName;
            txtLastName.Text = User.LastName;
            txtPassword.Text = User.Password;
            txtPhone.Text = User.Phone;
            
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            UploadInfo(ref User);
            if (User.Save())
            {
                MessageBox.Show("Update Successfully");
                pnlInfo.Enabled = false;
            }
            else
            {
                MessageBox.Show("Failed Update");
            }
        }
    }
}
