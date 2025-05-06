using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace application.C_DAL
{
    internal static class DataAccessHelper
    {
        public static MySqlConnection MakeConnection() => new("DataSource=localhost;DataBase=materialmanagement;UserID=root;Password=");
    }
}
