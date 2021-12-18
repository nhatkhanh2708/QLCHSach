using Service.DTOs;
using System.Drawing;

namespace MVP.IViews
{
    public interface IXacNhanHDNhapView
    {
        public void Notification(string title, string description, Image img, bool flag);
        public void GetTenNV_Ncc(NhanVienDTO nv, NccDTO ncc);
        public void GetSachById(SachDTO sach);
        public void GetHDNhapNew(HdNhapDTO hdNhapDTO);
    }
}
