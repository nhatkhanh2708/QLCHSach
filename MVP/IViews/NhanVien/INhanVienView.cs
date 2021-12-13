using Service.DTOs;
using System.Collections.Generic;

namespace MVP.IViews
{
    public interface INhanVienView
    {
        public void GetsAll(IEnumerable<NhanVienDTO> listNV);
        public void GetsByName(List<NhanVienDTO> listNV);
    }
}
