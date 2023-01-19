using ChikenProject.BL;
using ChikenProject.Properties;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Net;
using TheChicken;
using TheChicken.BL;

namespace ChikenProject
{
    public partial class DailyInvoice : MetroFramework.Forms.MetroForm
    {
        public static bool CheckForInternetConnection()
        {
            try
            {
                using (var client = new WebClient())
                using (client.OpenRead("http://google.com/generate_204"))
                    return true;
            }
            catch
            {
                return false;
            }
        }
        public void LoadGridView()
        {
            grdItem.DataSource = BL_Cart.Get();
            grdItem.Columns["CartId"].IsVisible = false;
            grdItem.Columns["ItemId"].IsVisible = false;
            grdItem.Columns["Status"].IsVisible = false;
            grdItem.Columns["ItemType"].IsVisible = false;

        }
        public bool CheckStock(decimal weight, int flag)
        {
            if (flag == 0)
            {
                if (BL_Stock.Get(Status: true).Remaining >= weight)
                    return true;
                return false;
            }
            else if (flag == 1)
            {
                if (BL_DesiStock.Get(Status: true).Remaining >= weight)
                    return true;
                return false;
            }
            else if (flag == 2)
            {
                if (BL_EggStock.Get(Status: true).Remaining >= weight)
                    return true;
                return false;
            }
            else
                return false;
        }
        public void Clear()
        {
            BL_Cart.Delete();
            LoadGridView();
            cmbInvoiceType.SelectedIndex = 0;
            txtCustomerName.Text = string.Empty;
            txtDiscount.Text = "";
            txtPrice.Value = 0;
            cmbItem.SelectedIndex = -1;
            Sum();
            Weight = 0;
            EggStock = 0;
            DesiStock = 0;
            lblTotalweight.Text = "0";
            lblTotalQty.Text = "0";
            lblTotalAmount.Text = "0";
            lbldiscount.Text = "0";
            lblNetToal.Text = "0";
        }
        public void Sum()
        {
            DataTable dt = BL_Cart.GetSum();
            if (dt.Rows.Count > 0)
            {
                lblTotalAmount.Text = Convert.ToString(dt.Rows[0]["Amount"]);
                lblTotalweight.Text = Convert.ToString(dt.Rows[0]["Weight"]);
                lblTotalQty.Text = Convert.ToString(dt.Rows[0]["Qty"]);
                lbldiscount.Text = txtDiscount.Text;
                if (string.IsNullOrEmpty(lblTotalAmount.Text) == true)
                    lblTotalAmount.Text = "0";
                if (string.IsNullOrEmpty(lbldiscount.Text) == true)
                    lbldiscount.Text = "0";
               lblNetToal.Text = Convert.ToString(Convert.ToDecimal(lblTotalAmount.Text) - Convert.ToInt16(lbldiscount.Text));
            }

        }
        int CashierId = 0;
        decimal Weight = 0, DesiStock = 0, EggStock = 0;
        public void LoadStock()
        {

            itemfarmy.ItemName = "Farmy Chiken";
            itemfarmy.Price = BL_Stock.Get(Status: true).Remaining;

            itemdesi.ItemName = "Desi Chiken";
            itemdesi.Price = BL_DesiStock.Get(Status: true).Remaining;

            itemegg.ItemName = "Eggs";
            itemegg.Price = Convert.ToDecimal(BL_EggStock.Get(Status: true).Remaining);
        }
        public void LoadItem()
        {
            cmbItem.DataSource = BL_Item.Get();
            cmbItem.DisplayMember = "ItemName";
            cmbItem.ValueMember = "ItemId";
        }
        public void LoadRateList(bool flag)
        {
            flowLayoutPanel1.Controls.Clear();
            RateList_ rateList_ = new RateList_();
            rateList_.R_Date = DateTime.Now.Date;
            DataTable data = BL_RateList.Get(rateList_);
            if (data != null)
            {
                RateListItem[] rateListItems = new RateListItem[data.Rows.Count];
                for (int i = 0; i < data.Rows.Count; i++)
                {
                    rateListItems[i] = new RateListItem();
                    rateListItems[i].ItemName = Convert.ToString(data.Rows[i]["Item Name"]);
                    if (flag == true)
                        rateListItems[i].Price = Convert.ToDecimal(data.Rows[i]["RetailPrice"]);
                    else
                        rateListItems[i].Price = Convert.ToDecimal(data.Rows[i]["WholeSalePrice"]);
                    flowLayoutPanel1.Controls.Add(rateListItems[i]);
                }
            }

        }
        public DailyInvoice(int Cashierid)
        {
            InitializeComponent();
            lblDate.Text = DateTime.Now.ToShortDateString();
            timer1.Enabled = true;
            LoadRateList(true);
            cmbInvoiceType.SelectedIndex = 0;
            LoadItem();
            cmbItem.SelectedIndex = -1;
            LoadGridView();
            LoadStock();
            CashierId = Cashierid;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToLongTimeString();
        }

