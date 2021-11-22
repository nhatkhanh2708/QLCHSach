using Model.Entities;
using Model.IRepositories;

namespace Repository.Repositories
{
    public class SachTheLoaiRepository : EFRepository<SachTheLoai>, ISachTheLoaiRepository
    {
        public SachTheLoaiRepository (DatabaseContext context) : base(context) { }
    }
}
