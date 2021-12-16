using Model.Entities;
using MVP.IViews;
using MVP.Views;
using Service.IServices;
using System.Windows.Forms;

namespace MVP.Presenters
{
    public class LoginPresenter
    {
        private readonly ITaiKhoanService _taiKhoanService;
        private readonly ILoginView _loginView;
        public LoginPresenter(ILoginView loginView)
        {
            _loginView = loginView;
            _taiKhoanService = (ITaiKhoanService)Startup.ServiceProvider.GetService(typeof(ITaiKhoanService));
        }

        public void login(string username, string password, Form flogin)
        {
            if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password))
            {
                var acc = _taiKhoanService.isLogin(username, password);
                if (acc != null)
                {
                    new Main(acc, flogin).Show();
                    flogin.Hide();
                }
                else
                {
                    _loginView.Notification(true);
                }
            }
            else
            {
                _loginView.Notification(true);
            }
        }

    }
}
