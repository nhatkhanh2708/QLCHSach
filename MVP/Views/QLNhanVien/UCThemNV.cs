using System;
using System.Windows.Forms;

namespace MVP.Views
{
    public partial class UCThemNV : UserControl
    {
        public UCThemNV()
        {
            InitializeComponent();
        }

        private void UCThemNV_Load(object sender, EventArgs e)
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
