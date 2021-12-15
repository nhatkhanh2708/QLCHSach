using Service.DTOs;
using System;
using System.Windows.Forms;

namespace MVP.Views
{
    public partial class UCItemSachChon : UserControl
    {
        private SachDTO _sach;
        private int _slNhap;
        private FlowLayoutPanel _flp;
        public int id;
        public UCItemSachChon(FlowLayoutPanel flp, SachDTO sachDTO, int slnhap)
        {
            InitializeComponent();
            _sach = sachDTO;
            _slNhap = slnhap;
            _flp = flp;
        }

        private void UCItemSachChon_Load(object sender, EventArgs e)
        {
            lblSach.Text = _sach.TenSach;
            lblSlNhap.Text = _slNhap.ToString();
            id = _sach.Id;
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            _flp.Controls.Remove(this);
        }
    }
}
