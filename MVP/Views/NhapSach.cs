﻿using System;
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
    public partial class NhapSach : Form
    {
        public NhapSach()
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
        private void buttonTimKiem_Click(object sender, EventArgs e)
        {

        }
        private void buttonXoa_Click(object sender, EventArgs e)
        {

        }

        private void buttonSua_Click(object sender, EventArgs e)
        {

        }

        private void NhapSach_Load(object sender, EventArgs e)
        {
            loadTheme();
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            ThemPhieuNhap themphieunhap = new ThemPhieuNhap();
            themphieunhap.ShowDialog();
        }
    }
}
