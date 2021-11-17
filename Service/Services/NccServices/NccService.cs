using AutoMapper;
using Model.Entities;
using Model.IRepositories;
using Service.DTOs;
using Service.IServices;
using System.Collections.Generic;

namespace Service.Services
{
    public class NccService : INccService
    {
        private readonly INccRepository _nccRepository;
        private readonly IMapper _mapper;

        public NccService(INccRepository nccRepository, IMapper mapper)
        {
            _nccRepository = nccRepository;
            _mapper = mapper;
        }

        public void Add(NccDTO dto)
        {
            var entity = _mapper.Map<NccDTO, NhaCungCap>(dto);
            _nccRepository.Add(entity);
        }

        public void Delete(int id)
        {
            var entity = _nccRepository.GetById(id);
            _nccRepository.Delete(entity);
        }

        public IEnumerable<NccDTO> GetsAll()
        {
            var entities = _nccRepository.GetsAll();
            return _mapper.Map<IEnumerable<NhaCungCap>, IEnumerable<NccDTO>>(entities);
        }

        public NccDTO GetById(int id)
        {
            var entity = _nccRepository.GetById(id);
            return _mapper.Map<NhaCungCap, NccDTO>(entity);
        }

        public void Update(NccDTO dto)
        {
            var entity = _nccRepository.GetById(dto.Id);
            _mapper.Map<NccDTO, NhaCungCap>(dto, entity);
            _nccRepository.Update(entity);
        }

        public bool isExistById(int id)
        {
            return _nccRepository.GetById(id) != null;
        }
    }
}
