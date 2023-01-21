using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehicle.Core;
using Vehicle.Dal;
using Vehicle.Repos.Abstracts;

namespace Vehicle.Repos.Concretes
{
    public class ModelRep<T>:BaseRepository<Model>,IModelRep
    {
        public ModelRep(MyContext db):base(db)
        {

        }

    }
}
