using Model.Entities;
using Service.IServices;
using System;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace MVP.Views
{
    public partial class UCThongKeSach : UserControl
    {
        private readonly IHdXuatService _hdXuatService;
        private readonly ICtXuatService _ctXuatService;
        private readonly IHdNhapService _hdNhapService;
        private readonly ICtNhapService _ctNhapService;
        private readonly INhanVienService _nvService;
        private readonly INccService _nccService;
        private readonly ISachService _sService;
        CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");
        public UCThongKeSach()
        {
            InitializeComponent();
            _hdXuatService = (IHdXuatService)Startup.ServiceProvider.GetService(typeof(IHdXuatService));
            _hdNhapService = (IHdNhapService)Startup.ServiceProvider.GetService(typeof(IHdNhapService));
            _ctXuatService = (ICtXuatService)Startup.ServiceProvider.GetService(typeof(ICtXuatService));
            _ctNhapService = (ICtNhapService)Startup.ServiceProvider.GetService(typeof(ICtNhapService));
            _nvService = (INhanVienService)Startup.ServiceProvider.GetService(typeof(INhanVienService));
            _nccService = (INccService)Startup.ServiceProvider.GetService(typeof(INccService));
            _sService = (ISachService)Startup.ServiceProvider.GetService(typeof(ISachService));
        }

        private void UCThongKeSach_Load(object sender, System.EventArgs e)
        {
            labelSach.Text = _sService.GetsByName("").Count().ToString();
            labelNV.Text = _nvService.GetsAll().Where(p => p.Status == true).Count().ToString();
            labelNcc.Text = _nccService.GetsAll().Where(p => p.Status == true).Count().ToString();

            var listNhap = _hdNhapService.GetsAll().Where(p => p.NgayTao.Year == DateTime.Today.Year &&
                                        p.NgayTao.Month == DateTime.Today.Month);
            var pricenhap = listNhap.Sum(x => x.TongTien);

            labelChiphinhap.Text = double.Parse(pricenhap.ToString()).ToString("#,###", cul.NumberFormat) + " VND";

            var listBan = _hdXuatService.GetsAll().Where(p => p.NgayTao.Year == DateTime.Today.Year &&
                                        p.NgayTao.Month == DateTime.Today.Month);
            var priceban = listBan.Sum(x => x.TongTien);

            labeldoanhthu.Text = double.Parse(priceban.ToString()).ToString("#,###", cul.NumberFormat) + " VND";

            var listnhaptemp = _ctNhapService.GetsAll().Join(listNhap,
                  p => p.HdNhapId,
                  q => q.Id,
                  (aw, bw) => new {aw.SoLuong}
                );
            labelsachnhap.Text = listnhaptemp.Sum(p => p.SoLuong).ToString();

            var listbantemp = _ctXuatService.GetsAll().Join(listBan,
                  p => p.HdXuatId,
                  q => q.Id,
                  (aw, bw) => new { aw.SoLuong }
                );
            labelsachban.Text = listbantemp.Sum(p => p.SoLuong).ToString();
        }
    }
}
