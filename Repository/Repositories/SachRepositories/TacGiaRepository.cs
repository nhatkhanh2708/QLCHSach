using Model.Entities;
using Model.IRepositories;
using System.Collections.Generic;
using System.Linq;

namespace Repository.Repositories
{
    public class TacGiaRepository : EFRepository<TacGia>, ITacGiaRepository
    {
        public TacGiaRepository(DatabaseContext context) : base(context) { }

        public IEnumerable<TacGia> GetByName(string tentg, string butdanh)
        {
            return _context.TacGias.Where(q => (q.HoTen.Equals(tentg) && q.ButDanh.Equals(butdanh))).ToList();
        }
    }
}
