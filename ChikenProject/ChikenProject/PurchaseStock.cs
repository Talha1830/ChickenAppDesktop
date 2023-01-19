using ChikenProject.BL;
using System;
using System.Windows.Forms;
using TheChicken.BL;

namespace ChikenProject
{
    public partial class PurchaseStock : Form
    {
        public void LoadFormyStock()
        {
            grdpurchaseStock.DataSource = BL_PurchaseStock.Get();
            grdpurchaseStock.Columns["PurchaseId"].IsVisible = false;
            grdpurchaseStock.Columns["VendorId"].IsVisible = false;
        }
        public void LoadDesiStock()
        {
            grdpurchaseStock.DataSource = BL_PurchaseDesi.Get();
            grdpurchaseStock.Columns["PurchaseDesiId"].IsVisible = false;
            grdpurchaseStock.Columns["VendorId"].IsVisible = false;
        }
        public void LoadEggStock()
        {
            grdpurchaseStock.DataSource = BL_PurchaseEgg.Get();
            grdpurchaseStock.Columns["PurchaseEggId"].IsVisible = false;
            grdpurchaseStock.Columns["VendorId"].IsVisible = false;
        }
        public PurchaseStock()
        {
            InitializeComponent();
            cmbitemType.SelectedIndex = -1;
        }
        private void BtnNew_Click(object sender, EventArgs e)
        {
            PurchaseStockInput obj = new PurchaseStockInput();
            obj.ShowDialog();
            if (cmbitemType.SelectedIndex == 0)
            {
                LoadFormyStock();
            }
            else if (cmbitemType.SelectedIndex == 1)
            {
                LoadDesiStock();
            }
            else if (cmbitemType.SelectedIndex == 2)
            {
                LoadEggStock();
            }
        }
        private void CmbitemType_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            grdpurchaseStock.DataSource = null;
            if(cmbitemType.SelectedIndex==0)
            {
                LoadFormyStock();
            }
           else if (cmbitemType.SelectedIndex == 1)
            {
                LoadDesiStock();
            }
           else if (cmbitemType.SelectedIndex == 2)
            {
                LoadEggStock();
            }
        }
    }
}
