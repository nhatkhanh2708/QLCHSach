using Model.Entities;
using Model.IRepositories;

namespace Repository.Repositories.SachRepositories
{
    public class TacGiaRepository : EFRepository<TacGia>, ITacGiaRepository
    {
        public TacGiaRepository(DatabaseContext context) : base(context) { }
    }
}
