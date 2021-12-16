using MVP.IViews;
using MVP.Presenters;
using Service.DTOs;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace MVP.Views
{
    public partial class UCThemTaiKhoan : UserControl, IThemTaiKhoanView
    {
        private bool isComplete = false;
        private ThemTaiKhoanPresenter _themTaiKhoanPresenter;
        private UCTaiKhoan _ucTK;
        public UCThemTaiKhoan(UCTaiKhoan ucTK)
        {
            InitializeComponent();
            _themTaiKhoanPresenter = new ThemTaiKhoanPresenter(this);
            _ucTK = ucTK;
        }

        private void UCThemTaiKhoan_Load(object sender, EventArgs e)
        {
            hideScrollBar();
            _themTaiKhoanPresenter.GetsAllQuyen();
            _themTaiKhoanPresenter.GetsNV_NotAccount();
        }

        private void hideScrollBar()
        {
            flp.AutoScroll = false;
            flp.HorizontalScroll.Maximum = 0;
            flp.HorizontalScroll.Visible = false;
            flp.VerticalScroll.Maximum = 0;
            flp.VerticalScroll.Visible = false;
            flp.AutoScroll = true;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (isComplete)
            {
                _ucTK.LoadTK(isComplete);
            }
            else
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
            {
                isComplete = true;
                refresh();
            }
                
        }

        private void refresh()
        {
            flp.Controls.Clear();
            _themTaiKhoanPresenter.GetsNV_NotAccount();
        }

        public void GetsNV_NotAccount(IEnumerable<NhanVienDTO> listNV)
        {
            for (int i = 0; i < listNV.Count(); i++)
                flp.Controls.Add(new UCItemNV_TK(listNV.ElementAt(i), lblId, lblTenNV, lblNgaySinh));
        }

        public void GetsAllQuyen(IEnumerable<QuyenDTO> listQuyen)
        {
            cbxQuyen.DataSource = listQuyen;
            cbxQuyen.DisplayMember = "TenQuyen";
            cbxQuyen.ValueMember = "Id";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            _themTaiKhoanPresenter.Add(txtUsername.Text, lblNgaySinh.Text, lblId.Text, (int)cbxQuyen.SelectedValue);
        }
    }
}
