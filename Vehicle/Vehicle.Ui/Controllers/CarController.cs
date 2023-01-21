using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;
using Vehicle.Dal;
using Vehicle.Dto;
using Vehicle.Entity.Concretes;
using Vehicle.Uw;

namespace Vehicle.Ui.Controllers
{
    [Route("/[controller]/[action]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        MyContext _db;
        IUow _uow;
        Response _response;


        public CarController(MyContext db, IUow uow, Response response)
        {
            _db = db;
            _uow = uow;
            _response = response;
        }


        [HttpGet("{id:int}")]
        public Car GetCar(int id)
        {
            return _db.Set<Car>().Find(id);
        }



        [HttpGet("{id:int}")]
        public List<VehicleDTO> GetById(int id)
        {
            return _uow._carRep.GetById(id);

            
        }


        [HttpPost]
        public Response Add(Car car)
        {
            try
            {
                _db.Set<Car>().Add(car);
                _db.SaveChanges();
                _response.Error = false;
                _response.Msg = "Başarılı şekilde eklendi";

            }
            catch (Exception ex)
            {

                _response.Error = true;
                _response.Msg = ex.Message;
                throw;
            }
            return _response;
        }
        [HttpPut]
        public Response Update(Car car)
        {
            try
            {

                _db.Set<Car>().Update(car);
                _db.SaveChanges();
                _response.Error = false;
                _response.Msg = "Başarılı şekilde güncellendi";

            }
            catch (Exception ex)
            {

                _response.Error = true;
                _response.Msg = ex.Message;
            }
            return _response;
        }
        [HttpDelete]
        public Response Delete(Car car)
        {
            try
            {
                _db.Set<Car>().Remove(car);
                _db.SaveChanges();
                _response.Error=false;
                _response.Msg = "Başarılı şekilde silindi";

            }
            catch (Exception ex)
            {

                _response.Error = true;
                _response.Msg=ex.Message;  
            }
            return _response;
        }
        [HttpDelete("{Id:int}")]
        public Response DeletebyId(int Id)
        {
            return Delete(GetCar(Id));
        }

    }
}
