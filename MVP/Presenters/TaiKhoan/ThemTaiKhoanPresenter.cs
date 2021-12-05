using Model.Entities;
using MVP.IViews;
using MVP.Properties;
using MVP.Utils;
using Service.DTOs;
using Service.IServices;
using System.Collections.Generic;

namespace MVP.Presenters
{
    public class ThemTaiKhoanPresenter
    {
        private ITaiKhoanService _taiKhoanService;
        private INhanVienService _nhanVienService;
        private IQuyenService _quyenService;
        private IThemTaiKhoanView _themTaiKhoanView;
        public ThemTaiKhoanPresenter(IThemTaiKhoanView themTaiKhoanView)
        {
            _themTaiKhoanView = themTaiKhoanView;
            _taiKhoanService = (ITaiKhoanService)Startup.ServiceProvider.GetService(typeof(ITaiKhoanService));
            _nhanVienService = (INhanVienService)Startup.ServiceProvider.GetService(typeof(INhanVienService));
            _quyenService = (IQuyenService)Startup.ServiceProvider.GetService(typeof(IQuyenService));
        }
        public void Add(string username, string password, string nvId, int quyenId)
        {
            if (!string.IsNullOrEmpty(username) || !_taiKhoanService.isExistByUsername(username))
            {
                var date = password.Split("/");
                var thang = date[0].Length == 1 ? "0" + date[0] : date[0];
                var ngay = date[1].Length == 1 ? "0" + date[1] : date[1];
                var pass = thang + ngay + date[2];
                var taiKhoan = new TaiKhoanDTO();
                taiKhoan.NhanVienId = int.Parse(nvId);
                taiKhoan.QuyenId = quyenId;
                taiKhoan.Username = username;
                taiKhoan.Status = true;
                _taiKhoanService.Add(taiKhoan, pass);
                _themTaiKhoanView.Notification(Notification.ADD_SUCCESSED, null, Resources.success, true);
            }
            else
                _themTaiKhoanView.Notification(Notification.ADD_FAILED, Notification.EXIST_NAME, Resources.fail, true);
        }

        public void GetsAllQuyen()
        {
            _themTaiKhoanView.GetsAllQuyen(_quyenService.GetsAll());
        }

        public void GetsNV_NotAccount()
        {
            var listTK = _taiKhoanService.GetsAll();
            var listNV = _nhanVienService.GetsAll();
            List<NhanVienDTO> listNV_NotAccount = new List<NhanVienDTO>();
            bool flag = false;
            foreach (NhanVienDTO nv in listNV)
            {
                flag = false;
                foreach (TaiKhoanDTO tk in listTK)
                {
                    if(tk.NhanVienId == nv.Id)
                    {
                        flag = true;
                        break;
                    }
                }
                if (!flag)
                {
                    listNV_NotAccount.Add(nv);
                }
                    
            }
            _themTaiKhoanView.GetsNV_NotAccount(listNV_NotAccount);
        }
    }
}
