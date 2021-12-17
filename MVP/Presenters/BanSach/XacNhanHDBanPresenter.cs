using Model.Entities;
using MVP.IViews;
using MVP.Properties;
using Service.DTOs;
using Service.IServices;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MVP.Presenters
{
    public class XacNhanHDBanPresenter
    {
        private readonly IXacNhanHDBanView _xacNhanHDBanView;
        private readonly INhanVienService _nhanVienService;
        private readonly IHdXuatService _hdXuatService;
        private readonly ICtXuatService _ctXuatService;
        private readonly ISachService _sachService;
        public XacNhanHDBanPresenter(IXacNhanHDBanView xacNhanHDBanView)
        {
            _xacNhanHDBanView = xacNhanHDBanView;
            _nhanVienService = (INhanVienService)Startup.ServiceProvider.GetService(typeof(INhanVienService));
            _hdXuatService = (IHdXuatService)Startup.ServiceProvider.GetService(typeof(IHdXuatService));
            _ctXuatService = (ICtXuatService)Startup.ServiceProvider.GetService(typeof(ICtXuatService));
            _sachService = (ISachService)Startup.ServiceProvider.GetService(typeof(ISachService));
        }
        public void GetTenNV(int nvId)
        {
            _xacNhanHDBanView.GetTenNV(_nhanVienService.GetById(nvId).HoTen);
        }

        public void GetSachById(int sachId)
        {
            _xacNhanHDBanView.GetSachById(_sachService.GetById(sachId));
        }

        public void AddHDXuat(Dictionary<int, int> sachSelected, int taikhoanId, decimal totalPrice)
        {
            HdXuatDTO hdXuat = new HdXuatDTO();
            hdXuat.NgayTao = DateTime.Now;
            hdXuat.TaiKhoanId = taikhoanId;
            hdXuat.TongTien = totalPrice;
            var hdXuatId = _hdXuatService.AddHdXuat(hdXuat);
            for (int i = 0; i < sachSelected.Count; i++)
            {
                CtXuatDTO ctHdXuat = new CtXuatDTO();
                ctHdXuat.HdXuatId = hdXuatId;
                ctHdXuat.SachId = sachSelected.ElementAt(i).Key;
                ctHdXuat.SoLuong = sachSelected.ElementAt(i).Value;
                _ctXuatService.Add(ctHdXuat);
                _sachService.UpdateSoLuong(sachSelected.ElementAt(i).Key, -(sachSelected.ElementAt(i).Value));
            }
            _xacNhanHDBanView.Notification("Thanh toán thành công", null, Resources.success, true);
        }
    }
}
