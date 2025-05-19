using MySql.Data.MySqlClient;

namespace application.C_DAL
{
    /// <summary>
    /// Represents the data of admins as declared in the DB
    /// </summary>
    internal class AdminData : UserData
    {
        public AdminData(string firstName, string lastName, string email, string phone, string password, int? id = null) : 
            base(id, firstName, lastName, email, phone)
        {
            Password = password;
        }

        public string Password { get; } = string.Empty;


        public static List<AdminData> FromDatabase()
        {
            List<AdminData> collection = new();
            using (MySqlConnection conn = DataAccessHelper.CreateConnection())
            {
                conn.Open();
                using (MySqlCommand cmd = new("Select * FROM admin JOIN user ON admin.user_id = user.user_id", conn))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            collection.Add(new(
                                reader.GetString("first_name"),
                                reader.GetString("last_name"),
                                reader.GetString("email"),
                                reader.GetString("phone"),
                                reader.GetString("password"),
                                reader.GetInt32("user_id")
                                ));
                        }
                    }
                }
            }
            return collection;
        }

        //TODO: Ask Frau Mayer if its Possible to override InsertIntoDatabase without params 
        public override void InsertIntoDatabase(UserData user = null)
        {
            base.InsertIntoDatabase(this);

            //TODO: Ask Frau Mayer if a select for getting the primary key of the new user is needed, or if there is another way

            using (MySqlConnection conn = DataAccessHelper.CreateConnection())
            {
                conn.Open();

                using (MySqlCommand cmd = new MySqlCommand("INSERT INTO `admin`(`user_id`, `password`) VALUES (@userID, @password)", conn))
                {
                    cmd.Parameters.AddWithValue("@userID", /*See lines above*/ null);
                    cmd.Parameters.AddWithValue("@password", Password);
                }
            }
        }
    }
}
