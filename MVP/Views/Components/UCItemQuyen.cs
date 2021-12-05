using Service.DTOs;
using System.Windows.Forms;

namespace MVP.Views
{
    public partial class UCItemQuyen : UserControl
    {
        private QuyenDTO _quyenDTO;
        private Panel _pnlContainer;

        public UCItemQuyen(QuyenDTO quyenDTO, Panel pnlContainer)
        {
            InitializeComponent();
            _quyenDTO = quyenDTO;
            _pnlContainer = pnlContainer;
        }

        private void UCItemQuyen_Load(object sender, System.EventArgs e)
        {
            lblId.Text = "#" + _quyenDTO.Id;
            lblTenQuyen.Text = _quyenDTO.TenQuyen;
            lblMota.Text = _quyenDTO.MoTa;
        }

        private void lblTenQuyen_Click(object sender, System.EventArgs e)
        {
            UCChiTietQuyen ucChiTietQuyen = new UCChiTietQuyen(_quyenDTO);
            ucChiTietQuyen.Dock = DockStyle.Fill;
            _pnlContainer.Controls.Add(ucChiTietQuyen);
            _pnlContainer.Controls.SetChildIndex(ucChiTietQuyen, 0);
        }
    }
}
