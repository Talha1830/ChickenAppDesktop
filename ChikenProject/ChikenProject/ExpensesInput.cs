using System;
using TheChicken.BL;

namespace ChikenProject
{
    public partial class ExpensesInput : MetroFramework.Forms.MetroForm
    {
        public void Clear()
        {
            txtAmount.Value = 0;
            txtDescription.Text = string.Empty;
        }
        public void ClearGlyph()
        {
            errorProvider1.SetError(txtAmount, null);
            errorProvider1.SetError(txtDescription, null);
        }
        public bool Validation()
        {
            if (txtAmount.Value == 0)
            {
                errorProvider1.SetError(txtAmount, "Please Enter Amount");
                return false;
            }
            else if (string.IsNullOrEmpty(txtDescription.Text) == true)
            {
                errorProvider1.SetError(txtDescription, "Please Enter Descritption");
                return false;
            }
            else
                return true;
        }
        int CashierId = 0;
        public ExpensesInput(int Cashierid)
        {
            InitializeComponent();
            CashierId = Cashierid;

        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            ClearGlyph();
            if (Validation() == true)
            {
                Expenses_ obj = new Expenses_();
                obj.CashierId = CashierId;
                obj.Amount = txtAmount.Value;
                obj.Description = txtDescription.Text;
                obj.E_date = DateTime.Now.Date;
                obj.IsNew = true;
                BL_Expenses.Save(obj);
                this.Close();
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {

        }
    }
}
