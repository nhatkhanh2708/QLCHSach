using System;
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
            UCChiTietSach ucChiTietSach = new UCChiTietSach();
            ucChiTietSach.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(ucChiTietSach);
            pnlMain.Controls.SetChildIndex(ucChiTietSach, 0);
        }
    }
}
