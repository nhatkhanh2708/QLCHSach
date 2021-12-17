using Service.DTOs;
using System.Collections.Generic;

namespace MVP.IViews
{
    public interface ICtXuatView
    {
        public void GetsCtHdByHdId(IEnumerable<CtXuatDTO> listCtXuat);
        public void GetsAllTG_STG(IEnumerable<TacGiaDTO> listTG, IEnumerable<SachTacGiaDTO> listSTG);
        public void GetSachById(SachDTO s);
    }
}
