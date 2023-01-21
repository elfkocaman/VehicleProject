using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehicle.Entity.Concretes;

namespace Vehicle.Dal
{
    public class MyContext:DbContext
    {
        
        public MyContext(DbContextOptions<MyContext> db):base(db)
        {

              
        }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Model> Models { get; set; }
        public DbSet<User>  Users { get; set; }
        

    }
}
