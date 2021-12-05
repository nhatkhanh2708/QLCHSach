using Service.DTOs;
using System;
using System.Windows.Forms;

namespace MVP.Views
{
    public partial class UCChiTietNCC : UserControl
    {
        private NccDTO _nccDTO;
        public UCChiTietNCC(NccDTO nccDTO)
        {
            InitializeComponent();
            _nccDTO = nccDTO;
        }

        private void UCChiTietNCC_Load(object sender, EventArgs e)
        {
            dtpNgayHopTac.Format = DateTimePickerFormat.Custom;
            dtpNgayHopTac.CustomFormat = "MM/dd/yyyy";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
