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
    public partial class Sach : Form
    {
        public Sach()
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

        private void button1_Click(object sender, EventArgs e)
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

        private void buttonHoTroTG_Click(object sender, EventArgs e)
        {
            SupportPickTacGia stacgia = new SupportPickTacGia();
            stacgia.ShowDialog();
        }

        private void Sach_Load(object sender, EventArgs e)
        {
            loadTheme();
        }

        private void buttonHoTroTL_Click(object sender, EventArgs e)
        {
            SupportPickTheLoai stheloai = new SupportPickTheLoai();
            stheloai.ShowDialog();
        }

        private void labelNXBID_Click(object sender, EventArgs e)
        {

        }
    }
}
