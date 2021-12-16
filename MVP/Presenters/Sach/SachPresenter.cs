using Model.Entities;
using MVP.IViews;
using Service.IServices;

namespace MVP.Presenters
{
    public class SachPresenter
    {
        private readonly ISachService _sachService;
        private readonly ISachTacGiaService _sachTGService;
        private readonly ITacGiaService _tgService;
        private readonly ISachView _sachView;
        public SachPresenter(ISachView sView)
        {
            _sachView = sView;
            _sachService = (ISachService)Startup.ServiceProvider.GetService(typeof(ISachService));
            _sachTGService = (ISachTacGiaService)Startup.ServiceProvider.GetService(typeof(ISachTacGiaService));
            _tgService = (ITacGiaService)Startup.ServiceProvider.GetService(typeof(ITacGiaService));
        }

        public void GetsAll()
        {
            _sachView.GetsAll(
                _sachService.GetsByName(""),
                _tgService.GetsAll(),
                _sachTGService.GetsAll()
                );
        }

        public void GetsByName(string sach)
        {
            _sachView.GetsByName(_sachService.GetsByName(sach));
        }
    }
}
