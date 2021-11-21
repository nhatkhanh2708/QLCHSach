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
    public partial class NhanVien : Form
    {
        public NhanVien()
        {
            InitializeComponent();
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
        private void NhanVien_Load(object sender, EventArgs e)
        {
            loadTheme();
        }

        private void buttonXem_Click(object sender, EventArgs e)
        {
            ChiTietNhanVien ctnv = new ChiTietNhanVien();
            ctnv.ShowDialog();
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            AddNhanVien addnv = new AddNhanVien();
            addnv.ShowDialog();
        }

        private void buttonSua_Click(object sender, EventArgs e)
        {
            SuaNhanVien suanv = new SuaNhanVien();
            suanv.ShowDialog();
        }
    }
}
