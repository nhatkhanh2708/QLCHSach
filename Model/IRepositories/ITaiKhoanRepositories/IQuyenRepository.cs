using Model.Entities;
using System.Collections.Generic;

namespace Model.IRepositories
{
    public interface IQuyenRepository : IRepository<Quyen>
    {
        IEnumerable<Quyen> GetsByTen(string tenquyen);
        IEnumerable<Quyen> GetsByMoTa(string mota);
    }
}
