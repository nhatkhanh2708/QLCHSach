using MVP.Properties;
using Service.DTOs;
using System;
using System.Windows.Forms;

namespace MVP.Views
{
    public partial class UCItemNV : UserControl
    {        
        private NhanVienDTO _nhanVienDTO;
        private Panel _pnlContainer;
        private UCNhanVien _ucNv;
        public UCItemNV(UCNhanVien ucNv, NhanVienDTO nhanVienDTO, Panel pnlContainer)
        {
            InitializeComponent();
            _pnlContainer = pnlContainer;
            _nhanVienDTO = nhanVienDTO;
            _ucNv = ucNv;
        }

        private void UCItemNV_Load(object sender, EventArgs e)
        {
            lblId.Text = "#" + _nhanVienDTO.Id;
            lblTenNv.Text = _nhanVienDTO.HoTen;
            lblChucVu.Text = _nhanVienDTO.ChucVu;
            lblNgayBatDau.Text = _nhanVienDTO.NgayBatDau.ToShortDateString();
            lblGender.Image = _nhanVienDTO.GioiTinh ? Resources.icons8_male_24 : Resources.icons8_female_24;
            lblStatus.Image = _nhanVienDTO.Status ? Resources.icons8_filled_circle_green : Resources.icons8_filled_circle_red;
        }

        private void lblTenNv_Click(object sender, EventArgs e)
        {
            UCChiTietNV ucChiTietNV = new UCChiTietNV(_ucNv, _nhanVienDTO);
            ucChiTietNV.Dock = DockStyle.Fill;
            _pnlContainer.Controls.Add(ucChiTietNV);
            _pnlContainer.Controls.SetChildIndex(ucChiTietNV, 0);
        }
    }
}
