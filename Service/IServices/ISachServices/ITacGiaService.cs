using Service.DTOs;
using System.Collections.Generic;

namespace Service.IServices
{
    public interface ITacGiaService : IService<TacGiaDTO>
    {
        public bool isExistByName(string tentg, string butdanh);
        public IEnumerable<TacGiaDTO> GetByTen(string tg);
    }
}
