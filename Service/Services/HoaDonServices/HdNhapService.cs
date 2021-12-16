using AutoMapper;
using Model.Entities;
using Model.IRepositories;
using Service.DTOs;
using Service.IServices;
using System.Collections.Generic;

namespace Service.Services
{
    public class HdNhapService : IHdNhapService
    {
        private readonly IHdNhapRepository _hdNhapRepository;
        private readonly IMapper _mapper;

        public HdNhapService(IHdNhapRepository hdNhapRepository, IMapper mapper)
        {
            _hdNhapRepository = hdNhapRepository;
            _mapper = mapper;
        }

        public void Add(HdNhapDTO dto)
        {
            var entity = _mapper.Map<HdNhapDTO, HoaDonNhap>(dto);
            _hdNhapRepository.Add(entity);
        }

        public int AddHdNhap(HdNhapDTO dto)
        {
            var entity = _mapper.Map<HdNhapDTO, HoaDonNhap>(dto);
            return _hdNhapRepository.Add_ReturnId(entity);
        }

        public void Delete(int id)
        {
            var entity = _hdNhapRepository.GetById(id);
            _hdNhapRepository.Delete(entity);
        }

        public HdNhapDTO GetById(int id)
        {
            var entity = _hdNhapRepository.GetById(id);
            return _mapper.Map<HoaDonNhap, HdNhapDTO>(entity);
        }

        public IEnumerable<HdNhapDTO> GetsAll()
        {
            var entities = _hdNhapRepository.GetsAll();
            return _mapper.Map<IEnumerable<HoaDonNhap>, IEnumerable<HdNhapDTO>>(entities);
        }

        public bool isExistById(int id)
        {
            return _hdNhapRepository.GetById(id) != null;
        }

        public void Update(HdNhapDTO dto)
        {
            var entity = _hdNhapRepository.GetById(dto.Id);
            _mapper.Map<HdNhapDTO, HoaDonNhap>(dto, entity);
            _hdNhapRepository.Update(entity);
        }
    }
}
