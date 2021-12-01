using Service.DTOs;
using System.Collections.Generic;
using System.Drawing;

namespace MVP.IViews
{
    public interface INXBView
    {
        public void Notification(string title, string description, Image img, bool flag);
        public void GetsAll(IEnumerable<NhaXuatBanDTO> listNXB);
    }
}
