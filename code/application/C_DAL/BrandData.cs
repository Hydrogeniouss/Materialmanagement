using MySql.Data.MySqlClient;

namespace application.C_DAL
{
    public class BrandData
    {
        public BrandData(string name, int? id = null)
        {
            Id = id;
            Name = name;
        }

        public int? Id { get; set; }
        public string Name { get; set; }

        public static List<BrandData> FromDatabase()
        {
            return FromDatabaseBase();
        }

        public static BrandData FromDatabase(int id)
        {
            List<BrandData> brands = FromDatabaseBase(id);

            if (brands.Count == 0)
                throw new Exception("Unknown Id");

            return brands[0];
        }

        private static List<BrandData> FromDatabaseBase(int? id = null)
        {
            List<BrandData> types = new();
            if (id == null)
            {
                using (MySqlConnection conn = DataAccessHelper.CreateConnection())
                {
                    conn.Open();
                    using (MySqlCommand cmd = new("Select * FROM brand", conn))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                types.Add(new(
                                    reader.GetString("brand"),
                                    reader.GetInt32("brand_id")
                                ));
                            }
                        }
                    }
                }
                return types;
            }
            else
            {
                using (MySqlConnection conn = DataAccessHelper.CreateConnection())
                {
                    conn.Open();
                    using (MySqlCommand cmd = new("Select * FROM brand WHERE brand_id = @id", conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                types.Add(new(
                                    reader.GetString("brand"),
                                    reader.GetInt32("brand_id")
                                ));
                            }
                        }
                    }

                }
                return types;
            }


        }

        public void InsertIntoDatabase()
        {
            using (MySqlConnection conn = DataAccessHelper.CreateConnection())
            {
                conn.Open();

                using (MySqlCommand cmd = new("INSERT INTO `brand`(`brand`) " +
                    "VALUES(@brand)"))
                {
                    cmd.Parameters.AddWithValue("@brand", Name);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void DeleteOnDatabase()
            => DeleteOnDatabaseBase(Id);

        public static void DeleteOnDatabase(int id)
            => DeleteOnDatabaseBase(id);


        private static void DeleteOnDatabaseBase(int? id)
        {
            using (MySqlConnection conn = DataAccessHelper.CreateConnection())
            {
                conn.Open();

                using (MySqlCommand cmd = new MySqlCommand("DELETE FROM `brand` WHERE @id", conn))
                {
                    cmd.Parameters.AddWithValue("@id", id == null ? throw new Exception("Brand not in Database/brandId is null") : id);
                }
            }

        }

        public override string ToString() => this.Name;
    }
}
