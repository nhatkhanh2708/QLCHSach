using AutoMapper;
using Model.Entities;
using Model.IRepositories;
using Service.DTOs;
using Service.IServices;
using System.Collections.Generic;
using System.Linq;

namespace Service.Services
{
    public class TheLoaiService : ITheLoaiService
    {
        private readonly ITheLoaiRepository _theLoaiRepository;
        private readonly IMapper _mapper;

        public TheLoaiService(ITheLoaiRepository theLoaiRepository, IMapper mapper)
        {
            _theLoaiRepository = theLoaiRepository;
            _mapper = mapper;
        }

        public void Add(TheLoaiDTO dto)
        {
            var entity = _mapper.Map<TheLoaiDTO, TheLoai>(dto);
            _theLoaiRepository.Add(entity);
        }

        public void Delete(int id)
        {
            var entity = _theLoaiRepository.GetById(id);
            _theLoaiRepository.Delete(entity);
        }

        public IEnumerable<TheLoaiDTO> GetsAll()
        {
            var entities = _theLoaiRepository.GetsAll();
            return _mapper.Map<IEnumerable<TheLoai>, IEnumerable<TheLoaiDTO>>(entities);
        }

        public TheLoaiDTO GetById(int id)
        {
            var entity = _theLoaiRepository.GetById(id);
            return _mapper.Map<TheLoai, TheLoaiDTO>(entity);
        }

        public void Update(TheLoaiDTO dto)
        {
            var entity = _theLoaiRepository.GetById(dto.Id);
            _mapper.Map<TheLoaiDTO, TheLoai>(dto, entity);
            _theLoaiRepository.Update(entity);
        }

        public bool isExistById(int id)
        {
            return _theLoaiRepository.GetById(id) != null;
        }

        public bool isExistByTenTheLoai(string tenTheLoai)
        {
            return _theLoaiRepository.GetByTenTheLoai(tenTheLoai).LongCount() != 0;
        }
    }
}
