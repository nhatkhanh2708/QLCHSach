using Service.DTOs;
using System.Collections.Generic;
using System.Drawing;

namespace MVP.IViews
{
    public interface ITheLoaiView
    {
        public void Notification(string title, string description, Image img, bool flag);
        public void GetsAll(IEnumerable<TheLoaiDTO> listTheLoai);
    }
}
