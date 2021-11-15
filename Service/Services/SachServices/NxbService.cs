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
        private readonly INxbRepository nxbRepository;
        public NxbService(INxbRepository nxbRepository)
        {
            this.nxbRepository = nxbRepository;
        }
        public void Add(NhaXuatBanDTO dto)
        {
            var entity = dto.MappingEntity();
            nxbRepository.Add(entity);
        }

        public void Delete(int id)
        {
            var entity = nxbRepository.GetById(id);
            nxbRepository.Delete(entity);
        }

        public IEnumerable<NhaXuatBanDTO> GetsAll()
        {
            return nxbRepository.GetsAll().MappingDTOs();
        }

        public NhaXuatBanDTO GetById(int id)
        {
            return nxbRepository.GetById(id).MappingDTO();
        }

        public IEnumerable<NhaXuatBanDTO> GetsByTenNXB(string tenNXB)
        {
            return nxbRepository.GetsByTenNXB(tenNXB).MappingDTOs();
        }

        public void Update(NhaXuatBanDTO dto)
        {
            var entity = nxbRepository.GetById(dto.Id);
            dto.MappingEntity(entity);
            nxbRepository.Update(entity);
        }
    }
}
