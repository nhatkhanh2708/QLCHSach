using Service.DTOs;
using System.Collections.Generic;

namespace MVP.IViews
{
    public interface IBanView
    {
        public void GetNV(NhanVienDTO nhanVienDTO);
        public void GetsHdXuat(IEnumerable<HdXuatDTO> listHdXuat);
    }
}
