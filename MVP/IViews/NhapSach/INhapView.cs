using Service.DTOs;
using System.Collections.Generic;

namespace MVP.IViews
{
    public interface INhapView
    {
        public void GetsNcc(IEnumerable<NccDTO> listNcc);
        public void GetsHdNhap(IEnumerable<HdNhapDTO> listHdNhap);
    }
}
