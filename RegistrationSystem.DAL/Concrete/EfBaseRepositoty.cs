using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using RegistrationSystem.DAL.Interfaces;
using System.Linq.Expressions;

namespace RegistrationSystem.DAL.Concrete
{
    public class EfBaseRepositoty<T, C> :
        IRepository<T> where T : class where C : EfDataContext, new()
    {
        
        private C _entities = new C();
        public C Context => _entities;

        public virtual void Add(T entity)
        {
            _entities.Set<T>().Add(entity);
        }

        public virtual void Delete(T entity)
        {
            _entities.Set<T>().Remove(entity);
        }

        public IEnumerable<T> FindBy(Expression<Func<T, bool>> predicate)
        {
            IEnumerable<T> query = _entities.Set<T>().Where(predicate);
            return query;
        }

        public virtual IEnumerable<T> GetAll()
        {
            IEnumerable<T> query = _entities.Set<T>();
            return query;
        }

        public virtual void Update(T entity)
        {
            _entities.Entry(entity).State = EntityState.Modified;
        }

        public virtual void Save() => _entities.SaveChanges();

        #region IDisposable Support

        private bool _disposedValue = false; // To detect redundant calls

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposedValue)
            {
                if (disposing)
                {
                    _entities.Dispose();
                }

                // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
                // TODO: set large fields to null.

                _disposedValue = true;
            }
        }

        // TODO: override a finalizer only if Dispose(bool disposing) above has code to free unmanaged resources.
        // ~EfBaseRepositoty() {
        //   // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
        //   Dispose(false);
        // }

        // This code added to correctly implement the disposable pattern.
        public void Dispose()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(true);
            // TODO: uncomment the following line if the finalizer is overridden above.
             GC.SuppressFinalize(this);
        }

        #endregion
    }
}