using Model.Entities;
using MVP.IViews;
using Service.IServices;

namespace MVP.Presenters
{
    public class QuyenPresenter
    {
        private readonly IQuyenService _quyenService;
        private readonly IQuyenView _quyenView;
        public QuyenPresenter(IQuyenView quyenView)
        {
            _quyenView = quyenView;
            _quyenService = (IQuyenService)Startup.ServiceProvider.GetService(typeof(IQuyenService));
        }
        public void GetsAll()
        {
            _quyenView.GetsAll(_quyenService.GetsAll());
        }
    }
}
