using System;
using System.Windows.Forms;
using TheChicken.BL;

namespace ChikenProject
{
    public partial class VendorShow : Form
    {
        int VendorId = 0;
        public void LoadGridView()
        {
            grdVendor.DataSource = BL_Vendor.Get();
            grdVendor.Columns["VendorId"].IsVisible = false;
        }
        public VendorShow()
        {
            InitializeComponent();
            LoadGridView();
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            VendorInput obj = new VendorInput(0);
            obj.ShowDialog();
            LoadGridView();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (VendorId != 0)
            {
                VendorInput obj = new VendorInput(VendorId);
                obj.ShowDialog();
                VendorId = 0;
                LoadGridView();
            }
            else
                Helper.MessageSelectRow();

        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (VendorId != 0)
            {
                if (BL_Vendor.Delete(VendorId) == true)
                    LoadGridView();
                VendorId = 0;

            }
            else
                Helper.MessageSelectRow();
        }

        private void GrdVendor_CellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
                VendorId = Convert.ToInt16(grdVendor.Rows[e.RowIndex].Cells["VendorId"].Value);
        }
    }
}
