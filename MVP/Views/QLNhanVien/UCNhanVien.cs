using MVP.IViews;
using MVP.Presenters;
using Service.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MVP.Views
{
    public partial class UCNhanVien : UserControl, INhanVienView
    {
        private NhanVienPresenter _nvPresenter;
        public UCNhanVien()
        {
            InitializeComponent();
            _nvPresenter = new NhanVienPresenter(this);
        }

        private void UCNhanVien_Load(object sender, EventArgs e)
        {
            hideScrollBar();
            loadAllNV();
        }

        private void loadAllNV()
        {
            _nvPresenter.GetsAll();
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
            UCThemNV ucThemNV = new UCThemNV();
            ucThemNV.Dock = DockStyle.Fill;
            pnlContainer.Controls.Add(ucThemNV);
            pnlContainer.Controls.SetChildIndex(ucThemNV, 0);
        }

        public void GetsAll(IEnumerable<NhanVienDTO> listNV)
        {
            for (int i = 0; i < listNV.Count(); i++)
            {
                flp.Controls.Add(new UCItemNV(listNV.ElementAt(i), getPanelContainer));
            }
        }
    }
}
