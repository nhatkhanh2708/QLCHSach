using Model.IRepositories.ISachRepositories;
using Service.DTOs;
using Service.IServices.ISachServices;
using Service.Mapping;
using System.Collections.Generic;

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
            _nxbRepository.Add(dto.MappingEntity());
        }

        public void Delete(int id)
        {
            var entity = _nxbRepository.GetById(id);
            _nxbRepository.Delete(entity);
        }

        public IEnumerable<NhaXuatBanDTO> GetsAll()
        {
            return null;
            //return _nxbRepository.GetsAll().MappingDTOs();
        }

        public NhaXuatBanDTO GetById(int id)
        {
            return _nxbRepository.GetById(id).MappingDTO();
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
