using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RegistrationSystem.Entities;

namespace RegistrationSystem.DAL.Interfaces
{
    interface IUserRepository
    {
        User GetUserByLogin(string login);
    }
}
