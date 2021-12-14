using Service.DTOs;
using System.Collections.Generic;

namespace MVP.IViews
{
    public interface ISachView
    {
        public void GetsAll(IEnumerable<SachDTO> listSach, IEnumerable<TacGiaDTO> listTG, IEnumerable<SachTacGiaDTO> listSTG);
    }
}
