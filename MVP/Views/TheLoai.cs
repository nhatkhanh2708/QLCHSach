using System;
using System.Drawing;
using System.Windows.Forms;

namespace MVP.Views
{
    public partial class TheLoai : Form
    {
        public TheLoai()
        {
            InitializeComponent();
        }
        private void loadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button) && !btns.Name.Equals("buttonXoa"))
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

        private void buttonThem_Click(object sender, EventArgs e)
        {

        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {

        }

        private void buttonSua_Click(object sender, EventArgs e)
        {

        }

        private void buttonDatLai_Click(object sender, EventArgs e)
        {

        }

        private void TheLoai_Load(object sender, EventArgs e)
        {
            loadTheme();
        }
    }
}
