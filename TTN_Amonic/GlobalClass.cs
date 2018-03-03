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
    }
}
