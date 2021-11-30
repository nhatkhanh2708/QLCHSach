using Model.Entities;
using MVP.IViews;
using MVP.Properties;
using MVP.Utils;
using Service.DTOs;
using Service.IServices;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVP.Presenters
{
    public class TheLoaiPresenter : ITheLoaiPresenter
    {
        private readonly ITheLoaiService _theLoaiService;
        private readonly ITheLoaiView _theLoaiView;
        public TheLoaiPresenter(ITheLoaiView theLoaiView)
        {
            _theLoaiView = theLoaiView;
            _theLoaiService = (ITheLoaiService)Startup.ServiceProvider.GetService(typeof(ITheLoaiService));
        }

        public void AddCategory(string tenTheLoai)
        {
            if (!String.IsNullOrEmpty(tenTheLoai))
            {
                if (!_theLoaiService.isExistByTenTheLoai(tenTheLoai))
                {
                    var theLoai = new TheLoaiDTO();
                    theLoai.TenTheLoai = tenTheLoai.Trim();
                    _theLoaiService.Add(theLoai);
                    _theLoaiView.Notification(Notification.ADD_SUCCESSED, null, Resources.success);
                }
                else
                    _theLoaiView.Notification(Notification.ADD_FAILED, Notification.EXIST_NAME, Resources.success);
            }
            else
            {
                _theLoaiView.Notification(Notification.ADD_FAILED, "Chưa nhập nội dung", Resources.fail);
            }
        }

        public void DeleteCategory(string id)
        {
            if(!String.IsNullOrEmpty(id))
            {
                _theLoaiService.Delete(int.Parse(id));
                _theLoaiView.Notification(Notification.DELETE_SUCCESSED, null, Resources.success);
            }
            else
            {
                _theLoaiView.Notification(Notification.DELETE_FAILED, "Chưa chọn item", Resources.fail);
            }
        }

        public void GetsAll()
        {
            _theLoaiView.GetsAll(_theLoaiService.GetsAll());
        }

        public void UpdateCategory(string id, string tenTheLoai)
        {
            if (!String.IsNullOrEmpty(id))
            {
                var theLoai = new TheLoaiDTO();
                theLoai.Id = int.Parse(id);
                theLoai.TenTheLoai = tenTheLoai.Trim();
                _theLoaiService.Update(theLoai);
                _theLoaiView.Notification(Notification.EDIT_SUCCESSED, null, Resources.success);
            }
            else
            {
                _theLoaiView.Notification(Notification.EDIT_FAILED, "Chưa chọn item", Resources.fail);
            }
        }
    }
}
