using MySql.Data.MySqlClient;

namespace application.C_DAL
{
    /// <summary>
    /// Represents the data of members as declared in the DB
    /// </summary>

    public class MemberData : UserData
    {
        public MemberData(string firstName, string lastName, string email, string phone, int pin, int? id = null)
            : base(id, firstName, lastName, email, phone)
        {
            Pin = pin;
        }

        public int Pin { get; }

        /// <summary>
        /// Retrieves a list of all member data from the database.
        /// </summary>
        /// <returns>
        /// A list of <see cref="MemberData"/> objects representing the member records in the database.
        /// </returns>

        public static List<MemberData> FromDatabase()
        {
            return FromDatabaseBase();
        }
        public static MemberData FromDatabase(int id)
        {
            return FromDatabaseBase(id)[0];
        }

        private static List<MemberData> FromDatabaseBase(int? id = null)
        {
            if (id == null)
            {

                List<MemberData> members = new();
                using (MySqlConnection conn = DataAccessHelper.CreateConnection())
                {
                    conn.Open();
                    using (MySqlCommand cmd = new("Select * FROM member JOIN user ON member.user_id = user.user_id", conn))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                members.Add(new MemberData(
                                    reader.GetString("first_name"),
                                    reader.GetString("last_name"),
                                    reader.GetString("email"),
                                    reader.GetString("phone"),
                                    reader.GetInt32("pin"),
                                    reader.GetInt32("user_id")
                                ));
                            }
                        }
                    }
                }
                return members;
            }
            else
            {

                List<MemberData> members = new();
                using (MySqlConnection conn = DataAccessHelper.CreateConnection())
                {
                    conn.Open();
                    using (MySqlCommand cmd = new("Select * FROM member JOIN user ON member.user_id = user.user_id WHERE member.user_id = @id", conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                members.Add(new MemberData(
                                    reader.GetString("first_name"),
                                    reader.GetString("last_name"),
                                    reader.GetString("email"),
                                    reader.GetString("phone"),
                                    reader.GetInt32("pin"),
                                    reader.GetInt32("user_id")
                                    ));
                            }
                        }
                    }
                }
                return members;
            }
        }


        public long InsertIntoDatabase()
        {

            //Create user in the user table
            long id = InsertIntoDatabase(this);

            //Create Member Account
            using (MySqlConnection conn = DataAccessHelper.CreateConnection())
            {
                conn.Open();

                using (MySqlCommand cmd = new MySqlCommand("INSERT INTO `member`(`user_id`, `pin`) VALUES (@userID, @pin)", conn))
                {
                    cmd.Parameters.AddWithValue("@userID", id);
                    cmd.Parameters.AddWithValue("@pin", Pin);
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

                using (MySqlCommand cmd = new MySqlCommand("DELETE FROM `member` WHERE @id", conn))
                {
                    cmd.Parameters.AddWithValue("@id", id == null ? throw new Exception("Member not in Database/userId is null") : id);
                }
            }

        }

    }
}
