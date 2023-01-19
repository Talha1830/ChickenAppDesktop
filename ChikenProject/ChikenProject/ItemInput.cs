using System;
using TheChicken.BL;

namespace ChikenProject
{
    public partial class ItemInput : MetroFramework.Forms.MetroForm
    {
        int ItemId = 0;
        public ItemInput(int id)
        {
            InitializeComponent();
            cmbitemType.SelectedIndex = -1;
            if (id != 0)
            {
                LoadData(id);
                ItemId = id;
            }
          
        }
        public void LoadData(int Id)
        {
            Item_ obj = BL_Item.Get(Id);
            txtName.Text = obj.ItemName;
            cmbitemType.SelectedIndex = obj.ItemType;
            btnAdd.Text = "Update";
            this.Text = "Update Item";
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (cmbitemType.SelectedIndex==-1)
                errorProvider1.SetError(cmbitemType, "Please Select Item Type");
           else if (string.IsNullOrEmpty(txtName.Text) == true)
                errorProvider1.SetError(txtName, "Please Enter Name");
            else
            {
                errorProvider1.SetError(txtName, null);
                Item_ obj = new Item_();
                obj.ItemName = txtName.Text;
                obj.ItemType = cmbitemType.SelectedIndex;
                obj.IsNew = true;
                if (ItemId != 0)
                {
                    obj.IsNew = false;
                    obj.itemId = ItemId;
                }
                BL_Item.Save(obj);
                this.Close();
                txtName.Text = string.Empty;
                ItemId = 0;
            }


        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            txtName.Text = string.Empty;
        }
    }
}
