using Model.Entities;
using Model.IRepositories;

namespace Repository.Repositories
{
    public class TheLoaiRepository : EFRepository<TheLoai>, ITheLoaiRepository
    {
        public TheLoaiRepository(DatabaseContext context) : base(context) { }
    }
}
