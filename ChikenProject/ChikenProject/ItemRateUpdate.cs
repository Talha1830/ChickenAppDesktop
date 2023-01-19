using System;
using TheChicken.BL;

namespace ChikenProject
{
    public partial class ItemRateUpdate : MetroFramework.Forms.MetroForm
    {
        int Id = 0;
        public void LoadData(int RateListId)
        {

            RateList_ obj = BL_RateList.Get(RateListId);
            txtRetailPrice.Value = obj.RetailPrice;
            txtWholeSalePrice.Value = obj.WholeSalePrice;

        }
        public ItemRateUpdate(int RateListId)
        {
            InitializeComponent();
            LoadData(RateListId);
            Id = RateListId;

        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (txtRetailPrice.Value == 0)
                errorProvider1.SetError(txtRetailPrice, "Please Enter Amount");
            else if (txtWholeSalePrice.Value == 0)
                errorProvider1.SetError(txtWholeSalePrice, "Please Enter Amount");
            else
            {
                errorProvider1.SetError(txtRetailPrice, null);
                errorProvider1.SetError(txtWholeSalePrice, null);
                RateList_ obj = BL_RateList.Get(Id);
                obj.WholeSalePrice = txtWholeSalePrice.Value;
                obj.RetailPrice = txtRetailPrice.Value;
                obj.IsNew = false;
                obj.RateListId = Id;
                BL_RateList.Save(obj);
                this.Close();
            }



        }
    }
}
