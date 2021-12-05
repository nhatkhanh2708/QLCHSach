using Model.Entities;
using MVP.IViews;
using MVP.Properties;
using MVP.Utils;
using Service.DTOs;
using Service.IServices;
using System;

namespace MVP.Presenters
{
    public class ThemQuyenPresenter
    {
        private readonly IQuyenService _quyenService;
        private readonly IThemQuyenView _themQuyenView;
        public ThemQuyenPresenter(IThemQuyenView themQuyenView)
        {
            _themQuyenView = themQuyenView;
            _quyenService = (IQuyenService)Startup.ServiceProvider.GetService(typeof(IQuyenService));
        }
        public void Add(string tenquyen, string mota)
        {
            if(!String.IsNullOrEmpty(tenquyen) && !String.IsNullOrEmpty(mota))
            {
                mota = mota.Substring(0, mota.Length - 1);
                if(_quyenService.isExistMota(mota) || _quyenService.isExistTenQuyen(tenquyen))
                {
                    _themQuyenView.Notification(Notification.ADD_FAILED, Notification.EXIST_NAME, Resources.fail, false);
                    return;
                }
                var quyen = new QuyenDTO();
                quyen.TenQuyen = tenquyen;
                quyen.MoTa = mota;
                _quyenService.Add(quyen);
                _themQuyenView.Notification(Notification.ADD_SUCCESSED, null, Resources.success, true);
            }
            else
                _themQuyenView.Notification(Notification.ADD_FAILED, Notification.NOT_FILL_CONTENT, Resources.fail, false);
        }
    }
}
