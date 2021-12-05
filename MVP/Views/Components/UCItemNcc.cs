using MVP.Properties;
using System;
using System.Windows.Forms;

namespace MVP.Views
{
    public partial class UCItemNcc : UserControl
    {
        private bool _active;
        private Panel _pnlContainer;
        public UCItemNcc(bool isActive, Panel pnlContainer)
        {
            InitializeComponent();
            _active = isActive;
            _pnlContainer = pnlContainer;
        }

        private void UCItemNcc_Load(object sender, EventArgs e)
        {
            lblStatus.Image = _active ? Resources.icons8_filled_circle_green : Resources.icons8_filled_circle_red;
        }

        private void lblTenNcc_Click(object sender, EventArgs e)
        {
            UCChiTietNCC ucChiTietNCC = new UCChiTietNCC();
            ucChiTietNCC.Dock = DockStyle.Fill;
            _pnlContainer.Controls.Add(ucChiTietNCC);
            _pnlContainer.Controls.SetChildIndex(ucChiTietNCC, 0);
        }
    }
}
