using Service.DTOs;
using System.Collections.Generic;

namespace MVP.IViews
{
    public interface ITaiKhoanView
    {
        public void GetsAllTaiKhoan(IEnumerable<TaiKhoanDTO> listTK);
        public void GetsAllNhanVien(IEnumerable<NhanVienDTO> listNV);
    }
}
