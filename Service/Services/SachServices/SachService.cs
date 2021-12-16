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

        public int AddSach(SachDTO s)
        {
            var entity = _mapper.Map<SachDTO, Sach>(s);
            return _sachRepository.Add_ReturnId(entity);
        }

        public void UpdateStatus(int id)
        {
            var entity = _sachRepository.GetById(id);
            entity.Status = false;
            _sachRepository.Update(entity);
        }

        public IEnumerable<SachDTO> GetsByName_NccId(string sach, int nccId)
        {
            var entities = _sachRepository.GetsByName_NccId(sach, nccId);
            return _mapper.Map<IEnumerable<Sach>, IEnumerable<SachDTO>>(entities);
        }

        public IEnumerable<SachDTO> GetsByName(string sach)
        {
            var entities = _sachRepository.GetsByName(sach);
            return _mapper.Map<IEnumerable<Sach>, IEnumerable<SachDTO>>(entities);
        }
    }
}
