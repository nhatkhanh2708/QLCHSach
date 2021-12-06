using Service.DTOs;
using System;
using System.Windows.Forms;

namespace MVP.Views
{
    public partial class UCChiTietQuyen : UserControl
    {
        private QuyenDTO _quyenDTO;
        public UCChiTietQuyen(QuyenDTO quyenDTO)
        {
            InitializeComponent();
            _quyenDTO = quyenDTO;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void UCChiTietQuyen_Load(object sender, EventArgs e)
        {

        }
    }
}
