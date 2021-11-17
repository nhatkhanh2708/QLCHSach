using Model.Entities;
using MVP.IViews;
using Service.DTOs;
using Service.IServices;

namespace MVP.Presenters
{
    public class NxbPresenter : INxbPresenter
    {
        private readonly INxbView _nxbView;
        private readonly INxbService _nxbService;

        public NxbPresenter(INxbView nxbView)
        {
            _nxbView = nxbView;
            _nxbService = (INxbService)Startup.ServiceProvider.GetService(typeof(INxbService));
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
                _nxbService.Add(nxbDTO);
                //_nxbService.Update(nxbDTO);
                _nxbView.ThemThanhCong();
            }
            else
            {
                _nxbView.ThemThatBai();
            }
        }
    }
}
