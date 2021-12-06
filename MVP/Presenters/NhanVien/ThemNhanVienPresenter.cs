using Model.Entities;
using MVP.IViews;
using MVP.Properties;
using MVP.Utils;
using Service.DTOs;
using Service.IServices;
using System;

namespace MVP.Presenters
{
    public class ThemNhanVienPresenter
    {
        private readonly IThemNhanVienView _themNVView;
        private readonly INhanVienService _nvService;
        public ThemNhanVienPresenter(IThemNhanVienView nvView)
        {
            _themNVView = nvView;
            _nvService = (INhanVienService)Startup.ServiceProvider.GetService(typeof(INhanVienService));
        }
        
        public int IsNumber(string pValue)
        {
            int a = 0;
            foreach (Char c in pValue)
            {
                if (!Char.IsDigit(c))
                    a = a+1;
            }
            return a;

        }
        
        public int IsChar(string pValue)
        {
            int a = 0;
            foreach (Char c in pValue)
            {
                if (Char.IsDigit(c))
                    a=a+1;
            }
            return a;
        }
        
        public bool IsGender(string gioitinh)
        {
            if(gioitinh.Equals("Nam"))
            {
                return true;
            }   
            else
            {
                return false;
            }
        }
        
        public bool IsWorking(string trangthai)
        {
            if(trangthai.Equals("Đang làm việc"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
        public string ChangeText(string gioitinh)
        {
            if(gioitinh.Equals("True"))
            {
                return "Nam";
            }
            else
            {
                return "Nữ";
            }
        }

        public int CheckAge(DateTime ngaysinh)
        {
            var today = DateTime.Today;
            var age = today.Year - ngaysinh.Year;
            if (ngaysinh.Date > today.AddYears(-age)) 
                age--;
            return age;
        }

        public void Add(string hoten, string gioitinh, string ngaysinh, string diachi, string sdt, string ngaybatdau)
        {
            if(hoten.Length==0 || gioitinh.Length==0 || ngaysinh.Length==0 || diachi.Length==0 ||sdt.Length==0 || ngaybatdau.Length == 0)
            {
                _themNVView.Notification(Notification.ADD_FAILED, Notification.NOT_FILL_CONTENT, Resources.fail, true);
            }
            else
            {
                if(hoten.Length >50 || diachi.Length >50 || sdt.Length > 10)
                {
                    _themNVView.Notification(Notification.ADD_FAILED, Notification.LENGTH_LIMIT, Resources.fail, true);
                }
                else
                {
                    if (IsChar(hoten) > 0)
                    {
                        _themNVView.Notification(Notification.ADD_FAILED, Notification.NAME_NOT_CONTENT_NUMBER, Resources.fail, true);
                    }
                    else
                    {
                        if(IsNumber(sdt) > 0)
                        {
                            _themNVView.Notification(Notification.ADD_FAILED, Notification.NUMBER_NOT_CONTENT_CHAR, Resources.fail, true);
                        }
                        else
                        {
                            if (CheckAge(Convert.ToDateTime(ngaysinh)) >= 18){
                                DateTime ns = Convert.ToDateTime(ngaysinh);
                                DateTime nbd = Convert.ToDateTime(ngaybatdau);
                                var nvDTO = new NhanVienDTO
                                {
                                    HoTen = hoten,
                                    GioiTinh = IsGender(gioitinh),
                                    DiaChi = diachi,
                                    SDT = sdt,
                                    NgaySinh = ns,
                                    NgayBatDau = nbd,
                                    Status = true
                                };
                                _nvService.Add(nvDTO);
                                _themNVView.Notification(Notification.ADD_SUCCESSED, null, Resources.success, true);
                            }
                            else
                            {
                                _themNVView.Notification(Notification.ADD_FAILED, Notification.AGE_LIMIT, Resources.fail, true);
                            }
                        }
                    }
                }
            }
        }
    }
}
