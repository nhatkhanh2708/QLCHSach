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
        private string _tg;
        private readonly IThemHDNhapView _themHDNhapView;
        public UCItemSachChon(IThemHDNhapView themHDNhapView, FlowLayoutPanel flp, SachDTO sachDTO, string tg, int slnhap)
        {
            InitializeComponent();
            _sach = sachDTO;
            _slNhap = slnhap;
            _flp = flp;
            _themHDNhapView = themHDNhapView;
            _tg = tg;
        }

        private void UCItemSachChon_Load(object sender, EventArgs e)
        {
            lblSach.Text = _sach.TenSach;
            lblSlNhap.Text = "+" + _slNhap.ToString();
            id = _sach.Id;
            CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");
            var tiensach = _sach.GiaNhap * _slNhap;
            lblTienSach.Text = "-" + double.Parse(tiensach.ToString()).ToString("#,###", cul.NumberFormat);
            lblGiaNhap.Text = double.Parse(_sach.GiaNhap.ToString()).ToString("#,###", cul.NumberFormat);
            lblTg.Text = _tg;
            if (_themHDNhapView != null && _flp != null)
            {
                btnDel.Visible = true;
            }
            else
            {
                btnDel.Visible = false;
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if(_themHDNhapView != null && _flp != null)
            {
                _themHDNhapView.RmSelected(_sach.Id, _sach.GiaNhap * _slNhap);
                _flp.Controls.Remove(this);
            }
        }
    }
}
