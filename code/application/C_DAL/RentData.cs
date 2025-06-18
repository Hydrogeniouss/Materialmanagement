using MySql.Data.MySqlClient;
using System.Text;

namespace application.C_DAL
{
    public class RentData
    {
        public RentData(int quantity, DateTime dateOfAquisition, DateTime? dateOfRetunal = null, int? userId = null, int? materialId = null)
        {
            Quantity = quantity;
            DateOfAquisition = dateOfAquisition;
            DateOfReturnal = dateOfRetunal;
            UserId = userId;
            MaterialId = materialId;
        }

        public int Quantity { get; set; }
        public DateTime DateOfAquisition { get; set; }
        public DateTime? DateOfReturnal { get; set; }
        public int? UserId { get; set; }
        public int? MaterialId { get; set; }

        public static List<RentData> FromDatabase(bool isOnlyRented = false, int? userID = null)
        {
            List<RentData> materials = new List<RentData>();

            using (MySqlConnection conn = DataAccessHelper.CreateConnection())
            {
                StringBuilder sql = new StringBuilder("SELECT * FROM `member_has_rented_material` ");
                conn.Open();

                if (isOnlyRented)
                {
                    sql.Append("WHERE date_of_returnal IS NULL ");
                    if (userID != null) sql.Append("AND user_id = @userId ");


                    using (MySqlCommand cmd = new())
                    {
                        cmd.Connection = conn;
                        cmd.CommandText = sql.ToString();
                        if (userID != null) cmd.Parameters.AddWithValue("@userId", userID);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {

                            List<RentData> hasRented = new();
                            while (reader.Read())
                            {
                                hasRented.Add(new RentData(
                                    reader.GetInt32("quantity"),
                                    reader.GetDateTime("date_of_aquisition"),
                                    null,
                                    reader.GetInt32("user_id"),
                                    reader.GetInt32("material_id")
                                ));
                            }

                            return hasRented;
                        }


                    }
                }
                else
                {
                    using (MySqlCommand cmd = new())
                    {
                        if (userID != null) sql.Append("WHERE user_id = @userId ");

                        cmd.Connection = conn;
                        cmd.CommandText = sql.ToString();
                        if (userID != null) cmd.Parameters.AddWithValue("@userId", userID);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            List<RentData> hasRented = new();
                            while (reader.Read())
                            {
                                hasRented.Add(new RentData(
                                    reader.GetInt32("quantity"),
                                    reader.GetDateTime("date_of_aquisition"),
                                    reader.IsDBNull(reader.GetOrdinal("date_of_returnal")) ? null : reader.GetDateTime("date_of_returnal"),
                                    reader.GetInt32("user_id"),
                                    reader.GetInt32("material_id")
                                ));
                            }

                            return hasRented;
                        }
                    }
                }
            }
        }


        /// <summary>
        /// Checks if an userId is used
        /// </summary>
        /// <param name="id">userId to check</param>
        /// <returns>Returns `true` when the given Id is used in member_has_rented_material, else `false` table</returns>
        public static bool CheckForeignKeyRelationForUser(int id)
        {
            int howOften; // better name
            using (MySqlConnection conn = DataAccessHelper.CreateConnection())
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM member_has_rented_material WHERE user_id = @id", conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);

                    howOften = cmd.ExecuteNonQuery();
                }
            }

            return howOften > 0 ? true : false;
        }

        public void InsertIntoDatabase()
        {
            using (MySqlConnection conn = DataAccessHelper.CreateConnection())
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand("INSERT INTO `member_has_rented_material` (`quantity`, `date_of_aquisition`, `user_id`, `material_id`) VALUES (@quantity, @date_of_aquisition, @user_id, @material_id)", conn))
                {
                    cmd.Parameters.AddWithValue("@quantity", Quantity);
                    cmd.Parameters.AddWithValue("@date_of_aquisition", DateOfAquisition);
                    cmd.Parameters.AddWithValue("@user_id", UserId);
                    cmd.Parameters.AddWithValue("@material_id", MaterialId);

                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void UpdateOnDatabase()
        {
            using (MySqlConnection conn = DataAccessHelper.CreateConnection())
            {
                conn.Open();
                using (MySqlCommand cmd = new("UPDATE `member_has_rented_material` SET `quantity`=@quantity,`date_of_aquisition`=@dateOfAquisition,`date_of_returnal`=@dateOfReturnal WHERE member_has_rented_material.user_id = @userId AND member_has_rented_material.material_id = @materialId", conn))
                {
                    cmd.Parameters.AddWithValue("@userId", UserId);
                    cmd.Parameters.AddWithValue("@materialId", MaterialId);
                    cmd.Parameters.AddWithValue("@quantity", Quantity);
                    cmd.Parameters.AddWithValue("@dateOfAquisition", DateOfAquisition);
                    cmd.Parameters.AddWithValue("@dateOfReturnal", DateOfReturnal.HasValue ? (object)DateOfReturnal.Value : DBNull.Value);
                    cmd.ExecuteNonQuery();
                }
            }
        }

    }
}
