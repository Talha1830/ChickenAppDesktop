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
    internal class BL_Cashier
    {
        public static bool Save(Cashier_ ex)
        {
            SqlParameter[] Param = new SqlParameter[6];
            Param[0] = new SqlParameter("@CashierId", ex.CashierId);
            Param[1] = new SqlParameter("@UserName", ex.UserName);
            Param[2] = new SqlParameter("@Email", ex.Email);
            Param[3] = new SqlParameter("@Password", ex.Password);
            Param[4] = new SqlParameter("@Status", ex.Status);
            Param[5] = new SqlParameter("@Type", ex.IsNew == true ? ActionType.Save : ActionType.Edit);
            if (DataLayer.ExecuteQuery("Sp_Cashier", Param) == true)
            {
                if (ex.IsNew == false)
                {
                    Helper.MessageEdit();
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Your Account Create SuccessFully","Information",System.Windows.Forms.MessageBoxButtons.OK,System.Windows.Forms.MessageBoxIcon.Information);
                }

                return true;
            }
            return false;
        }

        public static bool Delete(int CashierId)
        {

            if (Helper.DeleteDecesion() == true)
            {
                SqlParameter[] Param = new SqlParameter[2];
                Param[0] = new SqlParameter("@CashierId", CashierId);
                Param[1] = new SqlParameter("@Type", ActionType.Delete);
                if (DataLayer.ExecuteQuery("Sp_Cashier", Param) == true)
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

        public static Cashier_ Get(int? CashierId)
        {
            SqlParameter[] Param = new SqlParameter[2];
            Param[0] = new SqlParameter("@Type", ActionType.Select);
            Param[1] = new SqlParameter("@CashierId", CashierId);
            DataTable dt = DataLayer.DataAdapter("Sp_Cashier", Param);
            Cashier_ obj = new Cashier_();
            if (dt.Rows.Count > 0)
            {
                obj.UserName = Convert.ToString(dt.Rows[0]["UserName"]);
                obj.Password = Convert.ToString(dt.Rows[0]["Password"]);
                obj.Email = Convert.ToString(dt.Rows[0]["Email"]);
                obj.Status = Convert.ToBoolean(dt.Rows[0]["Status"]);
            }
            return obj;
        }

        public static DataTable Get(Cashier_ ex=null)
        {
            SqlParameter[] Param;
            if (ex!=null)
            {
                Param= new SqlParameter[4];
                Param[0] = new SqlParameter("@Type", ActionType.Select);
                Param[1] = new SqlParameter("@UserName", ex.UserName);
                Param[2] = new SqlParameter("@Password", ex.Password);
                Param[3] = new SqlParameter("@Status", ex.Status);
            }
            else
            {
                Param = new SqlParameter[1];
                Param[0] = new SqlParameter("@Type", ActionType.Select);
            }
            return DataLayer.DataAdapter("Sp_Cashier",Param);
        }
    }

    class Cashier_
    {
        public bool IsNew { get; set; }
        public int? CashierId { get; set; }

        public string UserName { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public bool? Status { get; set; }

    }
}
