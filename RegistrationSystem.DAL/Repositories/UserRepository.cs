using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RegistrationSystem.DAL.Concrete;
using RegistrationSystem.DAL.Interfaces;
using RegistrationSystem.Entities;

namespace RegistrationSystem.DAL.Repositories
{
    public class UserRepository : EfBaseRepositoty<User, EfDataContext>, IUserRepository
    {
        public User GetUserByLogin(string login)
        {
            User user = Context.Users.FirstOrDefault((user1 => user1.Login == login));
            return user;
        }

       
    }
}
