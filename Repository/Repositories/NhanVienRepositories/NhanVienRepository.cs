using Model.Entities;
using Model.IRepositories;

namespace Repository.Repositories
{
    public class NhanVienRepository : EFRepository<NhanVien>, INhanVienRepository
    {
        public NhanVienRepository(DatabaseContext context) : base(context) { }

        public int Add_ReturnId(NhanVien entity)
        {
            var temp = _context.NhanViens.Add(entity);
            _context.SaveChanges();
            return temp.Entity.Id;
        }
    }
}
