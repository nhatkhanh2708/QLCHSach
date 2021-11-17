using System.Collections.Generic;

namespace Model.IRepositories
{
    public interface IRepository<T>
    {
        IEnumerable<T> GetsAll();
        T GetById(int id);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        void Delete(int id);
    }
}
