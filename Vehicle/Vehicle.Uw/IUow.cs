using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehicle.Repos.Abstracts;

namespace Vehicle.Uw
{
    public interface IUow
    { 
        IBrandRep _brandRep { get; }
        ICarRep _carRep { get; }
        IModelRep _modelRep { get; }
       
        IUserRep _userRep { get; }
        void Commit();
    }
}
