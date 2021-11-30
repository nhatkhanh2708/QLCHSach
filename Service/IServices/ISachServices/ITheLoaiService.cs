using Service.DTOs;

namespace Service.IServices
{
    public interface ITheLoaiService : IService<TheLoaiDTO>
    {
        public bool isExistByTenTheLoai(string tenTheLoai);
    }
}
