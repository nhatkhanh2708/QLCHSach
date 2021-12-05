using Service.DTOs;
using System.Collections.Generic;

namespace Service.IServices
{
    public interface ITaiKhoanService
    {
        IEnumerable<TaiKhoanDTO> GetsAll();
        TaiKhoanDTO GetById(int id);
        void Add(TaiKhoanDTO taiKhoanDTO, string password);
        void Update(TaiKhoanDTO dto);
        void Delete(int id);
        bool isExistById(int id);
        bool isExistByUsername(string username);
        TaiKhoanDTO isLogin(string username, string password);
    }
}
