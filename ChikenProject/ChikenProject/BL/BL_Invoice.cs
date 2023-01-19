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
    internal class BL_Invoice
    {
        public static int Save(Invoice_ ex)
        {
            SqlParameter[] Param = new SqlParameter[9];
            Param[0] = new SqlParameter("@InvoiceId", ex.InvoiceId);
            Param[1] = new SqlParameter("@CustomerName", ex.CustomerName);
            Param[2] = new SqlParameter("@Total", ex.Total);
            Param[3] = new SqlParameter("@Discount", ex.Discount);
            Param[4] = new SqlParameter("@NetTotal", ex.NetTotal);
            Param[5] = new SqlParameter("@I_date", ex.I_date);
            Param[6] = new SqlParameter("@Status", ex.Status);
            Param[7] = new SqlParameter("@Type", ex.IsNew == true ? ActionType.Save : ActionType.Edit);
            Param[8] = new SqlParameter("@ID", SqlDbType.Int);
            Param[8].Direction = ParameterDirection.Output;
            return DataLayer.ExecuteQueryOutput("Sp_Invoice", Param);
        }

        public static bool Delete(int InvoiceId)
        {

            if (Helper.DeleteDecesion() == true)
            {
                SqlParameter[] Param = new SqlParameter[2];
                Param[0] = new SqlParameter("@InvoiceId", InvoiceId);
                Param[1] = new SqlParameter("@Type", ActionType.Delete);
                if (DataLayer.ExecuteQuery("Sp_Invoice", Param) == true)
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

        public static Invoice_ Get(int InvoiceId)
        {
            SqlParameter[] Param = new SqlParameter[2];
            Param[0] = new SqlParameter("@Type", ActionType.Select);
            Param[1] = new SqlParameter("@InvoiceId", InvoiceId);
            DataTable dt = DataLayer.DataAdapter("Sp_Admin", Param);
            Invoice_ obj = new Invoice_();
            if (dt.Rows.Count > 0)
            {
                obj.CustomerName = Convert.ToString(dt.Rows[0]["CustomerName"]);
                obj.Total = Convert.ToDecimal(dt.Rows[0]["Total"]);
                obj.Discount = Convert.ToDecimal(dt.Rows[0]["Discount"]);
                obj.NetTotal = Convert.ToDecimal(dt.Rows[0]["NetTotal"]);
                obj.I_date = Convert.ToDateTime(dt.Rows[0]["I_date"]);
                obj.Status = Convert.ToString(dt.Rows[0]["Status"]) == "Active" ? true : false;
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
                Param[1] = new SqlParameter("@I_Date", DateTime.Now.Date);
            }
            else
            {
                Param = new SqlParameter[1];
                Param[0] = new SqlParameter("@Type", 5);
            }
            return DataLayer.DataAdapter("Sp_Invoice", Param);
        }
        public static DataTable Get()
        {
           
            return DataLayer.DataAdapter("Sp_Invoice", new SqlParameter("@Type", ActionType.Select));
        }
    }
    class Invoice_
    {
        public bool IsNew { get; set; }
        public int InvoiceId { get; set; }
        public string CustomerName { get; set; }
        public decimal Total { get; set; }
        public decimal Discount { get; set; }
        public decimal NetTotal { get; set; }
        public DateTime I_date { get; set; }
        public bool Status { get; set; }


    }
}
