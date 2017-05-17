using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RegistrationSystem.Entities;
using System.Linq.Expressions;

namespace RegistrationSystem.DAL.Interfaces
{
    interface IStaffRepository
    {
        Staff GetStaff(Expression<Func<Staff, bool>> predicate);
        void SaveOrder();
    }
}
