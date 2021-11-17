using AutoMapper;
using Model.Entities;
using Model.IRepositories.ISachRepositories;
using Service.DTOs;
using Service.IServices.ISachServices;
using Service.Mapping;
using System.Collections.Generic;

namespace Service.Services
{
    public class NxbService : INxbService
    {
        private readonly INxbRepository _nxbRepository;
        private IMapper _mapper;

        public NxbService(INxbRepository nxbRepository)
        {
            _nxbRepository = nxbRepository;
        }
        public void Add(NhaXuatBanDTO dto)
        {
            //_nxbRepository.Add(dto.MappingEntity());
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new AutoMapperConfig());
            });
            _mapper = config.CreateMapper();
            var entity = _mapper.Map<NhaXuatBanDTO, NhaXuatBan>(dto);
            _nxbRepository.Add(entity);
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

        public bool isExistById(int id)
        {
            return _nxbRepository.GetById(id) != null;
        }
    }
}
