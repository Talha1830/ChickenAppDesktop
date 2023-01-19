using System;
using System.Windows.Forms;
using TheChicken.BL;

namespace ChikenProject
{
    public partial class Cashier : Form
    {
        public void LoadGridView()
        {
            grdCashier.DataSource = BL_Cashier.Get();
            grdCashier.Columns["CashierId"].IsVisible = false;
            grdCashier.Columns["Status"].IsVisible = false;
            grdCashier.Columns["Password"].IsVisible = false;
        }
        public Cashier()
        {
            InitializeComponent();
            LoadGridView();
        }
        int CashierId = 0;
        private void BtnEdit_Click(object sender, System.EventArgs e)
        {
            if (CashierId != 0)
            {
                CashierUpdate obj = new CashierUpdate(CashierId);
                obj.ShowDialog();
                LoadGridView();
                CashierId = 0;
            }
            else
                Helper.MessageSelectRow();

        }

        private void GrdCashier_CellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
                CashierId = Convert.ToInt16(grdCashier.Rows[e.RowIndex].Cells["CashierId"].Value);
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (CashierId != 0)
            {
                BL_Cashier.Delete(CashierId);
                LoadGridView();
                CashierId = 0;
            }
            else
                Helper.MessageSelectRow();
        }
    }
}
