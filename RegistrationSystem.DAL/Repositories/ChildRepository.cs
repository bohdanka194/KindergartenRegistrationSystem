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
    public class ChildRepository : EfBaseRepositoty<Child, EfDataContext>,IChildRepository
    {
        public Child GetChild(Expression<Func<Child, bool>> predicate)
        {
            Child result = Context.Children.Where(predicate).FirstOrDefault();
            return result;
        }

        public void AddChild(Child child,string login,int number)
        {
            child.KindergartenId = (Context.Kindergartens.FirstOrDefault((kindergarten => kindergarten.Number == number))).KindergartenId;
            child.User = Context.Users.FirstOrDefault((user => user.Login == login));
            
            Context.Children.Add(child);
           
            Context.SaveChanges();
        }

      
    }
}
