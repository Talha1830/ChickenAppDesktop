using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheChicken.DL;

namespace TheChicken.BL
{
    internal class BL_Expenses
    {
        public static bool Save(Expenses_ ex)
        {
            SqlParameter[] Param = new SqlParameter[6];
            Param[0] = new SqlParameter("@ExpensesId", ex.ExpensesId);
            Param[1] = new SqlParameter("@CashierId", ex.CashierId);
            Param[2] = new SqlParameter("@Description", ex.Description);
            Param[3] = new SqlParameter("@Amount", ex.Amount);
            Param[4] = new SqlParameter("@E_date", ex.E_date);
            Param[5] = new SqlParameter("@Type", ex.IsNew == true ? ActionType.Save : ActionType.Edit);
            if (DataLayer.ExecuteQuery("Sp_Expenses", Param) == true)
            {
                if (ex.IsNew == false)
                {
                    Helper.MessageEdit();
                }
                else
                {
                    Helper.MessageSave();
                }

                return true;
            }
            return false;
        }

        public static bool Delete(int ExpensesId)
        {

            if (Helper.DeleteDecesion() == true)
            {
                SqlParameter[] Param = new SqlParameter[2];
                Param[0] = new SqlParameter("@ExpensesId", ExpensesId);
                Param[1] = new SqlParameter("@Type", ActionType.Delete);
                if (DataLayer.ExecuteQuery("Sp_Expenses", Param) == true)
                {
                    Helper.MessageDelete();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public static Expenses_ Get(int ExpensesId)
        {
            SqlParameter[] Param = new SqlParameter[2];
            Param[0] = new SqlParameter("@Type", ActionType.Select);
            Param[1] = new SqlParameter("@ExpensesId", ExpensesId);
            DataTable dt = DataLayer.DataAdapter("Sp_Expenses", Param);
            Expenses_ obj = new Expenses_();
            if (dt.Rows.Count > 0)
            {
                obj.CashierId = Convert.ToInt32(dt.Rows[0]["CashierId"]);
                obj.Description = Convert.ToString(dt.Rows[0]["Description"]);
                obj.Amount = Convert.ToDecimal(dt.Rows[0]["Amount"]);
                obj.E_date = Convert.ToDateTime(dt.Rows[0]["E_date"]);
            }
            return obj;
        }
        public static DataTable Get_Home(bool flag, int? Type = null)
        {
            SqlParameter[] Param;
            if (flag == true)
            {
                Param = new SqlParameter[2];
                Param[0] = new SqlParameter("@Type", 5);
                Param[1] = new SqlParameter("@E_Date", DateTime.Now.Date);
            }
            else
            {
                Param = new SqlParameter[1];
                Param[0] = new SqlParameter("@Type", 5);
            }
            return DataLayer.DataAdapter("Sp_Expenses", Param);
        }
        public static DataTable Get()
        {
            
            return DataLayer.DataAdapter("Sp_Expenses", new SqlParameter("@Type", ActionType.Select));
        }
    }
    class Expenses_
    {
        public bool IsNew { get; set; }
        public int ExpensesId { get; set; }
        public int CashierId { get; set; }
        public string Description { get; set; }
        public Decimal Amount { get; set; }
        public DateTime E_date { get; set; }

    }
}
