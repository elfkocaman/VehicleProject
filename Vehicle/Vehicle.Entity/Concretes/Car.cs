using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehicle.Entity.Abstracts;

namespace Vehicle.Entity.Concretes
{
    public class Car : BaseEntity
    {
        public int CarAge { get; set; }
        public string BodyType { get; set; }
        public string GearType { get; set; }
        public string FuelType { get; set; }
        public int Km { get; set; }
        public int DamageRecord { get; set; }
        public int CarPrice { get; set; }
        public int ModelId { get; set; }
        [ForeignKey("ModelId")]
        public Model? Model { get; set; }
        public int BrandId { get; set; }
        [ForeignKey("BrandId")]
        public Brand? Brand { get; set; }
        public int UserId { get; set; }
        [ForeignKey("UserId")]
        public User? User { get; set; }

    }
}
