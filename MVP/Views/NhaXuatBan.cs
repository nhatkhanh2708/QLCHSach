using MVP.IViews;
using MVP.Presenters;
using Service.DTOs;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace MVP.Views
{
    public partial class NhaXuatBan : Form, INxbView
    {
        private IEnumerable<NhaXuatBanDTO> _nhaXuatBans;
        private NxbPresenter _nxbPresenter;
        private BindingSource tblNXBs = new BindingSource();

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

        private void loadData()
        {
            dataGV.DataSource = tblNXBs;
            tblNXBs.DataSource = _nhaXuatBans.ToList();
            //Sắp xếp id lên cột đầu tiên
            dataGV.Columns["Id"].DisplayIndex = 0;
            addBinding();

        }

        // Binding row lên textbox tương ứng
        private void addBinding()
        {
            lbId.DataBindings.Add(new Binding("Text", tblNXBs.DataSource, "Id", true, DataSourceUpdateMode.Never));
            textBoxTenNXB.DataBindings.Add(new Binding("Text", tblNXBs.DataSource, "TenNxb", true, DataSourceUpdateMode.Never));
            textBoxVietTat.DataBindings.Add(new Binding("Text", tblNXBs.DataSource, "VietTat", true, DataSourceUpdateMode.Never));
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
            loadData();
        }

        private void buttonTimKiem_Click(object sender, EventArgs e)
        {

        }

        public void ThemThanhCong()
        {
            
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
