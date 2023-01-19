using ChikenProject.BL;
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
    public partial class PurchaseStockInput : MetroFramework.Forms.MetroForm
    {
        public void LoadVendor()
        {
            cmbVendor.DataSource = BL_Vendor.Get();
            cmbVendor.DisplayMember = "Name";
            cmbVendor.ValueMember = "VendorId";

            cmbvendordes.DataSource = BL_Vendor.Get();
            cmbvendordes.DisplayMember = "Name";
            cmbvendordes.ValueMember = "VendorId";

            cmbvendoregg.DataSource = BL_Vendor.Get();
            cmbvendoregg.DisplayMember = "Name";
            cmbvendoregg.ValueMember = "VendorId";
        }
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
        public void Clear()
        {
            txtPrice.Value = 0;
            txtWeight.Value = 0;
            cmbVendor.SelectedIndex = -1;
            txtQty.Value = 0;
            txtQtyPrice.Value = 0;
            cmbvendordes.SelectedIndex = -1;
            txtDozen.Value = 0;
            txtPricePerdzn.Value = 0;
            cmbvendoregg.SelectedIndex = -1;
            pnlDesi.Visible = false;
            pnlEgg.Visible = false;
            pnlFormychk.Visible = false;
            flowLayoutPanel1.Controls.Clear();
        }
        public void ClearGlyph()
        {
            errorProvider1.SetError(cmbVendor, null);
            errorProvider1.SetError(cmbitemType, null);
            errorProvider1.SetError(cmbvendordes, null);
            errorProvider1.SetError(cmbvendoregg, null);
            errorProvider1.SetError(txtPrice, null);
            errorProvider1.SetError(txtPricePerdzn, null);
            errorProvider1.SetError(txtQtyPrice, null);
            errorProvider1.SetError(txtWeight, null);
            errorProvider1.SetError(txtQty, null);
            errorProvider1.SetError(txtDozen, null);

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
        public bool ValidationFarmy()
        {

            if (cmbVendor.SelectedIndex == -1)
            {
                errorProvider1.SetError(cmbVendor, "Please Select Vendor");
                return false;
            }
            else if (txtWeight.Value == 0)
            {
                errorProvider1.SetError(txtWeight, "Please Enter Weight");
                return false;
            }
            else if (txtPrice.Value == 0)
            {
                errorProvider1.SetError(txtPrice, "Please Enter Price");
                return false;
            }
            else
                return true;


        }
        public bool ValidationDesi()
        {

            if (cmbvendordes.SelectedIndex == -1)
            {
                errorProvider1.SetError(cmbvendordes, "Please Select Vendor");
                return false;
            }
            else if (txtQty.Value == 0)
            {
                errorProvider1.SetError(txtQty, "Please Enter Qty");
                return false;
            }
            else if (txtQtyPrice.Value == 0)
            {
                errorProvider1.SetError(txtQtyPrice, "Please Enter Price");
                return false;
            }
            else
                return true;


        }
        public bool ValidationEgg()
        {

            if (cmbvendoregg.SelectedIndex == -1)
            {
                errorProvider1.SetError(cmbvendoregg, "Please Select Vendor");
                return false;
            }
            else if (txtDozen.Value == 0)
            {
                errorProvider1.SetError(txtDozen, "Please Enter Dozen");
                return false;
            }
            else if (txtPricePerdzn.Value == 0)
            {
                errorProvider1.SetError(txtPricePerdzn, "Please Enter Price");
                return false;
            }
            else
                return true;


        }
        public PurchaseStockInput()
        {
            InitializeComponent();
            LoadVendor();
            cmbVendor.SelectedIndex = -1;
            pnlFormychk.Visible = false;

        }

        private void BtnClear_Click(object sender, EventArgs e)
        {


            Clear();
        }
        //All Messsages Show  btnadd
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            ClearGlyph();
            if(cmbitemType.SelectedIndex==-1)
            { 
                errorProvider1.SetError(cmbitemType, "Select ItemType");
            }
            else
            {
                
                if (cmbitemType.SelectedIndex == 0)
                {
                    if (ValidationFarmy() == true && Validation2() == true)
                    {
                        PurchaseStock_ obj = new PurchaseStock_();
                        obj.VendorId = Convert.ToInt16(cmbVendor.SelectedValue);
                        obj.PurchaseDate = DateTime.Now.Date;
                        obj.Weight = txtWeight.Value;
                        obj.Rate = txtPrice.Value;
                        obj.IsNew = true;
                        int PurchaseId = BL_PurchaseStock.Save(obj);

                        Stock_ stock = new Stock_();
                        stock.Remaining = txtWeight.Value;
                        stock.Sold = 0;
                        stock.PurchaseId = PurchaseId;
                        stock.IsNew = true;
                        stock.Status = true;
                        BL_Stock.Save(stock);

                        for (int i = 0; i < flowLayoutPanel1.Controls.Count; i++)
                        {
                            RateList_ rateList_ = new RateList_();
                            rateList_.PurchaseId = PurchaseId;
                            rateList_.ItemId = Convert.ToInt16(item[i].Name);
                            rateList_.WholeSalePrice = item[i].txtWholeSale.Value;
                            rateList_.RetailPrice = item[i].txtRetail.Value;
                            rateList_.IsNew = true;
                            rateList_.R_Type = 0;
                            rateList_.R_Date = DateTime.Now.Date;
                            BL_RateList.Save(rateList_);
                        }
                        MessageBox.Show("Submit SuccessFully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }

                }
                else if (cmbitemType.SelectedIndex == 1)
                {
                    if (ValidationDesi() == true && Validation2() == true)
                    {
                        PurchaseDesi_ obj = new PurchaseDesi_();
                        obj.VendorId = Convert.ToInt16(cmbvendordes.SelectedValue);
                        obj.PurchaseDate = DateTime.Now.Date;
                        obj.Qty = Convert.ToInt16(txtQty.Value);
                        obj.Rate = txtQtyPrice.Value;
                        int PurchaseId = BL_PurchaseDesi.Save(obj);

                        DesiStock_ stock = new DesiStock_();
                        stock.Remaining = Convert.ToInt16(txtQty.Value);
                        stock.Sold = 0;
                        stock.PurchaseDesiId = PurchaseId;
                        stock.Status = true;
                        BL_DesiStock.Save(stock);

                        for (int i = 0; i < flowLayoutPanel1.Controls.Count; i++)
                        {
                            RateList_ rateList_ = new RateList_();
                            rateList_.PurchaseId = PurchaseId;
                            rateList_.ItemId = Convert.ToInt16(item[i].Name);
                            rateList_.WholeSalePrice = item[i].txtWholeSale.Value;
                            rateList_.RetailPrice = item[i].txtRetail.Value;
                            rateList_.IsNew = true;
                            rateList_.R_Type = 1;
                            rateList_.R_Date = DateTime.Now.Date;
                            BL_RateList.Save(rateList_);
                        }
                        MessageBox.Show("Submit SuccessFully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
                else if (cmbitemType.SelectedIndex == 2)
                {
                    if (ValidationEgg() == true && Validation2() == true)
                    {
                        PurchaseEgg_ obj = new PurchaseEgg_();
                        obj.VendorId = Convert.ToInt16(cmbvendoregg.SelectedValue);
                        obj.PurchaseDate = DateTime.Now.Date;
                        obj.Dozen = Convert.ToInt16(txtDozen.Value);
                        obj.Rate = txtPricePerdzn.Value;
                        int PurchaseId = BL_PurchaseEgg.Save(obj);

                        EggStock_ stock = new EggStock_();
                        stock.Remaining = Convert.ToInt16(txtDozen.Value * 12);
                        stock.Sold = 0;
                        stock.PurchaseEggId = PurchaseId;
                        stock.Status = true;
                        BL_EggStock.Save(stock);

                        for (int i = 0; i < flowLayoutPanel1.Controls.Count; i++)
                        {
                            RateList_ rateList_ = new RateList_();
                            rateList_.PurchaseId = PurchaseId;
                            rateList_.ItemId = Convert.ToInt16(item[i].Name);
                            rateList_.WholeSalePrice = item[i].txtWholeSale.Value;
                            rateList_.RetailPrice = item[i].txtRetail.Value;
                            rateList_.IsNew = true;
                            rateList_.R_Type = 2;
                            rateList_.R_Date = DateTime.Now.Date;
                            BL_RateList.Save(rateList_);
                        }
                        MessageBox.Show("Submit SuccessFully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
            }
          
          
        }

        private void CmbitemType_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            Clear();
            if (cmbitemType.SelectedIndex == 0)
            {
                pnlFormychk.Visible = true;

                LoadItem(cmbitemType.SelectedIndex);
            }
            else if (cmbitemType.SelectedIndex == 1)
            {
                pnlDesi.Visible = true;

                LoadItem(cmbitemType.SelectedIndex);
            }
            else if (cmbitemType.SelectedIndex == 2)
            {
                pnlEgg.Visible = true;
                LoadItem(cmbitemType.SelectedIndex);
            }

        }
    }
}
