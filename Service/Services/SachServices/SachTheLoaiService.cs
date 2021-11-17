using AutoMapper;
using Model.Entities;
using Model.IRepositories;
using Service.DTOs;
using Service.IServices;
using System.Collections.Generic;

namespace Service.Services
{
    public class SachTheLoaiService : ISachTheLoaiService
    {
        private readonly ISachTheLoaiRepository _sachTheLoaiRepository;
        private readonly IMapper _mapper;

        public SachTheLoaiService(ISachTheLoaiRepository sachTheLoaiRepository, IMapper mapper)
        {
            _sachTheLoaiRepository = sachTheLoaiRepository;
            _mapper = mapper;
        }

        public void Add(SachTheLoaiDTO dto)
        {
            var entity = _mapper.Map<SachTheLoaiDTO, SachTheLoai>(dto);
            _sachTheLoaiRepository.Add(entity);
        }

        public void Delete(int id)
        {
            var entity = _sachTheLoaiRepository.GetById(id);
            _sachTheLoaiRepository.Delete(entity);
        }

        public IEnumerable<SachTheLoaiDTO> GetsAll()
        {
            var entities = _sachTheLoaiRepository.GetsAll();
            return _mapper.Map<IEnumerable<SachTheLoai>, IEnumerable<SachTheLoaiDTO>>(entities);
        }

        public SachTheLoaiDTO GetById(int id)
        {
            var entity = _sachTheLoaiRepository.GetById(id);
            return _mapper.Map<SachTheLoai, SachTheLoaiDTO>(entity);
        }

        public void Update(SachTheLoaiDTO dto)
        {
            var entity = _sachTheLoaiRepository.GetById(dto.Id);
            _mapper.Map<SachTheLoaiDTO, SachTheLoai>(dto, entity);
            _sachTheLoaiRepository.Update(entity);
        }

        public bool isExistById(int id)
        {
            return _sachTheLoaiRepository.GetById(id) != null;
        }
    }
}
