using MVP.IViews;
using Service.DTOs;
using System;
using System.Globalization;
using System.Windows.Forms;

namespace MVP.Views
{
    public partial class UCItemSachNhap : UserControl
    {
        private SachDTO _sachDTO;
        private readonly IThemHDNhapView _themHDNhapView;
        public UCItemSachNhap(IThemHDNhapView themHDNhapView, SachDTO sach)
        {
            InitializeComponent();
            _sachDTO = sach;
            _themHDNhapView = themHDNhapView;
        }

        private void lblSach_Click(object sender, EventArgs e)
        {
            _themHDNhapView.SelectedSach(_sachDTO);
        }

        private void UCItemSachNhap_Load(object sender, EventArgs e)
        {
            CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");
            lblSach.Text = _sachDTO.TenSach;
            lblGiaNhap.Text = double.Parse(_sachDTO.GiaNhap.ToString()).ToString("#,###", cul.NumberFormat);
            lblSL.Text = "+"+_sachDTO.SoLuong.ToString();
        }
    }
}
