using MVP.IViews;
using MVP.Presenters;
using Service.DTOs;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace MVP.Views
{
    public partial class NhaXuatBan : Form, INxbView
    {
        private IEnumerable<NhaXuatBanDTO> _nhaXuatBans;
        private NxbPresenter _nxbPresenter;

        public void GetListNXB(IEnumerable<NhaXuatBanDTO> listNXB)
        {
            _nhaXuatBans = listNXB;
        }
        public NhaXuatBan()
        {
            InitializeComponent();
            _nxbPresenter = new NxbPresenter(this);
            _nxbPresenter.GetList();
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
        private void NhaXuatBan_Load(object sender, EventArgs e)
        {
            loadTheme();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void labelIdNXB_Click(object sender, EventArgs e)
        {

        }

        private void buttonTimKiem_Click(object sender, EventArgs e)
        {

        }

        private void labelTimKiem_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        public void ThemThanhCong()
        {
            throw new NotImplementedException();
        }

        public void ThemThatBai()
        {
            throw new NotImplementedException();
        }

        public void XoaThanhCong()
        {
            throw new NotImplementedException();
        }

    }
}
