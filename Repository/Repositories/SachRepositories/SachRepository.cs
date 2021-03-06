using Model.Entities;
using Model.IRepositories;
using System.Collections.Generic;
using System.Linq;

namespace Repository.Repositories
{
    public class SachRepository : EFRepository<Sach>, ISachRepository
    {
        public SachRepository(DatabaseContext context) : base(context) { }

        public int Add_ReturnId(Sach entity)
        {
            var temp = _context.Sachs.Add(entity);
            _context.SaveChanges();
            return temp.Entity.Id;
        }

        public IEnumerable<Sach> GetsByName(string sach)
        {
            return _context.Sachs.Where(p => p.TenSach.StartsWith(sach) && p.Status == true)
                .Select(p => new Sach()
                {
                    Id = p.Id,
                    TenSach = p.TenSach,
                    GiaBan = p.GiaBan,
                    GiaNhap = p.GiaNhap,
                    NccId = p.NccId,
                    Status = p.Status,
                    NxbId = p.NxbId,
                    SoLuong = p.SoLuong
                })
                .ToList();
        }

        public IEnumerable<Sach> GetsByName_NccId(string sach, int nccId)
        {
            return _context.Sachs.Where(p => p.TenSach.StartsWith(sach) && p.NccId == nccId && p.Status == true)
                .Select(p => new Sach()
                {
                    Id = p.Id,
                    TenSach = p.TenSach,
                    GiaBan = p.GiaBan,
                    GiaNhap = p.GiaNhap,
                    NccId = p.NccId,
                    Status = p.Status,
                    NxbId = p.NxbId,
                    SoLuong = p.SoLuong
                })
                .ToList();
        }
    }
}
