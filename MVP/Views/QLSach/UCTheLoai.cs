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
        private List<TheLoaiDTO> _listTheLoai;
        private TheLoaiPresenter _theLoaiPresenter;
        public UCTheLoai()
        {
            InitializeComponent();
            _theLoaiPresenter = new TheLoaiPresenter(this);
        }

        private void UCTheLoai_Load(object sender, EventArgs e)
        {
            _theLoaiPresenter.GetsAll();
            refresh();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _theLoaiPresenter.AddCategory(txtTheLoai.Text);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            _theLoaiPresenter.UpdateCategory(lblId.Text, txtTheLoai.Text);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            _theLoaiPresenter.DeleteCategory(lblId.Text);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            refresh();
        }

        private void refresh()
        {
            txtTimKiem.Text = "";
            lblId.Text = "";
            txtTheLoai.Text = "";
        }

        public void Notification(string title, string description, Image img)
        {
            UCNotification ucNotifi = new UCNotification(title, description, img);
            panel2.Controls.Add(ucNotifi);
            panel2.Controls.SetChildIndex(ucNotifi, 0);
        }

        public void GetsAll(IEnumerable<TheLoaiDTO> listTheLoai)
        {
            _listTheLoai = listTheLoai.ToList();
        }
    }
}
