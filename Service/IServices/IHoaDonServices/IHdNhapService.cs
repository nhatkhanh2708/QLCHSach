using Service.DTOs;

namespace Service.IServices
{
    public interface IHdNhapService : IService<HdNhapDTO>
    {
        public int AddHdNhap(HdNhapDTO dto);
    }
}
