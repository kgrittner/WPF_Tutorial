using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLHelperClass
{
    public static class SQLHELPER
    {
        public static DataTable GetDataTable(string sql, string connString, List<SqlParameter> paramList = null)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        conn.Open();

                        if (paramList != null)
                        {
                            cmd.Parameters.AddRange(paramList.ToArray());
                        }

                        using (SqlDataAdapter da = new SqlDataAdapter())
                        {
                            da.SelectCommand = cmd;
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            conn.Close();
                            return dt;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                return null;
                throw ex;
            }
        }


        public static SqlDataReader ExecuteReader(string sql, string connString, List<SqlParameter> paramList = null)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        conn.Open();

                        if (paramList != null)
                        {
                            cmd.Parameters.AddRange(paramList.ToArray());
                        }

                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            conn.Close();
                            return dr;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                return null;
                throw ex;
            }
        }


        public static int ExecuteNonQuery(string sql, string connString, List<SqlParameter> paramList = null)
        {
            int count = 0;

            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        if (paramList != null)
                        {
                            cmd.Parameters.AddRange(paramList.ToArray());
                        }

                        conn.Open();
                        count = cmd.ExecuteNonQuery();
                        conn.Close();
                        return count;
                    }
                }
            }
            catch (Exception ex)
            {
                return 0;
                throw ex;
            }
        }


        public static string ExecuteScalar(string sql, string connString, List<SqlParameter> paramList = null)
        {
            string result = "";

            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        if (paramList != null)
                        {
                            cmd.Parameters.AddRange(paramList.ToArray());
                        }

                        conn.Open();
                        result = cmd.ExecuteScalar().ToString();
                        conn.Close();
                        return result;
                    }
                }
            }
            catch (Exception ex)
            {
                return "";
                throw ex;
            }
        }


    } //END CLASS
}
