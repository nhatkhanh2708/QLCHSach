using Service.DTOs;

namespace Service.IServices
{
    public interface ISachService : IService<SachDTO>
    {
        public int AddSach(SachDTO s);
        public void UpdateStatus(int id);
    }
}
