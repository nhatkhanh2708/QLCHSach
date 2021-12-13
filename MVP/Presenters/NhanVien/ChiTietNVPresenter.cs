using Model.Entities;
using MVP.IViews;
using MVP.Properties;
using MVP.Utils;
using Service.DTOs;
using Service.IServices;

namespace MVP.Presenters
{
    public class ChiTietNVPresenter
    {
        private readonly INhanVienService _nvService;
        private readonly IChiTietNVView _ctnvView;
        private readonly IQuyenService _quyenService;
        private readonly ITaiKhoanService _tkService;
        public ChiTietNVPresenter(IChiTietNVView ctnhanVienView)
        {
            _ctnvView = ctnhanVienView;
            _nvService = (INhanVienService)Startup.ServiceProvider.GetService(typeof(INhanVienService));
            _quyenService = (IQuyenService)Startup.ServiceProvider.GetService(typeof(IQuyenService));
            _tkService = (ITaiKhoanService)Startup.ServiceProvider.GetService(typeof(ITaiKhoanService));
        }

        public void DeleteNV(int id)
        {
            _nvService.UpdateStatus(id);
            var tk = _tkService.GetByNVId(id);
            tk.Status = false;
            _tkService.Update(tk);
        }

        public void UpdateNV(NhanVienDTO nv, int quyenid)
        {
            if(quyenid != -1)
            {
                var tk = _tkService.GetByNVId(nv.Id);
                tk.QuyenId = quyenid;
                _tkService.Update(tk);
                var q = _quyenService.GetById(quyenid);
                nv.ChucVu = q.TenQuyen;
            }
            _nvService.Update(nv);
            _ctnvView.Notification(Notification.EDIT_SUCCESSED, null, Resources.success, true);
        }

        public void isExistTaiKhoanNV(int id)
        {
            _ctnvView.isExistTaiKhoanNV(_tkService.GetByNVId(id) != null);
        }

        public void GetAllChucVu()
        {
            _ctnvView.GetAllChucVu(_quyenService.GetsAll());
        }
    }
}
