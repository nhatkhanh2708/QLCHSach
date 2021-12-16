using Service.DTOs;
using System.Collections.Generic;

namespace MVP.IViews
{
    public interface ICtNhapView
    {
        public void GetsCtHdByHdId(IEnumerable<CtNhapDTO> listCtNhap);
        public void GetNv(NhanVienDTO nv);
        public void GetsAllTG_STG(IEnumerable<TacGiaDTO> listTG, IEnumerable<SachTacGiaDTO> listSTG);
        public void GetSachById(SachDTO s);
    }
}
