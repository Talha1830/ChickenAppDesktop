using System;
using System.Data;
using System.Data.SqlClient;
using TheChicken.BL;
using TheChicken.DL;

namespace ChikenProject.BL
{
    class BL_PurchaseDesi
    {
        public static int Save(PurchaseDesi_ ex)
        {
            SqlParameter[] Param = new SqlParameter[7];
            Param[0] = new SqlParameter("@PurchaseDesiId", ex.PurchaseDesiId);
            Param[1] = new SqlParameter("@PurchaseDate", ex.PurchaseDate);
            Param[2] = new SqlParameter("@Rate", ex.Rate);
            Param[3] = new SqlParameter("@VendorId", ex.VendorId);
            Param[4] = new SqlParameter("@Qty", ex.Qty);
            Param[5] = new SqlParameter("@Type", ActionType.Save);
            Param[6] = new SqlParameter("@ID", SqlDbType.Int);
            Param[6].Direction = ParameterDirection.Output;
            return DataLayer.ExecuteQueryOutput("Sp_PurchaseDesi", Param);
        }
        public static PurchaseDesi_ Get(int PurchaseDesiId)
        {
            SqlParameter[] Param = new SqlParameter[2];
            Param[0] = new SqlParameter("@Type", ActionType.Select);
            Param[1] = new SqlParameter("@PurchaseDesiId", PurchaseDesiId);
            DataTable dt = DataLayer.DataAdapter("Sp_PurchaseDesi", Param);
            PurchaseDesi_ obj = new PurchaseDesi_();
            if (dt.Rows.Count > 0)
            {
                obj.PurchaseDesiId = Convert.ToInt16(dt.Rows[0]["PurchaseDesiId"]);
                obj.VendorId = Convert.ToInt16(dt.Rows[0]["VendorId"]);
                obj.Qty = Convert.ToInt16(dt.Rows[0]["Qty"]);
                obj.Rate = Convert.ToDecimal(dt.Rows[0]["Rate"]);
                obj.PurchaseDate = Convert.ToDateTime(dt.Rows[0]["PurchaseDate"]);
            }
            return obj;
        }
        public static DataTable Get_Home(bool flag)
        {
            SqlParameter[] Param;
            if (flag == true)
            {
                Param = new SqlParameter[2];
                Param[0] = new SqlParameter("@Type", 5);
                Param[1] = new SqlParameter("@PurchaseDate", DateTime.Now.Date);
            }
            else
            {
                Param = new SqlParameter[1];
                Param[0] = new SqlParameter("@Type", 5);
            }

            return DataLayer.DataAdapter("Sp_PurchaseDesi", Param);
        }
        public static DataTable Get()
        {
            return DataLayer.DataAdapter("Sp_PurchaseDesi",new SqlParameter("@Type",ActionType.Select));
        }

    }
    public class PurchaseDesi_
    {
        public int PurchaseDesiId { get; set; }
        public int VendorId { get; set; }
        public int Qty { get; set; }
        public decimal Rate { get; set; }
        public DateTime PurchaseDate { get; set; }
    }

}
