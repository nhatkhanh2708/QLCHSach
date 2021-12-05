using Service.DTOs;

namespace Service.IServices
{
    public interface IQuyenService : IService<QuyenDTO>
    {
        public bool isExistTenQuyen(string tenquyen);
        public bool isExistMota(string mota);
    }
}
