using MySql.Data.MySqlClient;
using System.Text;

namespace application.C_DAL
{
    public class MaterialData
    {
        public MaterialData(string name, string description, int quantityTotal, int quantityAvailable, BrandData brand, TypeData type, string? img_filepath, int? id = null)
        {
            Id = id;
            Name = name;
            Description = description;
            AmountTotal = quantityTotal;
            AmountAvailable = quantityAvailable;
            Brand = brand;
            Type = type;
            ImageFilepath = img_filepath;
        }


        public int? Id { get; }
        public int AmountTotal { get; }
        public int AmountAvailable { get; }
        public string Name { get; } = string.Empty;
        public string Description { get; } = string.Empty;
        public BrandData Brand { get; }
        public TypeData Type { get; }
        public string? ImageFilepath { get; } = string.Empty;


        public static MaterialData FromDatabase(int id)
        {
            List<MaterialData> materials = new();
            using (MySqlConnection conn = DataAccessHelper.CreateConnection())
            {
                conn.Open();
                using (MySqlCommand cmd = new("SELECT * FROM material " +
                        "LEFT JOIN brand ON material.brand_id = brand.brand_id " +
                        "LEFT JOIN type ON material.type_id = type.type_id WHERE material_id = @id",
                        conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            materials.Add(new(

                                reader.GetString("material"),
                                reader.GetString("description"),
                                reader.GetInt32("amount_total"),
                                reader.GetInt32("amount_available"),
                                BrandData.FromDatabase(reader.GetInt32("brand_id")),
                                TypeData.FromDatabase(reader.GetInt32("type_id")),
                                reader.IsDBNull(reader.GetOrdinal("img_filepath")) ? null : reader.GetString("img_filepath"),
                                reader.GetInt32("material_id")
                                ));
                        }
                    }

                }
                return materials[0];
            }
        }


        public static List<MaterialData> FromDatabase(MaterialFilterData? filter = null)
        {
            List<MaterialData> materials = new();
            using (MySqlConnection conn = DataAccessHelper.CreateConnection())
            {
                conn.Open();
                using (MySqlCommand cmd = new())
                {
                    StringBuilder sql = new("SELECT * FROM material " +
                        "LEFT JOIN brand ON material.brand_id = brand.brand_id " +
                        "LEFT JOIN type ON material.type_id = type.type_id");

                    if (filter != null)
                    {
                        List<string> conditions = new();

                        if (!string.IsNullOrEmpty(filter.Name))
                        {
                            conditions.Add("material.material LIKE @name");
                            cmd.Parameters.AddWithValue("@name", "%" + filter.Name + "%");
                        }

                        if (!string.IsNullOrEmpty(filter.Description))
                        {
                            conditions.Add("material.Description LIKE @description");
                            cmd.Parameters.AddWithValue("@description", "%" + filter.Description + "%");
                        }

                        if (filter.Brand != null)
                        {
                            conditions.Add("brand.brand_id = @brand_id");
                            cmd.Parameters.AddWithValue("@brand_id", filter.Brand);
                        }

                        if (filter.Type != null)
                        {
                            conditions.Add("type.type_id = @type_id");
                            cmd.Parameters.AddWithValue("@type_id", filter.Type);
                        }

                        if (conditions.Count > 0)
                        {
                            sql.Append(" WHERE " + string.Join(" AND ", conditions));
                        }
                    }

                    cmd.CommandText = sql.ToString();
                    cmd.Connection = conn;



                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            materials.Add(new(

                                reader.GetString("material"),
                                reader.GetString("description"),
                                reader.GetInt32("amount_total"),
                                reader.GetInt32("amount_available"),
                                BrandData.FromDatabase(reader.GetInt32("brand_id")),
                                TypeData.FromDatabase(reader.GetInt32("type_id")),
                                reader.IsDBNull(reader.GetOrdinal("img_filepath")) ? null : reader.GetString("img_filepath"),
                                reader.GetInt32("material_id")
                                ));
                        }
                    }

                }
                return materials;
            }
        }

        public void InsertIntoDatabase()
        {
            using (MySqlConnection conn = DataAccessHelper.CreateConnection())
            {

                conn.Open();

                using (MySqlCommand cmd = new("INSERT INTO `material`(`material`, `description`, `amount_total`, `amount_available`, `img_filepath`, `brand_id`, `type_id`) " +
                    "VALUES (@material, @description, @amountTotal,@amountAvailable, @imgFilepath, @brandId, @typeId)"))
                {
                    cmd.Parameters.AddWithValue("@material", Name);
                    cmd.Parameters.AddWithValue("@description", Description);
                    cmd.Parameters.AddWithValue("@amountTotal", AmountTotal);
                    cmd.Parameters.AddWithValue("@amountAvailable", AmountAvailable);
                    cmd.Parameters.AddWithValue("@imgFilepath", ImageFilepath);
                    cmd.Parameters.AddWithValue("@brandId", Brand.Id);
                    cmd.Parameters.AddWithValue("@typeId", Type.Id);

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

                using (MySqlCommand cmd = new MySqlCommand("DELETE FROM `material` WHERE @id", conn))
                {
                    cmd.Parameters.AddWithValue("@id", id == null ? throw new Exception("Material not in Database/materialId is null") : id);
                }
            }

        }
    }

    public sealed class MaterialFilterData
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public int? AmountTotal { get; set; }
        public int? AmountAvailable { get; set; }
        public TypeData? Brand { get; set; }
        public TypeData? Type { get; set; }
        public MaterialFilterData()
        {

        }
    }
}
