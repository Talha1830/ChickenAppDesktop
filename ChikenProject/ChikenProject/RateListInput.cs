using System;
using System.Data;
using System.Windows.Forms;
using TheChicken.BL;

namespace ChikenProject
{
    public partial class RateListInput : MetroFramework.Forms.MetroForm
    {
        Item[] item;
        public void LoadItem(int ItemType)
        {
            flowLayoutPanel1.Controls.Clear();
            DataTable dt = BL_Item.Get(ItemType: ItemType);
            if (dt != null)
            {
                item = new Item[dt.Rows.Count];
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    item[i] = new Item();
                    item[i].ItemName = Convert.ToString(dt.Rows[i]["ItemName"]);
                    item[i].Name = Convert.ToString(dt.Rows[i]["ItemId"]);
                    flowLayoutPanel1.Controls.Add(item[i]);
                }
            }
        }
        public RateListInput()
        {
            InitializeComponent();
        }

        private void CmbitemType_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            if(cmbitemType.SelectedIndex==0)
            {
                LoadItem(cmbitemType.SelectedIndex);
            }
            else if (cmbitemType.SelectedIndex==1)
            {
                LoadItem(cmbitemType.SelectedIndex);
            }
            else if (cmbitemType.SelectedIndex==2)
            {
                LoadItem(cmbitemType.SelectedIndex);
            }
        }
        public bool Validation2()
        {
            for (int i = 0; i < flowLayoutPanel1.Controls.Count; i++)
            {
                if (item[i].txtWholeSale.Value == 0)
                {
                    errorProvider1.SetError(item[i].txtWholeSale, "Please Enter Retail Price");
                    return false;

                }
                else if (item[i].txtRetail.Value == 0)
                {
                    errorProvider1.SetError(item[i].txtRetail, "Please Enter Whole Sale Rate");
                    return false;

                }
                else if (i == flowLayoutPanel1.Controls.Count - 1)
                    return true;
            }
            return false;
        }
        private void BtnClear_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (flowLayoutPanel1.Controls.Count > 0)
            {
                if (Validation2() == true)
                {

                    for (int i = 0; i < flowLayoutPanel1.Controls.Count; i++)
                    {
                        RateList_ rateList_ = new RateList_();
                        rateList_.PurchaseId = BL_RateList.Get_ID(cmbitemType.SelectedIndex);
                        rateList_.ItemId = Convert.ToInt16(item[i].Name);
                        rateList_.WholeSalePrice = item[i].txtWholeSale.Value;
                        rateList_.RetailPrice = item[i].txtRetail.Value;
                        rateList_.IsNew = true;
                        rateList_.R_Type = cmbitemType.SelectedIndex;
                        rateList_.R_Date = DateTime.Now.Date;
                        BL_RateList.Save(rateList_);
                    }
                    MessageBox.Show("Submit SuccessFully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            else
                Helper.MessageCustomError("No Items");

        }
    }
}
