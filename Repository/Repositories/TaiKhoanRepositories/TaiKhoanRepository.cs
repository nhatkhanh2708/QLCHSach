using Model.Entities;
using Model.IRepositories;

namespace Repository.Repositories.TaiKhoanRepositories
{
    public class TaiKhoanRepository : EFRepository<TaiKhoan>, ITaiKhoanRepository
    {
        public TaiKhoanRepository(DatabaseContext context) : base(context) { }
    }
}
