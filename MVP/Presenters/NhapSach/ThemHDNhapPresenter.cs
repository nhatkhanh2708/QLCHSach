using Model.Entities;
using MVP.IViews;
using Service.IServices;
using System.Linq;

namespace MVP.Presenters
{
    public class ThemHDNhapPresenter
    {
        private readonly IThemHDNhapView _themHDNhapView;
        private readonly INccService _nccService;
        private readonly ISachService _sachService;
        private readonly ISachTacGiaService _sachTGService;
        private readonly ITacGiaService _tgService;
        public ThemHDNhapPresenter(IThemHDNhapView themHDNhapView)
        {
            _themHDNhapView = themHDNhapView;
            _nccService = (INccService)Startup.ServiceProvider.GetService(typeof(INccService));
            _sachService = (ISachService)Startup.ServiceProvider.GetService(typeof(ISachService));
            _sachTGService = (ISachTacGiaService)Startup.ServiceProvider.GetService(typeof(ISachTacGiaService));
            _tgService = (ITacGiaService)Startup.ServiceProvider.GetService(typeof(ITacGiaService));
        }

        public void GetsAllNcc()
        {
            _themHDNhapView.GetsAllNCC(_nccService.GetsAll().Where(p => p.Status == true));
        }

        public void GetsSachByNccId(int nccId)
        {
            _themHDNhapView.GetsSachByNccId(_sachService.GetsByName_NccId("", nccId));
        }

        public void GetsSachByName_NccId(string sach, int nccId)
        {
            _themHDNhapView.GetsSachByName_NccId(_sachService.GetsByName_NccId(sach, nccId));
        }

        public void GetsAllSTG()
        {
            _themHDNhapView.GetsAllSTG(_tgService.GetsAll(), _sachTGService.GetsAll());
        }
    }
}
