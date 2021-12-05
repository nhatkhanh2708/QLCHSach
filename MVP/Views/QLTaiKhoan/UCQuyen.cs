using System;
using System.Windows.Forms;

namespace MVP.Views
{
    public partial class UCQuyen : UserControl
    {
        public UCQuyen()
        {
            InitializeComponent();
        }

        private void UCQuyen_Load(object sender, EventArgs e)
        {
            hideScrollBar();

            for (int i = 0; i < 15; i++)
            {
                flp.Controls.Add(new UCItemQuyen());
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
            UCThemQuyen ucThemQuyen = new UCThemQuyen();
            ucThemQuyen.Dock = DockStyle.Fill;
            pnlContainer.Controls.Add(ucThemQuyen);
            pnlContainer.Controls.SetChildIndex(ucThemQuyen, 0);
        }
    }
}
