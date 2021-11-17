using AutoMapper;
using Model.Entities;
using Model.IRepositories;
using Service.DTOs;
using Service.Helpers;
using Service.IServices;
using System.Collections.Generic;

namespace Service.Services
{
    public class TaiKhoanService : ITaiKhoanService
    {
        private readonly ITaiKhoanRepository _taiKhoanRepository;
        private readonly IMapper _mapper;

        public TaiKhoanService(ITaiKhoanRepository taiKhoanRepository, IMapper mapper)
        {
            _taiKhoanRepository = taiKhoanRepository;
            _mapper = mapper;
        }

        public void Add(TaiKhoanDTO dto, string password)
        {
            byte[] passHash, passSalt;
            HashPass.CreateHash(password, out passHash, out passSalt);
            dto.PasswordHash = passHash;
            dto.PasswordSalt = passSalt;
            var entity = _mapper.Map<TaiKhoanDTO, TaiKhoan>(dto);
            _taiKhoanRepository.Add(entity);
        }

        public void Delete(int id)
        {
            var entity = _taiKhoanRepository.GetById(id);
            _taiKhoanRepository.Delete(entity);
        }

        public IEnumerable<TaiKhoanDTO> GetsAll()
        {
            var entities = _taiKhoanRepository.GetsAll();
            return _mapper.Map<IEnumerable<TaiKhoan>, IEnumerable<TaiKhoanDTO>>(entities);
        }

        public TaiKhoanDTO GetById(int id)
        {
            var entity = _taiKhoanRepository.GetById(id);
            return _mapper.Map<TaiKhoan, TaiKhoanDTO>(entity);
        }

        public void Update(TaiKhoanDTO dto)
        {
            var entity = _taiKhoanRepository.GetById(dto.Id);
            _mapper.Map<TaiKhoanDTO, TaiKhoan>(dto, entity);
            _taiKhoanRepository.Update(entity);
        }

        public bool isExistById(int id)
        {
            return _taiKhoanRepository.GetById(id) != null;
        }

        public bool isExistByUsername(string username)
        {
            return _taiKhoanRepository.GetByUsername(username) != null;
        }
    }
}
