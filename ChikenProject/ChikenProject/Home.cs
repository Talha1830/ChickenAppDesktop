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
    public partial class Home : Form
    {
        DataTable dt;
        decimal PurchaseEgg = 0, PurchaseDesi = 0, PurchaseFarmy = 0, Expenses = 0, Purcase = 0, sale = 0;

        private void BtnAll_Click(object sender, EventArgs e)
        {
            LoadData(false);
        }

        private void BtnToday_Click(object sender, EventArgs e)
        {
            LoadData(true);
        }
        decimal Stockamount = 0;
        public void LoadData(bool flag)
        {
            dt = new DataTable();
            PurchaseEgg = 0;
            Stockamount = 0;
            PurchaseDesi = 0;
            PurchaseFarmy = 0;
            Expenses = 0;
            Purcase = 0;
            sale = 0;
            dt = BL_PurchaseStock.Get_Home(flag);
            if (dt.Rows.Count > 0)
                PurchaseFarmy = Convert.ToDecimal(dt.Rows[0]["Total"]);

            dt = BL_PurchaseDesi.Get_Home(flag);
            if (dt.Rows.Count > 0)
                PurchaseDesi = Convert.ToDecimal(dt.Rows[0]["Total"]);

            dt = BL_PurchaseEgg.Get_Home(flag);
            if (dt.Rows.Count > 0)
                PurchaseEgg = Convert.ToDecimal(dt.Rows[0]["Total"]);
            Purcase = PurchaseFarmy + PurchaseDesi + PurchaseEgg;
            lblVendorPurchase.Text = Convert.ToDecimal(PurchaseFarmy + PurchaseDesi + PurchaseEgg).ToString("#,##0.00");

            dt = BL_Invoice.Get_Home(flag);
            if (dt.Rows.Count > 0)
            {
                sale = Convert.ToDecimal(dt.Rows[0]["Total"]);
                lblSale.Text = Convert.ToDecimal(dt.Rows[0]["Total"]).ToString("#,##0.00");
            }
            dt = BL_EggStock.Get_Home();
            if (dt.Rows.Count > 0)
                Stockamount += Convert.ToDecimal(dt.Rows[0]["Total"]);
            dt = BL_DesiStock.Get_Home();
            if (dt.Rows.Count > 0)
                Stockamount += Convert.ToDecimal(dt.Rows[0]["Total"]);
            dt = BL_Stock.Get_Home();
            if (dt.Rows.Count > 0)
                Stockamount += Convert.ToDecimal(dt.Rows[0]["Total"]);

            lblStock.Text = Stockamount.ToString("#,##0.00");

            dt = BL_Expenses.Get_Home(flag);
            if (dt.Rows.Count > 0)
            {
                Expenses = Convert.ToDecimal(dt.Rows[0]["Total"]);
                lblExpenses.Text = Convert.ToDecimal(dt.Rows[0]["Total"]).ToString("#,##0.00");
            }

            if (((sale+Stockamount) - (Expenses + Purcase)) > 0)
                lblProfit.Text = ((sale+ Stockamount) - (Expenses + Purcase)).ToString("#,##0.00");
            else
                lblProfit.Text = "0.00";
            if (((sale + Stockamount)-(Expenses + Purcase) ) < 0)
                lblLoss.Text = ((Expenses + Purcase) - (sale+ Stockamount)).ToString("#,##0.00");
            else
                lblLoss.Text = "0.00";




        }
        public Home()
        {
            InitializeComponent();
            timer1.Enabled = true;
            LoadData(false);
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
