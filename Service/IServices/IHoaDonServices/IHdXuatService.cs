using Service.DTOs;

namespace Service.IServices
{
    public interface IHdXuatService : IService<HdXuatDTO>
    {
        public int AddHdXuat(HdXuatDTO dto);
    }
}
