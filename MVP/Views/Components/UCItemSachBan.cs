using MVP.IViews;
using Service.DTOs;
using System;
using System.Globalization;
using System.Windows.Forms;

namespace MVP.Views
{
    public partial class UCItemSachBan : UserControl
    {
        private SachDTO _sachDTO;
        private readonly IThemHDBanView _themHDBanView;
        private string _tg;
        public UCItemSachBan(IThemHDBanView themHDBanView, SachDTO sach, string tg)
        {
            InitializeComponent();
            _sachDTO = sach;
            _themHDBanView = themHDBanView;
            _tg = tg;
        }

        private void lblSach_Click(object sender, EventArgs e)
        {
            _themHDBanView.SelectedSach(_sachDTO, _tg);
        }

        private void UCItemSachBan_Load(object sender, EventArgs e)
        {
            CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");
            lblSach.Text = _sachDTO.TenSach;
            lblGiaBan.Text = double.Parse(_sachDTO.GiaBan.ToString()).ToString("#,###", cul.NumberFormat);
            lblSL.Text = _sachDTO.SoLuong.ToString();
            lblTg.Text = _tg;
        }
    }
}
