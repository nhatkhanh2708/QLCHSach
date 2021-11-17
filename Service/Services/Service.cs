using Service.IServices;
using System;
using System.Collections.Generic;

namespace Service.Services
{
    public class Service<T, E> : IService<T> where T : class
    {
        private readonly E _repository;
        public Service(E repository)
        {
            _repository = repository;
        }
        public void Add(T dto)
        {
            
        }

        public void Delete(int id)
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

        public bool isExistById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(T dto)
        {
            throw new NotImplementedException();
        }
    }
}
