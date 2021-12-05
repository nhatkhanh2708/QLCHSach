using System;
using System.Windows.Forms;

namespace MVP.Views
{
    public partial class UCChiTietQuyen : UserControl
    {
        public UCChiTietQuyen()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
