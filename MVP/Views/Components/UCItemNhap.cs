using Service.DTOs;
using System;
using System.Globalization;
using System.Windows.Forms;

namespace MVP.Views
{
    public partial class UCItemNhap : UserControl
    {
        private Panel pnlContainer;
        private NccDTO _ncc;
        private HdNhapDTO _hdNhap;
        public UCItemNhap(Panel pnlCont, NccDTO ncc, HdNhapDTO hdNhap)
        {
            InitializeComponent();
            pnlContainer = pnlCont;
            _ncc = ncc;
            _hdNhap = hdNhap;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            UCChiTietHDNhap ucChiTietNhap = new UCChiTietHDNhap();
            ucChiTietNhap.Dock = DockStyle.Fill;
            pnlContainer.Controls.Add(ucChiTietNhap);
            pnlContainer.Controls.SetChildIndex(ucChiTietNhap, 0);
        }

        private void UCItemNhap_Load(object sender, EventArgs e)
        {
            CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");
            lblId.Text = "#" + _hdNhap.Id;
            lblNcc.Text = _ncc.TenNCC;
            lblTongTien.Text = double.Parse(_hdNhap.TongTien.ToString()).ToString("#,###", cul.NumberFormat) + " VND";
            lblDate.Text = _hdNhap.NgayTao.ToString("dd-MM-yyyy HH:mm:ss");
        }
    }
}
