using System;
using System.Windows.Forms;

namespace MVP.Views
{
    public partial class UCThongKeDoanhThu : UserControl
    {
        public UCThongKeDoanhThu()
        {
            InitializeComponent();
        }

        private void UCThongKeDoanhThu_Load(object sender, EventArgs e)
        {
            dateFrom.Format = DateTimePickerFormat.Custom;
            dateFrom.CustomFormat = "dd-MM-yyyy";
            dateTo.Format = DateTimePickerFormat.Custom;
            dateTo.CustomFormat = "dd-MM-yyyy";
        }
    }
}
