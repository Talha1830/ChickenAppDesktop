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
    public partial class LoginCashier : MetroFramework.Forms.MetroForm
    {
        public LoginCashier()
        {
            InitializeComponent();
            txtPassword.isPassword = true;
        }

        private void MetroLink1_Click(object sender, EventArgs e)
        {
            SighnUp obj = new SighnUp();
            obj.Show();
            this.Hide();
        }

       

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUserName.Text) == true)
                errorProvider1.SetError(txtUserName, "Please Enter User Name or Email");
           else if (string.IsNullOrEmpty(txtPassword.Text) == true)
                errorProvider1.SetError(txtPassword, "Please Enter Password");
            else
            {
                Cashier_ obj = new Cashier_();
                obj.UserName = txtUserName.Text;
                obj.Password = txtPassword.Text;
                Admin_ admin_ = new Admin_();
                admin_.UserName = txtUserName.Text;
                admin_.Password = txtPassword.Text;
                if(BL_Cashier.Get(obj).Rows.Count>0)
                {
                    this.Hide();
                    DailyInvoice dailyInvoice = new DailyInvoice(Convert.ToInt16(obj.CashierId));
                    dailyInvoice.Show();
                }
                else if(BL_Admin.Get(admin_).Rows.Count>0)
                {
                    this.Hide();
                    DailyInvoice dailyInvoice = new DailyInvoice(Convert.ToInt16(obj.CashierId));
                    dailyInvoice.Show();
                }
                else
                    MessageBox.Show("User Name or Password are incorrect","Error",MessageBoxButtons.OK,MessageBoxIcon.Information);

            }   
        }

        private void TxtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtPassword.isPassword = true;
        }
    }
}
