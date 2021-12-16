using MVP.IViews;
using MVP.Presenters;
using Service.DTOs;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace MVP.Views
{
    public partial class UCXacNhanHDNhap : UserControl, IXacNhanHDNhapView
    {
        private bool isComplete = false;
        private Dictionary<int, int> _listSelected;
        CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");
        private decimal _totalPrice = 0;
        private IEnumerable<SachTacGiaDTO> _listSTG;
        private IEnumerable<TacGiaDTO> _listTG;
        private int _NccId;
        private TaiKhoanDTO _taikhoan;        
        private XacNhanHDNhapPresenter _xacNhanHDNhapPresenter;
        private SachDTO _sach;
        private UCThemHDNhap _ucThemHdNhap;
        public UCXacNhanHDNhap(UCThemHDNhap ucThemHDNhap, TaiKhoanDTO taiKhoanDTO, Dictionary<int, int> listSelected, int nccId, IEnumerable<TacGiaDTO> listTG, IEnumerable<SachTacGiaDTO> listSTG, decimal totalPrice)
        {
            InitializeComponent();
            _taikhoan = taiKhoanDTO;
            _listSelected = listSelected;
            _NccId = nccId;
            _listTG = listTG;
            _listSTG = listSTG;
            _totalPrice = totalPrice;
            _xacNhanHDNhapPresenter = new XacNhanHDNhapPresenter(this);
            _ucThemHdNhap = ucThemHDNhap;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (isComplete)
            {
                _ucThemHdNhap.CompleteCreatedBill(isComplete);
                Dispose();
            }
            else
                Dispose();
        }

        private void UCXacNhanHDNhap_Load(object sender, EventArgs e)
        {
            hideScrollbar();
            load();
        }

        private void load()
        {
            lblDate.Text = DateTime.Now.ToString("dd-MM-yyyy");
            _xacNhanHDNhapPresenter.GetTenNV_Ncc(_taikhoan.NhanVienId, _NccId);
            lblTongTien.Text = double.Parse(_totalPrice.ToString()).ToString("#,###", cul.NumberFormat) + " VND";            

            var _listTemp = _listTG.Join(_listSTG,
                p => p.Id,
                q => q.TacGiaId,
                (tg, stg) => new { tg.ButDanh, stg.SachId }
                );
            int sum = 0;
            for (int i = 0; i < _listSelected.Count(); i++)
            {
                string tg = "";
                _xacNhanHDNhapPresenter.GetSachById(_listSelected.ElementAt(i).Key);
                for (int j = 0; j < _listTemp.Count(); j++)
                {
                    if (_listSelected.ElementAt(i).Key == _listTemp.ElementAt(j).SachId)
                    {
                        tg += _listTemp.ElementAt(j).ButDanh + ", ";
                    }
                }
                tg = tg.Substring(0, tg.Length - 2);
                sum += _listSelected.ElementAt(i).Value;
                flp.Controls.Add(new UCItemSachChon(null, null, _sach, tg, _listSelected.ElementAt(i).Value));
            }
            lblTongSoSach.Text = sum.ToString();
        }

        private void hideScrollbar()
        {
            flp.AutoScroll = false;
            flp.HorizontalScroll.Maximum = 0;
            flp.HorizontalScroll.Visible = false;
            flp.VerticalScroll.Maximum = 0;
            flp.VerticalScroll.Visible = false;
            flp.AutoScroll = true;
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
            {
                btnInHD.Visible = true;
                btnThanhtoan.Visible = false;
                isComplete = true;
            }
        }

        public void GetTenNV_Ncc(string tennv, string ncc)
        {
            lblNcc.Text = ncc;
            lblNguoitao.Text = tennv;
        }

        private void btnInHD_Click(object sender, EventArgs e)
        {
            // in hoa don
        }

        private void btnThanhtoan_Click(object sender, EventArgs e)
        {
            _xacNhanHDNhapPresenter.AddHDNhap(_listSelected, _taikhoan.Id, _NccId, _totalPrice);
        }

        public void GetSachById(SachDTO sach)
        {
            _sach = sach;
        }
    }
}
