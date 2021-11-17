using Model.Entities;
using Model.IRepositories;

namespace Repository.Repositories.HoaDonRepositories
{
    public class HdNhapRepository : EFRepository<HoaDonNhap>, IHdNhapRepository
    {
        public HdNhapRepository(DatabaseContext context) : base(context) { }
    }
}
