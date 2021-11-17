using Service.DTOs;
using System.Collections.Generic;

namespace Service.IServices
{
    public interface INxbService : IService<NhaXuatBanDTO>
    {
        IEnumerable<NhaXuatBanDTO> GetsByTenNXB (string tenNXB);
    }
}
