using Service.DTOs;
using System;
using System.Windows.Forms;

namespace MVP.Views
{
    public partial class UCNhap : UserControl
    {
        private TaiKhoanDTO _taikhoan;
        public UCNhap(TaiKhoanDTO taiKhoanDTO)
        {
            InitializeComponent();
            _taikhoan = taiKhoanDTO;
        }

        private void UCNhap_Load(object sender, EventArgs e)
        {
            loadflp();
            hideScrollBar();
        }

        private void loadflp()
        {
            for (int i = 0; i < 20; i++)
            {
                flp.Controls.Add(new UCItemNhap(getPanelContainer));
            }
        }

        public Panel getPanelContainer
        {
            get { return pnlContainer; }
            set { pnlContainer = value; }
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            UCThemHDNhap ucThemHDNhap = new UCThemHDNhap(_taikhoan);
            ucThemHDNhap.Dock = DockStyle.Fill;
            pnlContainer.Controls.Add(ucThemHDNhap);
            pnlContainer.Controls.SetChildIndex(ucThemHDNhap, 0);
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {

        }

        private void btnRefesh_Click(object sender, EventArgs e)
        {

        }

        private void btnMore_Click(object sender, EventArgs e)
        {

        }
    }
}
