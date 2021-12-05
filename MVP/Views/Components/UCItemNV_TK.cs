using Service.DTOs;
using System;
using System.Windows.Forms;

namespace MVP.Views
{
    public partial class UCItemNV_TK : UserControl
    {
        private NhanVienDTO _nhanVienDTO;
        private Label _id, _ten, _ngaysinh;

        public UCItemNV_TK(NhanVienDTO nhanVienDTO, Label id, Label ten, Label ngaysinh)
        {
            InitializeComponent();
            _nhanVienDTO = nhanVienDTO;
            _id = id;
            _ten = ten;
            _ngaysinh = ngaysinh;
        }

        private void UCItemNV_TK_Load(object sender, EventArgs e)
        {
            lblId.Text = _nhanVienDTO.Id.ToString();
            lblTenNV.Text = _nhanVienDTO.HoTen;
            lblNgaySinh.Text = _nhanVienDTO.NgaySinh.ToShortDateString();
        }

        private void lblTenNV_Click(object sender, EventArgs e)
        {
            _id.Text = _nhanVienDTO.Id.ToString();
            _ten.Text = _nhanVienDTO.HoTen;
            _ngaysinh.Text = _nhanVienDTO.NgaySinh.ToShortDateString();
        }
    }
}
