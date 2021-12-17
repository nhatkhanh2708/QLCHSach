using Model.Entities;
using MVP.IViews;
using Service.IServices;
using System.Linq;

namespace MVP.Presenters
{
    public class CtXuatPresenter
    {
        private readonly ICtXuatView _ctXuatView;
        private readonly ICtXuatService _ctXuatService;
        private readonly ISachService _sachService;
        private readonly ITacGiaService _tacGiaService;
        private readonly ISachTacGiaService _sachTacGiaService;
        public CtXuatPresenter(ICtXuatView ctXuatView)
        {
            _ctXuatView = ctXuatView;
            _ctXuatService = (ICtXuatService)Startup.ServiceProvider.GetService(typeof(ICtXuatService));
            _tacGiaService = (ITacGiaService)Startup.ServiceProvider.GetService(typeof(ITacGiaService));
            _sachTacGiaService = (ISachTacGiaService)Startup.ServiceProvider.GetService(typeof(ISachTacGiaService));
            _sachService = (ISachService)Startup.ServiceProvider.GetService(typeof(ISachService));
        }

        public void GetsCtHdByHdId(int id)
        {
            _ctXuatView.GetsCtHdByHdId(_ctXuatService.GetsAll().Where(p => p.HdXuatId == id));
        }

        public void GetSachById(int id)
        {
            _ctXuatView.GetSachById(_sachService.GetById(id));
        }

        public void GetsAllTG_STG()
        {
            _ctXuatView.GetsAllTG_STG(_tacGiaService.GetsAll(), _sachTacGiaService.GetsAll());
        }
    }
}
