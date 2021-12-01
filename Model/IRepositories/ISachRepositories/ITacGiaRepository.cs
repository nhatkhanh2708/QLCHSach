using Model.Entities;
using System.Collections.Generic;

namespace Model.IRepositories
{
    public interface ITacGiaRepository : IRepository<TacGia>
    {
        public IEnumerable<TacGia> GetByName(string tentg, string butdanh);
    }
}
