
using System;
using TheChicken.BL;

namespace ChikenProject
{
    public partial class SighnUp : MetroFramework.Forms.MetroForm
    {

        public bool Validation()
        {
            if (string.IsNullOrEmpty(txtUserName.Text) == true)
            {
                errorProvider1.SetError(txtUserName, "Please Enter User Name");
                return false;
            }
            else if (string.IsNullOrEmpty(txtPassword.Text) == true)
            {
                errorProvider1.SetError(txtPassword, "Please Enter Password");
                return false;
            }
            else if (string.IsNullOrEmpty(txtEmail.Text) == true)
            {
                errorProvider1.SetError(txtEmail, "Please Enter Email");
                return false;
            }
            else
            {
                return true;
            }

        }
        public void clearGlyph()
        {
            errorProvider1.SetError(txtUserName, null);
            errorProvider1.SetError(txtPassword, null);
            errorProvider1.SetError(txtEmail, null);
        }
        public void Clear()
        {
            txtUserName.Text = "";
            txtEmail.Text = "";
            txtPassword.Text = "";
        }

        public SighnUp()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void LinkLogin_Click(object sender, EventArgs e)
        {
            LoginCashier obj = new LoginCashier();
            obj.Show();
            this.Hide();
        }

        private void btnregister_Click(object sender, EventArgs e)
        {
            clearGlyph();
            if (Validation() == true)
            {
                Cashier_ obj = new Cashier_();
                obj.UserName = txtUserName.Text;
                obj.Password = txtPassword.Text;
                obj.Email = txtEmail.Text;
                obj.Status = false;
                obj.IsNew = true;
                BL_Cashier.Save(obj);
                this.Hide();
                LoginCashier loginCashier = new LoginCashier();
                loginCashier.Show();
            }
        }

        private void TxtPassword_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            txtPassword.isPassword = true;
        }
    }
}
