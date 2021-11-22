using Service.DTOs;
using System.Collections.Generic;

namespace MVP.IViews
{
    public interface INxbView
    {
        public void ThemThanhCong();
        public void ThemThatBai();
        public void XoaThanhCong();

        public void GetListNXB(IEnumerable<NhaXuatBanDTO> listNXB);
    }
}
