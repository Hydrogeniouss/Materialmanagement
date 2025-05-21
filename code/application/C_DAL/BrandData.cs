using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            using (MySqlConnection conn = DataAccessHelper.CreateConnection())
            {
                conn.Open();
                using (MySqlCommand cmd = new("Select * FROM type", conn))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            types.Add(new(
                                reader.GetString("type"),
                                reader.GetInt32("type_id")
                            ));
                        }
                    }
                }
            }
            return types;
        }
    }
}
