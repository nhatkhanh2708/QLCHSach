using Model.Entities;
using MVP.IViews.Sach;
using MVP.Properties;
using MVP.Utils;
using Service.DTOs;
using Service.IServices;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace MVP.Presenters
{
    public class ThemSachPresenter
    {
        private readonly IThemSachView _themSachView;
        private readonly ITheLoaiService _theLoaiService;
        private readonly INxbService _nxbService;
        private readonly ITacGiaService _tacGiaService;
        private readonly INccService _nccService;
        private readonly ISachService _sachService;
        private readonly ISachTheLoaiService _sachTLService;
        private readonly ISachTacGiaService _sachTGService;
        public ThemSachPresenter(IThemSachView themSachView)
        {
            _themSachView = themSachView;
            _nxbService = (INxbService)Startup.ServiceProvider.GetService(typeof(INxbService));
            _tacGiaService = (ITacGiaService)Startup.ServiceProvider.GetService(typeof(ITacGiaService));
            _theLoaiService = (ITheLoaiService)Startup.ServiceProvider.GetService(typeof(ITheLoaiService));
            _nccService = (INccService)Startup.ServiceProvider.GetService(typeof(INccService));
            _sachService = (ISachService)Startup.ServiceProvider.GetService(typeof(ISachService));
            _sachTLService = (ISachTheLoaiService)Startup.ServiceProvider.GetService(typeof(ISachTheLoaiService));
            _sachTGService = (ISachTacGiaService)Startup.ServiceProvider.GetService(typeof(ISachTacGiaService));
        }
        
        public void Add(string tensach, List<int> listtgid, List<int> listtlid, int nxbId,
                string giaban, string gianhap, string sl, int nccId, System.Drawing.Image img)
        {
            var listSach = _sachService.GetsAll();
            foreach (SachDTO s in listSach)
            {
                if (s.Equals(tensach))
                {
                    _themSachView.Notification(Notification.ADD_FAILED, Notification.EXIST_NAME, Resources.fail, false);
                    return;
                }
            }
            decimal gban;
            decimal.TryParse(giaban, out gban);
            decimal gnhap;
            decimal.TryParse(gianhap, out gnhap);
            int soluong;
            int.TryParse(gianhap, out soluong);

            if (string.IsNullOrEmpty(tensach) || listtgid.Count < 1 || listtlid.Count < 1 || gban < 0 || gnhap < 0 || gban < gnhap || soluong < 0)
            {
                _themSachView.Notification(Notification.ADD_FAILED, "Do nhập sai điều kiện !", Resources.fail, false);
                return;
            }
            else
            {
                var sachdto = new SachDTO();
                sachdto.TenSach = tensach;
                sachdto.NxbId = nxbId;
                sachdto.GiaBan = gban;
                sachdto.GiaNhap = gnhap;
                sachdto.SoLuong = soluong;
                if (img != null)
                    sachdto.Img = Utils.Image.ConvertImg2Bytes(img);
                else
                    sachdto.Img = null;
                sachdto.NccId = nccId;
                sachdto.Status = true;

                int idSachnew = _sachService.AddSach(sachdto);
                foreach (int i in listtgid)
                {
                    var stg = new SachTacGiaDTO();
                    stg.SachId = idSachnew;
                    stg.TacGiaId = i;
                    _sachTGService.Add(stg);
                }

                foreach (int i in listtlid)
                {
                    var stl = new SachTheLoaiDTO();
                    stl.SachId = idSachnew;
                    stl.TheLoaiId = i;
                    _sachTLService.Add(stl);
                }
                _themSachView.Notification(Notification.ADD_SUCCESSED, null, Resources.success, true);
            }            
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
                    _themSachView.GetImg(System.Drawing.Image.FromFile(ofd.FileName));
                }
            }
        }

        public void GetsAllCbx()
        {
            _themSachView.GetsAllCbx(
                _tacGiaService.GetsAll(),
                _theLoaiService.GetsAll(),
                _nxbService.GetsAll(),
                _nccService.GetsAll().Where(q => q.Status == true)
                );
        }
    }
}
