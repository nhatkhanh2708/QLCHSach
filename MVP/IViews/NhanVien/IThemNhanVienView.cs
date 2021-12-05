using System.Drawing;

namespace MVP.IViews
{
    public interface IThemNhanVienView
    {
        public void Notification(string title, string description, Image img, bool flag);
        //public void GetsAllCbx(IEnumerable<QuyenDTO> listQ);
    }
}
