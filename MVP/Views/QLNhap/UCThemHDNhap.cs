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
        public UCThemHDNhap()
        {
            InitializeComponent();
            _themHDNhapPresenter = new ThemHDNhapPresenter(this);
            listSelected = new Dictionary<int, int>();
        }

        private void btnBack_Click(object sender, System.EventArgs e)
        {
            Dispose();
        }

        private void UCThemHDNhap_Load(object sender, System.EventArgs e)
        {
            isLoad = true;
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
            /*if (flag)
            {
                lblSLHienCo.Text = "";
                lblTenSach.Text = "";
                lblGiaNhap.Text = "";
                numerSLNhap.Value = 0;
            }*/
        }

        public void GetsAllNCC(IEnumerable<NccDTO> listNcc)
        {
            cbxNcc.DataSource = listNcc.ToList();
            cbxNcc.DisplayMember = "TenNCC";
            cbxNcc.ValueMember = "Id";
        }

        public void GetsSachByNccId(IEnumerable<SachDTO> listSach)
        {
            flp.Controls.Clear();
            for (int i = 0; i < listSach.Count(); i++)
            {
                flp.Controls.Add(new UCItemSachNhap(this, listSach.ElementAt(i)));
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
                    flpSachDaChon.Controls.Clear();
                    refresh();
                    _themHDNhapPresenter.GetsSachByNccId(_NccId);
                }
            }
        }

        private void refresh()
        {
            txtTimKiem.Text = "";
            lblSLHienCo.Text = "";
            lblTenSach.Text = "";
            lblGiaNhap.Text = "";
            lblTongTien.Text = "0 VND";
            numerSLNhap.Value = 0;
            listSelected.Clear();
            temp = null;
            totalPrice = 0;
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
            flp.Controls.Clear();
            for (int i = 0; i < listSach.Count(); i++)
            {
                flp.Controls.Add(new UCItemSachNhap(this, listSach.ElementAt(i)));
            }
        }

        public void SelectedSach(SachDTO s)
        {
            temp = (SachDTO) s.Clone();
            lblTenSach.Text = temp.TenSach;
            CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");           
            lblGiaNhap.Text = double.Parse(temp.GiaNhap.ToString()).ToString("#,###", cul.NumberFormat);
            lblSLHienCo.Text = temp.SoLuong.ToString();
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
                    flpSachDaChon.Controls.Add(new UCItemSachChon(this, flpSachDaChon, temp, (int)numerSLNhap.Value));
                    listSelected.Add(temp.Id, (int) numerSLNhap.Value);
                    totalPrice = totalPrice + (numerSLNhap.Value * temp.GiaNhap);
                    lblTongTien.Text = double.Parse(totalPrice.ToString()).ToString("#,###", cul.NumberFormat)+" VND";
                    temp = null;
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
                lblTongTien.Text = double.Parse(totalPrice.ToString()).ToString("#,###", cul.NumberFormat) + " VND";
                listSelected.Remove(id);
            }
        }

        private void btnThem_Click(object sender, System.EventArgs e)
        {

        }

        private void btnRmAll_Click(object sender, EventArgs e)
        {
            flpSachDaChon.Controls.Clear();
            temp = null;
            totalPrice = 0;
            listSelected.Clear();
        }
    }
}
