using Model.Entities;
using MVP.IViews;
using MVP.Properties;
using MVP.Utils;
using Service.DTOs;
using Service.IServices;

namespace MVP.Presenters
{
    public class CtNccPresenter
    {
        private readonly ICtNccView _ctNccView;
        private readonly INccService _nccService;
        public CtNccPresenter(ICtNccView ctNccView)
        {
            _ctNccView = ctNccView;
            _nccService = (INccService)Startup.ServiceProvider.GetService(typeof(INccService));
        }

        public void DeleteNcc(int id)
        {
            var t = _nccService.GetById(id);
            t.Status = false;
            _nccService.Update(t);
        }

        public void UpdateNcc(NccDTO ncc)
        {
            _nccService.Update(ncc);
            _ctNccView.Notification(Notification.EDIT_SUCCESSED, null, Resources.success, true);
        }
    }
}
