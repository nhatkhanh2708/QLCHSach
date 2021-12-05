using MVP.Properties;
using System;
using System.Windows.Forms;

namespace MVP.Views
{
    public partial class UCItemNV : UserControl
    {
        private bool _male;
        private Panel _pnlContainer;
        public UCItemNV(bool isMale, Panel pnlContainer)
        {
            InitializeComponent();
            _male = isMale;
            _pnlContainer = pnlContainer;
        }

        private void UCItemNV_Load(object sender, EventArgs e)
        {
            lblGender.Image = _male ? Resources.icons8_male_24 : Resources.icons8_female_24;
            lblStatus.Image = true ? Resources.icons8_filled_circle_green : Resources.icons8_filled_circle_red;
        }

        private void lblTenNv_Click(object sender, EventArgs e)
        {
            UCChiTietNV ucChiTietNV = new UCChiTietNV();
            ucChiTietNV.Dock = DockStyle.Fill;
            _pnlContainer.Controls.Add(ucChiTietNV);
            _pnlContainer.Controls.SetChildIndex(ucChiTietNV, 0);
        }
    }
}
