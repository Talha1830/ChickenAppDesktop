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
    public partial class Invoice : Form
    {
        public void LoadGridview()
        {
            grdincoices.DataSource = BL_Invoice.Get();
            grdincoices.Columns["Status"].IsVisible = false;
        }
        public Invoice()
        {
            InitializeComponent();
            LoadGridview();
        }
    }
}
