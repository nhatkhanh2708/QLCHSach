using Service.DTOs;

namespace Service.IServices
{
    public interface ITacGiaService : IService<TacGiaDTO>
    {
        public bool isExistByName(string tentg, string butdanh);
    }
}
