using System;
using TheChicken.BL;

namespace ChikenProject
{
    public partial class VendorInput : MetroFramework.Forms.MetroForm
    {
        int VendorId = 0;
        public void Clear()
        {
            txtAddress.Text = string.Empty;
            txtName.Text = string.Empty;
            VendorId = 0;
        }
        public void clearGlyph()
        {
            errorProvider1.SetError(txtName, null);
            errorProvider1.SetError(txtAddress, null);
        }
        public bool validation()
        {

            if (string.IsNullOrEmpty(txtName.Text) == true)
            {
                errorProvider1.SetError(txtName, "Please Enter Name");
                return false;
            }
            if (string.IsNullOrEmpty(txtAddress.Text) == true)
            {
                errorProvider1.SetError(txtAddress, "Please Enter Address");
                return false;
            }
            else
            {
                return true;
            }
        }
        public VendorInput(int id)
        {
            InitializeComponent();
            if (id != 0)
            {
                LoadData(id);
                VendorId = id;
            }

        }
        public void LoadData(int Id)
        {
            Vendor_ obj = BL_Vendor.Get(Id);
            txtName.Text = obj.Name;
            txtAddress.Text = obj.Address;
            btnAdd.Text = "Update";
            this.Text = "Update Vendor";
        }
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            clearGlyph();
            if (validation() == true)
            {
                Vendor_ obj = new Vendor_();
                obj.Name = txtName.Text;
                obj.Address = txtAddress.Text;
                obj.IsNew = true;
                if (VendorId != 0)
                {
                    obj.IsNew = false;
                    obj.VendorId = VendorId;
                }
                BL_Vendor.Save(obj);
                Clear();
                this.Close();
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
