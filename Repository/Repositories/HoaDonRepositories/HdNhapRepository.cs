using Model.Entities;
using Model.IRepositories.IHoaDonRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repositories.HoaDonRepositories
{
    public class HdNhapRepository : EFRepository<HoaDonNhap>, IHdNhapRepository
    {
        public HdNhapRepository(DatabaseContext context) : base(context) { }
    }
}
