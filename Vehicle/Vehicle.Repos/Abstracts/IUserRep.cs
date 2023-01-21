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
    public interface IUserRep:IBaseRepository<User>
    {
        UserDto CreateUser(UserDto user);
      
        UserDto Login(string Mail, string Password);
    }
}
