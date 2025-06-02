using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.ComponentModel.Design.ObjectSelectorEditor;

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
        public int? MaterialId{ get; set; }

        public static List<RentData> FromDatabase(bool isOnlyRented = false)
        {
            List<RentData> materials = new List<RentData>();

            using (MySqlConnection conn = DataAccessHelper.CreateConnection())
            {
                conn.Open();

                if (isOnlyRented) {

                    using (MySqlCommand cmd = new MySqlCommand("SELECT* FROM `member_has_rented_material` WHERE date_of_returnal IS null", conn))
                    {
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
                    using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM `member_has_rented_material`", conn))
                    {
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
    }
}
