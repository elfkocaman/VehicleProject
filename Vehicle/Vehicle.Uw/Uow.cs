using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehicle.Dal;
using Vehicle.Repos.Abstracts;

namespace Vehicle.Uw
{
    public class Uow : IUow
    {
        MyContext _db;
        public Uow( MyContext db,   IBrandRep brandRep, 
            ICarRep carRep, IModelRep modelRep,  IUserRep userRep)
        {
            _db = db;
            _brandRep = brandRep;
            _carRep = carRep;
            _modelRep = modelRep;
            _userRep = userRep;
           
        }

        public IBrandRep _brandRep { get; private set; }

        public ICarRep _carRep { get; private set; }

        public IModelRep _modelRep { get; private set; }

       public IUserRep _userRep { get; private set; }
        

        public void Commit()
        {
            _db.SaveChanges();
        }
    }
}
