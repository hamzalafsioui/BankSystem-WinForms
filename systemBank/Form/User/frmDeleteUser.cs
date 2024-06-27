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
    public partial class frmDeleteUser : Form
    {
        public frmDeleteUser()
        {
            InitializeComponent();
        }
        clsUser User = new clsUser();
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(clsUser.IsUserExists(txtUserName.Text))
            {
                User = clsUser.FindByUserName(txtUserName.Text);
                btnDelete.Visible = true;
                btnDelete.Enabled = true;
                txtPhone.Text = User.Phone;
                txtEmail.Text = User.Email;
                txtFirstName.Text = User.FirstName;   
                txtLastName.Text = User.LastName;
                txtPassword.Text = User.Password;
            }
            else
            {
                MessageBox.Show("User Not Found");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (clsUser.DeleteUserByUserName(User.UserName))
            {
                MessageBox.Show("Delete Successfully");
            }
            else
            {
                MessageBox.Show("User Not Deleted");
            }
        }
    }
}
