using MVP.IViews;
using MVP.Presenters;
using Service.DTOs;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace MVP.Views
{
    public partial class UCTacGia : UserControl, ITacGiaView
    {
        private IEnumerable<TacGiaDTO> _listTG;
        private TacGiaPresenter _TGPresenter;
        private BindingSource _tblTGs = new BindingSource();

        public UCTacGia()
        {
            InitializeComponent();
        }

        private void UCTacGia_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnRefesh_Click(object sender, EventArgs e)
        {

        }

        public void Notification(string title, string description, Image img, bool flag)
        {
            throw new NotImplementedException();
        }

        public void GetsAll(IEnumerable<TacGiaDTO> listTheLoai)
        {
            throw new NotImplementedException();
        }

    }
}
