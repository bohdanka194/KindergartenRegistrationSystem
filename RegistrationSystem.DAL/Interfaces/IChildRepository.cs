using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RegistrationSystem.Entities;
using System.Linq.Expressions;

namespace RegistrationSystem.DAL.Interfaces
{
    interface IChildRepository
    {
        Child GetChild(Expression<Func<Child, bool>> predicate);
       
    }
}
