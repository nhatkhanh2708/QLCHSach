using System;
using System.Windows.Forms;

namespace MVP.Views
{
    public partial class UCItemNhap : UserControl
    {
        private Panel pnlContainer;
        public UCItemNhap(Panel pnlCont)
        {
            InitializeComponent();
            pnlContainer = pnlCont;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            UCChiTietHDNhap ucChiTietNhap = new UCChiTietHDNhap();
            ucChiTietNhap.Dock = DockStyle.Fill;
            pnlContainer.Controls.Add(ucChiTietNhap);
            pnlContainer.Controls.SetChildIndex(ucChiTietNhap, 0);
        }
    }
}
