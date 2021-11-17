using AutoMapper;
using Model.Entities;
using Model.IRepositories;
using Service.DTOs;
using Service.IServices;
using System.Collections.Generic;

namespace Service.Services
{
    public class CtNhapService : ICtNhapService
    {
        private readonly ICtNhapRepository _ctNhapRepository;
        private readonly IMapper _mapper;

        public CtNhapService(ICtNhapRepository ctNhapRepository, IMapper mapper)
        {
            _ctNhapRepository = ctNhapRepository;
            _mapper = mapper;
        }

        public void Add(CtNhapDTO dto)
        {
            _ctNhapRepository.Add(_mapper.Map<CtNhapDTO, ChiTietNhap>(dto));
        }

        public void Delete(int id)
        {
            var entity = _ctNhapRepository.GetById(id);
            _ctNhapRepository.Delete(entity);
        }

        public CtNhapDTO GetById(int id)
        {
            var entity = _ctNhapRepository.GetById(id);
            return _mapper.Map<ChiTietNhap, CtNhapDTO>(entity);
        }

        public IEnumerable<CtNhapDTO> GetsAll()
        {
            var entities = _ctNhapRepository.GetsAll();
            return _mapper.Map<IEnumerable<ChiTietNhap>, IEnumerable<CtNhapDTO>>(entities);
        }

        public bool isExistById(int id)
        {
            return _ctNhapRepository.GetById(id) != null;
        }

        public void Update(CtNhapDTO dto)
        {
            var entity = _ctNhapRepository.GetById(dto.Id);
            _mapper.Map<CtNhapDTO, ChiTietNhap>(dto, entity);
            _ctNhapRepository.Update(entity);
        }
    }
}
