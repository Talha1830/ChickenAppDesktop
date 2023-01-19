using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheChicken.BL;

namespace ChikenProject
{
    public partial class AdminLogin : MetroFramework.Forms.MetroForm
    {
        public AdminLogin()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUserName.Text) == true)
                errorProvider1.SetError(txtUserName, "Please Enter UserName,Email");
            else if (string.IsNullOrEmpty(txtPassword.Text) == true)
                errorProvider1.SetError(txtPassword, "Please Enter Password");
            else
            {
                errorProvider1.SetError(txtUserName, null);
                errorProvider1.SetError(txtPassword, null);
                Admin_ obj = new Admin_();
                obj.UserName = txtUserName.Text;
                obj.Password = txtPassword.Text;
                Cashier_ cashier_ = new Cashier_();
                cashier_.UserName = txtUserName.Text;
                cashier_.Password = txtPassword.Text;
                cashier_.Status = true;
                if (BL_Admin.Get(obj).Rows.Count > 0)
                {
                    this.Hide();
                    Admin admin = new Admin();
                    admin.Show();
                }
                else if (BL_Cashier.Get(cashier_).Rows.Count > 0)
                {
                    this.Hide();
                    Admin admin = new Admin();
                    admin.Show();
                }

                else
                    Helper.MessageCustomError("UserName or Password are incorrect");

            }
        }

        private void TxtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtPassword.isPassword = true;
        }
    }
}
