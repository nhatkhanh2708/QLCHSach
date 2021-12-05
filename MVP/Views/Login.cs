using MVP.IViews;
using MVP.Presenters;
using System;
using System.Windows.Forms;

namespace MVP.Views
{
    public partial class Login : Form, ILoginView
    {
        private LoginPresenter loginPresenter;
        public Login()
        {
            InitializeComponent();
            loginPresenter = new LoginPresenter(this);
        }

        private void btnShutdown_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            loginPresenter.login(txtUsername.Text, txtPass.Text, this);
        }

        public void Notification(bool flag)
        {
            lblFailed.Visible = flag;
        }
    }
}
