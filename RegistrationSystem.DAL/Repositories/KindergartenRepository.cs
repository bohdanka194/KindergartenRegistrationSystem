using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using RegistrationSystem.DAL.Concrete;
using RegistrationSystem.DAL.DTO;
using RegistrationSystem.DAL.Interfaces;
using RegistrationSystem.Entities;



namespace RegistrationSystem.DAL.Repositories
{
    public class KindergartenRepository : EfBaseRepositoty<Kindergarten, EfDataContext>, IKindetgartenRepository
    {

        public IEnumerable<Kindergarten> GetKindergartens()
        {
            var result = Context.Kindergartens.ToList();

            return result;
        }
    }
}