using MVP.IViews;
using Service.DTOs;
using System.Globalization;
using System.Windows.Forms;

namespace MVP.Views
{
    public partial class UCItemSachBanChon : UserControl
    {
        private SachDTO _sach;
        private int _slBan;
        private FlowLayoutPanel _flp;
        public int id;
        private string _tg;
        private readonly IThemHDBanView _themHDBanView;
        public UCItemSachBanChon(IThemHDBanView themHDBanView, FlowLayoutPanel flp, SachDTO sachDTO, string tg, int slban)
        {
            InitializeComponent();
            _sach = sachDTO;
            _slBan = slban;
            _flp = flp;
            _themHDBanView = themHDBanView;
            _tg = tg;
        }

        private void UCItemSachBanChon_Load(object sender, System.EventArgs e)
        {
            lblSach.Text = _sach.TenSach;
            lblSlBan.Text = "-" + _slBan.ToString();
            id = _sach.Id;
            CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");
            var tiensach = _sach.GiaBan * _slBan;
            lblTienSach.Text = "+" + double.Parse(tiensach.ToString()).ToString("#,###", cul.NumberFormat);
            lblGiaBan.Text = double.Parse(_sach.GiaBan.ToString()).ToString("#,###", cul.NumberFormat);
            lblTg.Text = _tg;
            if (_themHDBanView != null && _flp != null)
            {
                btnDel.Visible = true;
            }
            else
            {
                btnDel.Visible = false;
            }
        }

        private void btnDel_Click(object sender, System.EventArgs e)
        {
            if (_themHDBanView != null && _flp != null)
            {
                _themHDBanView.RmSelected(_sach.Id, _sach.GiaBan * _slBan);
                _flp.Controls.Remove(this);
            }
        }
    }
}
