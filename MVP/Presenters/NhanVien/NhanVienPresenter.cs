using Model.Entities;
using MVP.IViews;
using Service.DTOs;
using Service.IServices;
using System.Collections.Generic;

namespace MVP.Presenters
{
    public class NhanVienPresenter
    {
        private readonly INhanVienService _nvService;
        private readonly INhanVienView _nvView;
        public NhanVienPresenter(INhanVienView nhanVienView)
        {
            _nvView = nhanVienView;
            _nvService = (INhanVienService)Startup.ServiceProvider.GetService(typeof(INhanVienService));
        }

        public void GetsAll()
        {
            var listnv = _nvService.GetsAll();
            List<NhanVienDTO> listemp = new List<NhanVienDTO>();
            foreach (NhanVienDTO nv in listnv)
            {
                if (nv.Status)
                {
                    listemp.Add(nv);
                }
            }
            _nvView.GetsAll(listemp);
        }

        public void GetByName(string name)
        {
            var listnv = _nvService.GetsAll();
            List<NhanVienDTO> listemp = new List<NhanVienDTO>();
            foreach(NhanVienDTO nv in listnv)
            {
                if (nv.HoTen.StartsWith(name) && nv.Status)
                {
                    listemp.Add(nv);
                }
            }
            _nvView.GetsByName(listemp);
        }
    }
}
