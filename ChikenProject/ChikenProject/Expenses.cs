using System.Windows.Forms;
using TheChicken.BL;

namespace ChikenProject
{
    public partial class Expenses : Form
    {
        public void LoadGridView()
        {
            grdExpenses.DataSource = BL_Expenses.Get();
            grdExpenses.Columns["ExpensesId"].IsVisible = false;
            grdExpenses.Columns["CashierId"].IsVisible = false;
        }
        public Expenses()
        {
            InitializeComponent();
            LoadGridView();
        }
    }
}
