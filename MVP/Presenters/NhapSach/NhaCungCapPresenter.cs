using Model.Entities;
using MVP.IViews;
using Service.DTOs;
using Service.IServices;
using System.Collections.Generic;

namespace MVP.Presenters
{
    public class NhaCungCapPresenter
    {
        private readonly INccService _nccService;
        private readonly INhaCungCapView _nccView;
        public NhaCungCapPresenter(INhaCungCapView nhaCungCapView)
        {
            _nccView = nhaCungCapView;
            _nccService = (INccService)Startup.ServiceProvider.GetService(typeof(INccService));
        }
        public void GetsAll()
        {
            var listall = _nccService.GetsAll();
            List<NccDTO> listemp = new List<NccDTO>();
            foreach (NccDTO n in listall)
            {
                if (n.Status != null)
                {
                    listemp.Add(n);
                }
            }
            _nccView.GetsAll(listemp);
        }

        public void GetByName(string name)
        {
            var listall = _nccService.GetsAll();
            List<NccDTO> listemp = new List<NccDTO>();
            foreach(NccDTO n in listall)
            {
                if (n.TenNCC.StartsWith(name) && n.Status != null)
                {
                    listemp.Add(n);
                }
            }
            _nccView.GetsByName(listemp);
        }
    }
}
