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
    public partial class CashierUpdate : MetroFramework.Forms.MetroForm
    {
        int ID = 0;
        public void LoadData(int CashierId)
        {
            Cashier_ obj = BL_Cashier.Get(CashierId);
            cmbitemType.SelectedIndex = obj.Status == true ? 1 : 0;
        }
        public CashierUpdate(int CashierId)
        {
            InitializeComponent();
            LoadData(CashierId);
            ID = CashierId;

        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            Cashier_ obj = BL_Cashier.Get(ID);
            obj.Status = cmbitemType.SelectedIndex == 1 ? true : false;
            obj.IsNew = false;
            BL_Cashier.Save(obj);
            this.Close();
        }
    }
}
