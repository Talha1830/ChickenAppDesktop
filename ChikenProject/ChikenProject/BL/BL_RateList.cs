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
    internal class BL_RateList
    {
        public static bool Save(RateList_ ex)
        {
            SqlParameter[] Param = new SqlParameter[8];
            Param[0] = new SqlParameter("@RateListId", ex.RateListId);
            Param[1] = new SqlParameter("@PurchaseId", ex.PurchaseId);
            Param[2] = new SqlParameter("@WholeSalePrice", ex.WholeSalePrice);
            Param[3] = new SqlParameter("@RetailPrice", ex.RetailPrice);
            Param[4] = new SqlParameter("@Type", ex.IsNew == true ? ActionType.Save : ActionType.Edit);
            Param[5] = new SqlParameter("@ItemId", ex.ItemId);
            Param[6] = new SqlParameter("@R_Type", ex.R_Type);
            Param[7] = new SqlParameter("@R_Date", ex.R_Date);
            if (ex.IsNew == false)
                Helper.MessageEdit();
            return DataLayer.ExecuteQuery("Sp_RateList", Param);
            
        }

        public static bool Delete(int RateListId)
        {

            if (Helper.DeleteDecesion() == true)
            {
                SqlParameter[] Param = new SqlParameter[2];
                Param[0] = new SqlParameter("@RateListId", RateListId);
                Param[1] = new SqlParameter("@Type", ActionType.Delete);
                if (DataLayer.ExecuteQuery("Sp_RateList", Param) == true)
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

        public static RateList_ Get(int? RateListId)
        {
            SqlParameter[] Param = new SqlParameter[2];
            Param[0] = new SqlParameter("@Type", ActionType.Select);
            Param[1] = new SqlParameter("@RateListId", RateListId);
            DataTable dt = DataLayer.DataAdapter("Sp_RateList", Param);
            RateList_ obj = new RateList_();
            if (dt.Rows.Count > 0)
            {
                obj.PurchaseId = Convert.ToInt32(dt.Rows[0]["PurchaseId"]);
                obj.WholeSalePrice = Convert.ToDecimal(dt.Rows[0]["WholeSalePrice"]);
                obj.RetailPrice = Convert.ToDecimal(dt.Rows[0]["RetailPrice"]);
                obj.R_Date = Convert.ToDateTime(dt.Rows[0]["R_Date"]);
                obj.R_Type = Convert.ToInt16(dt.Rows[0]["R_Type"]);
            }
            return obj;
        }

        public static DataTable Get(RateList_ ex = null)
        {
            SqlParameter[] Param;
            if (ex != null)
            {
                Param = new SqlParameter[4];
                Param[0] = new SqlParameter("@Type", ActionType.Select);
                Param[1] = new SqlParameter("@R_Date", ex.R_Date);
                Param[2] = new SqlParameter("@ItemId", ex.ItemId);
                Param[3] = new SqlParameter("@R_Type", ex.R_Type);
            }
            else
            {
                Param = new SqlParameter[1];
                Param[0] = new SqlParameter("@Type", ActionType.Select);
            }

            return DataLayer.DataAdapter("Sp_RateList", Param);
        }


        public static int Get_ID(int Type)
        {
            
            if (Type==0)
            {
                return Convert.ToInt16(DataLayer.DataAdapter("Sp_PurchaseStock", new SqlParameter("@Type",6)).Rows[0]["PurchaseId"]);

            }
            else if(Type==1)
            {
                return Convert.ToInt16(DataLayer.DataAdapter("Sp_PurchaseDesi", new SqlParameter("@Type", 6)).Rows[0]["PurchaseDesiId"]);
            }
            else
            {
                return Convert.ToInt16(DataLayer.DataAdapter("Sp_PurchaseEgg", new SqlParameter("@Type", 6)).Rows[0]["PurchaseEggId"]);
            }

           
        }
    }
    class RateList_
    {
        public bool IsNew { get; set; }
        public int RateListId { get; set; }
        public int? ItemId { get; set; }
        public int? R_Type { get; set; }
        public DateTime R_Date { get; set; }
        public int PurchaseId { get; set; }
        public decimal WholeSalePrice { get; set; }

        public decimal RetailPrice { get; set; }

    }
}
