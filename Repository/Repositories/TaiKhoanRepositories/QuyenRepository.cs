using Model.Entities;
using Model.IRepositories;
using System.Linq;

namespace Repository.Repositories
{
    public class QuyenRepository : EFRepository<Quyen>, IQuyenRepository
    {
        public QuyenRepository(DatabaseContext context) : base(context) { }

        public Quyen GetsByMoTa(string mota)
        {
            return _context.Quyens.FirstOrDefault(q => q.MoTa.Equals(mota));
        }

        public Quyen GetsByTen(string tenquyen)
        {
            return _context.Quyens.FirstOrDefault(q => q.TenQuyen.Equals(tenquyen));
        }
    }
}
