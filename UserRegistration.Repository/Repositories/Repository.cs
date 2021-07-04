using System.Collections.Generic;
using System.Linq;
using UserRegistration.Repository.Interfaces;

namespace UserRegistration.Repository.Repositories
{
    public abstract class Repository<T> : IRepository<T> where T : class
    {
        protected IList<T> _lista = new List<T>();

        public virtual void Add(T entity)
        {
            _lista.Add(entity);
        }

        public virtual IEnumerable<T> GetAll()
        {
            return _lista.AsEnumerable();
        }

        public virtual void Remove(T entity)
        {
            _lista.Remove(entity);
        }
    }
}
