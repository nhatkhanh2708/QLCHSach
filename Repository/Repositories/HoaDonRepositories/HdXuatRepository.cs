using Model.Entities;
using Model.IRepositories;

namespace Repository.Repositories.HoaDonRepositories
{
    public class HdXuatRepository : EFRepository<HoaDonXuat>, IHdXuatRepository
    {
        public HdXuatRepository(DatabaseContext context) : base(context) { }
    }
}
