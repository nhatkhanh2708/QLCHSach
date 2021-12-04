using Model.Entities;
using Model.IRepositories;

namespace Repository.Repositories
{
    public class HdXuatRepository : EFRepository<HoaDonXuat>, IHdXuatRepository
    {
        public HdXuatRepository(DatabaseContext context) : base(context) { }

        public int Add_ReturnId(HoaDonXuat entity)
        {
            var temp = _context.HoaDonXuats.Add(entity);
            _context.SaveChanges();
            return temp.Entity.Id;
        }
    }
}
