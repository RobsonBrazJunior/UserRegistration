using System.Collections.Generic;

namespace UserRegistration.Repository.Interfaces
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        void Add(T entity);
        void Remove(T entity);
    }
}
