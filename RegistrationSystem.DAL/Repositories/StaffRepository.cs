using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using RegistrationSystem.DAL.Concrete;
using RegistrationSystem.DAL.DTO;
using RegistrationSystem.DAL.Interfaces;
using RegistrationSystem.Entities;

namespace RegistrationSystem.DAL.Repositories
{
    public class StaffRepository : EfBaseRepositoty<Staff, EfDataContext>, IStaffRepository
    {
        public Staff GetStaff(Expression<Func<Staff, bool>> predicate)
        {
            Staff result = Context.Staves.Where(predicate).FirstOrDefault();
            return result;
        }

        public IEnumerable<StaffDTO> GetCurrentStaff(int number)
        {
            var result = from staff in Context.Staves
                join kin in Context.Kindergartens on staff.KindergartenId equals kin.KindergartenId
                join pos in Context.StaffPositions on staff.StaffPositionId equals pos.StaffPositionId
                where kin.Number == number
                select new StaffDTO()
                {
                    FirstName = staff.FirstName,
                    LastName = staff.LastName,
                    Position = pos.PositionName
                };
            return result;
        }

        public void SaveOrder()
        {
            Context.SaveChanges();
        }
    }
}
