using TheChicken.BL;
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
    internal class BL_PurchaseStock
    {
        public static int Save(PurchaseStock_ ex)
        {
            SqlParameter[] Param = new SqlParameter[7];
            Param[0] = new SqlParameter("@PurchaseId", ex.PurchaseId);
            Param[1] = new SqlParameter("@VendorId", ex.VendorId);
            Param[2] = new SqlParameter("@Weight", ex.Weight);
            Param[3] = new SqlParameter("@Rate", ex.Rate);
            Param[4] = new SqlParameter("@PurchaseDate", ex.PurchaseDate);
            Param[5] = new SqlParameter("@Type", ex.IsNew == true ? ActionType.Save : ActionType.Edit);
            Param[6] = new SqlParameter("@ID", SqlDbType.Int);
            Param[6].Direction = ParameterDirection.Output;
            return DataLayer.ExecuteQueryOutput("Sp_PurchaseStock", Param);
        }

        public static bool Delete(int PurchaseId)
        {

            if (Helper.DeleteDecesion() == true)
            {
                SqlParameter[] Param = new SqlParameter[2];
                Param[0] = new SqlParameter("@PurchaseId", PurchaseId);
                Param[1] = new SqlParameter("@Type", ActionType.Delete);
                if (DataLayer.ExecuteQuery("Sp_PurchaseStock", Param) == true)
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

        public static PurchaseStock_ Get(int PurchaseId)
        {
            SqlParameter[] Param = new SqlParameter[2];
            Param[0] = new SqlParameter("@Type", ActionType.Select);
            Param[1] = new SqlParameter("@PurchaseId", PurchaseId);
            DataTable dt = DataLayer.DataAdapter("Sp_PurchaseStock", Param);
            PurchaseStock_ obj = new PurchaseStock_();
            if (dt.Rows.Count > 0)
            {
                obj.VendorId = Convert.ToInt32(dt.Rows[0]["UserName"]);
                obj.Weight = Convert.ToDecimal(dt.Rows[0]["Weight"]);
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
            return DataLayer.DataAdapter("Sp_PurchaseStock", Param);
        }

        public static DataTable Get()
        {
          
            return DataLayer.DataAdapter("Sp_PurchaseStock", new SqlParameter("@Type", ActionType.Select));
        }
    }
    class PurchaseStock_
    {
        public bool IsNew { get; set; }
        public int PurchaseId { get; set; }

        public int VendorId { get; set; }

        public decimal Weight { get; set; }

        public decimal Rate { get; set; }

        public DateTime PurchaseDate { get; set; }

    }
}
