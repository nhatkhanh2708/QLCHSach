using Service.DTOs.SachDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.IServices.ISachServices
{
    public interface INxbService : IService<NhaXuatBanDTO>
    {
        IEnumerable<NhaXuatBanDTO> GetsByTenNXB (string tenNXB);
    }
}
