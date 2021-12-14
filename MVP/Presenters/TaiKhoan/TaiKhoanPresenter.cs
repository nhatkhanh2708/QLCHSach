using Model.Entities;
using MVP.IViews;
using Service.IServices;
using System.Linq;

namespace MVP.Presenters
{
    public class TaiKhoanPresenter
    {
        private readonly ITaiKhoanService _taiKhoanService;
        private readonly INhanVienService _nhanVienService;
        private readonly ITaiKhoanView _taiKhoanView;
        public TaiKhoanPresenter(ITaiKhoanView taiKhoanView)
        {
            _taiKhoanView = taiKhoanView;
            _taiKhoanService = (ITaiKhoanService)Startup.ServiceProvider.GetService(typeof(ITaiKhoanService));
            _nhanVienService = (INhanVienService)Startup.ServiceProvider.GetService(typeof(INhanVienService));
        }

        public void GetsAllTaiKhoan()
        {
            _taiKhoanView.GetsAllTaiKhoan(_taiKhoanService.GetsAll().Where(p => p.Status != null));
        }

        public void GetsAllNhanVien()
        {
            _taiKhoanView.GetsAllNhanVien(_nhanVienService.GetsAll().Where(n => n.Status == true));
        }
    }
}
