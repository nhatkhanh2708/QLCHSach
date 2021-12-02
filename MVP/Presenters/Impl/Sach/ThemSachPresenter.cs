using Model.Entities;
using MVP.IViews.Sach;
using Service.IServices;
using System.Drawing;
using System.Windows.Forms;

namespace MVP.Presenters
{
    public class ThemSachPresenter : IThemSachPresenter
    {
        private readonly IThemSachView _themSachView;
        private readonly ITheLoaiService _theLoaiService;
        private readonly INxbService _nxbService;
        private readonly ITacGiaService _tacGiaService;
        public ThemSachPresenter(IThemSachView themSachView)
        {
            _themSachView = themSachView;
            _nxbService = (INxbService)Startup.ServiceProvider.GetService(typeof(INxbService));
            _tacGiaService = (ITacGiaService)Startup.ServiceProvider.GetService(typeof(ITacGiaService));
            _theLoaiService = (ITheLoaiService)Startup.ServiceProvider.GetService(typeof(ITheLoaiService));
        }
        public void Add(string tennxb, string viettat)
        {
            
        }

        public void GetImg()
        {
            using (OpenFileDialog ofd = new OpenFileDialog()
            {
                Title = "Open image",
                Filter = "(*.jpg;*.jpeg,*.png)|*.JPG;*.JPEG;*.PNG",
                ValidateNames = true,
                Multiselect = false
            })
            {                
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    _themSachView.GetImg(Image.FromFile(ofd.FileName));
                }
            }
        }

        public void GetsAllCbx()
        {
            _themSachView.GetsAllCbx(
                _tacGiaService.GetsAll(),
                _theLoaiService.GetsAll(),
                _nxbService.GetsAll()
                );
        }
    }
}
