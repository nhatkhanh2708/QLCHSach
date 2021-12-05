using System;
using System.Windows.Forms;

namespace MVP.Views
{
    public partial class UCTaiKhoan : UserControl
    {
        public UCTaiKhoan()
        {
            InitializeComponent();
        }

        private void UCTaiKhoan_Load(object sender, EventArgs e)
        {
            hideScrollBar();
            for (int i = 1; i < 15; i++)
                flp.Controls.Add(new UCItemTK());
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
    }
}
