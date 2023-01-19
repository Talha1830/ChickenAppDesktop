using System;
using System.Data;
using System.Data.SqlClient;
using TheChicken.BL;
using TheChicken.DL;

namespace ChikenProject.BL
{
    class BL_EggStock
    {
        public static void Save(EggStock_ ex)
        {
            SqlParameter[] Param = new SqlParameter[6];
            Param[0] = new SqlParameter("@EggStockId", ex.EggStockId);
            Param[1] = new SqlParameter("@PurchaseEggId", ex.PurchaseEggId);
            Param[2] = new SqlParameter("@Sold", ex.Sold);
            Param[3] = new SqlParameter("@Remaining", ex.Remaining);
            Param[4] = new SqlParameter("@Status", ex.Status);
            Param[5] = new SqlParameter("@Type", ActionType.Save);
            DataLayer.ExecuteQuery("Sp_EggStock", Param);
        }
        public static EggStock_ Get(int? EggStockId=null,bool? Status=null)
        {
            SqlParameter[] Param = new SqlParameter[3];
            Param[0] = new SqlParameter("@Type", ActionType.Select);
            Param[1] = new SqlParameter("@EggStockId", EggStockId);
            Param[2] = new SqlParameter("@Status", Status);
            DataTable dt = DataLayer.DataAdapter("Sp_EggStock", Param);
            EggStock_ obj = new EggStock_();
            if (dt.Rows.Count > 0)
            {
                obj.EggStockId = Convert.ToInt16(dt.Rows[0]["EggStockId"]);
                obj.PurchaseEggId = Convert.ToInt16(dt.Rows[0]["PurchaseEggId"]);
                obj.Sold = Convert.ToInt16(dt.Rows[0]["Sold"]);
                obj.Remaining = Convert.ToInt16(dt.Rows[0]["Remaining"]);
                obj.Status = Convert.ToBoolean(dt.Rows[0]["Status"]);
            }
            return obj;
        }

        public static DataTable Get()
        {
            return DataLayer.DataAdapter("Sp_EggStock", new SqlParameter("@Type", ActionType.Select));
        }
        public static DataTable Get_Home()
        {
            return DataLayer.DataAdapter("Sp_EggStock", new SqlParameter("@Type", 5));
        }
        public static void Update(decimal Sold)
        {
            SqlParameter[] Param = new SqlParameter[2];
            Param[0] = new SqlParameter("@Sold", Sold);
            Param[1] = new SqlParameter("@Type", ActionType.Edit);
            DataLayer.ExecuteQuery("Sp_EggStock", Param);
        }

    }
    public class EggStock_
    {
        public int EggStockId { get; set; }
        public int PurchaseEggId { get; set; }
        public float Sold { get; set; }
        public decimal Remaining { get; set; }
        public bool Status { get; set; }
    }
}
