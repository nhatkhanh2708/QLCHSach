using Model.Entities;
using System.Collections.Generic;

namespace Model.IRepositories
{
    public interface INxbRepository : IRepository<NhaXuatBan>
    {
        IEnumerable<NhaXuatBan> GetsByTenNXB(string tenNXB);
    }
}
