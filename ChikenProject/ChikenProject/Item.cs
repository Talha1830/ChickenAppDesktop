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
    public partial class Item : UserControl
    {
        public Item()
        {
            InitializeComponent();
        }
        private string itemName;

        public string ItemName
        {
            get { return itemName; }
            set { itemName = value;lblItemName.Text = itemName; }
        }

    }
}
