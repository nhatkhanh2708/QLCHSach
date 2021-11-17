using Model.Entities;
using Model.IRepositories;

namespace Repository.Repositories.SachRepositories
{
    public class SachTacGiaRepository : EFRepository<SachTacGia>, ISachTacGiaRepository
    {
        public SachTacGiaRepository(DatabaseContext context) : base(context) { }
    }
}
