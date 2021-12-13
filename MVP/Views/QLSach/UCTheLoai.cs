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
    public partial class UCTheLoai : UserControl, ITheLoaiView
    {
        private IEnumerable<TheLoaiDTO> _listTheLoai;
        private TheLoaiPresenter _theLoaiPresenter;
        
        public UCTheLoai()
        {
            InitializeComponent();
            _theLoaiPresenter = new TheLoaiPresenter(this);
        }

        private void UCTheLoai_Load(object sender, EventArgs e)
        {            
            loadData();
            dtgv.Columns["Id"].DisplayIndex = 0;
        }

        private void loadData()
        {
            _theLoaiPresenter.GetsAll();
            dtgv.DataSource = _listTheLoai;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _theLoaiPresenter.Add(txtTheLoai.Text);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            _theLoaiPresenter.Update(lblId.Text, txtTheLoai.Text);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            _theLoaiPresenter.Delete(lblId.Text);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            refresh();
        }

        private void refresh()
        {
            loadData();
            txtTimKiem.Text = "";
            lblId.Text = "";
            txtTheLoai.Text = "";
        }

        public void Notification(string title, string description, Image img, bool flag)
        {
            UCNotification ucNotifi = new UCNotification(title, description, img);
            ucNotifi.Anchor = AnchorStyles.None;
            ucNotifi.Location = new Point((panel2.Width-ucNotifi.Width) / 2 ,
                (panel2.Height - ucNotifi.Height) / 2);
            panel2.Controls.Add(ucNotifi);
            panel2.Controls.SetChildIndex(ucNotifi, 0);
            if (flag)
                loadData();
        }

        public void GetsAll(IEnumerable<TheLoaiDTO> listTheLoai)
        {
            _listTheLoai = listTheLoai;
        }

        private void dtgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dtgv.Rows[e.RowIndex];
                lblId.Text = row.Cells["Id"].Value.ToString();
                txtTheLoai.Text = row.Cells["TenTheLoai"].Value.ToString();
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            _theLoaiPresenter.GetByTen(txtTimKiem.Text);
        }

        public void GetByTen(IEnumerable<TheLoaiDTO> listTheLoai)
        {
            _listTheLoai = listTheLoai;
            dtgv.DataSource = _listTheLoai;
            lblId.Text = "";
            txtTheLoai.Text = "";
        }
    }
}
