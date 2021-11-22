using Model.Entities;
using Model.IRepositories;

namespace Repository.Repositories
{
    public class SachRepository : EFRepository<Sach>, ISachRepository
    {
        public SachRepository(DatabaseContext context) : base(context) { }
    }
}
