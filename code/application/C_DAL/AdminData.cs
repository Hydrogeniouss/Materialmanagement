using MySql.Data.MySqlClient;

namespace application.C_DAL
{
    /// <summary>
    /// Represents the data of admins as declared in the DB
    /// </summary>
    public class AdminData : UserData
    {
        public AdminData(string firstName, string lastName, string email, string phone, string password, int? id = null) :
            base(id, firstName, lastName, email, phone)
        {
            Password = password;
        }

        public string Password { get; } = string.Empty;


        /// <summary>
        /// Retrieves a list of all admin data from the database.
        /// </summary>
        /// <returns>
        /// A list of <see cref="AdminData"/> objects representing the admin records in the database.
        /// </returns>
        public static List<AdminData> FromDatabase()
        {
            List<AdminData> admins = new();
            using (MySqlConnection conn = DataAccessHelper.CreateConnection())
            {
                conn.Open();
                using (MySqlCommand cmd = new("Select * FROM admin JOIN user ON admin.user_id = user.user_id", conn))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            admins.Add(new(
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
            return admins;
        }
        protected static AdminData FromDatabase(string firstName, string lastName)
        {
            List<AdminData> admins = new();
            using (MySqlConnection conn = DataAccessHelper.CreateConnection())
            {
                conn.Open();
                using (MySqlCommand cmd = new("Select * FROM admin JOIN user ON admin.user_id = user.user_id WHERE user.first_name = @firstName AND user.last_name = @lastName", conn))
                {
                    cmd.Parameters.AddWithValue("@firstName", firstName);
                    cmd.Parameters.AddWithValue("@lastName", lastName);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            admins.Add(new(
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
            return admins[0];
        }

        /// <summary>
        /// Inserts the current admin data into the database.
        /// </summary>
        /// <returns>
        /// The ID of the newly inserted user record in the database.
        /// </returns>
        public long InsertIntoDatabase()
        {

            //Create user in the user table
            long id = InsertIntoDatabase(this);

            //Create Admin Account
            using (MySqlConnection conn = DataAccessHelper.CreateConnection())
            {
                conn.Open();

                using (MySqlCommand cmd = new MySqlCommand("INSERT INTO `admin`(`user_id`, `password`) VALUES (@userID, @password)", conn))
                {
                    cmd.Parameters.AddWithValue("@userID", id);
                    cmd.Parameters.AddWithValue("@password", Password);
                }
            }
            return id;
        }

        public new void DeleteOnDatabase()
            => DeleteOnDatabaseBase(Id);

        public static new void DeleteOnDatabase(int id)
            => DeleteOnDatabaseBase(id);


        private static void DeleteOnDatabaseBase(int? id)
        {
            using (MySqlConnection conn = DataAccessHelper.CreateConnection())
            {
                conn.Open();

                using (MySqlCommand cmd = new MySqlCommand("DELETE FROM `admin` WHERE @id", conn))
                {
                    cmd.Parameters.AddWithValue("@id", id == null ? throw new Exception("Admin not in Database/userId is null") : id);
                }
            }

        }

    }
}
