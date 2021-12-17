using Service.DTOs;
using System.Globalization;
using System.Windows.Forms;

namespace MVP.Views
{
    public partial class UCItemBan : UserControl
    {
        private Panel pnlContainer;
        private NhanVienDTO _nv;
        private HdXuatDTO _hdXuat;
        public UCItemBan(Panel pnlCont, NhanVienDTO nv, HdXuatDTO hdXuat)
        {
            InitializeComponent();
            pnlContainer = pnlCont;
            _nv = nv;
            _hdXuat = hdXuat;
        }

        private void UCItemBan_Load(object sender, System.EventArgs e)
        {
            CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");
            lblId.Text = "#" + _hdXuat.Id;
            lblNv.Text = _nv.HoTen;
            lblTongTien.Text = double.Parse(_hdXuat.TongTien.ToString()).ToString("#,###", cul.NumberFormat) + " VND";
            lblDate.Text = _hdXuat.NgayTao.ToString("dd-MM-yyyy HH:mm:ss");
        }

        private void lblId_Click(object sender, System.EventArgs e)
        {
            UCChiTietHDBan ucChiTietBan = new UCChiTietHDBan(_nv, _hdXuat);
            ucChiTietBan.Dock = DockStyle.Fill;
            pnlContainer.Controls.Add(ucChiTietBan);
            pnlContainer.Controls.SetChildIndex(ucChiTietBan, 0);
        }
    }
}
