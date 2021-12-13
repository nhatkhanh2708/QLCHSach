using Service.DTOs;

namespace Service.IServices
{
    public interface INhanVienService : IService<NhanVienDTO>
    {
        public void UpdateStatus(int id);
    }
}
