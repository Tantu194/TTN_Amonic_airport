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

        /// <summary>
        /// insert User
        /// </summary>
        /// <param name="param">du lieu cua user</param>
        /// <returns>true or false</returns>
        public static bool insertUser(Dictionary<String,Object> param)
        {
            DataRow dr = DataAccess.QuerySingle("select top 1 ID from Users order by ID Desc");
            if (dr != null)
            {
                int uid = int.Parse(dr["ID"] + string.Empty) + 1;
                param.Add("ID", uid);
                string q = @"INSERT INTO Users(RoleID, Email, Password, FirstName, LastName, OfficeID, Birthdate, Active, ID) VALUES (2, @Email, @Password, @FirstName, @LastName, @OfficeId, @Birthdate, 1, @ID)";

                return DataAccess.Execute(q, param);
            }
            //if (dt.Rows.Count > 0)
            //{
            //    int uid = int.Parse(dt.Rows[0]["ID"].ToString()) + 1;
            //    //Console.WriteLine(uid);
            //    string q = @"insert into Users VALUES (" + uid + ", 2, @email, @password, @firstName, @lastName, @officeID, @birthdate, 1)";
            //    return DataAccess.Execute(q, param);
            //}
            //return false;

            return false;
        }

        public static bool enableUser(int uid, int active)
        {
            string q = "update Users set Active = @active where ID = @uid";
            return DataAccess.Execute(q,new Dictionary<string, object> { {"active",active },{"uid",uid} });
        }
    }
}
