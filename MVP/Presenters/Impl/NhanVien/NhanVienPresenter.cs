using Model.Entities;
using MVP.IViews;
using Service.IServices;

namespace MVP.Presenters
{
    public class NhanVienPresenter : INhanVienPresenter
    {
        private readonly INhanVienService _nvService;
        private readonly INhanVienView _nvView;
        public NhanVienPresenter(INhanVienView nhanVienView)
        {
            _nvView = nhanVienView;
            _nvService = (INhanVienService)Startup.ServiceProvider.GetService(typeof(INhanVienService));
        }

        public void GetsAll()
        {
            _nvView.GetsAll(_nvService.GetsAll());
        }
    }
}
