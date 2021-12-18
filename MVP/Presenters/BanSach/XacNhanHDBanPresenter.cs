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
        private int _GetHdXuatId = -1;
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
            _GetHdXuatId = hdXuatId;
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

        public void PrintInvoice(Dictionary<int, int> listSelected, int nvId, decimal totalPrice, int totalSach,
            IEnumerable<SachDTO> listSach, IEnumerable<TacGiaDTO> listTG, IEnumerable<SachTacGiaDTO> listSTG)
        {
            if(_GetHdXuatId != -1)
            {
                var tennv = _nhanVienService.GetById(nvId).HoTen;
                var _listTemp = listTG.Join(listSTG,
                p => p.Id,
                q => q.TacGiaId,
                (tg, stg) => new { tg.ButDanh, stg.SachId }
                );
                for (int i = 0; i < listSelected.Count(); i++)
                {
                    var sach = listSach.FirstOrDefault(p => p.Id == listSelected.ElementAt(i).Key);
                    string tg = "";
                    for (int j = 0; j < _listTemp.Count(); j++)
                    {
                        if (listSelected.ElementAt(i).Key == _listTemp.ElementAt(j).SachId)
                        {
                            tg += _listTemp.ElementAt(j).ButDanh + ", ";
                        }
                    }
                    tg = tg.Substring(0, tg.Length - 2);
                }
                
                
                
                
                
                _xacNhanHDBanView.Notification("In hóa đơn thành công", null, Resources.success, true);
            }
            else
            {
                _xacNhanHDBanView.Notification("In hóa đơn không thành công", null, Resources.fail, false);
            }
        }
    }
}
