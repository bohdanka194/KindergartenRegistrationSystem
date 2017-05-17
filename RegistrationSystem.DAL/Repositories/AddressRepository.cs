using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RegistrationSystem.DAL.Concrete;
using RegistrationSystem.Entities;

namespace RegistrationSystem.DAL.Repositories
{
    public class AddressRepository:EfBaseRepositoty<Address,EfDataContext>
    {
    }
}
