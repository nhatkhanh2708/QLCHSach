using Service.DTOs;
using System.Collections.Generic;
using System.Drawing;

namespace MVP.IViews
{
    public interface ICtNhapView
    {
        public void GetsCtHdByHdId(IEnumerable<CtNhapDTO> listCtNhap);
        public void GetNv(NhanVienDTO nv);
        public void GetsAllTG_STG(IEnumerable<TacGiaDTO> listTG, IEnumerable<SachTacGiaDTO> listSTG);
        public void GetSachById(SachDTO s);
        public void Notification(string title, string description, Image img, bool flag);
    }
}
