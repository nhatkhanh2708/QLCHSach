using Service.DTOs;
using System;
using System.Windows.Forms;

namespace MVP.Views
{
    public partial class UCItemTK : UserControl
    {
        private Panel _pnlContainer;
        private TaiKhoanDTO _taiKhoanDTO;
        private NhanVienDTO _nhanvienDTO;
        public UCItemTK(NhanVienDTO nv, TaiKhoanDTO taiKhoan, Panel pnl)
        {
            InitializeComponent();
            _pnlContainer = pnl;
            _taiKhoanDTO = taiKhoan;
            _nhanvienDTO = nv;
        }

        private void UCItemTK_Load(object sender, EventArgs e)
        {
            lblTenNV.Text = _nhanvienDTO.HoTen;
            lblChucVu.Text = _nhanvienDTO.ChucVu;
            lblUsername.Text = _taiKhoanDTO.Username;
        }

        private void lblTenNV_Click(object sender, EventArgs e)
        {

        }
    }
}
