
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
    internal class BL_InvoiceItem
    {
        public static void Save(InvoiceItem_ ex)
        {
            SqlParameter[] Param = new SqlParameter[6];
            Param[0] = new SqlParameter("@InvItemId", ex.InvItemId);
            Param[1] = new SqlParameter("@InvoiceId", ex.InvoiceId);
            Param[2] = new SqlParameter("@itemId", ex.itemId);
            Param[3] = new SqlParameter("@Weight", ex.Weight);
            Param[4] = new SqlParameter("@Price", ex.Price);
            Param[5] = new SqlParameter("@type", ex.IsNew == true ? ActionType.Save : ActionType.Edit);
            DataLayer.ExecuteQuery("Sp_InvoiceItem", Param);
            
        }

        public static bool Delete(int InvItemId)
        {

            if (Helper.DeleteDecesion() == true)
            {
                SqlParameter[] Param = new SqlParameter[2];
                Param[0] = new SqlParameter("@InvItemId", InvItemId);
                Param[1] = new SqlParameter("@Type", ActionType.Delete);
                if (DataLayer.ExecuteQuery("Sp_InvoiceItem", Param) == true)
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

        public static InvoiceItem_ Get(int? InvItemId)
        {
            SqlParameter[] Param = new SqlParameter[2];
            Param[0] = new SqlParameter("@Type", ActionType.Select);
            Param[1] = new SqlParameter("@InvItemId", InvItemId);
            DataTable dt = DataLayer.DataAdapter("Sp_InvoiceItem", Param);
            InvoiceItem_ obj = new InvoiceItem_();
            if (dt.Rows.Count > 0)
            {
                obj.InvoiceId = Convert.ToInt32(dt.Rows[0]["InvoiceId"]);
                obj.itemId = Convert.ToInt32(dt.Rows[0]["itemId"]);
                obj.Weight = Convert.ToDecimal(dt.Rows[0]["Weight"]);
                obj.Price = Convert.ToDecimal(dt.Rows[0]["Price"]);



            }
            return obj;
        }

        public static DataTable Get()
        {
            return DataLayer.DataAdapter("Sp_InvoiceItem", new SqlParameter("@Type", ActionType.Select));
        }
    }
    class InvoiceItem_
    {
        public bool IsNew { get; set; }
        public int InvItemId { get; set; }
        public int InvoiceId { get; set; }
        public int itemId { get; set; }
        public decimal Weight { get; set; }
        public decimal Price { get; set; }

    }
}
