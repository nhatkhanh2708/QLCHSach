using Model.Entities;
using MVP.IViews;
using Service.IServices;
using System.Linq;

namespace MVP.Presenters
{
    public class NhapPresenter
    {
        private readonly INhapView _nhapView;
        private readonly INccService _nccService;
        private readonly IHdNhapService _hdNhapService;
        public NhapPresenter(INhapView nhapView)
        {
            _nhapView = nhapView;
            _nccService = (INccService)Startup.ServiceProvider.GetService(typeof(INccService));
            _hdNhapService = (IHdNhapService)Startup.ServiceProvider.GetService(typeof(IHdNhapService));
        }

        public void GetsAllHdNhap()
        {
            _nhapView.GetsHdNhap(_hdNhapService.GetsAll());
        }

        public void GetsAllNcc()
        {
            _nhapView.GetsNcc(_nccService.GetsAll().Where(p => p.Status == true));
        }
    }
}
