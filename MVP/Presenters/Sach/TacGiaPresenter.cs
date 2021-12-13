using Model.Entities;
using MVP.IViews;
using MVP.Properties;
using MVP.Utils;
using Service.DTOs;
using Service.IServices;
using System;

namespace MVP.Presenters
{
    public class TacGiaPresenter
    {
        private readonly ITacGiaService _tacGiaService;
        private readonly ITacGiaView _tacGiaView;
        public TacGiaPresenter(ITacGiaView tacGiaView)
        {
            _tacGiaView = tacGiaView;
            _tacGiaService = (ITacGiaService)Startup.ServiceProvider.GetService(typeof(ITacGiaService));
        }

        public void Add(string tentg, string butdanh)
        {
            if (!String.IsNullOrEmpty(tentg) && !String.IsNullOrEmpty(butdanh))
            {
                if (!_tacGiaService.isExistByName(tentg, butdanh))
                {
                    var tg = new TacGiaDTO();
                    tg.HoTen = tentg.Trim();
                    tg.ButDanh = butdanh.Trim();
                    _tacGiaService.Add(tg);
                    _tacGiaView.Notification(Notification.ADD_SUCCESSED, null, Resources.success, true);
                }
                else
                {
                    _tacGiaView.Notification(Notification.ADD_FAILED, Notification.EXIST_NAME, Resources.success, false);
                }
            }
            else
            {
                _tacGiaView.Notification(Notification.ADD_FAILED, Notification.NOT_FILL_CONTENT, Resources.fail, false);
            }
        }

        public void Delete(string id)
        {
            if (!String.IsNullOrEmpty(id))
            {
                _tacGiaService.Delete(int.Parse(id));
                _tacGiaView.Notification(Notification.DELETE_SUCCESSED, null, Resources.success, true);
            }
            else
            {
                _tacGiaView.Notification(Notification.DELETE_FAILED, Notification.NOT_SELECTED_ITEM, Resources.fail, false);
            }
        }

        public void GetsAll()
        {
            _tacGiaView.GetsAll(_tacGiaService.GetsAll());
        }

        public void Update(string id, string tentg, string butdanh)
        {
            if (String.IsNullOrEmpty(id))
            {
                _tacGiaView.Notification(Notification.DELETE_FAILED, Notification.NOT_SELECTED_ITEM, Resources.fail, false);
                return;
            }
            if (!String.IsNullOrEmpty(tentg) && !String.IsNullOrEmpty(butdanh))
            {
                tentg = tentg.Trim();
                butdanh = butdanh.Trim();
                if (!_tacGiaService.isExistByName(tentg, butdanh))
                {
                    var tg = new TacGiaDTO();
                    tg.Id = int.Parse(id);
                    tg.HoTen = tentg.Trim();
                    tg.ButDanh = butdanh.Trim();
                    _tacGiaService.Update(tg);
                    _tacGiaView.Notification(Notification.EDIT_SUCCESSED, null, Resources.success, true);                    
                }
                else
                {
                    _tacGiaView.Notification(Notification.EDIT_FAILED, Notification.EXIST_NAME, Resources.success, false);
                }
            }
            else
            {
                _tacGiaView.Notification(Notification.EDIT_FAILED, Notification.NOT_FILL_CONTENT, Resources.fail, false);
            }
        }

        public void GetByTen(string tg)
        {
            if (!String.IsNullOrEmpty(tg))
            {
                _tacGiaView.GetByTen(_tacGiaService.GetByTen(tg));
            }
            else
            {
                _tacGiaView.GetByTen(_tacGiaService.GetsAll());
            }
        }
    }
}
