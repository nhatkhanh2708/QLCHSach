using System;
using System.Windows.Forms;

namespace MVP.Views
{
    public partial class UCItemSach : UserControl
    {
        private Panel _pnlCont;
        public UCItemSach(Panel pnlCont)
        {
            InitializeComponent();
            _pnlCont = pnlCont;
        }
        private void pic_Click(object sender, EventArgs e)
        {
            UCChiTietSach ucChiTietSach = new UCChiTietSach();
            ucChiTietSach.Dock = DockStyle.Fill;
            _pnlCont.Controls.Add(ucChiTietSach);
            _pnlCont.Controls.SetChildIndex(ucChiTietSach, 0);
        }
    }
}
