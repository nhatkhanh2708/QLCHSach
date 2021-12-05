using Service.DTOs;
using System.Collections.Generic;

namespace MVP.IViews
{
    public interface IQuyenView
    {
        public void GetsAll(IEnumerable<QuyenDTO> listQuyen);
    }
}
