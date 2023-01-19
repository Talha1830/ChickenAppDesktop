using TheChicken.BL;
using System;

using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace TheChicken.DL
{
    class DataLayer
    {

        static SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ToString());
        static SqlCommand cmd;
        static SqlDataAdapter sda;
        static DataTable dt;

     

        public static bool ExecuteQuery(string ProcName, SqlParameter[] Param)
        {
            try
            {
                cmd = new SqlCommand(ProcName, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddRange(Param);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                return true;
            }
            catch (Exception ex)
            {
                Helper.MessageDataBase(ex.Message);
                conn.Close();
                return false;
            }
        }
        public static int ExecuteQueryOutput(string ProcName, SqlParameter[] Param)
        {
            try
            {
                cmd = new SqlCommand(ProcName, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddRange(Param);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                return Convert.ToInt16(cmd.Parameters["@ID"].Value);
            }
            catch (Exception ex)
            {
                Helper.MessageDataBase(ex.Message);
                conn.Close();
                return 0;
            }
        }
        public static DataTable DataAdapter(string ProcName)
        {
            try
            {
                cmd = new SqlCommand(ProcName, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                sda = new SqlDataAdapter(cmd);
                dt = new DataTable();
                sda.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                Helper.MessageDataBase(ex.Message);
                return null;
            }
        }
        public static DataSet DataSet(string ProcName, SqlParameter[] Param)
        {
            try
            {
                cmd = new SqlCommand(ProcName, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddRange(Param);
                sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                return ds;
            }
            catch (Exception ex)
            {
                Helper.MessageDataBase(ex.Message);
                return null;
            }
        }
        public static DataSet DataSet(string ProcName, SqlParameter Param)
        {
            try
            {
                cmd = new SqlCommand(ProcName, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(Param);
                sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                return ds;
            }
            catch (Exception ex)
            {
                Helper.MessageDataBase(ex.Message);
                return null;
            }
        }
        public static DataTable DataAdapter(string ProcName, SqlParameter Param)
        {
            try
            {
                cmd = new SqlCommand(ProcName, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(Param);
                sda = new SqlDataAdapter(cmd);
                dt = new DataTable();
                sda.Fill(dt);
                return (dt);
            }
            catch (Exception ex)
            {
                Helper.MessageDataBase(ex.Message);
                return null;
            }

        }
        public static DataTable DataAdapter(string ProcName, SqlParameter[] Param)
        {
            try
            {
                cmd = new SqlCommand(ProcName, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddRange(Param);
                sda = new SqlDataAdapter(cmd);
                dt = new DataTable();
                sda.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                Helper.MessageDataBase(ex.Message);
                return null;
            }
        }
    }
}

