using Service.DTOs;
using System.Collections.Generic;

namespace MVP.IViews
{
    public interface IThemNCCView
    {
        public void ThemThanhCong();
        public void ThemThatBai();
        public void GetListNCC(IEnumerable<NccDTO> listNCC);
    }
}
