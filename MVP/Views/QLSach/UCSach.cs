using System;
using System.Windows.Forms;

namespace MVP.Views
{
    public partial class UCSach : UserControl
    {
        public UCSach()
        {
            InitializeComponent();
        }

        private void UCSach_Load(object sender, EventArgs e)
        {
            loadflp();
            hideScrollBar();
        }

        public Panel getPanelMain
        {
            get { return pnlMain; }
            set { pnlMain = value; }
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

        private void loadflp()
        {
            for (int i = 0; i < 20; i++)
            {
                flp.Controls.Add(new UCItemSach(getPanelMain));
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            UCThemSach ucThemSach = new UCThemSach();
            ucThemSach.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(ucThemSach);
            pnlMain.Controls.SetChildIndex(ucThemSach, 0);
        }
    }
}
