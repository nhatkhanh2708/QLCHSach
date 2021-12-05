using Service.DTOs;
using System;
using System.Windows.Forms;

namespace MVP.Views
{
    public partial class UCChiTietNV : UserControl
    {
        private NhanVienDTO _nvDTO;
        public UCChiTietNV(NhanVienDTO nhanVienDTO)
        {
            InitializeComponent();
            _nvDTO = nhanVienDTO;
        }

        private void UCChiTietNV_Load(object sender, EventArgs e)
        {
            dtpNgaySinh.Format = DateTimePickerFormat.Custom;
            dtpNgaySinh.CustomFormat = "MM/dd/yyyy";
            dtpNgayBatDau.Format = DateTimePickerFormat.Custom;
            dtpNgayBatDau.CustomFormat = "MM/dd/yyyy";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Dispose();
        }

    }
}
