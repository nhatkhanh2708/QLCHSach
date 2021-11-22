using System.Linq;
using Model.Entities;
using Model.IRepositories;

namespace Repository.Repositories
{
    public class TaiKhoanRepository : EFRepository<TaiKhoan>, ITaiKhoanRepository
    {
        public TaiKhoanRepository(DatabaseContext context) : base(context) { }

        public TaiKhoan GetByUsername(string username)
        {
            return _context.TaiKhoans.FirstOrDefault(u => u.Username == username);
        }
    }
}
