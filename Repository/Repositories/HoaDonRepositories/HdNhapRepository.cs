using Model.Entities;
using Model.IRepositories;

namespace Repository.Repositories
{
    public class HdNhapRepository : EFRepository<HoaDonNhap>, IHdNhapRepository
    {
        public HdNhapRepository(DatabaseContext context) : base(context) { }
    }
}
