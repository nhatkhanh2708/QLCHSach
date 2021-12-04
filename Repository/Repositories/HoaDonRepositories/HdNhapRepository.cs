using Model.Entities;
using Model.IRepositories;

namespace Repository.Repositories
{
    public class HdNhapRepository : EFRepository<HoaDonNhap>, IHdNhapRepository
    {
        public HdNhapRepository(DatabaseContext context) : base(context) { }

        public int Add_ReturnId(HoaDonNhap entity)
        {
            var temp = _context.HoaDonNhaps.Add(entity);
            _context.SaveChanges();
            return temp.Entity.Id;
        }
    }
}
