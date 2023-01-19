using System;
using System.Data;
using System.Data.SqlClient;
using TheChicken.BL;
using TheChicken.DL;

namespace ChikenProject.BL
{
    class BL_DesiStock
    {
        public static void Save(DesiStock_ ex)
        {
            SqlParameter[] Param = new SqlParameter[6];
            Param[0] = new SqlParameter("@DesiStockId", ex.DesiStockId);
            Param[1] = new SqlParameter("@PurchaseDesiId", ex.PurchaseDesiId);
            Param[2] = new SqlParameter("@Sold", ex.Sold);
            Param[3] = new SqlParameter("@Remaining", ex.Remaining);
            Param[4] = new SqlParameter("@Status", ex.Status);
            Param[5] = new SqlParameter("@Type", ActionType.Save);
            DataLayer.ExecuteQuery("Sp_DesiStock", Param);
        }
        public static DesiStock_ Get(int? DesiStockId = null,bool? Status=null)
        {
            SqlParameter[] Param = new SqlParameter[3];
            Param[0] = new SqlParameter("@Type", ActionType.Select);
            Param[1] = new SqlParameter("@DesiStockId", DesiStockId);
            Param[2] = new SqlParameter("@Status", Status);
            DataTable dt = DataLayer.DataAdapter("Sp_DesiStock", Param);
            DesiStock_ obj = new DesiStock_();
            if (dt.Rows.Count > 0)
            {
                obj.DesiStockId = Convert.ToInt16(dt.Rows[0]["DesiStockId"]);
                obj.PurchaseDesiId = Convert.ToInt16(dt.Rows[0]["PurchaseDesiId"]);
                obj.Sold = Convert.ToInt16(dt.Rows[0]["Sold"]);
                obj.Remaining = Convert.ToInt16(dt.Rows[0]["Remaining"]);
                obj.Status = Convert.ToBoolean(dt.Rows[0]["Status"]);
            }
            return obj;
        }

        public static DataTable Get()
        {
            return DataLayer.DataAdapter("Sp_DesiStock", new SqlParameter("@Type", ActionType.Select));
        }
        public static DataTable Get_Home()
        {
            return DataLayer.DataAdapter("Sp_DesiStock", new SqlParameter("@Type", 5));
        }
        public static void Update(decimal Sold)
        {
            SqlParameter[] Param = new SqlParameter[2];
            Param[0] = new SqlParameter("@Sold", Sold);
            Param[1] = new SqlParameter("@Type", ActionType.Edit);
            DataLayer.ExecuteQuery("Sp_DesiStock", Param);
        }

    }
    public class DesiStock_
    {
        public int DesiStockId { get; set; }
        public int PurchaseDesiId { get; set; }
        public int Sold { get; set; }
        public bool Status { get; set; }
        public int Remaining { get; set; }
    }
}
