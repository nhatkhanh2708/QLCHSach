using Model.Entities;
using MVP.IViews;
using MVP.Properties;
using MVP.Utils;
using Service.DTOs;
using Service.IServices;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVP.Presenters
{
    public class CtSachPresenter
    {
        private readonly ICtSachView _ctSachView;
        private readonly ITheLoaiService _theLoaiService;
        private readonly INxbService _nxbService;
        private readonly ITacGiaService _tacGiaService;
        private readonly INccService _nccService;
        private readonly ISachService _sachService;
        private readonly ISachTheLoaiService _sachTLService;
        private readonly ISachTacGiaService _sachTGService;
        public CtSachPresenter(ICtSachView ctSachView)
        {
            _ctSachView = ctSachView;
            _nxbService = (INxbService)Startup.ServiceProvider.GetService(typeof(INxbService));
            _tacGiaService = (ITacGiaService)Startup.ServiceProvider.GetService(typeof(ITacGiaService));
            _theLoaiService = (ITheLoaiService)Startup.ServiceProvider.GetService(typeof(ITheLoaiService));
            _nccService = (INccService)Startup.ServiceProvider.GetService(typeof(INccService));
            _sachService = (ISachService)Startup.ServiceProvider.GetService(typeof(ISachService));
            _sachTLService = (ISachTheLoaiService)Startup.ServiceProvider.GetService(typeof(ISachTheLoaiService));
            _sachTGService = (ISachTacGiaService)Startup.ServiceProvider.GetService(typeof(ISachTacGiaService));
        }

        public void LoadData(SachDTO s)
        {
            var nxb = _nxbService.GetById(s.NxbId);
            var ncc = _nccService.GetById(s.NccId);
            var liststl = _sachTLService.GetsAll().Where(p => p.SachId == s.Id);
            var listTL = _theLoaiService.GetsAll().Join(
                    liststl,
                    p => p.Id,
                    q => q.TheLoaiId,
                    (tl, stl) => new { tl, stl }
                );
            var liststg = _sachTGService.GetsAll().Where(p => p.SachId == s.Id);
            var listTG = _tacGiaService.GetsAll().Join(
                    liststg,
                    p => p.Id,
                    q => q.TacGiaId,
                    (tg, stg) => new { tg, stg }
                );
            List<TheLoaiDTO> listTLtemp = new List<TheLoaiDTO>();
            for(int j = 0; j<listTL.Count(); j++)
            {
                listTLtemp.Add(listTL.ElementAt(j).tl);
            }
            List<TacGiaDTO> listTGtemp = new List<TacGiaDTO>();
            for (int j = 0; j < listTG.Count(); j++)
            {
                listTGtemp.Add(listTG.ElementAt(j).tg);
            }
            _ctSachView.LoadData( listTGtemp, listTLtemp, nxb, ncc);
        }

        public void Update(SachDTO sachdto, string tensach, List<int> listtgid, List<int> listtlid, int nxbId,
                string giaban, string gianhap, string sl, System.Drawing.Image img)
        {
            bool flag = false;
            var listSach = _sachService.GetsAll();
            foreach (SachDTO s in listSach)
            {
                if (s.Equals(tensach))
                {
                    _ctSachView.Notification(Notification.EDIT_FAILED, Notification.EXIST_NAME, Resources.fail, false);
                    flag = true;
                    return;
                }
            }
            decimal gban;
            if (!decimal.TryParse(giaban, out gban))
            {
                _ctSachView.Notification(Notification.EDIT_FAILED, "Do nhập sai điều kiện !", Resources.fail, false);
                flag = true;
                return;
            }
            decimal gnhap;
            if (!decimal.TryParse(gianhap, out gnhap))
            {
                _ctSachView.Notification(Notification.EDIT_FAILED, "Do nhập sai điều kiện !", Resources.fail, false);
                flag = true;
                return;
            }
            int soluong;
            if (!int.TryParse(sl, out soluong))
            {
                _ctSachView.Notification(Notification.EDIT_FAILED, "Do nhập sai điều kiện !", Resources.fail, false);
                flag = true;
                return;
            }

            if (string.IsNullOrEmpty(tensach) || listtgid.Count < 1 || listtlid.Count < 1 || gban < 0 || gnhap < 0 || gban < gnhap || soluong < 0)
            {
                _ctSachView.Notification(Notification.EDIT_FAILED, "Do nhập sai điều kiện !", Resources.fail, false);
                flag = true;
                return;
            }

            if(!flag)
            {
                sachdto.TenSach = tensach;
                sachdto.NxbId = nxbId;
                sachdto.GiaBan = gban;
                sachdto.GiaNhap = gnhap;
                sachdto.SoLuong = soluong;
                if (!CheckSameImg(img))
                    sachdto.Img = Image.ConvertImg2Bytes(img);
                else
                    sachdto.Img = null;
                sachdto.Status = true;
                _sachService.Update(sachdto);

                var AllListtl = _sachTLService.GetsAll();
                foreach(SachTheLoaiDTO stl in AllListtl)
                {
                    if (stl.SachId == sachdto.Id)
                        _sachTLService.Delete(stl.Id);
                }

                var AllListtg = _sachTGService.GetsAll();
                foreach (SachTacGiaDTO stl in AllListtg)
                {
                    if (stl.SachId == sachdto.Id)
                        _sachTGService.Delete(stl.Id);
                }

                foreach (int i in listtgid)
                {
                    var stg = new SachTacGiaDTO();
                    stg.SachId = sachdto.Id;
                    stg.TacGiaId = i;
                    _sachTGService.Add(stg);
                }

                foreach (int i in listtlid)
                {
                    var stl = new SachTheLoaiDTO();
                    stl.SachId = sachdto.Id;
                    stl.TheLoaiId = i;
                    _sachTLService.Add(stl);
                }
                _ctSachView.Notification(Notification.EDIT_SUCCESSED, null, Resources.success, true);
            }
        }

        public void Delete(int id)
        {
            _sachService.UpdateStatus(id);
        }

        public void GetAllCbx()
        {
            _ctSachView.GetAllCbx(
                _nxbService.GetsAll(),
                _tacGiaService.GetsAll(),
                _theLoaiService.GetsAll());
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
