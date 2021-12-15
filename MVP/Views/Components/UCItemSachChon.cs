using MVP.IViews;
using Service.DTOs;
using System;
using System.Globalization;
using System.Windows.Forms;

namespace MVP.Views
{
    public partial class UCItemSachChon : UserControl
    {
        private SachDTO _sach;
        private int _slNhap;
        private FlowLayoutPanel _flp;
        public int id;
        private readonly IThemHDNhapView _themHDNhapView;
        public UCItemSachChon(IThemHDNhapView themHDNhapView, FlowLayoutPanel flp, SachDTO sachDTO, int slnhap)
        {
            InitializeComponent();
            _sach = sachDTO;
            _slNhap = slnhap;
            _flp = flp;
            _themHDNhapView = themHDNhapView;
        }

        private void UCItemSachChon_Load(object sender, EventArgs e)
        {
            lblSach.Text = _sach.TenSach;
            lblSlNhap.Text = "+"+_slNhap.ToString();
            id = _sach.Id;
            CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");
            var tiensach = _sach.GiaNhap * _slNhap;
            lblTienSach.Text = "-"+double.Parse(tiensach.ToString()).ToString("#,###", cul.NumberFormat);
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            _themHDNhapView.RmSelected(_sach.Id, _sach.GiaNhap * _slNhap);
            _flp.Controls.Remove(this);
        }
    }
}
