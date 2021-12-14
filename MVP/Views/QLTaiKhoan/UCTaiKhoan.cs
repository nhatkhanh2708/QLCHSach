using MVP.IViews;
using MVP.Presenters;
using Service.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MVP.Views
{
    public partial class UCTaiKhoan : UserControl, ITaiKhoanView
    {
        private IEnumerable<TaiKhoanDTO> _listTK;
        private IEnumerable<NhanVienDTO> _listNV;
        private TaiKhoanPresenter _taiKhoanPresenter;
        public UCTaiKhoan()
        {
            InitializeComponent();
            _taiKhoanPresenter = new TaiKhoanPresenter(this);
        }

        private void UCTaiKhoan_Load(object sender, EventArgs e)
        {
            hideScrollBar();
            loadTaiKhoan();
        }

        private void loadTaiKhoan()
        {
            _taiKhoanPresenter.GetsAllTaiKhoan();
            _taiKhoanPresenter.GetsAllNhanVien();
            var results = _listNV.Join(_listTK,
                      wo => wo.Id,
                      p => p.NhanVienId,
                      (nv, tk) => new {nv, tk}
                    );
            for (int i=0; i < results.Count(); i++)
            {
                flp.Controls.Add(new UCItemTK(results.ElementAt(i).nv, results.ElementAt(i).tk, getPanelContainer));
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
            UCThemTaiKhoan ucThemTK = new UCThemTaiKhoan();
            ucThemTK.Dock = DockStyle.Fill;
            pnlContainer.Controls.Add(ucThemTK);
            pnlContainer.Controls.SetChildIndex(ucThemTK, 0);
        }

        private void btnRefesh_Click(object sender, EventArgs e)
        {
            flp.Controls.Clear();
            loadTaiKhoan();
        }

        public void GetsAllTaiKhoan(IEnumerable<TaiKhoanDTO> listTK)
        {
            _listTK = listTK;
        }

        public void GetsAllNhanVien(IEnumerable<NhanVienDTO> listNV)
        {
            _listNV = listNV;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            flp.Controls.Clear();
            List<TaiKhoanDTO> listtemptk = new List<TaiKhoanDTO>();
            foreach (TaiKhoanDTO tk in _listTK)
            {
                if (tk.Username.StartsWith(txtTimKiem.Text))
                {
                    listtemptk.Add(tk);
                }
            }
            var results = _listNV.Join(listtemptk,
                      wo => wo.Id,
                      p => p.NhanVienId,
                      (nv, tk) => new { nv, tk }
                    );
            for (int i = 0; i < results.Count(); i++)
            {
                
                flp.Controls.Add(new UCItemTK(results.ElementAt(i).nv, results.ElementAt(i).tk, getPanelContainer));
            }
        }
    }
}
