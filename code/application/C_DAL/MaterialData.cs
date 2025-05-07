using MySql.Data.MySqlClient;

namespace application.C_DAL
{
    public class MaterialData
    {
        public MaterialData(int id, string name, string description, int quantityTotal, int quantityAvailable, string brand, string type, string? img_filepath)
        {
            Id = id;
            Name = name;
            Description = description;
            Amount_total = quantityTotal;
            Amount_available = quantityAvailable;
            Brand = brand;
            Type = type;
            ImageFilepath = img_filepath;
        }


        public int Id { get; }
        public int Amount_total { get; }
        public int Amount_available { get; }
        public string Name { get; } = string.Empty;
        public string Description { get; } = string.Empty;
        public string Brand { get; }
        public string Type { get; }
        public string? ImageFilepath { get; } = string.Empty;


        public static List<MaterialData> FromDatabase()
        {
            List<MaterialData> collection = new();
            using (MySqlConnection conn = DataAccessHelper.MakeConnection())
            {
                conn.Open();
                using (MySqlCommand cmd = new("Select * FROM material LEFT JOIN brand ON material.brand_id = brand.brand_id LEFT JOIN type ON material.type_id = type.type_id"))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            collection.Add(new(
                                reader.GetInt32("material_id"),
                                reader.GetString("material"),
                                reader.GetString("description"),
                                reader.GetInt32("amount_total"),
                                reader.GetInt32("amount_available"),
                                reader.GetString("brand"),
                                reader.GetString("type"),
                                reader.IsDBNull(reader.GetOrdinal("img_filepath")) ? null : reader.GetString("img_filepath")
                                ));
                        }
                    }
                }
            }
            return collection;

        }
    }
}
