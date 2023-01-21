using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehicle.Entity.Concretes;

namespace Vehicle.Dto
{
    public class UserDto
    {

        public int Id { get; set; }
        public string? FullName { get; set; }
        public string Mail { get; set; }
        public string Password { get; set; }
        public string? Role { get; set; }
        public bool Error { get; set; }
        public string? Msg { get; set; }
        public User? User { get; set; }
        public User Map()
        {
            User user = new User();
            user.Id = Id;
            user.Mail = Mail;
            user.Password = Password;
            user.Role = Role;
            user.FullName = FullName;

            return user;
        }

    }
}
