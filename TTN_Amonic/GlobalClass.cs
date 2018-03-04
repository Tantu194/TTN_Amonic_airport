using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TTN_Amonic
{
    public static class GlobalClass
    {

        private static int _userID = -1;
        private static TimeSpan _loginTime;
        private static DateTime _dateLogin;
        private static int _roleID;
        private static string _firstName;

        public static int UserID
        {
            get
            {
                return _userID;
            }

            set
            {
                _userID = value;
            }
        }

        public static TimeSpan LoginTime
        {
            get
            {
                return _loginTime;
            }

            set
            {
                _loginTime = value;
            }
        }

        public static DateTime DateLogin
        {
            get
            {
                return _dateLogin;
            }

            set
            {
                _dateLogin = value;
            }
        }

        public static int RoleID
        {
            get
            {
                return _roleID;
            }

            set
            {
                _roleID = value;
            }
        }

        public static string FirstName
        {
            get
            {
                return _firstName;
            }

            set
            {
                _firstName = value;
            }
        }
    }
}
