using AutoMapper;
using Model.Entities;
using Model.IRepositories;
using Service.DTOs;
using Service.IServices;
using System.Collections.Generic;

namespace Service.Services
{
    public class NhanVienService : INhanVienService
    {
        private readonly INhanVienRepository _nhanVienRepository;
        private readonly IMapper _mapper;

        public NhanVienService(INhanVienRepository nccRepository, IMapper mapper)
        {
            _nhanVienRepository = nccRepository;
            _mapper = mapper;
        }

        public void Add(NhanVienDTO dto)
        {
            var entity = _mapper.Map<NhanVienDTO, NhanVien>(dto);
            _nhanVienRepository.Add(entity);
        }

        public void Delete(int id)
        {
            var entity = _nhanVienRepository.GetById(id);
            _nhanVienRepository.Delete(entity);
        }

        public IEnumerable<NhanVienDTO> GetsAll()
        {
            var entities = _nhanVienRepository.GetsAll();
            return _mapper.Map<IEnumerable<NhanVien>, IEnumerable<NhanVienDTO>>(entities);
        }

        public NhanVienDTO GetById(int id)
        {
            var entity = _nhanVienRepository.GetById(id);
            return _mapper.Map<NhanVien, NhanVienDTO>(entity);
        }

        public void Update(NhanVienDTO dto)
        {
            var entity = _nhanVienRepository.GetById(dto.Id);
            _mapper.Map<NhanVienDTO, NhanVien>(dto, entity);
            _nhanVienRepository.Update(entity);
        }

        public bool isExistById(int id)
        {
            return _nhanVienRepository.GetById(id) != null;
        }
    }
}
