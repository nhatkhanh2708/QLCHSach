using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MVP.Views
{
    public partial class UCXacNhanHDNhap : UserControl
    {
        public UCXacNhanHDNhap()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void UCXacNhanHDNhap_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 30; i++)
                flp.Controls.Add(new UCItemSachThanhToan());
            hideScrollbar();
        }

        private void hideScrollbar()
        {
            flp.AutoScroll = false;
            flp.HorizontalScroll.Maximum = 0;
            flp.HorizontalScroll.Visible = false;
            flp.VerticalScroll.Maximum = 0;
            flp.VerticalScroll.Visible = false;
            flp.AutoScroll = true;
        }
    }
}
