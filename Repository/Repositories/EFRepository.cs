using Model.IRepositories;
using System.Collections.Generic;
using System.Linq;

namespace Repository.Repositories
{
    public class EFRepository<T> : IRepository<T> where T : class
    {
        protected readonly DatabaseContext _context;

        public EFRepository(DatabaseContext context)
        {
            _context = context;
        }

        public IEnumerable<T> GetsAll()
        {
            return _context.Set<T>().ToList();
        }

        public T GetById(int id)
        {
            return _context.Set<T>().Find(id);
        }

        public void Add(T entity)
        {
            _context.Set<T>().Add(entity);
            _context.SaveChanges();
        }

        public void Delete(T entity)
        {
            _context.Set<T>().Remove(entity);
            _context.SaveChanges();
        }

        public void Update(T entity)
        {
            _context.Set<T>().Update(entity);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            Delete(GetById(id));
        }
    }
}
