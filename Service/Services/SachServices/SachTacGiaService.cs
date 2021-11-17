using AutoMapper;
using Model.Entities;
using Model.IRepositories;
using Service.DTOs;
using Service.IServices;
using System.Collections.Generic;

namespace Service.Services
{
    public class SachTacGiaService : ISachTacGiaService
    {
        private readonly ISachTacGiaRepository _sachTacGiaRepository;
        private readonly IMapper _mapper;

        public SachTacGiaService(ISachTacGiaRepository sachTacGiaRepository, IMapper mapper)
        {
            _sachTacGiaRepository = sachTacGiaRepository;
            _mapper = mapper;
        }

        public void Add(SachTacGiaDTO dto)
        {
            var entity = _mapper.Map<SachTacGiaDTO, SachTacGia>(dto);
            _sachTacGiaRepository.Add(entity);
        }

        public void Delete(int id)
        {
            var entity = _sachTacGiaRepository.GetById(id);
            _sachTacGiaRepository.Delete(entity);
        }

        public IEnumerable<SachTacGiaDTO> GetsAll()
        {
            var entities = _sachTacGiaRepository.GetsAll();
            return _mapper.Map<IEnumerable<SachTacGia>, IEnumerable<SachTacGiaDTO>>(entities);
        }

        public SachTacGiaDTO GetById(int id)
        {
            var entity = _sachTacGiaRepository.GetById(id);
            return _mapper.Map<SachTacGia, SachTacGiaDTO>(entity);
        }

        public void Update(SachTacGiaDTO dto)
        {
            var entity = _sachTacGiaRepository.GetById(dto.Id);
            _mapper.Map<SachTacGiaDTO, SachTacGia>(dto, entity);
            _sachTacGiaRepository.Update(entity);
        }

        public bool isExistById(int id)
        {
            return _sachTacGiaRepository.GetById(id) != null;
        }
    }
}
