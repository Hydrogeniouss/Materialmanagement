using MySql.Data.MySqlClient;

namespace application.C_DAL
{
    /// <summary>
    /// Contains multiple helper methods for interacting with the DB
    /// </summary>
    internal static class DataAccessHelper
    {
        /// <summary>
        /// Returns a MySqlConnection with our DB
        /// </summary>
        public static MySqlConnection CreateConnection() => new("DataSource=localhost;DataBase=materialmanagement;UserID=root;Password=");
    }
}
