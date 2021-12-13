using Model.Entities;
using Model.IRepositories;
using System.Collections.Generic;
using System.Linq;

namespace Repository.Repositories
{
    public class TheLoaiRepository : EFRepository<TheLoai>, ITheLoaiRepository
    {
        public TheLoaiRepository(DatabaseContext context) : base(context) { }

        public IEnumerable<TheLoai> GetByTen(string tenTheLoai)
        {
            return _context.TheLoais.Where(q => q.TenTheLoai.StartsWith(tenTheLoai)).ToList();
        }

        public IEnumerable<TheLoai> GetByTenTheLoai(string tenTheLoai)
        {
            return _context.TheLoais.Where(q => q.TenTheLoai.Equals(tenTheLoai)).ToList();
        }
    }
}
