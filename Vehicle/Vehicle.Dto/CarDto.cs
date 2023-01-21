using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 

namespace Vehicle.Dto
{
    public class CarDto
    {
        [Key]
        public int Id { get; set; }
        public int CarPrice { get; set; }
        public int CarAge { get; set; }
        public decimal DamageRecord { get; set; }
        public int KM { get; set; }
        public decimal Total { get; set; }

    }
}
