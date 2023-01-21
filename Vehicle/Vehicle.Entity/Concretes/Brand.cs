using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle.Entity.Concretes
{
    public class Brand : BaseEntity
    {
        public string BrandName { get; set; }
        public ICollection<Car> Cars { get; set; }
    }
}
