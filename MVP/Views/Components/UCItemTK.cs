using Model.Entities;
using Service.DTOs;
using Service.IServices;
using System;
using System.Drawing;
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

            if (_taiKhoanDTO.Status == true)
            {
                lblStatus.Text = "Active";
                lblStatus.BackColor = Color.LimeGreen;
            }
            else
            {
                lblStatus.Text = "Block";
                lblStatus.BackColor = Color.OrangeRed;
            }
        }

        private void lblTenNV_Click(object sender, EventArgs e)
        {

        }

        private void lblStatus_Click(object sender, EventArgs e)
        {
            var _tkService = (ITaiKhoanService)Startup.ServiceProvider.GetService(typeof(ITaiKhoanService));
            _taiKhoanDTO.Status = !_taiKhoanDTO.Status;
            _tkService.Update(_taiKhoanDTO);
            if (_taiKhoanDTO.Status == true)
            {
                lblStatus.Text = "Active";
                lblStatus.BackColor = Color.LimeGreen;
            }
            else
            {
                lblStatus.Text = "Block";
                lblStatus.BackColor = Color.OrangeRed;
            }
        }
    }
}
