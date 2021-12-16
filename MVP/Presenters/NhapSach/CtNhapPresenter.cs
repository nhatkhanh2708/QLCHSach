using Model.Entities;
using MVP.IViews;
using Service.IServices;
using System.Linq;

namespace MVP.Presenters
{
    public class CtNhapPresenter
    {
        private readonly ICtNhapView _ctNhapView;
        private readonly ICtNhapService _ctNhapService;
        private readonly INhanVienService _nhanVienService;
        private readonly ITaiKhoanService _taiKhoanService;
        private readonly ISachService _sachService;
        private readonly ITacGiaService _tacGiaService;
        private readonly ISachTacGiaService _sachTacGiaService;
        public CtNhapPresenter(ICtNhapView ctNhapView)
        {
            _ctNhapView = ctNhapView;
            _ctNhapService = (ICtNhapService)Startup.ServiceProvider.GetService(typeof(ICtNhapService));
            _nhanVienService = (INhanVienService)Startup.ServiceProvider.GetService(typeof(INhanVienService));
            _taiKhoanService = (ITaiKhoanService)Startup.ServiceProvider.GetService(typeof(ITaiKhoanService));
            _tacGiaService = (ITacGiaService)Startup.ServiceProvider.GetService(typeof(ITacGiaService));
            _sachTacGiaService = (ISachTacGiaService)Startup.ServiceProvider.GetService(typeof(ISachTacGiaService));
            _sachService = (ISachService)Startup.ServiceProvider.GetService(typeof(ISachService));
        }

        public void GetNv(int id)
        {
            _ctNhapView.GetNv(_nhanVienService.GetById(_taiKhoanService.GetById(id).NhanVienId));
        }

        public void GetsCtHd(int HdId)
        {
            _ctNhapView.GetsCtHdByHdId(_ctNhapService.GetsAll().Where(p => p.HdNhapId == HdId));
        }

        public void GetSachById(int id)
        {
            _ctNhapView.GetSachById(_sachService.GetById(id));
        }

        public void GetsAllTG_STG()
        {
            _ctNhapView.GetsAllTG_STG(_tacGiaService.GetsAll(), _sachTacGiaService.GetsAll());
        }
    }
}
