using System;
using System.Windows.Forms;
using TheChicken.BL;

namespace ChikenProject
{
    public partial class RateList : Form
    {
        public void LoadGridView(bool flag)
        {
            grdRateList.DataSource = null;
            if (flag == true)
            {
                RateList_ rateList_ = new RateList_();
                rateList_.R_Date = DateTime.Now.Date;
                grdRateList.DataSource = BL_RateList.Get(rateList_);
            }
            else
                grdRateList.DataSource = BL_RateList.Get();
            grdRateList.Columns["RateListId"].IsVisible = false;
            grdRateList.Columns["PurchaseId"].IsVisible = false;
            grdRateList.Columns["R_Type"].IsVisible = false;
            grdRateList.Columns["ItemId"].IsVisible = false;

        }
        public RateList()
        {
            InitializeComponent();
            LoadGridView(true);
            cmbitemType.SelectedIndex = 0;
        }
        int RateLsitId = 0;
        private void CmbitemType_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            if (cmbitemType.SelectedIndex == 0)
                LoadGridView(true);
            else if (cmbitemType.SelectedIndex == 1)
                LoadGridView(false);
        }

        private void GrdRateList_CellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
                RateLsitId = Convert.ToInt32(grdRateList.Rows[e.RowIndex].Cells["RateListId"].Value);
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (RateLsitId != 0)
            {
                ItemRateUpdate obj = new ItemRateUpdate(RateLsitId);
                obj.ShowDialog();
                if (cmbitemType.SelectedIndex == 0)
                    LoadGridView(true);
                else
                    LoadGridView(false);
                RateLsitId = 0;
            }
            else
                Helper.MessageSelectRow();

        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (RateLsitId != 0)
            {
                BL_RateList.Delete(RateLsitId);
                if (cmbitemType.SelectedIndex == 0)
                    LoadGridView(true);
                else
                    LoadGridView(false);
                RateLsitId = 0;
            }
            else
                Helper.MessageSelectRow();

        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            RateListInput rateListInput = new RateListInput();
            rateListInput.ShowDialog();
            LoadGridView(true);
        }
    }
}
