using Model.Entities;
using MVP.IViews;
using MVP.Properties;
using MVP.Utils;
using Service.DTOs;
using Service.IServices;
using System;

namespace MVP.Presenters
{
   public class ThemNCCPresenter
    {
        private readonly IThemNCCView _themnccView;
        private readonly INccService _nccService;
        public ThemNCCPresenter(IThemNCCView themNCCView)
        {
            _themnccView = themNCCView;
            _nccService = (INccService)Startup.ServiceProvider.GetService(typeof(INccService));
        }
        public void Add(string tenncc, string diachi, string sdt, DateTime ngayhoptac)
        {
            if (!String.IsNullOrEmpty(tenncc) && IsNumber(sdt) == 0 && IsChar(tenncc) == 0 && sdt.Length <= 10)
            {
                var ncc = new NccDTO();
                ncc.TenNCC = tenncc.Trim();
                ncc.DiaChi = diachi.Trim();
                ncc.SDT = sdt.Trim();
                ncc.NgayHopTac = ngayhoptac;
                ncc.Status = true;
                _nccService.Add(ncc);
                _themnccView.Notification(Notification.ADD_SUCCESSED, null, Resources.success, true);
            }
            else
            {
                _themnccView.Notification(Notification.ADD_FAILED, Notification.NOT_FILL_CONTENT, Resources.fail, false);
            }
        }
        public bool ConvertBoolToString(string status)
        {
            if (status.Equals("Hợp tác"))
                return true;
            else
                return false;
        }

        public int IsNumber(string pValue)
        {
            int a = 0;
            foreach (Char c in pValue)
            {
                if (!Char.IsDigit(c))
                    a = a + 1;
            }
            return a;

        }
        
        public int IsChar(string pValue)
        {
            int a = 0;
            foreach (Char c in pValue)
            {
                if (Char.IsDigit(c))
                    a = a + 1;
            }
            return a;
        }
    }
}
