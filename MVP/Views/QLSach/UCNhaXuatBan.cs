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
        public UCNhaXuatBan()
        {
            InitializeComponent();
            _nxbPresenter = new NXBPresenter(this);
        }

        private void UCNhaXuatBan_Load(object sender, EventArgs e)
        {
            loadData();
            dtgv.Columns["Id"].DisplayIndex = 0;
        }

        private void loadData()
        {
            _nxbPresenter.GetsAll();
            dtgv.DataSource = _listNXB.ToList();
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

        private void dtgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dtgv.Rows[e.RowIndex];
                lblId.Text = row.Cells["Id"].Value.ToString();
                txtNXB.Text = row.Cells["TenNxb"].Value.ToString();
                txtVietTat.Text = row.Cells["VietTat"].Value.ToString();
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            _nxbPresenter.GetByTen(txtTimKiem.Text);
        }

        public void GetByTen(IEnumerable<NhaXuatBanDTO> listNXB)
        {
            _listNXB = listNXB;
            dtgv.DataSource = _listNXB.ToList();
            lblId.Text = "";
            txtNXB.Text = "";
            txtVietTat.Text = "";
        }
    }
}
