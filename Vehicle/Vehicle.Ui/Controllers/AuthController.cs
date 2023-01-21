using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Vehicle.Dto;
using Vehicle.Uw;

namespace Vehicle.Ui.Controllers
{
    [Route("/[controller]/[action]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        IUow _uow;
        Response _response;

        public AuthController(IUow uow, Response response)
        {
            _uow = uow;
            _response = response;
        }

        [HttpPost]
        public Response Register(UserDto user)
        {
            user = _uow._userRep.CreateUser(user);


            if (user.Error)
            {
                _response.Error = true;
                _response.Msg = user.Msg;
            }
            else
            {
                _uow._userRep.Add(user.Map());
                var x = user.Map();
                _uow.Commit();
                _response.Error = false;
                _response.Msg = user.Msg;
                return _response;
            }


            return _response;
        }
        [HttpPost]
        public Response Login(UserDto user)
        {

            user = _uow._userRep.Login(user.Mail, user.Password);
            if (user.Error == false)
            {
                HttpContext.Session.SetString("User", JsonConvert.SerializeObject(user));
                if (user.Role == "Admin")
                {
                    _response.Error = false;
                    _response.Msg = "Admin girişi başarılı";

                }

                else
                {
                    _response.Error = false;
                    _response.Msg = "User girişi başarılı";
                }



            }
            else
            {
                _response.Error = true;
                _response.Msg = user.Msg;
            }



            return _response;
        }
        [HttpGet]
        public Response Logout()
        {
            try
            {
                HttpContext.Session.Clear();
                _response.Error = false;
                _response.Msg = "Başarılı şekilde çıkış yapıldı";
            }
            catch (Exception ex)
            {

                _response.Error = true;
                _response.Msg = ex.Message;
            }
            return _response;
        }
    }
}
