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
    internal class BL_Vendor
    {
        public static bool Save(Vendor_ ex)
        {
            SqlParameter[] Param = new SqlParameter[4];
            Param[0] = new SqlParameter("@VendorId", ex.VendorId);
            Param[1] = new SqlParameter("@Name", ex.Name);
            Param[2] = new SqlParameter("@Address", ex.Address);
            Param[3] = new SqlParameter("@type", ex.IsNew == true ? ActionType.Save : ActionType.Edit);
            if (DataLayer.ExecuteQuery("Sp_Vendor", Param) == true)
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

        public static bool Delete(int VendorId)
        {

            if (Helper.DeleteDecesion() == true)
            {
                SqlParameter[] Param = new SqlParameter[2];
                Param[0] = new SqlParameter("@VendorId", VendorId);
                Param[1] = new SqlParameter("@Type", ActionType.Delete);
                if (DataLayer.ExecuteQuery("Sp_Vendor", Param) == true)
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

        public static Vendor_ Get(int? VendorId)
        {
            SqlParameter[] Param = new SqlParameter[2];
            Param[0] = new SqlParameter("@Type", ActionType.Select);
            Param[1] = new SqlParameter("@VendorId", VendorId);
            DataTable dt = DataLayer.DataAdapter("Sp_Vendor", Param);
            Vendor_ obj = new Vendor_();
            if (dt.Rows.Count > 0)
            {
                obj.Name = Convert.ToString(dt.Rows[0]["Name"]);
                obj.Address = Convert.ToString(dt.Rows[0]["Address"]);
            }
            return obj;
        }

        public static DataTable Get()
        {
            return DataLayer.DataAdapter("Sp_Vendor", new SqlParameter("@Type", ActionType.Select));
        }
    }
    class Vendor_
    {
        public bool IsNew { get; set; }

        public int VendorId { get; set; }
        public string Address { get; set; }
        public string Name { get; set; }

    }
}
