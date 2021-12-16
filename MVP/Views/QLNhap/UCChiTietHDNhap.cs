using MVP.IViews;
using MVP.Presenters;
using Service.DTOs;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace MVP.Views
{
    public partial class UCChiTietHDNhap : UserControl, ICtNhapView
    {
        private CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");
        private NccDTO _ncc;
        private HdNhapDTO _hdNhap;
        private CtNhapPresenter _ctNhapPresenter;
        private SachDTO _sach;
        private IEnumerable<TacGiaDTO> _listTG;
        private IEnumerable<SachTacGiaDTO> _listSTG;
        private IEnumerable<CtNhapDTO> _listCtNhap;
        public UCChiTietHDNhap(NccDTO nccDTO, HdNhapDTO hdNhapDTO)
        {
            InitializeComponent();
            _ncc = nccDTO;
            _hdNhap = hdNhapDTO;
            _ctNhapPresenter = new CtNhapPresenter(this);
        }

        private void UCChiTietHDNhap_Load(object sender, EventArgs e)
        {
            _ctNhapPresenter.GetNv(_hdNhap.TaiKhoanId);
            _ctNhapPresenter.GetsCtHd(_hdNhap.Id);
            _ctNhapPresenter.GetsAllTG_STG();
            lblTitle.Text = lblTitle.Text + " #" + _hdNhap.Id;
            lblNcc.Text = _ncc.TenNCC;
            lblTongTien.Text = double.Parse(_hdNhap.TongTien.ToString()).ToString("#,###", cul.NumberFormat) + " VND";
            lblDate.Text = _hdNhap.NgayTao.ToString("dd-MM-yyyy HH:mm:ss");
            int sum = 0;
            var _listTemp = _listTG.Join(_listSTG,
                p => p.Id,
                q => q.TacGiaId,
                (tg, stg) => new { tg.ButDanh, stg.SachId }
                );

            for (int i = 0; i < _listCtNhap.Count(); i++)
            {                
                _ctNhapPresenter.GetSachById(_listCtNhap.ElementAt(i).SachId);
                string tg = "";
                for (int j = 0; j < _listTemp.Count(); j++)
                {
                    if (_listCtNhap.ElementAt(i).SachId == _listTemp.ElementAt(j).SachId)
                    {
                        tg += _listTemp.ElementAt(j).ButDanh + ", ";
                    }
                }
                tg = tg.Substring(0, tg.Length - 2);
                sum += _listCtNhap.ElementAt(i).SoLuong;
                flp.Controls.Add(new UCItemSachChon(null, null, _sach, tg, _listCtNhap.ElementAt(i).SoLuong));
            }
            lblTongSoSach.Text = sum.ToString();
        }

        private void btnInHD_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        public void GetNv(NhanVienDTO nv)
        {
            lblNguoitao.Text = nv.HoTen;
        }

        public void GetsCtHdByHdId(IEnumerable<CtNhapDTO> listCtNhap)
        {
            _listCtNhap = listCtNhap;
        }

        public void GetSachById(SachDTO s)
        {
            _sach = s;
        }

        public void GetsAllTG_STG(IEnumerable<TacGiaDTO> listTG, IEnumerable<SachTacGiaDTO> listSTG)
        {
            _listTG = listTG;
            _listSTG = listSTG;
        }
    }
}
