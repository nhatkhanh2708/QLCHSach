using Model.Entities;
using Model.IRepositories;
using System.Collections.Generic;
using System.Linq;

namespace Repository.Repositories
{
    public class QuyenRepository : EFRepository<Quyen>, IQuyenRepository
    {
        public QuyenRepository(DatabaseContext context) : base(context) { }

        public IEnumerable<Quyen> GetsByMoTa(string mota)
        {
            return _context.Quyens.Where(q => q.MoTa.Equals(mota)).ToList();
        }

        public IEnumerable<Quyen> GetsByTen(string tenquyen)
        {
            return _context.Quyens.Where(q => q.TenQuyen.Equals(tenquyen)).ToList();
        }
    }
}
