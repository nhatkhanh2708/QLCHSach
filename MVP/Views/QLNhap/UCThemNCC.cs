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

        private void btnBack_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
