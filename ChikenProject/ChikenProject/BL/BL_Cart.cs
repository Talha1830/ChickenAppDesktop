using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheChicken.BL;
using TheChicken.DL;

namespace ChikenProject.BL
{
    class BL_Cart
    {
        public static bool Save(Cart_ ex)
        {
            SqlParameter[] Param = new SqlParameter[8];
            Param[0] = new SqlParameter("@CartId", ex.CartId);
            Param[1] = new SqlParameter("@ItemId", ex.ItemId);
            Param[2] = new SqlParameter("@Weight", ex.Weight);
            Param[3] = new SqlParameter("@Amount", ex.Amount);
            Param[4] = new SqlParameter("@Rate", ex.Rate);
            Param[5] = new SqlParameter("@Status", ex.Status);
            Param[6] = new SqlParameter("@ItemType", ex.itemtype);
            Param[7] = new SqlParameter("@Type", ex.IsNew == true ? ActionType.Save : ActionType.Edit);
            DataLayer.ExecuteQuery("Sp_Cart", Param);
            return true;
        }

        public static bool Delete(int? CartId = null)
        {
            SqlParameter[] Param = new SqlParameter[2];
            Param[0] = new SqlParameter("@CartId", CartId);
            Param[1] = new SqlParameter("@Type", ActionType.Delete);
            DataLayer.ExecuteQuery("Sp_Cart", Param);
            return true;
        }

        public static Cart_ Get(int? CartId)
        {
            SqlParameter[] Param = new SqlParameter[2];
            Param[0] = new SqlParameter("@Type", ActionType.Select);
            Param[1] = new SqlParameter("@CartId", CartId);
            DataTable dt = DataLayer.DataAdapter("Sp_Cart", Param);
            Cart_ obj = new Cart_();
            if (dt.Rows.Count > 0)
            {
                obj.CartId = Convert.ToInt16(dt.Rows[0]["CartId"]);
                obj.ItemId = Convert.ToInt16(dt.Rows[0]["ItemId"]);
                obj.Weight = Convert.ToDecimal(dt.Rows[0]["Weight"]);
                obj.Amount = Convert.ToDecimal(dt.Rows[0]["Amount"]);
                obj.Rate = Convert.ToDecimal(dt.Rows[0]["Rate"]);
            }
            return obj;
        }

        public static DataTable Get()
        {
            return DataLayer.DataAdapter("Sp_Cart", new SqlParameter("@Type", ActionType.Select));
        }
        public static DataTable GetSum()
        {
            return DataLayer.DataAdapter("Sp_Cart", new SqlParameter("@Type", 5));
        }
    }
    public class Cart_

    {
        public int CartId { get; set; }
        public int ItemId { get; set; }
        public decimal Weight { get; set; }
        public decimal Rate { get; set; }
        public decimal Amount { get; set; }
        public bool Status { get; set; }
        public int itemtype { get; set; }
        public bool IsNew { get; set; }
    }
}
