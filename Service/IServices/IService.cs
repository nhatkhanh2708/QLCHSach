using Service.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.IServices
{
    public interface IService<T>
    {
        IEnumerable<T> GetsAll();
        T GetById(int id);
        void Add(T dto);
        void Update(T dto);
        void Delete(T dto);
    }
}
