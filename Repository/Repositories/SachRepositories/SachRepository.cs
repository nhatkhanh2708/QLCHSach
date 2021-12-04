using Model.Entities;
using Model.IRepositories;

namespace Repository.Repositories
{
    public class SachRepository : EFRepository<Sach>, ISachRepository
    {
        public SachRepository(DatabaseContext context) : base(context) { }

        public int Add_ReturnId(Sach entity)
        {
            var temp = _context.Sachs.Add(entity);
            _context.SaveChanges();
            return temp.Entity.Id;
        }
    }
}
