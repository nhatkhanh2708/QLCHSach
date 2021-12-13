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
    public partial class UCTacGia : UserControl, ITacGiaView
    {
        private IEnumerable<TacGiaDTO> _listTG;
        private TacGiaPresenter _TGPresenter;
        
        public UCTacGia()
        {
            InitializeComponent();
            _TGPresenter = new TacGiaPresenter(this);
        }

        private void UCTacGia_Load(object sender, EventArgs e)
        {
            loadData();
            dtgv.Columns["Id"].DisplayIndex = 0;
        }

        private void loadData()
        {
            _TGPresenter.GetsAll();
            dtgv.DataSource = _listTG.ToList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _TGPresenter.Add(txtTG.Text, txtButDanh.Text);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            _TGPresenter.Update(lblId.Text, txtTG.Text, txtButDanh.Text);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            _TGPresenter.Delete(lblId.Text);
        }

        private void refresh()
        {
            loadData();
            lblId.Text = "";
            txtButDanh.Text = "";
            txtTG.Text = "";
            txtTimKiem.Text = "";
        }

        private void btnRefesh_Click(object sender, EventArgs e)
        {
            refresh();
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

        public void GetsAll(IEnumerable<TacGiaDTO> listTG)
        {
            _listTG = listTG;
        }

        private void dtgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dtgv.Rows[e.RowIndex];
                lblId.Text = row.Cells["Id"].Value.ToString();
                txtTG.Text = row.Cells["HoTen"].Value.ToString();
                txtButDanh.Text = row.Cells["ButDanh"].Value.ToString();
            }
        }

        public void GetByTen(IEnumerable<TacGiaDTO> listTG)
        {
            _listTG = listTG;
            dtgv.DataSource = _listTG.ToList();
            lblId.Text = "";
            txtButDanh.Text = "";
            txtTG.Text = "";
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            _TGPresenter.GetByTen(txtTimKiem.Text);
        }
    }
}
