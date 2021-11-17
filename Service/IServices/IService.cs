using System.Collections.Generic;

namespace Service.IServices
{
    public interface IService<T>
    {
        IEnumerable<T> GetsAll();
        T GetById(int id);
        void Add(T dto);
        void Update(T dto);
        void Delete(int id);
    }
}
