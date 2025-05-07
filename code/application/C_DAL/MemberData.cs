using MySql.Data.MySqlClient;

namespace application.C_DAL
{
    /// <summary>
    /// Represents the data of members as declared in the DB
    /// </summary>

    internal class MemberData : UserData
    {
        public MemberData(int id, string firstName, string lastName, string email, string phone, int pin) : base(id, firstName, lastName, email, phone)
        {
            Pin = pin;
        }

        public int Pin { get; }


        public static List<MemberData> FromDatabase()
        {
            List<MemberData> collection = new();
            using (MySqlConnection conn = DataAccessHelper.MakeConnection())
            {
                conn.Open();
                using (MySqlCommand cmd = new("Select * FROM member JOIN user ON member.user_id = user.user_id"))
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
                                reader.GetInt32("pin")
                                ));
                        }
                    }
                }
            }
            return collection;
        }

    }
}
