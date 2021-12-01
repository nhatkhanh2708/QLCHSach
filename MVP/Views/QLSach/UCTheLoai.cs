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
        private BindingSource _tblTheLoais = new BindingSource();
        
        public UCTheLoai()
        {
            InitializeComponent();
            _theLoaiPresenter = new TheLoaiPresenter(this);
        }

        private void UCTheLoai_Load(object sender, EventArgs e)
        {            
            loadData();
            dtgv.DataSource = _tblTheLoais;
            dtgv.Columns["Id"].DisplayIndex = 0;
            AddBinding();
        }

        private void loadData()
        {
            _theLoaiPresenter.GetsAll();
            _tblTheLoais.DataSource = _listTheLoai.ToList();
        }

        private void AddBinding()
        {
            lblId.DataBindings.Add(new Binding("Text", _tblTheLoais.DataSource, "Id", true, DataSourceUpdateMode.Never));
            txtTheLoai.DataBindings.Add(new Binding("Text", _tblTheLoais.DataSource, "TenTheLoai", true, DataSourceUpdateMode.Never));
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
    }
}
