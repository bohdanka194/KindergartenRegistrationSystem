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

        public IQueryable<KindergartenDTO> GetKindergartens()
        {
            var result = from kin in Context.Kindergartens
                join add in Context.Addresses
                on kin.AddressId equals add.AddressId
                select new KindergartenDTO()
                {
                    Number = kin.Number,
                    Description = kin.Description,
                    Address = new AddressDTO()
                    {
                        City = add.City,
                        Street = add.Street,
                        House = add.House
                    }
                };
                          
       

            return result;



        }
    }
}
