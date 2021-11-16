using Model.IRepositories;
using Service.DTOs;
using Service.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services
{
    public class Service<T, E> : IService<T> where T : BaseDTO
    {
        private readonly E _repository;
        public Service(E repository)
        {
            _repository = repository;
        }
        public void Add(T dto)
        {
            
        }

        public void Delete(T dto)
        {
            throw new NotImplementedException();
        }

        public T GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetsAll()
        {
            throw new NotImplementedException();
        }

        public void Update(T dto)
        {
            throw new NotImplementedException();
        }
    }
}
