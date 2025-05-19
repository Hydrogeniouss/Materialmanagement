using Microsoft.VisualBasic.ApplicationServices;
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


    }
}
