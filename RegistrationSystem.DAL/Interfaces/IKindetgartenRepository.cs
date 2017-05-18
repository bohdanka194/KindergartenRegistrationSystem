using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RegistrationSystem.DAL.DTO;
using RegistrationSystem.Entities;

namespace RegistrationSystem.DAL.Interfaces
{
    interface IKindetgartenRepository
    {
        IEnumerable<Kindergarten> GetKindergartens();
    }
}
