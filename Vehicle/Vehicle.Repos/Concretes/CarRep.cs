using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehicle.Core;
using Vehicle.Dal;
using Vehicle.Dto;
using Vehicle.Entity.Concretes;
using Vehicle.Repos.Abstracts;

namespace Vehicle.Repos.Concretes
{
    public class CarRep<T> : BaseRepository<Car>, ICarRep
    {
        public CarRep(MyContext db) : base(db)
        {

        }


        public List<CarDto> CarDtos(int Id)
        {
            return Set().Where(x => x.Id == Id).Select(x => new CarDto
            {
                Id = x.Id,
                CarAge = x.CarAge,
                DamageRecord = x.DamageRecord,
                KM = x.Km,
                CarPrice = x.CarPrice,
                Total = (x.CarPrice) - (x.Km * 10 + x.DamageRecord),

            }).ToList();

        }

        public List<VehicleDTO> GetById(int Id)
        {
            return Set().Where(x => x.Id == Id).Select(x => new VehicleDTO
            {
                Id=x.Id,
                CarAge=x.CarAge,
                BodyType = x.BodyType,
                FuelType = x.FuelType,
                GearType = x.GearType,
                Km = x.Km,
                DamageRecord=x.DamageRecord,
                ModelBrand=x.Model.ModelName,
                ModelYear=x.Model.ModelYear,
                BrandType=x.Brand.BrandName


            }).ToList();
        }

    
        
    }
}
