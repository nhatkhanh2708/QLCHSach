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
    public partial class UCXacNhanHDBan : UserControl, IXacNhanHDBanView
    {
        private bool isComplete = false;
        private Dictionary<int, int> _listSelected;
        CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");
        private decimal _totalPrice = 0;
        private IEnumerable<SachDTO> _listSach;
        private IEnumerable<SachTacGiaDTO> _listSTG;
        private IEnumerable<TacGiaDTO> _listTG;
        private TaiKhoanDTO _taikhoan;
        private XacNhanHDBanPresenter _xacNhanHDBanPresenter;
        private SachDTO _sach;
        private UCThemHDBan _ucThemHdBan;
        public UCXacNhanHDBan(UCThemHDBan ucThemHDBan, TaiKhoanDTO taiKhoanDTO, Dictionary<int, int> listSelected, IEnumerable<SachDTO> listSach, IEnumerable<TacGiaDTO> listTG, IEnumerable<SachTacGiaDTO> listSTG, decimal totalPrice)
        {
            InitializeComponent();
            _taikhoan = taiKhoanDTO;
            _listSelected = listSelected;
            _listTG = listTG;
            _listSTG = listSTG;
            _listSach = listSach;
            _totalPrice = totalPrice;
            _xacNhanHDBanPresenter = new XacNhanHDBanPresenter(this);
            _ucThemHdBan = ucThemHDBan;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (isComplete)
            {
                _ucThemHdBan.CompleteCreatedBill(isComplete);
                Dispose();
            }
            else
                Dispose();
        }

        private void UCXacNhanHDBan_Load(object sender, EventArgs e)
        {
            hideScrollbar();
            load();
        }

        private void load()
        {
            lblDate.Text = DateTime.Now.ToString("dd-MM-yyyy");
            _xacNhanHDBanPresenter.GetTenNV(_taikhoan.NhanVienId);
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
                for (int j = 0; j < _listTemp.Count(); j++)
                {
                    if (_listSelected.ElementAt(i).Key == _listTemp.ElementAt(j).SachId)
                    {
                        tg += _listTemp.ElementAt(j).ButDanh + ", ";
                    }
                }
                tg = tg.Substring(0, tg.Length - 2);
                sum += _listSelected.ElementAt(i).Value;
                flp.Controls.Add(new UCItemSachBanChon(null, null,
                    _listSach.FirstOrDefault(p => p.Id == _listSelected.ElementAt(i).Key),
                    tg, _listSelected.ElementAt(i).Value));
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

        private void btnThanhtoan_Click(object sender, EventArgs e)
        {
            _xacNhanHDBanPresenter.AddHDXuat(_listSelected, _taikhoan.Id, _totalPrice);
        }

        private void btnInHD_Click(object sender, EventArgs e)
        {
            
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

        public void GetTenNV(string tennv)
        {
            lblNguoitao.Text = tennv;
        }

        public void GetSachById(SachDTO sach)
        {
            _sach = sach;
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font f = new Font("Arial", 20, FontStyle.Bold);
            e.Graphics.DrawString("hello", f, Brushes.Black, 150, 125);
        }
    }
}
