using Service.DTOs;
using System.Collections.Generic;
using System.Drawing;

namespace MVP.IViews
{
    public interface IThemHDNhapView
    {
        public void Notification(string title, string description, Image img, bool flag);
        public void GetsAllNCC(IEnumerable<NccDTO> listNcc);
        public void GetsSachByNccId(IEnumerable<SachDTO> listSach);
        public void GetsSachByName_NccId(IEnumerable<SachDTO> listSach);
        public void SelectedSach(SachDTO s, string tg);
        public void RmSelected(int id, decimal total);
        public void GetsAllSTG(IEnumerable<TacGiaDTO> listTG, IEnumerable<SachTacGiaDTO> listSTG);
    }
}
