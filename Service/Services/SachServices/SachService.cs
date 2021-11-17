using AutoMapper;
using Model.Entities;
using Model.IRepositories;
using Service.DTOs;
using Service.IServices;
using System.Collections.Generic;

namespace Service.Services
{
    public class SachService : ISachService
    {
        private readonly ISachRepository _sachRepository;
        private readonly IMapper _mapper;

        public SachService(ISachRepository sachRepository, IMapper mapper)
        {
            _sachRepository = sachRepository;
            _mapper = mapper;
        }

        public void Add(SachDTO dto)
        {
            var entity = _mapper.Map<SachDTO, Sach>(dto);
            _sachRepository.Add(entity);
        }

        public void Delete(int id)
        {
            var entity = _sachRepository.GetById(id);
            _sachRepository.Delete(entity);
        }

        public IEnumerable<SachDTO> GetsAll()
        {
            var entities = _sachRepository.GetsAll();
            return _mapper.Map<IEnumerable<Sach>, IEnumerable<SachDTO>>(entities);
        }

        public SachDTO GetById(int id)
        {
            var entity = _sachRepository.GetById(id);
            return _mapper.Map<Sach, SachDTO>(entity);
        }

        public void Update(SachDTO dto)
        {
            var entity = _sachRepository.GetById(dto.Id);
            _mapper.Map<SachDTO, Sach>(dto, entity);
            _sachRepository.Update(entity);
        }

        public bool isExistById(int id)
        {
            return _sachRepository.GetById(id) != null;
        }
    }
}
