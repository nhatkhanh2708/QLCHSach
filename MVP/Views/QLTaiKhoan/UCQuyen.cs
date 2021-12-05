using MVP.IViews;
using MVP.Presenters;
using Service.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MVP.Views
{
    public partial class UCQuyen : UserControl, IQuyenView
    {
        private QuyenPresenter _quyenPresenter;

        public UCQuyen()
        {
            InitializeComponent();
            _quyenPresenter = new QuyenPresenter(this);
        }

        private void UCQuyen_Load(object sender, EventArgs e)
        {
            hideScrollBar();
            loadQuyen();
        }

        private void loadQuyen()
        {
            _quyenPresenter.GetsAll();
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
            UCThemQuyen ucThemQuyen = new UCThemQuyen();
            ucThemQuyen.Dock = DockStyle.Fill;
            pnlContainer.Controls.Add(ucThemQuyen);
            pnlContainer.Controls.SetChildIndex(ucThemQuyen, 0);
        }

        public void GetsAll(IEnumerable<QuyenDTO> listQuyen)
        {
            for (int i = 0; i < listQuyen.Count(); i++)
            {
                flp.Controls.Add(new UCItemQuyen(listQuyen.ElementAt(i), getPanelContainer));
            }
        }

        private void btnRefesh_Click(object sender, EventArgs e)
        {
            flp.Controls.Clear();
            txtTimKiem.Text = "";
            loadQuyen();
        }
    }
}
