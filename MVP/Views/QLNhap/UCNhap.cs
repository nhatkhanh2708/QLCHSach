using MVP.IViews;
using MVP.Presenters;
using Service.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MVP.Views
{
    public partial class UCNhap : UserControl, INhapView
    {
        private TaiKhoanDTO _taikhoan;
        private NhapPresenter _nhapPresenter;
        private IEnumerable<NccDTO> _listNcc;
        private IEnumerable<HdNhapDTO> _listHdNhap;
        public UCNhap(TaiKhoanDTO taiKhoanDTO)
        {
            InitializeComponent();
            _taikhoan = taiKhoanDTO;
            _nhapPresenter = new NhapPresenter(this);
        }

        private void UCNhap_Load(object sender, EventArgs e)
        {
            _nhapPresenter.GetsAllNcc();
            _nhapPresenter.GetsAllHdNhap();
            loadflp();
            hideScrollBar();
        }

        private void loadflp()
        {
            var listTemp = _listNcc.Join(_listHdNhap,
                    p => p.Id,
                    q => q.NccId,
                    ( nc, hd) => new {nc, hd}
                );
            listTemp = listTemp.OrderByDescending(p => p.hd.NgayTao);
            for (int i = 0; i < listTemp.Count(); i++)
            {
                flp.Controls.Add(new UCItemNhap(getPanelContainer, listTemp.ElementAt(i).nc, listTemp.ElementAt(i).hd));
            }
        }

        public Panel getPanelContainer
        {
            get { return pnlContainer; }
            set { pnlContainer = value; }
        }

        private void hideScrollBar()
        {
            flp.AutoScroll = false;
            flp.HorizontalScroll.Maximum = 0;
            flp.HorizontalScroll.Visible = false;
            flp.VerticalScroll.Maximum = 0;
            flp.VerticalScroll.Visible = false;
            flp.AutoScroll = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            UCThemHDNhap ucThemHDNhap = new UCThemHDNhap(this, _taikhoan);
            ucThemHDNhap.Dock = DockStyle.Fill;
            pnlContainer.Controls.Add(ucThemHDNhap);
            pnlContainer.Controls.SetChildIndex(ucThemHDNhap, 0);
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {

        }

        private void btnRefesh_Click(object sender, EventArgs e)
        {
            flp.Controls.Clear();
            loadflp();
        }

        public void LoadBillNew(bool isComplete)
        {
            if (isComplete)
            {
                flp.Controls.Clear();
                _nhapPresenter.GetsAllHdNhap();
                loadflp();
            }
        }

        private void btnMore_Click(object sender, EventArgs e)
        {

        }

        public void GetsNcc(IEnumerable<NccDTO> listNcc)
        {
            _listNcc = listNcc;
        }

        public void GetsHdNhap(IEnumerable<HdNhapDTO> listHdNhap)
        {
            _listHdNhap = listHdNhap;
        }
    }
}
