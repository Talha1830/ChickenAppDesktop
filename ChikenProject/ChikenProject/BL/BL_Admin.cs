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
    internal class BL_Admin
    {
        public static bool Save(Admin_ ex)
        {
            SqlParameter[] Param = new SqlParameter[6];
            Param[0] = new SqlParameter("@AdminId", ex.AdminId);
            Param[1] = new SqlParameter("@UserName", ex.UserName);
            Param[2] = new SqlParameter("@Email", ex.Email);
            Param[3] = new SqlParameter("@Password", ex.Password);
            Param[4] = new SqlParameter("@Status", ex.Status);
            Param[5] = new SqlParameter("@type", ex.IsNew == true ? ActionType.Save : ActionType.Edit);
            if (DataLayer.ExecuteQuery("Sp_Admin", Param) == true)
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

        public static bool Delete(int AdminId)
        {

            if (Helper.DeleteDecesion() == true)
            {
                SqlParameter[] Param = new SqlParameter[2];
                Param[0] = new SqlParameter("@AdminId", AdminId);
                Param[1] = new SqlParameter("@Type", ActionType.Delete);
                if (DataLayer.ExecuteQuery("Sp_Admin", Param) == true)
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

        public static DataTable Get(Admin_ ex)
        {
            SqlParameter[] Param = new SqlParameter[3];
            Param[0] = new SqlParameter("@Type", ActionType.Select);
            Param[1] = new SqlParameter("@UserName", ex.UserName);
            Param[2] = new SqlParameter("@Password", ex.Password);
            return DataLayer.DataAdapter("Sp_Admin", Param);


        }


        public static DataTable Get()
        {
            return DataLayer.DataAdapter("Sp_Admin", new SqlParameter("@Type", ActionType.Select));
        }
    }

    class Admin_
    {
        public bool IsNew { get; set; }
        public int AdminId { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool Status { get; set; }

    }
}
