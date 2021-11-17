using Model.Entities;
using Model.IRepositories;

namespace Repository.Repositories.NhanVienRepositories
{
    public class NhanVienRepository : EFRepository<NhanVien>, INhanVienRepository
    {
        public NhanVienRepository(DatabaseContext context) : base(context) { }
    }
}
