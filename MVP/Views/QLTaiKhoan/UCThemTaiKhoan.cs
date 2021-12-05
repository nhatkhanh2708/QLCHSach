using System;
using System.Windows.Forms;

namespace MVP.Views
{
    public partial class UCThemTaiKhoan : UserControl
    {
        public UCThemTaiKhoan()
        {
            InitializeComponent();
        }

        private void UCThemTaiKhoan_Load(object sender, EventArgs e)
        {
            hideScrollBar();
            for (int i = 0; i < 10; i++)
                flp.Controls.Add(new UCItemNV_TK());
        }

        private void hideScrollBar()
        {
            flp.AutoScroll = false;
            flp.HorizontalScroll.Maximum = 0;
            flp.HorizontalScroll.Visible = false;
            flp.VerticalScroll.Maximum = 0;
            flp.VerticalScroll.Visible = false;
            flp.AutoScroll = true;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Dispose();
        }        
    }
}
