using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehicle.Entity.Abstracts;

namespace Vehicle.Entity.Concretes
{
    public class User : BaseEntity
    {
        public string? FullName { get; set; }
        public string Mail { get; set; }
        public string Password { get; set; }
        public bool Error { get; set; }
        public string Role { get; set; }

    }
}
