using MVP.IViews;
using MVP.Presenters;
using Service.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MVP.Views
{
    public partial class UCBan : UserControl, IBanView
    {
        private TaiKhoanDTO _taikhoan;
        private BanPresenter _banPresenter;
        private IEnumerable<HdXuatDTO> _listHdXuat;
        private NhanVienDTO _nv;
        public UCBan(TaiKhoanDTO taiKhoanDTO)
        {
            InitializeComponent();
            _taikhoan = taiKhoanDTO;
            _banPresenter = new BanPresenter(this);
        }

        private void UCNhap_Load(object sender, EventArgs e)
        {
            _banPresenter.GetsAllHdXuat();            
            loadflp();
            hideScrollBar();
        }

        private void loadflp()
        {
            for (int i = 0; i < _listHdXuat.Count(); i++)
            {
                _banPresenter.GetNVById(_listHdXuat.ElementAt(i).TaiKhoanId);
                if(_nv != null)
                    flp.Controls.Add(new UCItemBan(getPanelContainer, _nv, _listHdXuat.ElementAt(i)));
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
            UCThemHDBan ucThemHDBan = new UCThemHDBan(this, _taikhoan);
            ucThemHDBan.Dock = DockStyle.Fill;
            pnlContainer.Controls.Add(ucThemHDBan);
            pnlContainer.Controls.SetChildIndex(ucThemHDBan, 0);
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
                _banPresenter.GetsAllHdXuat();
                loadflp();
            }
        }

        private void btnMore_Click(object sender, EventArgs e)
        {

        }

        public void GetNV(NhanVienDTO nhanVienDTO)
        {
            _nv = nhanVienDTO;
        }

        public void GetsHdXuat(IEnumerable<HdXuatDTO> listHdXuat)
        {
            _listHdXuat = listHdXuat;
        }
    }
}
