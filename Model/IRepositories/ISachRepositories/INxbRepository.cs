using Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.IRepositories.ISachRepositories
{
    public interface INxbRepository : IRepository<NhaXuatBan>
    {
        IEnumerable<NhaXuatBan> GetsByTenNXB(String tenNXB);
    }
}
