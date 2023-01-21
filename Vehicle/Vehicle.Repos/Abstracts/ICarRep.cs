using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehicle.Core;
using Vehicle.Dto;
using Vehicle.Entity.Concretes;

namespace Vehicle.Repos.Abstracts
{
    public interface ICarRep:IBaseRepository<Car>
    {
        List<CarDto> CarDtos(int CarDtoId);
        
        List<VehicleDTO> GetById(int Id);
        

    }
}
