using Model.Entities;

namespace Model.IRepositories
{
    public interface ITaiKhoanRepository : IRepository<TaiKhoan>
    {
        TaiKhoan GetByUsername(string username);
    }
}
