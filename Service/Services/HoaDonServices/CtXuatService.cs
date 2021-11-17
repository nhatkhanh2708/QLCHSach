using AutoMapper;
using Model.Entities;
using Model.IRepositories;
using Service.DTOs;
using Service.IServices;
using System.Collections.Generic;

namespace Service.Services
{
    public class CtXuatService : ICtXuatService
    {
        private readonly ICtXuatRepository _ctXuatRepository;
        private readonly IMapper _mapper;

        public CtXuatService(ICtXuatRepository ctXuatRepository, IMapper mapper)
        {
            _ctXuatRepository = ctXuatRepository;
            _mapper = mapper;
        }

        public void Add(CtXuatDTO dto)
        {
            var entity = _mapper.Map<CtXuatDTO, ChiTietXuat>(dto);
            _ctXuatRepository.Add(entity);
        }

        public void Delete(int id)
        {
            var entity = _ctXuatRepository.GetById(id);
            _ctXuatRepository.Delete(entity);

        }

        public CtXuatDTO GetById(int id)
        {
            var entity = _ctXuatRepository.GetById(id);
            return _mapper.Map<ChiTietXuat, CtXuatDTO>(entity);
        }

        public IEnumerable<CtXuatDTO> GetsAll()
        {
            var entities = _ctXuatRepository.GetsAll();
            return _mapper.Map<IEnumerable<ChiTietXuat>, IEnumerable<CtXuatDTO>>(entities);
        }

        public bool isExistById(int id)
        {
            return _ctXuatRepository.GetById(id) != null;
        }

        public void Update(CtXuatDTO dto)
        {
            var entity = _ctXuatRepository.GetById(dto.Id);
            _mapper.Map<CtXuatDTO, ChiTietXuat>(dto, entity);
            _ctXuatRepository.Update(entity);
        }
    }
}
