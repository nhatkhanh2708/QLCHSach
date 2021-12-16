using Service.DTOs;
using System.Drawing;

namespace MVP.IViews
{
    public interface IXacNhanHDNhapView
    {
        public void Notification(string title, string description, Image img, bool flag);
        public void GetTenNV_Ncc(string tennv, string ncc);
        public void GetSachById(SachDTO sach);
    }
}
