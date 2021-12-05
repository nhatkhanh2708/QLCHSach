using System;
using System.Windows.Forms;

namespace MVP.Views
{
    public partial class UCNhaCungCap : UserControl
    {
        public UCNhaCungCap()
        {
            InitializeComponent();
        }

        private void UCNhaCungCap_Load(object sender, EventArgs e)
        {
            loadflp();
            hideScrollBar();
        }

        private void loadflp()
        {
            for (int i = 0; i < 20; i++)
            {
                flp.Controls.Add(new UCItemNcc(true, getPanelContainer));
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
            UCThemNCC ucThemNCC = new UCThemNCC();
            ucThemNCC.Dock = DockStyle.Fill;
            pnlContainer.Controls.Add(ucThemNCC);
            pnlContainer.Controls.SetChildIndex(ucThemNCC, 0);
        }
    }
}
