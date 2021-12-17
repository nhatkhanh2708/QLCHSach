using Model.Entities;
using MVP.IViews;
using Service.IServices;
using System.Linq;

namespace MVP.Presenters
{
    public class BanPresenter
    {
        private readonly IBanView _banView;
        private readonly IHdXuatService _hdXuatService;
        private readonly INhanVienService _nvService;
        private readonly ITaiKhoanService _taikhoanService;
        public BanPresenter(IBanView banView)
        {
            _banView = banView;
            _hdXuatService = (IHdXuatService)Startup.ServiceProvider.GetService(typeof(IHdXuatService));
            _nvService = (INhanVienService)Startup.ServiceProvider.GetService(typeof(INhanVienService));
            _taikhoanService = (ITaiKhoanService)Startup.ServiceProvider.GetService(typeof(ITaiKhoanService));
        }

        public void GetsAllHdXuat()
        {
            _banView.GetsHdXuat(_hdXuatService.GetsAll().OrderByDescending(p => p.NgayTao));
        }

        public void GetNVById(int id)
        {
            _banView.GetNV(_nvService.GetById(_taikhoanService.GetById(id).NhanVienId));
        }
    }
}
