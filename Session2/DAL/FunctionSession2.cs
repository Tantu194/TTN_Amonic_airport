using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace TTN_Amonic.DAL
{
    public static class FunctionSession2
    {
        public static DataTable getSchedules()
        {
            return DataAccess.Query("select * from Schedules, Aircrafts where Aircrafts.ID = Schedules.AircraftID");
        }
    }
}
