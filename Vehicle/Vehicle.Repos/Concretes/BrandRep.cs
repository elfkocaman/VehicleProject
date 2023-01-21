using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehicle.Core;
using Vehicle.Dal;
using Vehicle.Entity.Concretes;
using Vehicle.Repos.Abstracts;

namespace Vehicle.Repos.Concretes
{
    public class BrandRep<T> :BaseRepository<Brand>, IBrandRep 
    {
        public BrandRep(MyContext db):base(db)
        {
             
        }

    }
}
