using Service.DTOs;
using System;
using System.Windows.Forms;

namespace MVP.Views
{
    public partial class UCThongTinSach : UserControl
    {
        public UCThongTinSach()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
