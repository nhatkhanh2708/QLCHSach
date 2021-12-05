using MVP.Properties;
using Service.DTOs;
using System;
using System.Windows.Forms;

namespace MVP.Views
{
    public partial class UCItemNcc : UserControl
    {
        private NccDTO _nccDTO;
        private Panel _pnlContainer;
        public UCItemNcc(NccDTO nccDTO, Panel pnlContainer)
        {
            InitializeComponent();
            _nccDTO = nccDTO;
            _pnlContainer = pnlContainer;
        }

        private void UCItemNcc_Load(object sender, EventArgs e)
        {
            lblId.Text = "#" + _nccDTO.Id;
            lblTenNcc.Text = _nccDTO.TenNCC;
            lblDiaChi.Text = _nccDTO.DiaChi;
            lblNgayHopTac.Text = _nccDTO.NgayHopTac.ToShortDateString();
            lblStatus.Image = _nccDTO.Status ? Resources.icons8_filled_circle_green : Resources.icons8_filled_circle_red;
        }

        private void lblTenNcc_Click(object sender, EventArgs e)
        {
            UCChiTietNCC ucChiTietNCC = new UCChiTietNCC(_nccDTO);
            ucChiTietNCC.Dock = DockStyle.Fill;
            _pnlContainer.Controls.Add(ucChiTietNCC);
            _pnlContainer.Controls.SetChildIndex(ucChiTietNCC, 0);
        }
    }
}
