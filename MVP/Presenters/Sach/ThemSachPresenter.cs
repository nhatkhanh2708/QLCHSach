using Model.Entities;
using MVP.IViews.Sach;
using MVP.Properties;
using MVP.Utils;
using Service.DTOs;
using Service.IServices;
using System;
using System.Collections.Generic;
using System.IO;
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
            if(!decimal.TryParse(giaban, out gban))
            {
                _themSachView.Notification(Notification.ADD_FAILED, "Do nhập sai điều kiện !", Resources.fail, false);
                return;
            }
            decimal gnhap;
            if(!decimal.TryParse(gianhap, out gnhap))
            {
                _themSachView.Notification(Notification.ADD_FAILED, "Do nhập sai điều kiện !", Resources.fail, false);
                return;
            }
            int soluong;
            if(!int.TryParse(sl, out soluong))
            {
                _themSachView.Notification(Notification.ADD_FAILED, "Do nhập sai điều kiện !", Resources.fail, false);
                return;
            }

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
                if (!CheckSameImg(img))
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

        public bool CheckSameImg(System.Drawing.Image img1)
        {
            byte[] image1Bytes;
            byte[] image2Bytes;

            using (var mstream = new MemoryStream())
            {
                img1.Save(mstream, img1.RawFormat);
                image1Bytes = mstream.ToArray();
            }

            using (var mstream = new MemoryStream())
            {
                Resources.icons8_book_100__1_.Save(mstream, Resources.icons8_book_100__1_.RawFormat);
                image2Bytes = mstream.ToArray();
            }

            var image164 = Convert.ToBase64String(image1Bytes);
            var image264 = Convert.ToBase64String(image2Bytes);

            return string.Equals(image164, image264);
        }
    }
}
