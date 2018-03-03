using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace TTN_Amonic.DAL
{
    public static class FunctionSession1
    {
        public static DataTable Login(string username, string password)
        {
            string sqlQuery = "select * from Users where Email=@username and Password=@password";
            return DataAccess.Query(sqlQuery, new Dictionary<string, object>
            {
                {"@username", username}, {"@password", MD5(password)}
            });
        }

        public static string MD5(string input)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(input));
            byte[] result = md5.Hash;
            StringBuilder strBuilder = new StringBuilder();
            for (int i = 0; i < result.Length; i++)
            {
                strBuilder.Append(result[i].ToString("x2"));
            }
            return strBuilder.ToString();
        }
    }
}
