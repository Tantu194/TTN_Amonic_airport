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

        /// <summary>
        /// Update Logs when user logout
        /// </summary>
        /// <param name="UserId">User ID</param>
        /// <param name="dateLogin">Date user login</param>
        /// <param name="loginTime">Time user login</param>
        /// <param name="logoutTime">Time user logout</param>
        /// <param name="reason">reason cash system</param>
        /// <returns>True or False</returns>
        public static bool UpdateLogs(int UserId, string dateLogin, string loginTime, string logoutTime, string reason)
        {
            string sqlQuery = "update Logs set LogoutTime=@LogoutTime, Reason=@reason where UserId=@UserId and DateLogin=@DateLogin";
            //string sqlQuery = "insert into Logs values(@UserId, @DateTime, @LoginTime, @LogoutTime, @Reason)";
            return DataAccess.Execute(sqlQuery, new Dictionary<string, object>
            {
                {"@LogoutTime", logoutTime},
                {"@Reason", reason},
                {"@UserId", UserId},
                {"@DateTime", dateLogin}
            });
        }

        /// <summary>
        /// Insert Logs when user login
        /// </summary>
        /// <param name="UserId">User ID</param>
        /// <param name="dateLogin">Date user login</param>
        /// <param name="loginTime">Time user login</param>
        /// <returns>True or False</returns>
        public static bool InsertLogs(int UserId, string dateLogin, string loginTime)
        {
            string sqlQuery = "insert into Logs values(@UserId, @DateLogin, @LoginTime)";
            return DataAccess.Execute(sqlQuery, new Dictionary<string, object>
            {
                {"@UserId", UserId},
                {"@DateLogin", dateLogin},
                {"@LoginTime", loginTime}
            });
        }
        /// <summary>
        /// get all office
        /// </summary>
        /// <returns>data table</returns>
        public static DataTable getAllOffices()
        {
            String q = "select * from Offices";
            return DataAccess.Query(q);
        }
    }
}
