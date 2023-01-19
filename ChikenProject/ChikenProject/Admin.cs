using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChikenProject
{
    public partial class Admin : MetroFramework.Forms.MetroForm
    {
        Form currentform;

        public void LoadForms(Form frm)
        {
            if (currentform != null)
                currentform.Close();
            currentform = frm;
            currentform.TopLevel = false;
            currentform.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(currentform);
            currentform.Show();
        }

        public Admin()
        {
            InitializeComponent();
            LoadForms(new Home());
        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            pnlMov.Top = btnHome.Top;
            pnlMov.Height = btnHome.Height;
            LoadForms(new Home());
        }

        private void BtnVendor_Click(object sender, EventArgs e)
        {
            pnlMov.Top = btnVendor.Top;
            pnlMov.Height = btnVendor.Height;
            LoadForms(new VendorShow());
        }

        private void BtnPurhaseStock_Click(object sender, EventArgs e)
        {
            pnlMov.Top = btnPurhaseStock.Top;
            pnlMov.Height = btnPurhaseStock.Height;
            LoadForms(new PurchaseStock());
        }

        private void Btnitems_Click(object sender, EventArgs e)
        {
            pnlMov.Top = btnitems.Top;
            pnlMov.Height = btnitems.Height;
            LoadForms(new ItemShow());
        }

        private void BtnRateLit_Click(object sender, EventArgs e)
        {
            pnlMov.Top = btnRateLit.Top;
            pnlMov.Height = btnRateLit.Height;
            LoadForms(new RateList());
        }

        private void BtnStock_Click(object sender, EventArgs e)
        {
            pnlMov.Top = btnStock.Top;
            pnlMov.Height = btnStock.Height;
            LoadForms(new Stock());
        }

        private void BtnInovoices_Click(object sender, EventArgs e)
        {
            pnlMov.Top = btnInovoices.Top;
            pnlMov.Height = btnInovoices.Height;
            LoadForms(new Invoice());
        }

        private void BtnExpenses_Click(object sender, EventArgs e)
        {
            pnlMov.Top = btnExpenses.Top;
            pnlMov.Height = btnExpenses.Height;
            LoadForms(new Expenses());
        }

        private void BtnCashier_Click(object sender, EventArgs e)
        {
            pnlMov.Top = btnCashier.Top;
            pnlMov.Height = btnCashier.Height;
            LoadForms(new Cashier());
        }

    }
}
