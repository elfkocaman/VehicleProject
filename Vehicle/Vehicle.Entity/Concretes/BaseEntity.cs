using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehicle.Entity.Abstracts;

namespace Vehicle.Entity.Concretes
{
    public class BaseEntity : IBaseTable
    {
        [Key]
        public int Id { get ; set; }
        
    }
}
