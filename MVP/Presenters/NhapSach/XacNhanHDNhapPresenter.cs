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
    public class XacNhanHDNhapPresenter
    {
        private readonly INccService _nccService;
        private readonly IXacNhanHDNhapView _xacNhanHDNhapView;
        private readonly INhanVienService _nhanVienService;
        private readonly IHdNhapService _hdNhapService;
        private readonly ICtNhapService _ctNhapService;
        private readonly ISachService _sachService;
        public XacNhanHDNhapPresenter(IXacNhanHDNhapView xacNhanHDNhapView)
        {
            _xacNhanHDNhapView = xacNhanHDNhapView;
            _nccService = (INccService)Startup.ServiceProvider.GetService(typeof(INccService));
            _nhanVienService = (INhanVienService)Startup.ServiceProvider.GetService(typeof(INhanVienService));
            _hdNhapService = (IHdNhapService)Startup.ServiceProvider.GetService(typeof(IHdNhapService));
            _ctNhapService = (ICtNhapService)Startup.ServiceProvider.GetService(typeof(ICtNhapService));
            _sachService = (ISachService)Startup.ServiceProvider.GetService(typeof(ISachService));
        }
        public void GetTenNV_Ncc(int nvId, int nccId)
        {
            _xacNhanHDNhapView.GetTenNV_Ncc(
                    _nhanVienService.GetById(nvId).HoTen,
                    _nccService.GetById(nccId).TenNCC
                );
        }

        public void GetSachById(int sachId)
        {
            _xacNhanHDNhapView.GetSachById(_sachService.GetById(sachId));
        }

        public void AddHDNhap(Dictionary<int, int> sachSelected, int taikhoanId, int nccId, decimal totalPrice)
        {
            HdNhapDTO hdNhap = new HdNhapDTO();
            hdNhap.NccId = nccId;
            hdNhap.NgayTao = DateTime.Now;
            hdNhap.TaiKhoanId = taikhoanId;
            hdNhap.TongTien = totalPrice;
            var hdNhapId = _hdNhapService.AddHdNhap(hdNhap);
            for(int i =0;i<sachSelected.Count; i++)
            {
                CtNhapDTO ctHdNhap = new CtNhapDTO();
                ctHdNhap.HdNhapId = hdNhapId;
                ctHdNhap.SachId = sachSelected.ElementAt(i).Key;
                ctHdNhap.SoLuong = sachSelected.ElementAt(i).Value;
                _ctNhapService.Add(ctHdNhap);
                _sachService.UpdateSoLuong(sachSelected.ElementAt(i).Key, sachSelected.ElementAt(i).Value);
            }
            _xacNhanHDNhapView.Notification("Thanh toán thành công", null, Resources.success, true);
        }
    }
}
