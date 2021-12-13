using AutoMapper;
using Model.Entities;
using Model.IRepositories;
using Service.DTOs;
using Service.IServices;
using System.Collections.Generic;
using System.Linq;

namespace Service.Services
{
    public class TacGiaService : ITacGiaService
    {
        private readonly ITacGiaRepository _tacGiaRepository;
        private readonly IMapper _mapper;

        public TacGiaService(ITacGiaRepository tacGiaRepository, IMapper mapper)
        {
            _tacGiaRepository = tacGiaRepository;
            _mapper = mapper;
        }

        public void Add(TacGiaDTO dto)
        {
            var entity = _mapper.Map<TacGiaDTO, TacGia>(dto);
            _tacGiaRepository.Add(entity);
        }

        public void Delete(int id)
        {
            var entity = _tacGiaRepository.GetById(id);
            _tacGiaRepository.Delete(entity);
        }

        public IEnumerable<TacGiaDTO> GetsAll()
        {
            var entities = _tacGiaRepository.GetsAll();
            return _mapper.Map<IEnumerable<TacGia>, IEnumerable<TacGiaDTO>>(entities);
        }

        public TacGiaDTO GetById(int id)
        {
            var entity = _tacGiaRepository.GetById(id);
            return _mapper.Map<TacGia, TacGiaDTO>(entity);
        }

        public void Update(TacGiaDTO dto)
        {
            var entity = _tacGiaRepository.GetById(dto.Id);
            _mapper.Map<TacGiaDTO, TacGia>(dto, entity);
            _tacGiaRepository.Update(entity);
        }

        public bool isExistById(int id)
        {
            return _tacGiaRepository.GetById(id) != null;
        }

        public bool isExistByName(string tentg, string butdanh)
        {
            return _tacGiaRepository.GetByName(tentg, butdanh).LongCount() > 0;
        }

        public IEnumerable<TacGiaDTO> GetByTen(string tg)
        {
            var entities = _tacGiaRepository.GetByTen(tg, tg);
            return _mapper.Map<IEnumerable<TacGia>, IEnumerable<TacGiaDTO>>(entities);
        }
    }
}
