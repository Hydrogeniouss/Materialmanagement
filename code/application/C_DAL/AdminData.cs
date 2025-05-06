using MySql.Data.MySqlClient;

namespace application.C_DAL
{
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
                using (MySqlCommand adminCMD = new("SELECT * FROM admin", conn))
                {
                    using (MySqlDataReader adminReader = adminCMD.ExecuteReader())
                    {
                        while (adminReader.Read())
                        {
                            UserData user;
                            using (MySqlCommand userCMD = new($"SELECT * FROM user WHERE user.user_id = ${adminReader["user_id"]}"))
                            {
                                using (MySqlDataReader userReader = userCMD.ExecuteReader())
                                {
                                    user = new(
                                        userReader.GetInt32("user_id"),
                                        userReader.GetString("first_name"),
                                        userReader.GetString("last_name"),
                                        userReader.GetString("email"),
                                        userReader.GetString("phone")
                                        );
                                }
                            }
                            collection.Add(new(
                                user.Id,
                                user.FirstName,
                                user.LastName,
                                user.Email,
                                user.Phone,
                                adminReader.GetString("password"))
                                );
                        }
                    }
                }
            }
            return collection;
        }

    }
}
