using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChikenProject
{
    public partial class RateListItem : UserControl
    {
        public RateListItem()
        {
            InitializeComponent();
        }
        private string itemname;

        public string ItemName 
        {
            get { return itemname; }
            set { itemname = value;lblItemName.Text = itemname; }
        }
        private decimal price;

        public decimal Price
        {
            get { return price; }
            set { price = value;lblPrice.Text = Convert.ToString(price); }
        }


    }
}
