using Service.DTOs;
using System.Collections.Generic;
using System.Drawing;

namespace MVP.IViews
{
    public interface IChiTietNVView
    {
        public void GetAllChucVu(IEnumerable<QuyenDTO> listQuyen);
        public void Notification(string title, string description, Image img, bool flag);
        public void isExistTaiKhoanNV(bool isExist);
    }
}
