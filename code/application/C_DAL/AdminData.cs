using MySql.Data.MySqlClient;

namespace application.C_DAL
{
    /// <summary>
    /// Represents the data of admins as declared in the DB
    /// </summary>
    internal class AdminData : UserData
    {
        public AdminData(int id, string firstName, string lastName, string email, string phone, string password) : base(id, firstName, lastName, email, phone)
        {
            Password = password;
        }

        public string Password { get; } = string.Empty;


        public static List<AdminData> FromDatabase()
        {
            List<AdminData> collection = new();
            using (MySqlConnection conn = DataAccessHelper.MakeConnection())
            {
                conn.Open();
                using (MySqlCommand cmd = new("Select * FROM admin JOIN user ON admin.user_id = user.user_id"))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            collection.Add(new(
                                reader.GetInt32("user_id"),
                                reader.GetString("first_name"),
                                reader.GetString("last_name"),
                                reader.GetString("email"),
                                reader.GetString("phone"),
                                reader.GetString("password")
                                ));
                        }
                    }
                }
            }
            return collection;
        }

    }
}
