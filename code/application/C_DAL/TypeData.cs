using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace application.C_DAL
{
    public class TypeData
    {
        public TypeData(string name, int? id = null)
        {
            Id = id;
            Name = name;
        }

        public int? Id { get; set; }
        public string Name { get; set; }


        public static List<TypeData> FromDatabase()
        {
            return FromDatabaseBase();
        }

        public static TypeData FromDatabase(int id)
        {
            List<TypeData> types = FromDatabaseBase(id);

            if (types.Count == 0)
                throw new Exception("Unknown Id");

            return types[0];
        }
        

        //TODO: Implement optional param
        private static List<TypeData> FromDatabaseBase(int? id = null)
        {
            List<TypeData> types = new();
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

        public void InsertIntoDatabase()
        {
            using (MySqlConnection conn = DataAccessHelper.CreateConnection())
            {
                conn.Open();

                using (MySqlCommand cmd = new("INSERT INTO `type`(`type`) " +
                    "VALUES(@type)"))
                {
                    cmd.Parameters.AddWithValue("@type", Name);

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

                using (MySqlCommand cmd = new MySqlCommand("DELETE FROM `type` WHERE @id", conn))
                {
                    cmd.Parameters.AddWithValue("@id", id == null ? throw new Exception("Type not in Database/typeId is null") : id);
                }
            }

        }

        public void UpdateOnDatabase()
            => UpdateOnDatabaseBase(Id);

        public static void UpdateOnDatabase(int id)
            => UpdateOnDatabaseBase(id);


        private static void UpdateOnDatabaseBase(int? id)
        {
            using (MySqlConnection conn = DataAccessHelper.CreateConnection())
            {
                conn.Open();

                using (MySqlCommand cmd = new MySqlCommand("DELETE FROM `type` WHERE @id", conn))
                {
                    cmd.Parameters.AddWithValue("@id", id == null ? throw new Exception("Type not in Database/typeId is null") : id);
                }
            }

        }
    }
}
