using AutoMapper;
using Model.Entities;
using Model.IRepositories;
using Service.DTOs;
using Service.IServices;
using System.Collections.Generic;

namespace Service.Services
{
    public class NxbService : INxbService
    {
        private readonly INxbRepository _nxbRepository;
        private readonly IMapper _mapper;

        public NxbService(INxbRepository nxbRepository, IMapper mapper)
        {
            _nxbRepository = nxbRepository;
            _mapper = mapper;
        }

        public void Add(NhaXuatBanDTO dto)
        {
            var entity = _mapper.Map<NhaXuatBanDTO, NhaXuatBan>(dto);
            _nxbRepository.Add(entity);
        }

        public void Delete(int id)
        {
            var entity = _nxbRepository.GetById(id);
            _nxbRepository.Delete(entity);
        }

        public IEnumerable<NhaXuatBanDTO> GetsAll()
        {
            var listEntity = _nxbRepository.GetsAll();
            return _mapper.Map<IEnumerable<NhaXuatBan>, IEnumerable<NhaXuatBanDTO>>(listEntity);
        }

        public NhaXuatBanDTO GetById(int id)
        {
            var entity = _nxbRepository.GetById(id);
            return _mapper.Map<NhaXuatBan, NhaXuatBanDTO>(entity);
        }

        public IEnumerable<NhaXuatBanDTO> GetsByTenNXB(string tenNXB)
        {
            var listEntity = _nxbRepository.GetsByTenNXB(tenNXB);
            return _mapper.Map<IEnumerable<NhaXuatBan>, IEnumerable<NhaXuatBanDTO>>(listEntity);
        }

        public void Update(NhaXuatBanDTO dto)
        {
            var entity = _nxbRepository.GetById(dto.Id);
            _mapper.Map<NhaXuatBanDTO, NhaXuatBan>(dto, entity);
            _nxbRepository.Update(entity);
        }

        public bool isExistById(int id)
        {
            return _nxbRepository.GetById(id) != null;
        }
    }
}
