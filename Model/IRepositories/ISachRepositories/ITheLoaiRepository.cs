using Model.Entities;
using System.Collections.Generic;

namespace Model.IRepositories
{
    public interface ITheLoaiRepository : IRepository<TheLoai>
    {
        public IEnumerable<TheLoai> GetByTenTheLoai(string tenTheLoai);
    }
}
