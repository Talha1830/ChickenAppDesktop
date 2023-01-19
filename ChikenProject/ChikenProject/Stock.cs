using ChikenProject.BL;
using System.Windows.Forms;
using TheChicken.BL;

namespace ChikenProject
{
    public partial class Stock : Form
    {
       
        public Stock()
        {
            InitializeComponent();
            cmbitemType.SelectedIndex = -1;
        }

        private void CmbitemType_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            grdStock.DataSource = null;
            if(cmbitemType.SelectedIndex==0)
            {
                grdStock.DataSource = BL_Stock.Get();
                grdStock.Columns["StockId"].IsVisible = false;
                grdStock.Columns["Status"].IsVisible = false;
                grdStock.Columns["PurchaseId"].IsVisible = false;
            }
            else if(cmbitemType.SelectedIndex==1)
            {
                grdStock.DataSource = BL_DesiStock.Get();
                grdStock.Columns["DesiStockId"].IsVisible = false;
                grdStock.Columns["Status"].IsVisible = false;
                grdStock.Columns["PurchaseDesiId"].IsVisible = false;
            }
            else if(cmbitemType.SelectedIndex==2)
            {
                grdStock.DataSource = BL_EggStock.Get();
                grdStock.Columns["EggStockId"].IsVisible = false;
                grdStock.Columns["Status"].IsVisible = false;
                grdStock.Columns["PurchaseEggId"].IsVisible = false;
            }
        }
    }
}
