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
    public class UserRep<T>:BaseRepository<User>,IUserRep
    {
        MyContext _db;
        public UserRep(MyContext db):base(db)
        {
            _db=db;
        }


        public UserDto CreateUser(UserDto user)
        {
            
            User selectedUser = _db.Set<User>().FirstOrDefault(x => x.Mail == user.Mail);
            if (selectedUser != null)
            {
                user.Error = true;
                user.Msg = "Böyle bir kullanıcı zaten mevcut...";
            }
            else
            {
                user.Error = false;
                user.Msg = "Kaydınız başarıyla eklendi";
            }
            user.Password = BCrypt.Net.BCrypt.HashPassword(user.Password);
            user.Role = "User";
            
            return user;
        }

        public UserDto Login(string Mail, string Password)
        {
            User selectedUser = _db.Set<User>().FirstOrDefault(x => x.Mail == Mail);
            UserDto user = new UserDto();
            user.Mail = Mail;
            if (selectedUser != null)
            {

                user.Error = false;
               
                bool verified = BCrypt.Net.BCrypt.Verify(Password, selectedUser.Password);
                if (verified == true)
                {

                    user.Role = selectedUser.Role;
                    user.Id = selectedUser.Id;
                    user.Error = false;
                }
                else user.Error = true;
            }
            else
            {
                user.Error = true;
                user.Msg = "Böyle bir kullanıcı bulunamadı...";
            }
                
            return user;

           
        }

      


    }
}
