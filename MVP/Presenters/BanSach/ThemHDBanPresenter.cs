using Model.Entities;
using MVP.IViews;
using Service.IServices;
using System.Linq;

namespace MVP.Presenters
{
    public class ThemHDBanPresenter
    {
        private readonly IThemHDBanView _themHDBanView;
        private readonly ISachService _sachService;
        private readonly ISachTacGiaService _sachTGService;
        private readonly ITacGiaService _tgService;
        public ThemHDBanPresenter(IThemHDBanView themHDBanView)
        {
            _themHDBanView = themHDBanView;
            _sachService = (ISachService)Startup.ServiceProvider.GetService(typeof(ISachService));
            _sachTGService = (ISachTacGiaService)Startup.ServiceProvider.GetService(typeof(ISachTacGiaService));
            _tgService = (ITacGiaService)Startup.ServiceProvider.GetService(typeof(ITacGiaService));
        }

        public void GetsAllSach()
        {
            _themHDBanView.GetsAllSach(_sachService.GetsAll().Where(p => p.Status == true));
        }

        public void GetsAllSTG()
        {
            _themHDBanView.GetsAllSTG(_tgService.GetsAll(), _sachTGService.GetsAll());
        }
    }
}
