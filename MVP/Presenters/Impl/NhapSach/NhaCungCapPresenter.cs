using Model.Entities;
using MVP.IViews;
using Service.IServices;

namespace MVP.Presenters
{
    public class NhaCungCapPresenter : INhaCungCapPresenter
    {
        private readonly INccService _nccService;
        private readonly INhaCungCapView _nccView;
        public NhaCungCapPresenter(INhaCungCapView nhaCungCapView)
        {
            _nccView = nhaCungCapView;
            _nccService = (INccService)Startup.ServiceProvider.GetService(typeof(INccService));
        }
        public void GetsAll()
        {
            _nccView.GetsAll(_nccService.GetsAll());
        }
    }
}
