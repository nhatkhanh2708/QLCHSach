using Model.Entities.IViews;
using Service.DTOs.SachDTOs;
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
        private readonly INxbView nxbView;
        private readonly INxbService nxbService;

        public NxbPresenter(INxbView nxbView)
        {
            this.nxbView = nxbView;
            nxbService = (INxbService)Startup.ServiceProvider.GetService(typeof(INxbService));
        }

        public void checkThem(string tenNxb, string vietTat)
        {
            if(tenNxb.Length < 100 && vietTat.Length < 20)
            {
                var nxbDTO = new NhaXuatBanDTO
                {
                    TenNxb = tenNxb,
                    VietTat = vietTat
                };
                nxbService.Add(nxbDTO);
                nxbView.ThemThanhCong();
            }
            else
            {
                nxbView.ThemThatBai();
            }
        }
    }
}
