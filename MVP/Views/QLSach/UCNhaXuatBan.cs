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
    public partial class UCNhaXuatBan : UserControl, INXBView
    {
        private IEnumerable<NhaXuatBanDTO> _listNXB;
        private NXBPresenter _nxbPresenter;
        private BindingSource _tblNXBs = new BindingSource();
        public UCNhaXuatBan()
        {
            InitializeComponent();
            _nxbPresenter = new NXBPresenter(this);
        }

        private void UCNhaXuatBan_Load(object sender, EventArgs e)
        {
            loadData();
            dtgv.DataSource = _tblNXBs;
            dtgv.Columns["Id"].DisplayIndex = 0;
            AddBinding();
        }

        private void AddBinding()
        {
            lblId.DataBindings.Add(new Binding("Text", _tblNXBs.DataSource, "Id", true, DataSourceUpdateMode.Never));
            txtNXB.DataBindings.Add(new Binding("Text", _tblNXBs.DataSource, "TenNxb", true, DataSourceUpdateMode.Never));
            txtVietTat.DataBindings.Add(new Binding("Text", _tblNXBs.DataSource, "VietTat", true, DataSourceUpdateMode.Never));
        }

        private void loadData()
        {
            _nxbPresenter.GetsAll();
            _tblNXBs.DataSource = _listNXB.ToList();
        }

        public void GetsAll(IEnumerable<NhaXuatBanDTO> listNXB)
        {
            _listNXB = listNXB;
        }

        public void Notification(string title, string description, Image img, bool flag)
        {
            UCNotification ucNotifi = new UCNotification(title, description, img);
            ucNotifi.Anchor = AnchorStyles.None;
            ucNotifi.Location = new Point((panel2.Width - ucNotifi.Width) / 2,
                (panel2.Height - ucNotifi.Height) / 2);
            panel2.Controls.Add(ucNotifi);
            panel2.Controls.SetChildIndex(ucNotifi, 0);
            if (flag)
                loadData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _nxbPresenter.Add(txtNXB.Text, txtVietTat.Text);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            _nxbPresenter.Update(lblId.Text, txtNXB.Text, txtVietTat.Text);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            _nxbPresenter.Delete(lblId.Text);
        }

        private void btnRefesh_Click(object sender, EventArgs e)
        {
            refresh();
        }

        private void refresh()
        {
            loadData();
            lblId.Text = "";
            txtNXB.Text = "";
            txtVietTat.Text = "";
            txtTimKiem.Text = "";
        }
    }
}
