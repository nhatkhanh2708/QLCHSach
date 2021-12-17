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
    public partial class UCChiTietHDBan : UserControl, ICtXuatView
    {
        private CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");
        private HdXuatDTO _hdXuat;
        private CtXuatPresenter _ctXuatPresenter;
        private SachDTO _sach;
        private IEnumerable<TacGiaDTO> _listTG;
        private IEnumerable<SachTacGiaDTO> _listSTG;
        private IEnumerable<CtXuatDTO> _listCtXuat;
        public UCChiTietHDBan(NhanVienDTO nv, HdXuatDTO hdXuatDTO)
        {
            InitializeComponent();
            _hdXuat = hdXuatDTO;
            lblNguoitao.Text = nv.HoTen;
            _ctXuatPresenter = new CtXuatPresenter(this);
        }

        private void UCChiTietHDBan_Load(object sender, EventArgs e)
        {
            _ctXuatPresenter.GetsAllTG_STG();
            _ctXuatPresenter.GetsCtHdByHdId(_hdXuat.Id);
            lblTitle.Text = lblTitle.Text + " #" + _hdXuat.Id;
            lblTongTien.Text = double.Parse(_hdXuat.TongTien.ToString()).ToString("#,###", cul.NumberFormat) + " VND";
            lblDate.Text = _hdXuat.NgayTao.ToString("dd-MM-yyyy HH:mm:ss");
            
            int sum = 0;
            var _listTemp = _listTG.Join(_listSTG,
                p => p.Id,
                q => q.TacGiaId,
                (tg, stg) => new { tg.ButDanh, stg.SachId }
                );

            for (int i = 0; i < _listCtXuat.Count(); i++)
            {
                _ctXuatPresenter.GetSachById(_listCtXuat.ElementAt(i).SachId);
                string tg = "";
                for (int j = 0; j < _listTemp.Count(); j++)
                {
                    if (_listCtXuat.ElementAt(i).SachId == _listTemp.ElementAt(j).SachId)
                    {
                        tg += _listTemp.ElementAt(j).ButDanh + ", ";
                    }
                }
                tg = tg.Substring(0, tg.Length - 2);
                sum += _listCtXuat.ElementAt(i).SoLuong;
                flp.Controls.Add(new UCItemSachBanChon(null, null, _sach, tg, _listCtXuat.ElementAt(i).SoLuong));
            }
            lblTongSoSach.Text = sum.ToString();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnInHD_Click(object sender, EventArgs e)
        {

        }

        public void GetsCtHdByHdId(IEnumerable<CtXuatDTO> listCtXuat)
        {
            _listCtXuat = listCtXuat;
        }

        public void GetsAllTG_STG(IEnumerable<TacGiaDTO> listTG, IEnumerable<SachTacGiaDTO> listSTG)
        {
            _listTG = listTG;
            _listSTG = listSTG;
        }

        public void GetSachById(SachDTO s)
        {
            _sach = s;
        }
    }
}
