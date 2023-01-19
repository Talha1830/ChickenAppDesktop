
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
    internal class BL_Item
    {
        public static bool Save(Item_ ex)
        {
            SqlParameter[] Param = new SqlParameter[4];
            Param[0] = new SqlParameter("@itemId", ex.itemId);
            Param[1] = new SqlParameter("@ItemName", ex.ItemName);
            Param[2] = new SqlParameter("@ItemType", ex.ItemType);
            Param[3] = new SqlParameter("@Type", ex.IsNew == true ? ActionType.Save : ActionType.Edit);
            if (DataLayer.ExecuteQuery("Sp_Item", Param) == true)
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

        public static bool Delete(int itemId)
        {

            if (Helper.DeleteDecesion() == true)
            {
                SqlParameter[] Param = new SqlParameter[2];
                Param[0] = new SqlParameter("@itemId", itemId);
                Param[1] = new SqlParameter("@Type", ActionType.Delete);
                if (DataLayer.ExecuteQuery("Sp_Item", Param) == true)
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

        public static Item_ Get(int itemId)
        {
            SqlParameter[] Param = new SqlParameter[2];
            Param[0] = new SqlParameter("@Type", ActionType.Select);
            Param[1] = new SqlParameter("@itemId", itemId);
            DataTable dt = DataLayer.DataAdapter("Sp_Item", Param);
            Item_ obj = new Item_();
            if (dt.Rows.Count > 0)
            {
                obj.ItemName = Convert.ToString(dt.Rows[0]["ItemName"]);
                obj.ItemType = Convert.ToInt16(dt.Rows[0]["ItemType"]);
            }
            return obj;
        }

        public static DataTable Get(int? ItemType = null)
        {
            SqlParameter[] Param = new SqlParameter[2];
            Param[0] = new SqlParameter("@Type", ActionType.Select);
            Param[1] = new SqlParameter("@ItemType", ItemType);
            return DataLayer.DataAdapter("Sp_Item", Param);
        }
    }
    class Item_
    {
        public bool IsNew { get; set; }
        public int itemId { get; set; }
        public int ItemType { get; set; }
        public string ItemName { get; set; }


    }
}
