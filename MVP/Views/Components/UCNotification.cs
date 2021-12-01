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
            BackColor = Color.FromArgb(1, Color.Transparent);
            panel3.Location = new Point((Width - panel3.Width) / 2,
                (Height - panel3.Height) / 2);
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
