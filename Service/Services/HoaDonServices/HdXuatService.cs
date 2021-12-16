using AutoMapper;
using Model.Entities;
using Model.IRepositories;
using Service.DTOs;
using Service.IServices;
using System.Collections.Generic;

namespace Service.Services
{
    public class HdXuatService : IHdXuatService
    {
        private readonly IHdXuatRepository _hdXuatRepository;
        private readonly IMapper _mapper;

        public HdXuatService(IHdXuatRepository hdXuatRepository, IMapper mapper)
        {
            _hdXuatRepository = hdXuatRepository;
            _mapper = mapper;
        }

        public void Add(HdXuatDTO dto)
        {
            var entity = _mapper.Map<HdXuatDTO, HoaDonXuat>(dto);
            _hdXuatRepository.Add(entity);
        }

        public int AddHdXuat(HdXuatDTO dto)
        {
            var entity = _mapper.Map<HdXuatDTO, HoaDonXuat>(dto);
            return _hdXuatRepository.Add_ReturnId(entity);
        }

        public void Delete(int id)
        {
            var entity = _hdXuatRepository.GetById(id);
            _hdXuatRepository.Delete(entity);
        }

        public HdXuatDTO GetById(int id)
        {
            var entity = _hdXuatRepository.GetById(id);
            return _mapper.Map<HoaDonXuat, HdXuatDTO>(entity);
        }

        public IEnumerable<HdXuatDTO> GetsAll()
        {
            var entities = _hdXuatRepository.GetsAll();
            return _mapper.Map<IEnumerable<HoaDonXuat>, IEnumerable<HdXuatDTO>>(entities);
        }

        public bool isExistById(int id)
        {
            return _hdXuatRepository.GetById(id) != null;
        }

        public void Update(HdXuatDTO dto)
        {
            var entity = _hdXuatRepository.GetById(dto.Id);
            _mapper.Map<HdXuatDTO, HoaDonXuat>(dto, entity);
            _hdXuatRepository.Update(entity);
        }
    }
}
