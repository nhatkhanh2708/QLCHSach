using System;
using System.Windows.Forms;

namespace MVP.Views
{
    public partial class UCThemNCC : UserControl
    {
        public UCThemNCC()
        {
            InitializeComponent();
        }

        private void UCThemNCC_Load(object sender, EventArgs e)
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
