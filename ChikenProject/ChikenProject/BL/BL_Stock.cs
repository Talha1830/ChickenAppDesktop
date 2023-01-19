using System;
using System.Data;
using System.Data.SqlClient;
using TheChicken.DL;

namespace TheChicken.BL
{
    internal class BL_Stock
    {
        public static bool Save(Stock_ ex)
        {
            SqlParameter[] Param = new SqlParameter[6];
            Param[0] = new SqlParameter("@StockId", ex.StockId);
            Param[1] = new SqlParameter("@PurchaseId", ex.PurchaseId);
            Param[2] = new SqlParameter("@Sold", ex.Sold);
            Param[3] = new SqlParameter("@Remaining", ex.Remaining);
            Param[4] = new SqlParameter("Type", ex.IsNew == true ? ActionType.Save : ActionType.Edit);
            Param[5] = new SqlParameter("Status", ex.Status);
            return DataLayer.ExecuteQuery("Sp_Stock", Param);
        }

        public static bool Delete(int StockId)
        {

            if (Helper.DeleteDecesion() == true)
            {
                SqlParameter[] Param = new SqlParameter[2];
                Param[0] = new SqlParameter("@StockId", StockId);
                Param[1] = new SqlParameter("@Type", ActionType.Delete);
                if (DataLayer.ExecuteQuery("Sp_Stock", Param) == true)
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

        public static Stock_ Get(int? StockId=null,bool? Status=null)
        {
            SqlParameter[] Param = new SqlParameter[3];
            Param[0] = new SqlParameter("@Type", ActionType.Select);
            Param[1] = new SqlParameter("@StockId", StockId);
            Param[2] = new SqlParameter("@Status", Status);
            DataTable dt = DataLayer.DataAdapter("Sp_Stock", Param);
            Stock_ obj = new Stock_();
            if (dt.Rows.Count > 0)
            {
                obj.PurchaseId = Convert.ToInt32(dt.Rows[0]["PurchaseId"]);
                obj.Sold = Convert.ToDecimal(dt.Rows[0]["Sold"]);
                obj.Remaining = Convert.ToDecimal(dt.Rows[0]["Remaining"]);
                obj.Status = Convert.ToBoolean(dt.Rows[0]["Status"]);


            }
            return obj;
        }
        public static DataTable Get_Home()
        {
            return DataLayer.DataAdapter("Sp_Stock", new SqlParameter("@Type",5));
        }
        public static DataTable Get()
        {
            return DataLayer.DataAdapter("Sp_Stock", new SqlParameter("@Type", ActionType.Select));
        }
        public static void Update(decimal Sold)
        {
            SqlParameter[] Param = new SqlParameter[2];
            Param[0] = new SqlParameter("@Sold", Sold);
            Param[1] = new SqlParameter("@Type", ActionType.Edit);
            DataLayer.ExecuteQuery("Sp_Stock", Param);
        }
    }
    class Stock_
    {
        public bool IsNew { get; set; }
        public int StockId { get; set; }
        public int PurchaseId { get; set; }
        public decimal Sold { get; set; }
        public bool Status { get; set; }
        public decimal Remaining { get; set; }

    }
}
