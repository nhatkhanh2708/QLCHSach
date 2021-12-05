using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MVP.Views
{
    public partial class UCNhanVien : UserControl
    {
        public UCNhanVien()
        {
            InitializeComponent();
        }

        private void UCNhanVien_Load(object sender, EventArgs e)
        {
            loadflp();
            hideScrollBar();
        }

        private void loadflp()
        {
            for (int i = 0; i < 20; i++)
            {
                flp.Controls.Add(new UCItemNV(true, getPanelContainer));
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
            UCThemNV ucThemNV = new UCThemNV();
            ucThemNV.Dock = DockStyle.Fill;
            pnlContainer.Controls.Add(ucThemNV);
            pnlContainer.Controls.SetChildIndex(ucThemNV, 0);
        }

    }
}
