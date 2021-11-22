using Model.Entities;
using Model.IRepositories;

namespace Repository.Repositories
{
    public class CTXuatRepository : EFRepository<ChiTietXuat>, ICtXuatRepository
    {
        public CTXuatRepository(DatabaseContext context) : base(context) { }
    }
}
