using Service.DTOs;
using System.Drawing;

namespace MVP.IViews
{
    public interface IXacNhanHDBanView
    {
        public void Notification(string title, string description, Image img, bool flag);
        public void GetTenNV(string tennv);
        public void GetSachById(SachDTO sach);
        public void GetHDXuatNew(HdXuatDTO hd);
    }
}
