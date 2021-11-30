using System;
using System.Drawing;
using System.Windows.Forms;

namespace MVP.Views
{
    public partial class UCItemSach : UserControl
    {
        private Panel pnlMain;
        public UCItemSach(Panel pnlMain)
        {
            InitializeComponent();
            this.pnlMain = pnlMain;
        }
        private void pic_Click(object sender, EventArgs e)
        {
            UCThongTinSach ucThongTinSach = new UCThongTinSach();
            ucThongTinSach.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(ucThongTinSach);
            pnlMain.Controls.SetChildIndex(ucThongTinSach, 0);
        }
    }
}
