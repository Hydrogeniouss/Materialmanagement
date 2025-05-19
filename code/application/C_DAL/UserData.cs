using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace application.C_DAL
{
    /// <summary>
    /// Represents the data of users as declared in the DB. Cannot be instanciated
    /// </summary>

    public abstract class UserData
    {
        public UserData(int? id, string firstName, string lastName, string email, string phone)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Phone = phone;
        }

        public int? Id { get; }
        public string FirstName { get; } = string.Empty;
        public string LastName { get; } = string.Empty;
        public string Email { get; } = string.Empty;
        public string Phone { get; } = string.Empty;

        /// <summary>
        /// Inserts a new user record into the database.
        /// </summary>
        /// <param name="user">The <see cref="UserData"/> object containing user details to be inserted.</param>
        /// <returns>The ID of the newly inserted user record.</returns>
        /// <exception cref="MySqlException">Thrown when a database error occurs during the operation.</exception>
        public long InsertIntoDatabase(UserData user)
        {

            using (MySqlConnection conn = DataAccessHelper.CreateConnection())
            {
                conn.Open();

                using (MySqlCommand cmd = new MySqlCommand("INSERT INTO `user`(`first_name`, `last_name`, `email`, `phone`)" +
                    " VALUES(@firstname, @lastname, @email, @phone)", conn))
                {
                    cmd.Parameters.AddWithValue("@firstname", user.FirstName);
                    cmd.Parameters.AddWithValue("@lastname", user.LastName);
                    cmd.Parameters.AddWithValue("@email", user.Email);
                    cmd.Parameters.AddWithValue("@phone", user.Phone);

                    cmd.ExecuteNonQuery();
                    return cmd.LastInsertedId;
                }
            }
        }



    }
}
