using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVP.Views
{
    public partial class SupportPickTheLoai : Form
    {
        public SupportPickTheLoai()
        {
            InitializeComponent();
            this.Text = string.Empty;
        }
        private void loadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SencondaryColor;
                }
            }
        }

        private void buttonTimKiem_Click(object sender, EventArgs e)
        {

        }

        private void buttonChon_Click(object sender, EventArgs e)
        {

        }

        private void buttonHuy_Click(object sender, EventArgs e)
        {

        }

        private void SupportPickTheLoai_Load(object sender, EventArgs e)
        {
            loadTheme();
        }
    }
}
