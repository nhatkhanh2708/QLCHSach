using Service.DTOs;
using System.Collections.Generic;
using System.Drawing;

namespace MVP.IViews
{
    public interface ICtSachView
    {
        public void GetAllCbx(IEnumerable<NhaXuatBanDTO> listNXB,
            IEnumerable<TacGiaDTO> listTG, IEnumerable<TheLoaiDTO> listTL);

        public void Notification(string title, string description, Image img, bool flag);

        public void LoadData(IEnumerable<TacGiaDTO> listTG, IEnumerable<TheLoaiDTO> listTL,
            NhaXuatBanDTO nxb, NccDTO ncc);
    }
}
