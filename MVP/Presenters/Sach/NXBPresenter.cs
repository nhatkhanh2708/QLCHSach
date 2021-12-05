using Model.Entities;
using MVP.IViews;
using MVP.Properties;
using MVP.Utils;
using Service.DTOs;
using Service.IServices;
using System;

namespace MVP.Presenters
{
    public class NXBPresenter
    {
        private readonly INxbService _nxbService;
        private readonly INXBView _nxbView;
        public NXBPresenter(INXBView nxbView)
        {
            _nxbView = nxbView;
            _nxbService = (INxbService)Startup.ServiceProvider.GetService(typeof(INxbService));
        }

        public void Add(string tennxb, string viettat)
        {
            if (!String.IsNullOrEmpty(tennxb))
            {
                var tg = new NhaXuatBanDTO();
                tg.TenNxb = tennxb.Trim();
                tg.VietTat = viettat.Trim();
                _nxbService.Add(tg);
                _nxbView.Notification(Notification.ADD_SUCCESSED, null, Resources.success, true);
            }
            else
            {
                _nxbView.Notification(Notification.ADD_FAILED, Notification.NOT_FILL_CONTENT, Resources.fail, false);
            }
        }

        public void Delete(string id)
        {
            if (!String.IsNullOrEmpty(id))
            {
                _nxbService.Delete(int.Parse(id));
                _nxbView.Notification(Notification.DELETE_SUCCESSED, null, Resources.success, true);
            }
            else
            {
                _nxbView.Notification(Notification.DELETE_FAILED, Notification.NOT_SELECTED_ITEM, Resources.fail, false);
            }
        }

        public void GetsAll()
        {
            _nxbView.GetsAll(_nxbService.GetsAll());
        }

        public void Update(string id, string tennxb, string viettat)
        {
            if (String.IsNullOrEmpty(id))
            {
                _nxbView.Notification(Notification.DELETE_FAILED, Notification.NOT_SELECTED_ITEM, Resources.fail, false);
                return;
            }
            if (!String.IsNullOrEmpty(tennxb))
            {
                var tg = new NhaXuatBanDTO();
                tg.Id = int.Parse(id);
                tg.TenNxb = tennxb.Trim();
                tg.VietTat = viettat.Trim();
                _nxbService.Update(tg);
                _nxbView.Notification(Notification.EDIT_SUCCESSED, null, Resources.success, true);
            }
            else
            {
                _nxbView.Notification(Notification.EDIT_FAILED, Notification.NOT_FILL_CONTENT, Resources.fail, false);
            }
        }
    }
}
