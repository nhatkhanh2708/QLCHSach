using Model.Entities;
using Model.IRepositories;

namespace Repository.Repositories
{
    public class SachTacGiaRepository : EFRepository<SachTacGia>, ISachTacGiaRepository
    {
        public SachTacGiaRepository(DatabaseContext context) : base(context) { }
    }
}
