using Model.IRepositories.ISachRepositories;
using Service.DTOs;
using Service.IServices.ISachServices;
using Service.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services.SachServices
{
    public class NxbService : INxbService
    {
        private readonly INxbRepository _nxbRepository;
        public NxbService(INxbRepository nxbRepository)
        {
            _nxbRepository = nxbRepository;
        }
        public void Add(NhaXuatBanDTO dto)
        {
            //var entity = dto.MappingEntity();
            //nxbRepository.Add(entity);
        }

        public void Delete(NhaXuatBanDTO dto)
        {
            //var entity = dto.MappingEntity();
            //_nxbRepository.Delete(entity);
        }

        public IEnumerable<NhaXuatBanDTO> GetsAll()
        {
            return null;
            //return _nxbRepository.GetsAll().MappingDTOs();
        }

        public NhaXuatBanDTO GetById(int id)
        {
            return null;
            //return _nxbRepository.GetById(id).MappingDTO();
        }

        public IEnumerable<NhaXuatBanDTO> GetsByTenNXB(string tenNXB)
        {
            return null;
            //return _nxbRepository.GetsByTenNXB(tenNXB).MappingDTOs();
        }

        public void Update(NhaXuatBanDTO dto)
        {
            var entity = _nxbRepository.GetById(dto.Id);
            //dto.MappingEntity(entity);
            _nxbRepository.Update(entity);
        }
    }
}
