using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle.Entity.Concretes
{
    public class Model : BaseEntity
    {
        public int ModelYear { get; set; }
        public string ModelName { get; set; }
        public ICollection<Car> Cars { get; set; }
    }
}
