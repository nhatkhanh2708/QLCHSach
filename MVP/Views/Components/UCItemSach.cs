using Service.DTOs;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace MVP.Views
{
    public partial class UCItemSach : UserControl
    {
        private Panel _pnlCont;
        private SachDTO _sach;
        private List<string> _listtg;
        public UCItemSach(SachDTO sach, List<string> listtg, Panel pnlCont)
        {
            InitializeComponent();
            _pnlCont = pnlCont;
            _sach = sach;
            _listtg = listtg;
        }

        private void UCItemSach_Load(object sender, EventArgs e)
        {
            CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");
            lblTenSach.Text = _sach.TenSach;
            lblGiaNhap.Text = double.Parse(_sach.GiaNhap.ToString()).ToString("#,###", cul.NumberFormat);
            lblGiaBan.Text = double.Parse(_sach.GiaBan.ToString()).ToString("#,###", cul.NumberFormat);
            if (_sach.Img.Length != 0)
                lblImg.Image = (Image)(new ImageConverter()).ConvertFrom(_sach.Img);
            lblSl.Text = _sach.SoLuong.ToString();
            string tg = "";
            foreach(string t in _listtg)
            {
                tg += t+", ";
            }
            tg = tg.Substring(0, tg.Length - 2);
            lblTG.Text = tg;
        }

        private void lblImg_Click(object sender, EventArgs e)
        {
            UCChiTietSach ucChiTietSach = new UCChiTietSach(_sach);
            ucChiTietSach.Dock = DockStyle.Fill;
            _pnlCont.Controls.Add(ucChiTietSach);
            _pnlCont.Controls.SetChildIndex(ucChiTietSach, 0);
        }
    }
}
