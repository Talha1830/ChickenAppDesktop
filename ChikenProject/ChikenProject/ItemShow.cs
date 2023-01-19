using System;
using System.Windows.Forms;
using TheChicken.BL;

namespace ChikenProject
{
    public partial class ItemShow : Form
    {
        int ItemId = 0;
        public ItemShow()
        {
            InitializeComponent();
            LoadGridView();
        }
        public void LoadGridView()
        {
            grditem.DataSource = BL_Item.Get();
            grditem.Columns["ItemId"].IsVisible = false;
            grditem.Columns["ItemType"].IsVisible = false;
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            ItemInput obj = new ItemInput(0);
            obj.ShowDialog();
            LoadGridView();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (ItemId != 0)
            {
                ItemInput obj = new ItemInput(ItemId);
                obj.ShowDialog();
                ItemId  = 0;
                LoadGridView();
            }
            else
                Helper.MessageSelectRow();
           
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (ItemId != 0)
            {
                if (BL_Item.Delete(ItemId) == true)
                    LoadGridView();
                ItemId = 0;

            }
            else
                Helper.MessageSelectRow();
        }

        private void Grditem_CellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
                ItemId = Convert.ToInt16(grditem.Rows[e.RowIndex].Cells["ItemId"].Value);
        }
    }
}
