using MVP.Properties;
using System;
using System.Windows.Forms;

namespace MVP.Views
{
    public partial class UCItemNcc : UserControl
    {
        private bool _active;
        public UCItemNcc(bool isActive)
        {
            InitializeComponent();
            _active = isActive;
        }

        private void UCItemNcc_Load(object sender, EventArgs e)
        {
            lblStatus.Image = _active ? Resources.icons8_filled_circle_green : Resources.icons8_filled_circle_red;
        }

        private void lblTenNcc_Click(object sender, EventArgs e)
        {

        }
    }
}
