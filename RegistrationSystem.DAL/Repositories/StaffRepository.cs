using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using RegistrationSystem.DAL.Concrete;
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

        public void SaveOrder()
        {
            Context.SaveChanges();
        }
    }
}
