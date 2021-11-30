using System;
using System.Drawing;
using System.Windows.Forms;

namespace MVP.Views
{
    public partial class UCNotification : UserControl
    {
        public UCNotification(string title, string descript, Image img)
        {
            InitializeComponent();
            BackColor = Color.FromArgb(2, 0, 0, 0);
            panel1.BackColor = Color.FromArgb(2, 0, 0, 0);
            lblTitle.Text = title;
            if(descript != null)
                lblDescript.Text = descript;
            if(img != null)
                lblDescript.Image = img;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
