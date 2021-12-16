using MVP.IViews;
using MVP.Presenters;
using MVP.Properties;
using Service.DTOs;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace MVP.Views
{
    public partial class UCThemHDNhap : UserControl, IThemHDNhapView
    {
        private bool isLoad = true;
        private ThemHDNhapPresenter _themHDNhapPresenter;
        private int _NccId = -1;
        private SachDTO temp = null;
        private Dictionary<int, int> listSelected;
        CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");
        private decimal totalPrice = 0;
        private IEnumerable<SachTacGiaDTO> _listSTG;
        private IEnumerable<TacGiaDTO> _listTG;
        private string _tg;
        private TaiKhoanDTO _taikhoan;
        public UCThemHDNhap(TaiKhoanDTO taiKhoanDTO)
        {
            InitializeComponent();
            _themHDNhapPresenter = new ThemHDNhapPresenter(this);
            listSelected = new Dictionary<int, int>();
            _taikhoan = taiKhoanDTO;
        }

        private void btnBack_Click(object sender, System.EventArgs e)
        {
            Dispose();
        }

        private void UCThemHDNhap_Load(object sender, System.EventArgs e)
        {
            isLoad = true;
            _themHDNhapPresenter.GetsAllSTG();
            hideScrollBar();
            load();
            panel2.Visible = false;
            refresh();
            isLoad = false;
        }

        public void load()
        {
            _themHDNhapPresenter.GetsAllNcc();
        }

        private void hideScrollBar()
        {
            flp.AutoScroll = false;
            flp.HorizontalScroll.Maximum = 0;
            flp.HorizontalScroll.Visible = false;
            flp.VerticalScroll.Maximum = 0;
            flp.VerticalScroll.Visible = false;
            flp.AutoScroll = true;

            flpSachDaChon.AutoScroll = false;
            flpSachDaChon.HorizontalScroll.Maximum = 0;
            flpSachDaChon.HorizontalScroll.Visible = false;
            flpSachDaChon.VerticalScroll.Maximum = 0;
            flpSachDaChon.VerticalScroll.Visible = false;
            flpSachDaChon.AutoScroll = true;
        }

        public void Notification(string title, string description, Image img, bool flag)
        {
            UCNotification ucNotifi = new UCNotification(title, description, img);
            ucNotifi.Anchor = AnchorStyles.None;
            ucNotifi.Location = new Point((panel2.Width - ucNotifi.Width) / 2,
                (panel2.Height - ucNotifi.Height) / 2);
            panel2.Controls.Add(ucNotifi);
            panel2.Controls.SetChildIndex(ucNotifi, 0);
        }

        public void GetsAllNCC(IEnumerable<NccDTO> listNcc)
        {
            cbxNcc.DataSource = listNcc.ToList();
            cbxNcc.DisplayMember = "TenNCC";
            cbxNcc.ValueMember = "Id";
        }

        public void GetsSachByNccId(IEnumerable<SachDTO> listSach)
        {
            var _listTemp = _listTG.Join(_listSTG,
                p => p.Id,
                q => q.TacGiaId,
                (tg, stg) => new { tg.ButDanh, stg.SachId }
                );
            for (int i = 0; i < listSach.Count(); i++)
            {
                string tg = "";
                for(int j =0; j<_listTemp.Count(); j++)
                {
                    if(listSach.ElementAt(i).Id == _listTemp.ElementAt(j).SachId)
                    {
                        tg += _listTemp.ElementAt(j).ButDanh + ", ";
                    }
                }
                tg = tg.Substring(0, tg.Length - 2);
                flp.Controls.Add(new UCItemSachNhap(this, listSach.ElementAt(i), tg));
            }
        }

        private void cbxNcc_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (!isLoad)
            {
                if(_NccId == -1)
                {
                    panel2.Visible = true;
                    _NccId = (int)cbxNcc.SelectedValue;
                    _themHDNhapPresenter.GetsSachByNccId(_NccId);
                }

                if (_NccId != (int)cbxNcc.SelectedValue && _NccId != -1)
                {
                    refresh();
                    _NccId = (int)cbxNcc.SelectedValue;
                    _themHDNhapPresenter.GetsSachByNccId(_NccId);
                }
            }
        }

        private void refresh()
        {
            flp.Controls.Clear();
            flpSachDaChon.Controls.Clear();
            txtTimKiem.Text = "";
            lblSLHienCo.Text = "";
            lblTenSach.Text = "";
            lblGiaNhap.Text = "";
            lblTongTien.Text = "0 VND";
            numerSLNhap.Value = 0;
            listSelected.Clear();
            _tg = "";
            temp = null;
            totalPrice = 0;
            btnRmAll.Visible = false;
        }

        private void btnTimKiem_Click(object sender, System.EventArgs e)
        {
            if (_NccId != -1)
            {
                _themHDNhapPresenter.GetsSachByName_NccId(txtTimKiem.Text, _NccId);
            }            
        }

        public void GetsSachByName_NccId(IEnumerable<SachDTO> listSach)
        {
            var _listTemp = _listTG.Join(_listSTG,
                p => p.Id,
                q => q.TacGiaId,
                (tg, stg) => new { tg.ButDanh, stg.SachId }
                );
            flp.Controls.Clear();
            for (int i = 0; i < listSach.Count(); i++)
            {
                string tg = "";
                for (int j = 0; j < _listTemp.Count(); j++)
                {
                    if (listSach.ElementAt(i).Id == _listTemp.ElementAt(j).SachId)
                    {
                        tg += _listTemp.ElementAt(j).ButDanh + ", ";
                    }
                }
                tg = tg.Substring(0, tg.Length - 2);
                flp.Controls.Add(new UCItemSachNhap(this, listSach.ElementAt(i), tg));
            }
        }

        public void SelectedSach(SachDTO s, string tg)
        {
            temp = (SachDTO) s.Clone();
            lblTenSach.Text = temp.TenSach;
            CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");           
            lblGiaNhap.Text = double.Parse(temp.GiaNhap.ToString()).ToString("#,###", cul.NumberFormat);
            lblSLHienCo.Text = temp.SoLuong.ToString();
            _tg = tg;
        }

        private void btnThemSach_Click(object sender, System.EventArgs e)
        {
            if (numerSLNhap.Value <= 0 || temp == null)
            {
                Notification("Thêm không thành công !", "Chưa chọn sách hoặc số lượng <= 0", Resources.fail, false);
            }
            else if(temp != null)
            {
                bool isAdd = false;
                foreach(UCItemSachChon ctl in flpSachDaChon.Controls)
                {
                    if(temp.Id == ctl.id)
                    {
                        Notification("Thêm không thành công !", "Sách này đã được thêm trước đó !", Resources.fail, false);
                        isAdd = true;
                        break;
                    }
                }
                if (!isAdd)
                {
                    flpSachDaChon.Controls.Add(new UCItemSachChon(this, flpSachDaChon, temp, _tg, (int)numerSLNhap.Value));
                    listSelected.Add(temp.Id, (int) numerSLNhap.Value);
                    totalPrice = totalPrice + (numerSLNhap.Value * temp.GiaNhap);
                    lblTongTien.Text = double.Parse(totalPrice.ToString()).ToString("#,###", cul.NumberFormat)+" VND";
                    temp = null;
                    btnRmAll.Visible = true;
                    lblSLHienCo.Text = "";
                    lblTenSach.Text = "";
                    lblGiaNhap.Text = "";
                    numerSLNhap.Value = 0;
                }
            }
        }

        public void RmSelected(int id, decimal total)
        {
            if(listSelected.Count > 0)
            {
                totalPrice -= total;                
                lblTongTien.Text = totalPrice == 0 ? "0 VND" : double.Parse(totalPrice.ToString()).ToString("#,###", cul.NumberFormat) + " VND";
                listSelected.Remove(id);
            }   
            btnRmAll.Visible = listSelected.Count > 0 ? true : false;
        }

        private void btnRmAll_Click(object sender, EventArgs e)
        {
            flpSachDaChon.Controls.Clear();
            totalPrice = 0;
            listSelected.Clear();
            lblTongTien.Text = "0 VND";
            btnRmAll.Visible = false;
        }

        private void btnTaoHDXN_Click(object sender, EventArgs e)
        {
            if (listSelected.Count > 0)
            {                
                UCXacNhanHDNhap ucXNHDNhap = new UCXacNhanHDNhap(_taikhoan, listSelected, _NccId, _listTG, _listSTG, totalPrice);
                ucXNHDNhap.Dock = DockStyle.Fill;
                Controls.Add(ucXNHDNhap);
                Controls.SetChildIndex(ucXNHDNhap, 0);
            }
            else
            {
                Notification("Tạo không thành công", "Chưa thêm sách !", Resources.fail, false);
            }
        }

        public void GetsAllSTG(IEnumerable<TacGiaDTO> listTG, IEnumerable<SachTacGiaDTO> listSTG)
        {
            _listTG = listTG;
            _listSTG = listSTG;
        }
    }
}
