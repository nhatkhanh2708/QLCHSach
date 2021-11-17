using Model.Entities.IViews;
using Service.DTOs;
using Service.IServices.ISachServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entities.Presenters
{
    public class NxbPresenter
    {
        private readonly INxbView _nxbView;
        private INxbService _nxbService;

        public NxbPresenter(INxbView nxbView)
        {
            _nxbView = nxbView;
            _nxbService = (INxbService)Startup.ServiceProvider.GetService(typeof(INxbService));
        }

        public void checkThem(string tenNxb, string vietTat)
        {
            if(tenNxb.Length < 100 && vietTat.Length < 20)
            {
                /*var nxbDTO = new NhaXuatBanDTO
                {
                    TenNxb = tenNxb,
                    VietTat = vietTat
                };*/
                //_nxbService.Add(nxbDTO);
                _nxbView.ThemThanhCong();
            }
            else
            {
                _nxbView.ThemThatBai();
            }
        }
    }
}
