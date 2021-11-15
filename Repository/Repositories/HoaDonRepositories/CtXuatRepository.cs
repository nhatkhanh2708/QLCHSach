using Model.Entities;
using Model.IRepositories.IHoaDonRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repositories.HoaDonRepositories
{
    public class CTXuatRepository : EFRepository<ChiTietXuat>, ICtXuatRepository
    {
        public CTXuatRepository(DatabaseContext context) : base(context) { }
    }
}
