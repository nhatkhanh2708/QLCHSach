using MVP.IViews;
using MVP.Presenters;
using Service.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MVP.Views
{
    public partial class UCNhaCungCap : UserControl, INhaCungCapView
    {
        private NhaCungCapPresenter _nccPresenter;
        public UCNhaCungCap()
        {
            InitializeComponent();
            _nccPresenter = new NhaCungCapPresenter(this);
        }

        private void UCNhaCungCap_Load(object sender, EventArgs e)
        {
            hideScrollBar();
            loadAllNcc();
        }

        private void loadAllNcc()
        {
            _nccPresenter.GetsAll();
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
            UCThemNCC ucThemNCC = new UCThemNCC();
            ucThemNCC.Dock = DockStyle.Fill;
            pnlContainer.Controls.Add(ucThemNCC);
            pnlContainer.Controls.SetChildIndex(ucThemNCC, 0);
        }

        public void GetsAll(IEnumerable<NccDTO> listNcc)
        {
            for (int i = 0; i < listNcc.Count(); i++)
            {
                flp.Controls.Add(new UCItemNcc(listNcc.ElementAt(i), getPanelContainer));

            }
        }
    }
}
