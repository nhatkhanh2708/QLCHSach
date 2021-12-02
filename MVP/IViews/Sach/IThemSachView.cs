using Service.DTOs;
using System.Collections.Generic;
using System.Drawing;

namespace MVP.IViews.Sach
{
    public interface IThemSachView
    {
        public void Notification(string title, string description, Image img, bool flag);
        public void GetsAllCbx(IEnumerable<TacGiaDTO> listTG, IEnumerable<TheLoaiDTO> listTL, IEnumerable<NhaXuatBanDTO> listNXB);
        public void GetImg(Image img);
    }
}
