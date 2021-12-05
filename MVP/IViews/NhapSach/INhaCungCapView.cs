using Service.DTOs;
using System.Collections.Generic;

namespace MVP.IViews
{
    public interface INhaCungCapView
    {
        public void GetsAll(IEnumerable<NccDTO> listNcc);
    }
}
