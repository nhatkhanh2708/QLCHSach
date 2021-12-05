using MVP.IViews;
using MVP.Presenters;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MVP.Views
{
    public partial class UCThemNV : UserControl, IThemNhanVienView
    {
        private ThemNhanVienPresenter _themNhanVienPresenter;
        public UCThemNV()
        {
            InitializeComponent();
            _themNhanVienPresenter = new ThemNhanVienPresenter(this);
        }

        private void UCThemNV_Load(object sender, EventArgs e)
        {
            dtpNgaySinh.Format = DateTimePickerFormat.Custom;
            dtpNgaySinh.CustomFormat = "MM/dd/yyyy";
            dtpNgayBatDau.Format = DateTimePickerFormat.Custom;
            dtpNgayBatDau.CustomFormat = "MM/dd/yyyy";
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

        private void btnThem_Click(object sender, EventArgs e)
        {
            _themNhanVienPresenter.Add(txtTenNV.Text,
                cbxGender.GetItemText(cbxGender.SelectedItem),
                dtpNgaySinh.Value.ToShortDateString(),
                txtDiaChi.Text,
                txtSdt.Text,
                dtpNgayBatDau.Value.ToShortDateString()
            );
        }

        private void refresh()
        {
            txtDiaChi.Controls.Clear();
            txtTenNV.Controls.Clear();
            txtSdt.Controls.Clear();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            refresh();
        }
    }
}
