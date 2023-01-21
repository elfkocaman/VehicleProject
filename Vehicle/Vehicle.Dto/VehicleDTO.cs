using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle.Dto
{
    public class VehicleDTO
    {
        public int Id { get; set; }
        public int CarAge { get; set; }
        public string BodyType { get; set; }
        public string GearType { get; set; }
        public string FuelType { get; set; }
        public int Km { get; set; }
        public string BrandType { get; set; }
        public string ModelBrand { get; set; }
        public int ModelYear { get; set; }
        public int DamageRecord { get; set; }
    }
}
