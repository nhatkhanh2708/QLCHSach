using Service.DTOs;
using System.Collections.Generic;
using System.Drawing;

namespace MVP.IViews
{
    public interface IThemTaiKhoanView
    {
        public void Notification(string title, string description, Image img, bool flag);
        public void GetsNV_NotAccount(IEnumerable<NhanVienDTO> listNV);
        public void GetsAllQuyen(IEnumerable<QuyenDTO> listQuyen);
    }
}
