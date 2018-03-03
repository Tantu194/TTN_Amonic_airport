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
        /// <summary>
        /// Login into system
        /// </summary>
        /// <param name="username">Email to login</param>
        /// <param name="password">Password to login</param>
        /// <returns>Datatable</returns>
        public static DataTable Login(string username, string password)
        {
            string sqlQuery = "select * from Users where Email=@username and Password=@password";
            return DataAccess.Query(sqlQuery, new Dictionary<string, object>
            {
                {"@username", username}, {"@password", MD5(password)}
            });
        }

        /// <summary>
        /// Encryt string to MD5
        /// </summary>
        /// <param name="input">input</param>
        /// <returns>MD5 string</returns>
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

        //public static bool UpdateLogs(DateTime dateLogin, DateTime loginTime, DateTime logoutTime, string reason)
        //{
        //    string sqlQuery = "insert"
        //}
    }
}
