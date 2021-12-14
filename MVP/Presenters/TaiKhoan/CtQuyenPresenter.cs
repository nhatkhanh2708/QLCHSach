using Model.Entities;
using MVP.IViews;
using MVP.Properties;
using MVP.Utils;
using Service.DTOs;
using Service.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVP.Presenters
{
    public class CtQuyenPresenter
    {
        private readonly IQuyenService _quyenService;
        private readonly ITaiKhoanService _tkService;
        private readonly ICtQuyenView _ctquyenView;
        public CtQuyenPresenter(ICtQuyenView ctquyenView)
        {
            _ctquyenView = ctquyenView;
            _quyenService = (IQuyenService)Startup.ServiceProvider.GetService(typeof(IQuyenService));
            _tkService = (ITaiKhoanService)Startup.ServiceProvider.GetService(typeof(ITaiKhoanService));
        }

        public void Update(QuyenDTO q)
        {
            if (_quyenService.isExistMota(q.MoTa))
            {
                _ctquyenView.Notification(Notification.EDIT_FAILED, Notification.EXIST_NAME, Resources.fail, false);
                return;
            }
            if (!String.IsNullOrEmpty(q.TenQuyen) && !String.IsNullOrEmpty(q.MoTa))
            {
                _quyenService.Update(q);
                _ctquyenView.Notification(Notification.EDIT_SUCCESSED, null, Resources.success, true);
            }
            else
            {
                _ctquyenView.Notification(Notification.EDIT_FAILED, Notification.EXIST_NAME, Resources.fail, false);
            }
            
        }

        public void Delete(int id)
        {            
            var listtk = _tkService.GetsAll();
            foreach(TaiKhoanDTO tk in listtk)
            {
                if(tk.QuyenId == id)
                {
                    _ctquyenView.Notification(Notification.DELETE_FAILED, "Do có tài khoản đang sử dụng ! ", Resources.fail, false);
                    return;
                }
            }
            _quyenService.Delete(id);
            _ctquyenView.Notification(Notification.DELETE_SUCCESSED, null, Resources.success, true);
        }
    }
}
