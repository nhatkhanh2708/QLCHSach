using Model.Entities;
using Model.IRepositories.INhanVienRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repositories.NhanVienRepositories
{
    public class NhanVienRepository : EFRepository<NhanVien>, INhanVienRepository
    {
        public NhanVienRepository(DatabaseContext context) : base(context) { }
    }
}
