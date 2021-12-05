using Model.Entities;
using MVP.IViews;
using Service.IServices;

namespace MVP.Presenters
{
    public class MainPresenter
    {
        private readonly IMainView _mainView;
        private readonly INhanVienService _nhanVienService;
        private readonly IQuyenService _quyenService;
        public MainPresenter(IMainView mainView)
        {
            _mainView = mainView;
            _nhanVienService = (INhanVienService)Startup.ServiceProvider.GetService(typeof(INhanVienService));
            _quyenService = (IQuyenService)Startup.ServiceProvider.GetService(typeof(IQuyenService));
        }

        public void ShowName(int id)
        {
            _mainView.GetTenNV(_nhanVienService.GetById(id).HoTen);
        }

        public void ShowRole(int id)
        {
            var quyen = _quyenService.GetById(id);
            var funct = quyen.MoTa.Split(",");
            _mainView.GetTenQuyen(quyen.TenQuyen, funct);
        }
    }
}
