using Service.DTOs;
using System.Collections.Generic;

namespace Service.IServices
{
    public interface ITheLoaiService : IService<TheLoaiDTO>
    {
        public bool isExistByTenTheLoai(string tenTheLoai);

        public IEnumerable<TheLoaiDTO> GetByTen(string tenTheLoai);
    }
}
