using MVP.IViews;
using MVP.Presenters;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MVP.Views
{
    public partial class UCThemQuyen : UserControl, IThemQuyenView
    {
        private ThemQuyenPresenter _themQuyenPresenter;
        public UCThemQuyen()
        {
            InitializeComponent();
            _themQuyenPresenter = new ThemQuyenPresenter(this);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string mota = "";            
            mota += chkQLSach.Checked ? "QL sách," : "";
            mota += chkQLBan.Checked ? "QL bán," : "";
            mota += chkQLNhap.Checked ? "QL nhập," : "";
            mota += chkQLNV.Checked ? "QL nhân viên," : "";
            mota += chkQLTaiKhoan.Checked ? "QL tài khoản," : "";
            mota += chkThongKe.Checked ? "Thống kê," : "";            
            _themQuyenPresenter.Add(txtTenQuyen.Text, mota);
        }

        private void refresh()
        {
            txtTenQuyen.Text = "";
            chkQLSach.Checked = false;
            chkQLBan.Checked = false;
            chkQLNhap.Checked = false;
            chkQLNV.Checked = false;
            chkQLTaiKhoan.Checked = false;
            chkThongKe.Checked = false;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        public void Notification(string title, string description, Image img, bool flag)
        {
            UCNotification ucNotifi = new UCNotification(title, description, img);
            ucNotifi.Anchor = AnchorStyles.None;
            ucNotifi.Location = new Point((panel1.Width - ucNotifi.Width) / 2,
                (panel1.Height - ucNotifi.Height) / 2);
            panel1.Controls.Add(ucNotifi);
            panel1.Controls.SetChildIndex(ucNotifi, 0);
            if (flag)
                refresh();
        }
    }
}
