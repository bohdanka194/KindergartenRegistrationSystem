using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Linq;
using System.Net.Sockets;
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

        public bool IsUserExist(string login, string password)
        {
            var result = from user in Context.Users
                where user.Login == login && user.Password == password
                select user;
            if (result.Any())
            {
                return true;
            }
            return false;
        }

        public bool IsLoginAvailable(string login)
        {
            var result = from user in Context.Users
                where user.Login == login
                select user;
            if (result.Any())
            {
                return false;
            }
            return true;
        }
    }
}