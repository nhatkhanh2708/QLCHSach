using Model.Entities;
using Model.IRepositories;

namespace Repository.Repositories
{
    public class NhanVienRepository : EFRepository<NhanVien>, INhanVienRepository
    {
        public NhanVienRepository(DatabaseContext context) : base(context) { }
    }
}
