using AutoMapper;
using Model.Entities;
using Model.IRepositories;
using Service.DTOs;
using Service.IServices;
using System.Collections.Generic;

namespace Service.Services
{
    public class QuyenService : IQuyenService
    {
        private readonly IQuyenRepository _quyenRepository;
        private readonly IMapper _mapper;

        public QuyenService(IQuyenRepository quyenRepository, IMapper mapper)
        {
            _quyenRepository = quyenRepository;
            _mapper = mapper;
        }

        public void Add(QuyenDTO dto)
        {
            var entity = _mapper.Map<QuyenDTO, Quyen>(dto);
            _quyenRepository.Add(entity);
        }

        public void Delete(int id)
        {
            var entity = _quyenRepository.GetById(id);
            _quyenRepository.Delete(entity);
        }

        public IEnumerable<QuyenDTO> GetsAll()
        {
            var entities = _quyenRepository.GetsAll();
            return _mapper.Map<IEnumerable<Quyen>, IEnumerable<QuyenDTO>>(entities);
        }

        public QuyenDTO GetById(int id)
        {
            var entity = _quyenRepository.GetById(id);
            return _mapper.Map<Quyen, QuyenDTO>(entity);
        }

        public void Update(QuyenDTO dto)
        {
            var entity = _quyenRepository.GetById(dto.Id);
            _mapper.Map<QuyenDTO, Quyen>(dto, entity);
            _quyenRepository.Update(entity);
        }

        public bool isExistById(int id)
        {
            return _quyenRepository.GetById(id) != null;
        }
    }
}
