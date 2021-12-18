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
    public partial class UCThemHDBan : UserControl, IThemHDBanView
    {        
        private ThemHDBanPresenter _themHDBanPresenter;
        private SachDTO temp = null;
        private Dictionary<int, int> listSelected;
        CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");
        private decimal totalPrice = 0;
        private IEnumerable<SachDTO> _listSach;
        private IEnumerable<SachTacGiaDTO> _listSTG;
        private IEnumerable<TacGiaDTO> _listTG;
        private string _tg;
        private TaiKhoanDTO _taikhoan;
        private UCBan _ucBan;
        public UCThemHDBan(UCBan ucBan, TaiKhoanDTO taiKhoanDTO)
        {
            InitializeComponent();
            _taikhoan = taiKhoanDTO;
            _ucBan = ucBan;
            listSelected = new Dictionary<int, int>();
            _themHDBanPresenter = new ThemHDBanPresenter(this);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void UCThemHDBan_Load(object sender, EventArgs e)
        {
            refresh();
            load();
            hideScrollBar();
        }

        private void load()
        {
            _themHDBanPresenter.GetsAllSach();
            _themHDBanPresenter.GetsAllSTG();
            loadflp("");
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

        private void refresh()
        {
            flp.Controls.Clear();
            flpSachDaChon.Controls.Clear();
            txtTimKiem.Text = "";
            lblSLHienCo.Text = "";
            lblTenSach.Text = "";
            lblGiaBan.Text = "";
            lblTongTien.Text = "0 VND";
            numerSLBan.Value = 0;
            listSelected.Clear();
            _tg = "";
            temp = null;
            totalPrice = 0;
            btnRmAll.Visible = false;
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

        private void loadflp(string tensach)
        {
            var listSachSearch = _listSach.Where(p => p.TenSach.StartsWith(tensach));
            var _listTemp = _listTG.Join(_listSTG,
                p => p.Id,
                q => q.TacGiaId,
                (tg, stg) => new { tg.ButDanh, stg.SachId }
                );
            for (int i = 0; i < listSachSearch.Count(); i++)
            {
                string tg = "";
                for (int j = 0; j < _listTemp.Count(); j++)
                {
                    if (listSachSearch.ElementAt(i).Id == _listTemp.ElementAt(j).SachId)
                    {
                        tg += _listTemp.ElementAt(j).ButDanh + ", ";
                    }
                }
                tg = tg.Substring(0, tg.Length - 2);
                flp.Controls.Add(new UCItemSachBan(this, listSachSearch.ElementAt(i), tg));
            }
        }

        public void GetsAllSach(IEnumerable<SachDTO> listSach)
        {
            _listSach = listSach;
        }

        public void SelectedSach(SachDTO s, string tg)
        {
            temp = (SachDTO)s.Clone();
            lblTenSach.Text = temp.TenSach;
            lblGiaBan.Text = double.Parse(temp.GiaBan.ToString()).ToString("#,###", cul.NumberFormat);
            lblSLHienCo.Text = temp.SoLuong.ToString();
            _tg = tg;
        }

        public void RmSelected(int id, decimal total)
        {
            if (listSelected.Count > 0)
            {
                totalPrice -= total;
                lblTongTien.Text = totalPrice == 0 ? "0 VND" : double.Parse(totalPrice.ToString()).ToString("#,###", cul.NumberFormat) + " VND";
                listSelected.Remove(id);
            }
            btnRmAll.Visible = listSelected.Count > 0 ? true : false;
        }

        public void GetsAllSTG(IEnumerable<TacGiaDTO> listTG, IEnumerable<SachTacGiaDTO> listSTG)
        {
            _listTG = listTG;
            _listSTG = listSTG;
        }

        private void btnThemSach_Click(object sender, EventArgs e)
        {
            if (numerSLBan.Value <= 0 || temp == null || numerSLBan.Value > temp.SoLuong)
            {
                Notification("Thêm không thành công", "Chưa chọn sách hoặc số lượng không hợp lệ !", Resources.fail, false);
            }
            else if (temp != null)
            {
                bool isAdd = false;
                foreach (UCItemSachBanChon ctl in flpSachDaChon.Controls)
                {
                    if (temp.Id == ctl.id)
                    {
                        Notification("Thêm không thành công !", "Sách này đã được thêm trước đó !", Resources.fail, false);
                        isAdd = true;
                        break;
                    }
                }
                if (!isAdd)
                {
                    flpSachDaChon.Controls.Add(new UCItemSachBanChon(this, flpSachDaChon, temp, _tg, (int)numerSLBan.Value));
                    listSelected.Add(temp.Id, (int)numerSLBan.Value);
                    totalPrice = totalPrice + (numerSLBan.Value * temp.GiaBan);
                    lblTongTien.Text = double.Parse(totalPrice.ToString()).ToString("#,###", cul.NumberFormat) + " VND";
                    temp = null;
                    btnRmAll.Visible = true;
                    lblSLHienCo.Text = "";
                    lblTenSach.Text = "";
                    lblGiaBan.Text = "";
                    numerSLBan.Value = 0;
                }
            }
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
                UCXacNhanHDBan ucXNHDBan = new UCXacNhanHDBan(this, _taikhoan, listSelected, _listSach, _listTG, _listSTG, totalPrice);
                ucXNHDBan.Dock = DockStyle.Fill;
                Controls.Add(ucXNHDBan);
                Controls.SetChildIndex(ucXNHDBan, 0);
            }
            else
            {
                Notification("Tạo không thành công", "Chưa thêm sách !", Resources.fail, false);
            }
        }

        public void CompleteCreatedBill(bool isComplete)
        {
            if (isComplete)
            {
                _ucBan.LoadBillNew(isComplete);
                Dispose();
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            flp.Controls.Clear();
            loadflp(txtTimKiem.Text);
        }
    }
}
