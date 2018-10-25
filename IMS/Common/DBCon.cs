using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace Common
{
    class DBCon
    {
        public static string ConnectionString = "";
        public static SqlConnection con;
        
        public static void DB_Con()
        {
            try
            {
                if (con == null)
                {
                    con = new SqlConnection(ConnectionString);
                    con.Open();
                }
            }
            catch { }
        }

        public static void DB_Close()
        {
            try
            {
                if (con != null && con.State == ConnectionState.Open)
                    con.Close();
            }
            catch { }
        }


        public static DataSet DB_Execute_Dataset(SqlCommand cmd)
        {
            try
            {
                DataSet ds = new DataSet();
                if (con == null)
                    con = new SqlConnection(ConnectionString);
                cmd.Connection = con;
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(ds);
                return ds;
            }
            catch
            {
                return null;
            }
        }

        public static int DB_Execute(SqlCommand cmd)
        {
            try
            {
                if (con == null)
                    con = new SqlConnection(ConnectionString);
                if (con.State != ConnectionState.Open)
                    con.Open();

                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                return cmd.ExecuteNonQuery();
            }
            catch
            {
                return -1;
            }

        }

        public static string DB_ExecuteReturn(SqlCommand cmd)
        {
            string sRET_MSG = "";

            try
            {
                if (con == null)
                    con = new SqlConnection(ConnectionString);
                if (con.State != ConnectionState.Open)
                    con.Open();

                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;

                int result = cmd.ExecuteNonQuery();

                

                return result.ToString();
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }

        public static string DB_ExecuteReturn(SqlCommand cmd, string rtnPara)
        {
            string sRET_MSG = "";

            try
            {
                if (con == null)
                    con = new SqlConnection(ConnectionString);
                if (con.State != ConnectionState.Open)
                    con.Open();

                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.ExecuteNonQuery();

                sRET_MSG = Convert.ToString(cmd.Parameters[rtnPara].Value).Trim();

                return sRET_MSG;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }


        public static string DB_Select(SqlCommand cmd)
        {
            try
            {
                if (con == null)
                    con = new SqlConnection(ConnectionString);
                if (con.State != ConnectionState.Open)
                    con.Open();

                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                return (string)cmd.ExecuteScalar();
            }
            catch
            {
                return "err";
            }
        }
    }
}
