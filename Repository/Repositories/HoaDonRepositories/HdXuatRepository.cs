using Model.Entities;
using Model.IRepositories.IHoaDonRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repositories.HoaDonRepositories
{
    public class HdXuatRepository : EFRepository<HoaDonXuat>, IHdXuatRepository
    {
        public HdXuatRepository(DatabaseContext context) : base(context) { }
    }
}
