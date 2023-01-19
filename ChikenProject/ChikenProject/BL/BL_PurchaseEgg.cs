using System;
using System.Data;
using System.Data.SqlClient;
using TheChicken.BL;
using TheChicken.DL;

namespace ChikenProject.BL
{
    class BL_PurchaseEgg
    {
        public static int Save(PurchaseEgg_ ex)
        {
            SqlParameter[] Param = new SqlParameter[7];
            Param[0] = new SqlParameter("@PurchaseEggId", ex.PurchaseEggId);
            Param[1] = new SqlParameter("@PurchaseDate", ex.PurchaseDate);
            Param[2] = new SqlParameter("@Rate", ex.Rate);
            Param[3] = new SqlParameter("@VendorId", ex.VendorId);
            Param[4] = new SqlParameter("@Dozen", ex.Dozen);
            Param[5] = new SqlParameter("@Type", ActionType.Save);
            Param[6] = new SqlParameter("@ID", SqlDbType.Int);
            Param[6].Direction = ParameterDirection.Output;
            return DataLayer.ExecuteQueryOutput("Sp_PurchaseEgg", Param);
        }
        public static PurchaseEgg_ Get(int PurchaseEggId)
        {
            SqlParameter[] Param = new SqlParameter[2];
            Param[0] = new SqlParameter("@Type", ActionType.Select);
            Param[1] = new SqlParameter("@PurchaseEggId", PurchaseEggId);
            DataTable dt = DataLayer.DataAdapter("Sp_PurchaseEgg", Param);
            PurchaseEgg_ obj = new PurchaseEgg_();
            if (dt.Rows.Count > 0)
            {
                obj.PurchaseEggId = Convert.ToInt16(dt.Rows[0]["PurchaseEggId"]);
                obj.VendorId = Convert.ToInt16(dt.Rows[0]["VendorId"]);
                obj.Dozen = Convert.ToInt16(dt.Rows[0]["Dozen"]);
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
                Param[1] = new SqlParameter("@PurchaseDate", DateTime.Now);
            }
            else
            {
                Param = new SqlParameter[1];
                Param[0] = new SqlParameter("@Type",5);
            }
            return DataLayer.DataAdapter("Sp_PurchaseEgg", Param);
        }
        public static DataTable Get()
        {
           
            return DataLayer.DataAdapter("Sp_PurchaseEgg", new SqlParameter("@Type", ActionType.Select));
        }


    }
    public class PurchaseEgg_
    {
        public int PurchaseEggId { get; set; }
        public int VendorId { get; set; }
        public int Dozen { get; set; }
        public decimal Rate { get; set; }
        public DateTime PurchaseDate { get; set; }

    }
}
