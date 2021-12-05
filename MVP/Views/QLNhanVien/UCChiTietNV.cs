using System;
using System.Windows.Forms;

namespace MVP.Views
{
    public partial class UCChiTietNV : UserControl
    {
        public UCChiTietNV()
        {
            InitializeComponent();
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
