using Model.Entities;
using MVP.IViews;
using MVP.Properties;
using MVP.Utils;
using Service.DTOs;
using Service.IServices;
using System;

namespace MVP.Presenters
{
    public class TheLoaiPresenter
    {
        private readonly ITheLoaiService _theLoaiService;
        private readonly ITheLoaiView _theLoaiView;
        public TheLoaiPresenter(ITheLoaiView theLoaiView)
        {
            _theLoaiView = theLoaiView;
            _theLoaiService = (ITheLoaiService)Startup.ServiceProvider.GetService(typeof(ITheLoaiService));
        }

        public void Add(string tenTheLoai)
        {
            if (!String.IsNullOrEmpty(tenTheLoai))
            {
                tenTheLoai = tenTheLoai.Trim();
                if (!_theLoaiService.isExistByTenTheLoai(tenTheLoai))
                {
                    var theLoai = new TheLoaiDTO();
                    theLoai.TenTheLoai = tenTheLoai;
                    _theLoaiService.Add(theLoai);
                    _theLoaiView.Notification(Notification.ADD_SUCCESSED, null, Resources.success, true);
                }
                else
                {
                    _theLoaiView.Notification(Notification.ADD_FAILED, Notification.EXIST_NAME, Resources.success, false);
                }
            }
            else
            {
                _theLoaiView.Notification(Notification.ADD_FAILED, Notification.NOT_FILL_CONTENT, Resources.fail, false);
            }
        }

        public void Delete(string id)
        {
            if(!String.IsNullOrEmpty(id))
            {
                _theLoaiService.Delete(int.Parse(id));
                _theLoaiView.Notification(Notification.DELETE_SUCCESSED, null, Resources.success, true);
            }
            else
            {
                _theLoaiView.Notification(Notification.DELETE_FAILED, Notification.NOT_SELECTED_ITEM, Resources.fail, false);
            }
        }

        public void GetsAll()
        {
            _theLoaiView.GetsAll(_theLoaiService.GetsAll());
        }

        public void Update(string id, string tenTheLoai)
        {
            if (!String.IsNullOrEmpty(id))
            {
                tenTheLoai = tenTheLoai.Trim();
                if (!_theLoaiService.isExistByTenTheLoai(tenTheLoai))
                {
                    var theLoai = new TheLoaiDTO();
                    theLoai.Id = int.Parse(id);
                    theLoai.TenTheLoai = tenTheLoai;
                    _theLoaiService.Update(theLoai);
                    _theLoaiView.Notification(Notification.EDIT_SUCCESSED, null, Resources.success, true);
                }
                else
                {
                    _theLoaiView.Notification(Notification.EDIT_FAILED, Notification.EXIST_NAME, Resources.fail, false);
                }
            }                
            else
            {
                _theLoaiView.Notification(Notification.EDIT_FAILED, Notification.NOT_SELECTED_ITEM, Resources.fail, false);
            }
        }
    }
}
