using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace TTN_Amonic.DAL
{
    public class DataAccess
    {
        private static string connectionString = ConfigurationManager.ConnectionStrings["strConnectionSession1"].ConnectionString;

        public static DataTable Query(string query, Dictionary<string, object> param = null)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    SqlCommand cmd = new SqlCommand(query, connection);
                    if (param != null && param.Count > 0)
                    {
                        foreach (var par in param)
                            cmd.Parameters.AddWithValue(par.Key, par.Value);
                    }

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    return dt;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                    return new DataTable();
                }
                finally
                {
                    if (connection.State != ConnectionState.Closed)
                        connection.Close();
                }
            }
        }
        /// <summary>
        /// thuc thi query
        /// </summary>
        /// <param name="query">cau lenh sql</param>
        /// <param name="param">tham so ket noi</param>
        /// <returns>0 or 1</returns>
        public static bool Execute(string query, Dictionary<string, object> param = null)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                SqlTransaction transaction = null;
                try
                {
                    connection.Open();
                    transaction = connection.BeginTransaction();

                    SqlCommand cmd = new SqlCommand(query, connection,transaction);
                    if (param != null && param.Count > 0)
                    {
                        foreach (var par in param)
                        {
                            cmd.Parameters.AddWithValue(par.Key, par.Value);
                        }
                    }

                    int effectedRow = cmd.ExecuteNonQuery();

                    if (effectedRow > 0)
                        transaction.Commit();
                    else transaction.Rollback();

                    return effectedRow > 0;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                    transaction.Rollback();
                }
                finally
                {
                    if (connection.State != ConnectionState.Closed)
                        connection.Close();
                }
            }

            return false;
        }
    }
}
