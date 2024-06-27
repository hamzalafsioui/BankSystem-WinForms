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
    public partial class frmAddNewUser : Form
    {
        public frmAddNewUser()
        {
            InitializeComponent();
        }
        clsUser User = new clsUser();
        private void btnAddUser_Click(object sender, EventArgs e)
        {
            if(clsUser.IsUserExists(txtUserName.Text))
            {
                MessageBox.Show("UserName Is Exists !!!");
            }
            else
            {
                UploadInfo(ref User);
                if (User.Save())
                {
                    MessageBox.Show("Added Successfully");
                    txtUserName.Clear();
                    txtPhone.Clear();
                    txtPassword.Clear();
                    txtLastName.Clear();
                    txtFirstName.Clear();
                    txtPassword.Clear();
                    chkCurrency.Checked = false;
                    chkManageClient.Checked = false;
                    chkManageUser.Checked = false;
                    chkTransactions.Checked = false;

                }
                else
                {
                    MessageBox.Show("Failed Update !!!");
                    EmptyControls();
                }
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

        private void EmptyControls()
        {
            txtEmail.Clear();
            txtPassword.Clear();
            txtUserName.Clear();
            txtPhone.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
            chkCurrency.Checked = false;
            chkManageClient.Checked = false;
            chkManageUser.Checked = false;
            chkTransactions.Checked = false;

        }
    }
}
