using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace application.C_DAL
{
    public class MaterialData
    {
        public MaterialData(int id, string name, string description, int quantityTotal, int quantityAvailable, string imageFilepath, int brandId, int typeId)
        {
            Id = id;
            Name = name;
            Description = description;
            QuantityTotal = quantityTotal;
            QuantityAvailable = quantityAvailable;
            ImageFilepath = imageFilepath;
            BrandId = brandId;
            TypeId = typeId;
        }

        public int Id { get; }
        public string Name { get; } = string.Empty;
        public string Description { get; } = string.Empty;
        public int QuantityTotal { get; }
        public int QuantityAvailable { get; }
        public string ImageFilepath { get; } = string.Empty;
        public int BrandId { get; }
        public int TypeId { get; }

    }
}