        private void CmbInvoiceType_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            if (cmbInvoiceType.SelectedIndex == 0)
                LoadRateList(true);
            else
                LoadRateList(false);
        }
        private void BtnAddItem_Click(object sender, EventArgs e)
        {
            if (cmbItemType.SelectedIndex == -1)
            {
                errorProvider1.SetError(cmbItemType, "Select ItemType");
            }
            else if (cmbItem.SelectedIndex == -1)
            {
                errorProvider1.SetError(cmbItem, "Select Item");
            }
            else if (txtPrice.Value <= 0)
            {
                errorProvider1.SetError(txtPrice, "Enter Amount");
            }
            else
            {
                errorProvider1.SetError(cmbItemType, null);
                errorProvider1.SetError(cmbItem, null);
                errorProvider1.SetError(txtPrice, null);
                bool flag = false;
                Cart_ obj = new Cart_();
                obj.ItemId = Convert.ToInt16(cmbItem.SelectedValue);
                RateList_ rateList_ = new RateList_();
                rateList_.R_Date = DateTime.Now.Date;
                rateList_.ItemId = obj.ItemId;
                DataTable dt = BL_RateList.Get(rateList_);
                if (dt.Rows.Count > 0)
                {
                    if (cmbInvoiceType.SelectedIndex == 0)
                        obj.Rate = Convert.ToDecimal(dt.Rows[0]["RetailPrice"]);
                    else
                        obj.Rate = Convert.ToDecimal(dt.Rows[0]["WholeSalePrice"]);
                    if (cmbItemType.SelectedIndex == 0)
                    {
                        obj.Weight = Math.Round(((txtPrice.Value) / ((obj.Rate / 1000)) / 1000), 2);
                        obj.Amount = txtPrice.Value;
                        obj.Status = false;
                        Weight += obj.Weight;
                        flag = CheckStock(Weight, 0);
                    }
                    else
                    {
                        obj.Weight = txtPrice.Value;//For Qty
                        if (cmbItemType.SelectedIndex == 1)
                        {
                            DesiStock += txtPrice.Value;
                            flag = CheckStock(DesiStock, 1);
                            obj.Amount = obj.Weight * obj.Rate;
                        }

                        if (cmbItemType.SelectedIndex == 2)
                        {
                            EggStock += txtPrice.Value;
                            flag = CheckStock(EggStock, 2);
                            obj.Amount = obj.Weight * (obj.Rate / 12);  //For Price Qty*Rate
                        }
                        obj.Status = true;
                    }
                    if (flag == true)
                    {
                        obj.IsNew = true;
                        obj.itemtype = cmbItemType.SelectedIndex;
                        BL_Cart.Save(obj);
                        LoadGridView();
                        Sum();

                    }
                    else
                    {
                        Helper.MessageCustomError("Out of Stock");
                        if (cmbItemType.SelectedIndex == 0)
                            Weight -= obj.Weight;
                        else if (cmbItemType.SelectedIndex == 1)
                            DesiStock -= txtPrice.Value;
                        else if (cmbItemType.SelectedIndex == 2)
                            EggStock -= txtPrice.Value;
                    }
                    flag = false;
                    cmbItem.SelectedIndex = -1;
                    txtPrice.Value = 0;
                }
                else
                    Helper.MessageShowCustome("Today RateList not available!!!");
            }
        }
        int ItemType = 0;
        private void GrdItem_CellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                if (e.ColumnIndex == 0)
                {
                    ItemType = Convert.ToInt16(grdItem.Rows[e.RowIndex].Cells["ItemType"].Value);
                    if (ItemType == 0)
                        Weight -= Convert.ToDecimal(grdItem.Rows[e.RowIndex].Cells["Weight/Qty"].Value);
                   else if (ItemType == 1)
                        DesiStock -= Convert.ToDecimal(grdItem.Rows[e.RowIndex].Cells["Weight/Qty"].Value);

                    else if (ItemType == 2)
                        EggStock -= Convert.ToDecimal(grdItem.Rows[e.RowIndex].Cells["Weight/Qty"].Value);
                    BL_Cart.Delete(Convert.ToInt16(grdItem.Rows[e.RowIndex].Cells["CartId"].Value));
                    LoadGridView();
                    Sum();
                }
            }
        }

        private void BtnNewExpenes_Click(object sender, EventArgs e)
        {
            ExpensesInput obj = new ExpensesInput(CashierId);
            obj.ShowDialog();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void BtnAdmin_Click(object sender, EventArgs e)
        {
            AdminLogin obj = new AdminLogin();
            obj.Show();

        }
        DataTable dt;
        private void PrintDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
           
            int diff = 250;
            Image img = Resources.THE_CHICKEN1;
            Bitmap bitmap = new Bitmap(img, new Size(230, 120));
            //-------------------Header---------------------------
            e.Graphics.DrawImage(bitmap, new Point(15, 20));
            e.Graphics.DrawString("Customer Bill", new Font("Segoe UI", 10, FontStyle.Bold), Brushes.Black, new Point(90, 170));
            e.Graphics.DrawString("Invoice# : " + invoiceID, new Font("Segoe UI", 8, FontStyle.Regular), Brushes.Black, new Point(15, 200));
            e.Graphics.DrawString("Print Date : " + DateTime.Now.ToShortDateString(), new Font("Segoe UI", 8, FontStyle.Regular), Brushes.Black, new Point(150, 200));
            //-------------------------------------------------
            //---------------------------Body------------------------
            e.Graphics.DrawLine(new Pen(Color.Black, 1), new Point(10, 240), new Point(270, 240));
            e.Graphics.DrawString("Description", new Font("Segoe UI", 8, FontStyle.Bold), Brushes.Black, new Point(20, 243));
            e.Graphics.DrawString("Kg/Qty", new Font("Segoe UI", 8, FontStyle.Bold), Brushes.Black, new Point(150, 243));
            e.Graphics.DrawString("Rate", new Font("Segoe UI", 8, FontStyle.Bold), Brushes.Black, new Point(200, 243));
            e.Graphics.DrawString("Amount", new Font("Segoe UI", 8, FontStyle.Bold), Brushes.Black, new Point(230, 243));
            e.Graphics.DrawLine(new Pen(Color.Black, 1), new Point(10, 260), new Point(270, 260));
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                diff += 20;
                e.Graphics.DrawString(Convert.ToString(dt.Rows[i]["ItemName"]), new Font("Segoe UI", 8, FontStyle.Regular), Brushes.Black, new Point(15, diff));
                e.Graphics.DrawString(Convert.ToString(dt.Rows[i]["Weight/Qty"]), new Font("Segoe UI", 8, FontStyle.Regular), Brushes.Black, new Point(153, diff));
                e.Graphics.DrawString(Convert.ToDecimal(dt.Rows[i]["Rate"]).ToString("#,##0"), new Font("Segoe UI", 8, FontStyle.Regular), Brushes.Black, new Point(200, diff));
                e.Graphics.DrawString(Convert.ToDecimal(dt.Rows[i]["Amount"]).ToString("#,##0"), new Font("Segoe UI", 8, FontStyle.Regular), Brushes.Black, new Point(235, diff));

            }

            //difference 20
            e.Graphics.DrawLine(new Pen(Color.Black, 1), new Point(10, diff + 30), new Point(270, diff + 30));
            //----------------------------------------------------------------
            //-----------------------------Footer--------------------------------
            e.Graphics.DrawString(" Total Weight (Kg): ", new Font("Segoe UI", 8, FontStyle.Regular), Brushes.Black, new Point(120, diff + 40));
            e.Graphics.DrawString(lblTotalweight.Text, new Font("Segoe UI", 8, FontStyle.Regular), Brushes.Black, new Point(220, diff + 40));
            e.Graphics.DrawString("             Total Qty : ", new Font("Segoe UI", 8, FontStyle.Regular), Brushes.Black, new Point(120, diff + 60));
            e.Graphics.DrawString(lblTotalQty.Text, new Font("Segoe UI", 8, FontStyle.Regular), Brushes.Black, new Point(220, diff + 60));
            e.Graphics.DrawString("Total Amount (Rs): ", new Font("Segoe UI", 8, FontStyle.Regular), Brushes.Black, new Point(120, diff + 80));
            e.Graphics.DrawString(Convert.ToDecimal(lblTotalAmount.Text).ToString("#,##0"), new Font("Segoe UI", 8, FontStyle.Regular), Brushes.Black, new Point(220, diff + 80));
            e.Graphics.DrawString("      Discount (Rs): ", new Font("Segoe UI", 8, FontStyle.Regular), Brushes.Black, new Point(120, diff + 100));
            e.Graphics.DrawString(lbldiscount.Text, new Font("Segoe UI", 8, FontStyle.Regular), Brushes.Black, new Point(220, diff + 100));
            e.Graphics.DrawString("  Net Amount (Rs): ", new Font("Segoe UI", 8, FontStyle.Regular), Brushes.Black, new Point(120, diff + 120));
            e.Graphics.DrawString(Convert.ToDecimal(lblNetToal.Text).ToString("#,##0"), new Font("Segoe UI", 8, FontStyle.Regular), Brushes.Black, new Point(220, diff + 120));
            e.Graphics.DrawString("Al-Madinah Market(Main Branch) \n  Madinah Colony D.I.Khan", new Font("Segoe UI", 8, FontStyle.Regular), Brushes.Black, new Point(60, diff + 160));
            e.Graphics.DrawString("Contact : 0343-3078138", new Font("Segoe UI", 8, FontStyle.Bold), Brushes.Black, new Point(80, diff + 200));
        }


        private void RadDropDownList1_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            if (cmbItemType.SelectedIndex == 0)
            {
                cmbItem.DataSource = BL_Item.Get(ItemType: 0);
                lblRandom.Text = "Price (Rs)";
            }
            else if (cmbItemType.SelectedIndex == 1)
            {
                cmbItem.DataSource = BL_Item.Get(ItemType: 1);
                lblRandom.Text = "Qty";
            }
            else if (cmbItemType.SelectedIndex == 2)
            {
                cmbItem.DataSource = BL_Item.Get(ItemType: 2);
                lblRandom.Text = "Qty";
            }
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            LoadStock();
            LoadRateList(true);
        }


        private void TxtDiscount_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar >= 47 && e.KeyChar <= 57 || e.KeyChar == 8)
            {

            }
            else
                e.Handled = true;
        }

        private void TxtDiscount_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDiscount.Text) == false)
                lbldiscount.Text = txtDiscount.Text;
            else
                lbldiscount.Text = "0";
            Sum();
        }

        private void BtnBackup_Click(object sender, EventArgs e)
        {
            if(CheckForInternetConnection()==true)
            {
                
                if(EmailSender.SendMail("mtalhajoya@gmail.com", "Backup","The chiken app Backup")==true)
                {
                    File.Delete("c:\\Chiken.bak");
                    Helper.MessageShowCustome("Email send successfully");
                }
                
            }
            else
                Helper.MessageShowCustome("No internet connection");
        }

        int invoiceID = 0;
        private void RadButton2_Click(object sender, EventArgs e)
        {
            if (grdItem.Rows.Count > 0)
            {
                dt = BL_Cart.Get();
                printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("pprm", 285, 480 + (dt.Rows.Count * 20));

                BL_Stock.Update(Weight);
                BL_DesiStock.Update(DesiStock);
                BL_EggStock.Update(EggStock);

                Invoice_ invoice_ = new Invoice_();
                invoice_.CustomerName = txtCustomerName.Text;
                invoice_.Total = Convert.ToDecimal(lblTotalAmount.Text);
                invoice_.Discount = Convert.ToDecimal(lbldiscount.Text);
                invoice_.NetTotal = Convert.ToDecimal(lblNetToal.Text);
                invoice_.I_date = DateTime.Now.Date;
                invoice_.Status = true;
                invoice_.IsNew = true;
                invoiceID = BL_Invoice.Save(invoice_);

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    InvoiceItem_ invoiceItem_ = new InvoiceItem_();
                    invoiceItem_.InvoiceId = invoiceID;
                    invoiceItem_.itemId = Convert.ToInt16(dt.Rows[0]["ItemId"]);
                    invoiceItem_.Weight = Convert.ToDecimal(dt.Rows[0]["Weight/Qty"]);
                    invoiceItem_.Price = Convert.ToDecimal(dt.Rows[0]["Rate"]);
                    invoiceItem_.IsNew = true;
                    BL_InvoiceItem.Save(invoiceItem_);
                }
              printDocument1.Print();
                LoadStock();
                Clear();
            }
            else
                Helper.MessageCustomError("No items to print");

        }
    }
}
